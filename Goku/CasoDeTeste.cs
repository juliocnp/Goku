using System;
using System.Collections.Generic;

namespace Goku
{
    public class CasoDeTeste
    {
        public List<Galeria> Galerias;
        public List<Salao> Saloes;
        public Goku Goku;
        public int NumeroMagia;
        public int NumeroGaleria;
        public int NumeroSalao;
        public int NumeroMonstro;

        public CasoDeTeste(int NumeroMagia, int NumeroSalao, int NumeroGaleria, int NumeroMonstro)
        {
            this.NumeroMagia = NumeroMagia;
            this.NumeroGaleria = NumeroGaleria;
            this.NumeroSalao = NumeroSalao;
            this.NumeroMonstro = NumeroMonstro;
            this.Goku = new Goku();
            this.Galerias = new List<Galeria>();
            this.Saloes = new List<Salao>();
        }

        public string Imprimir()
        {
            string textAux = "";
            textAux += "Magias: " + this.NumeroMagia + Environment.NewLine;
            this.Goku.Magias.ForEach(m =>
            {
                textAux += "Ki: " + m.Ki.ToString() + " - Dano: " + m.Dano.ToString() + Environment.NewLine;
            });
            textAux += "Salões: " + this.NumeroSalao + Environment.NewLine;
            textAux += "Galerias: " + this.NumeroGaleria + Environment.NewLine;
            this.Galerias.ForEach(g =>
            {
                textAux += "Salão " + g.Salao1.NumeroSalao.ToString() + " - " + "Salão " + g.Salao2.NumeroSalao.ToString() + Environment.NewLine;
            });
            textAux += "Monstros: " + this.NumeroMonstro + Environment.NewLine;
            this.Saloes.ForEach(s =>
            {
                s.Monstros.ForEach(m =>
                {
                    textAux += "Salão " + s.NumeroSalao + " - Vida: " + m.Vida + Environment.NewLine;
                });
            });
            return textAux;
        }

        /// <summary>
        /// Para uma lista de magias e monstros, verifica o menor custo de ki possível
        /// para matar o monstro
        /// </summary>
        /// <param name="monstro">Alvo</param>
        /// <param name="magias">Magias possíveis para serem usadas no monstro</param>
        /// <returns></returns>
        public int CalcularMenorCusto(Monstro monstro, List<Magia> magias)
        {
            if (magias == null || monstro == null) return 0;

            List<int> custos = new List<int>();
            int numeroDeUsos = 0;
            int vidaRestante = monstro.Vida;
            int manaUsada = 0;

            // Verifica se existe pelo menos 1 magia válida (Tem dano e ki maior que 0)
            // se Todas não forem válidas. é retornado 0 
            if (magias.FindAll(magia => magia.Dano <= 0 || magia.Ki <= 0).Count == magias.Count) return 0;

            // O cálculo do menor custo acontece até a vida do monstro chegar a 0
            while (vidaRestante > 0)
            {
                // Para saber o menor custo, é necessário percorrer todas as magias
                foreach (Magia magia in magias)
                {
                    // A validação acima verifica se TODAS as magias são inválidas
                    // A verificação abaixo olha se a magia atual do loop é válida
                    if (magia != null && magia.Ki > 0 && magia.Dano > 0)
                    {
                        if (vidaRestante == monstro.Vida)
                        {
                            // A magia consegue matar o monstro com um único "lançamento"
                            // Se conseguir, o ki gasto por ela é adicionado na lista e o método
                            // verifica as outras magias
                            if (monstro.Vida % magia.Dano == 0)
                            {
                                numeroDeUsos = monstro.Vida / magia.Dano;
                                custos.Add(numeroDeUsos * magia.Ki);
                                manaUsada = numeroDeUsos = 0;
                            }
                            else
                            {
                                manaUsada = monstro.Vida / magia.Dano * magia.Ki;
                                vidaRestante = monstro.Vida % magia.Dano;
                            }
                        }
                        // Quando a vida do monstro não for igual a vida restante
                        // Significa que já foi usada uma magia nele e agora é necessário
                        // Calcular o quanto falta para mata-lo
                        else
                        {
                            numeroDeUsos = vidaRestante / magia.Dano;
                            if (numeroDeUsos == 0) numeroDeUsos = 1;
                            if (vidaRestante % magia.Dano == 0 || vidaRestante < magia.Dano)
                            {
                                custos.Add(numeroDeUsos * magia.Ki + manaUsada);
                                manaUsada = vidaRestante = numeroDeUsos = 0;
                            }
                            else
                            {
                                vidaRestante = vidaRestante % magia.Dano;
                            }
                        }
                    }
                }
            }
            custos.Sort();
            if (custos.Count > 0) return custos[0];
            return 0;
        }
    }
}

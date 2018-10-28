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

        public int CalcularMenorCusto(Monstro monstro, List<Magia> magias)
        {
            if (magias == null || monstro == null) return 0;

            List<int> custos = new List<int>();
            int numeroDeUsos = 0;
            int vidaRestante = 0;
            int manaUsada = 0;

            foreach (Magia magia in magias)
            {
                if(vidaRestante == 0)
                {
                    if (monstro.Vida % magia.Dano == 0)
                    {
                        numeroDeUsos = monstro.Vida / magia.Dano;
                        custos.Add(numeroDeUsos * magia.Ki);
                        manaUsada = vidaRestante = numeroDeUsos = 0;
                    }
                    else
                    {
                        manaUsada = numeroDeUsos * magia.Ki;
                        vidaRestante = monstro.Vida % magia.Dano;
                    }
                } else
                {
                    numeroDeUsos = vidaRestante / magia.Dano;
                    if (vidaRestante % magia.Dano == 0)
                    {
                        custos.Add(numeroDeUsos * magia.Ki + manaUsada);
                        manaUsada = vidaRestante = numeroDeUsos = 0;
                    } else
                    {
                        vidaRestante = vidaRestante % magia.Dano;
                    }
                }
            }
            custos.Sort();
            if (custos.Count > 0) return custos[0];
            return 0;
        }
    }
}

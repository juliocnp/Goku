using System;
using System.Collections.Generic;

namespace Goku
{
    public class Monstro
    {
        public Salao Salao;
        public int Vida;
        public int KiNecessario;

        public Monstro(Salao Salao, int Vida)
        {
            this.Salao = Salao;

            if (Vida < 1)
                this.Vida = 1;
            else if (Vida > 1000)
                this.Vida = 1000;
            else
                this.Vida = Vida;
        }

        public Monstro(int Vida)
        {
            if (Vida < 1)
                this.Vida = 1;
            else if (Vida > 1000)
                this.Vida = 1000;
            else
                this.Vida = Vida;
        }

        public Monstro(Salao Salao)
        {
            this.Salao = Salao;
        }

        public void CombaterMonstroDinamico (Goku goku, int[,] tabelaDinamica, out int melhorKi)
        {
            melhorKi = tabelaDinamica[tabelaDinamica.GetLength(0) - 1, this.Vida];
        }

        public void CombaterMonstroGuloso(Goku goku, out List<Magia> melhorCombinacao, out int melhorKi)
        {
            List<Magia> magiasOrdenadas = QuickSort.MetodoQuickSort(goku.Magias), magiasUsadas = new List<Magia>();
            int dano = 0, i = magiasOrdenadas.Count - 1;

            while (this.Vida >= dano)
            {
                if (magiasOrdenadas[i - 1].Dano >= this.Vida)
                    i--;
                else
                {
                    magiasUsadas.Add(magiasOrdenadas[i]);
                    dano += magiasOrdenadas[i].Dano;
                }
            }

            melhorCombinacao = magiasUsadas;
            melhorKi = dano;
        }

        public void CombaterMonstroForcaBruta(Goku goku, out List<Magia> melhorCombinacao, out int melhorKi)
        {
            List<Magia> magiasOrdenadas = QuickSort.MetodoQuickSort(goku.Magias);
            List<int> quantidadeMagias = new List<int>();
            List<List<Magia>> combinacaoMagias = new List<List<Magia>>();
            List<int> combinacaoKi = new List<int>();
            List<string> textoCombinacaoMagias = new List<string>();

            for (int i = 0; i < magiasOrdenadas.Count; i++)
                quantidadeMagias.Add(0);

            ForcaBruta(magiasOrdenadas, quantidadeMagias, combinacaoMagias, combinacaoKi, textoCombinacaoMagias);
            MelhorCombinacao(out melhorCombinacao, out melhorKi, combinacaoMagias, combinacaoKi);
        }

        private static void MelhorCombinacao(out List<Magia> melhorCombinacao, out int melhorKi, List<List<Magia>> combinacaoMagias, List<int> combinacaoKi)
        {
            int menorKi = int.MaxValue;
            int indexMenor = 0;
            for (int i = 0; i < combinacaoMagias.Count; i++)
            {
                if (menorKi > combinacaoKi[i])
                {
                    menorKi = combinacaoKi[i];
                    indexMenor = i;
                }
            }

            melhorCombinacao = combinacaoMagias[indexMenor];
            melhorKi = combinacaoKi[indexMenor];
        }

        private void ForcaBruta(List<Magia> magiasOrdenadas, List<int> quantidadeMagias, List<List<Magia>> combinacaoMagias, List<int> combinacaoKi, List<string> textoCombinacaoMagias)
        {
            while (true)
            { // nova sequencia de magias
                List<Magia> listaSequencia = new List<Magia>();
                string texto = "";
                int dano = 0, ki = 0, maiorUsada = 0, menorUsada = magiasOrdenadas.Count;
                bool preencheuMagia0 = false, preencheuMagiaN = false;

                PreencherMagias(magiasOrdenadas, quantidadeMagias, listaSequencia, ref texto, ref dano, ref ki, ref maiorUsada, ref menorUsada, ref preencheuMagiaN);
                PreencherRestanteComMagiasBaixa(magiasOrdenadas, listaSequencia, ref texto, ref dano, ref ki, ref preencheuMagia0);

                if (preencheuMagia0) // Se tiver sido acrescentado magias nível 0, incrementa magia 1
                    quantidadeMagias[1]++;
                else if (preencheuMagiaN && menorUsada != maiorUsada)// Se a menor e maior magias usadas forem iguais e for diferente da ultima magia, logo tem mais níveis de magias
                    menorUsada = IncrementarMagiasEZerarAnteriores(quantidadeMagias, menorUsada);
                else if (menorUsada != maiorUsada) // Se a menor magia usada for diferente da maior, quer dizer que não foi uma sequencia uni magical, logo incrementa a próxima da menor
                    quantidadeMagias[++menorUsada]++;
                else if (menorUsada != magiasOrdenadas.Count - 1)// Se a menor e maior magias usadas forem iguais e for diferente da ultima magia, logo tem mais níveis de magias
                    menorUsada = IncrementarMagiasEZerarAnteriores(quantidadeMagias, menorUsada);
                else
                { // Se for a ultima combinação, joga nas listas e quebra a repetição
                    AdicionarResultadosNasListas(combinacaoMagias, combinacaoKi, textoCombinacaoMagias, listaSequencia, texto, ki);
                    break;
                }
                //Chegando aqui acaba a sequencia atual, joga nas listas e comea uma nova
                AdicionarResultadosNasListas(combinacaoMagias, combinacaoKi, textoCombinacaoMagias, listaSequencia, texto, ki);
            }
        }

        private static int IncrementarMagiasEZerarAnteriores(List<int> quantidadeMagias, int menorUsada)
        {
            for (int i = menorUsada; i >= 0; i--)
            { // zera as anteriores inclusive a atual
                quantidadeMagias[i] = 0;
            }
            quantidadeMagias[++menorUsada]++; // incrementa a proxima
            return menorUsada;
        }

        private static void AdicionarResultadosNasListas(List<List<Magia>> combinacaoMagias, List<int> combinacaoKi, List<string> textoCombinacaoMagias, List<Magia> listaSequencia, string texto, int ki)
        {
            combinacaoMagias.Add(listaSequencia);
            //textoCombinacaoMagias.Add(texto);
            combinacaoKi.Add(ki);
        }

        private void PreencherRestanteComMagiasBaixa(List<Magia> magiasOrdenadas, List<Magia> listaSequencia, ref string texto, ref int dano, ref int ki, ref bool preencheuMagia0)
        {
            while (dano < this.Vida)
            {// preenchendo com magias nivel 0 se o dano nao for suficiente
                listaSequencia.Add(magiasOrdenadas[0]);
                //texto += "1, ";
                dano += magiasOrdenadas[0].Dano;
                ki += magiasOrdenadas[0].Ki;
                preencheuMagia0 = true;
            }
        }

        private void PreencherMagias(List<Magia> magiasOrdenadas, List<int> quantidadeMagias, List<Magia> listaSequencia, ref string texto, ref int dano, ref int ki, ref int maiorUsada, ref int menorUsada, ref bool preencheuMagiaN)
        {
            for (int i = quantidadeMagias.Count - 1; i >= 0; i--)
            {// colocando a quantidade de acordo com as pre definições
                for (int j = 0; j < quantidadeMagias[i]; j++)
                {
                    listaSequencia.Add(magiasOrdenadas[i]);
                    //texto += (i + 1).ToString() + ", ";
                    dano += magiasOrdenadas[i].Dano;
                    ki += magiasOrdenadas[i].Ki;
                    menorUsada = i;
                    if (maiorUsada < i)
                        maiorUsada = i;
                    if (dano > this.Vida)
                    {
                        preencheuMagiaN = true;
                        break;
                    }
                }

            }
        }
    }
}

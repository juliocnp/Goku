using System;
using System.Collections.Generic;

namespace Goku
{
    public static class Estruturas
    {
        static public List<CasoDeTeste> Casos;

        static Estruturas()
        {
            Casos = new List<CasoDeTeste>();
        }

        static public int[,] PreencherTabelaDinamica(CasoDeTeste casoDeTeste)
        {
            if (casoDeTeste == null || casoDeTeste.Goku == null || casoDeTeste.Goku.Magias == null || casoDeTeste.Goku.Magias.Count == 0)
                return null;

            int[,] tabela;
            List<Magia> magiasOrdenadas = QuickSort.MetodoQuickSort(casoDeTeste.Goku.Magias);
            int maiorVidaMonstro = int.MinValue;
            maiorVidaMonstro = casoDeTeste.getMaiorVidaMonstro();
            if (maiorVidaMonstro == int.MinValue)
            {
                maiorVidaMonstro = 0;
                tabela = new int[casoDeTeste.Goku.Magias.Count, maiorVidaMonstro + 1];
            }
            else
                tabela = new int[casoDeTeste.Goku.Magias.Count, maiorVidaMonstro + 1];

            for (int i = 0; i < tabela.GetLength(0); i++)
            {
                for (int j = 0; j < tabela.GetLength(1); j++)
                {
                    if (i == 0)
                    {
                        int dano = 0;
                        while (dano < j)
                        {
                            dano += magiasOrdenadas[i].Dano;
                            tabela[i, j] += magiasOrdenadas[i].Ki;
                        }
                    }
                    else if (j < magiasOrdenadas[i].Dano)
                        tabela[i, j] = tabela[i - 1, j];
                    else
                        tabela[i, j] = Math.Min(tabela[i - 1, j], tabela[i, j - magiasOrdenadas[i].Dano] + magiasOrdenadas[i].Ki);
                }
            }

            return tabela;
        }
    }
}

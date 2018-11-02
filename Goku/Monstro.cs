using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goku
{
    class Monstro
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

        public int CombaterMonstro(Goku goku)
        {
            List<Magia> magiasOrdenadas = QuickSort.MetodoQuickSort(goku.Magias);
            List<int> quantidadeMagias = new List<int>();
            List<int> maximoMagias = new List<int>();
            List<List<Magia>> combinacaoMagias = new List<List<Magia>>();
            List<int> combinacaoKi = new List<int>();

            for (int i = 0; i < quantidadeMagias.Count; i++)
            {
                quantidadeMagias.Add(0);
                maximoMagias.Add((int)Math.Ceiling((decimal)magiasOrdenadas[i].Dano / this.Vida));
            }

            this.Preencher(quantidadeMagias, magiasOrdenadas, combinacaoMagias, combinacaoKi);

            while (quantidadeMagias[magiasOrdenadas.Count - 1] <= maximoMagias[magiasOrdenadas.Count - 1])
            {
                quantidadeMagias[1]++;
                for (int i = 1; i < magiasOrdenadas.Count; i++)
                {
                    if (quantidadeMagias[i] > maximoMagias[i])
                    {
                        quantidadeMagias[++i]++;
                        for (int j = i; j > 0; j--)
                        {
                            quantidadeMagias[j] = 0;
                        }
                    }
                }
                this.Preencher(quantidadeMagias, magiasOrdenadas, combinacaoMagias, combinacaoKi);
            }
            //Enquanto não chegar no máximo da ultima magia
        }

        private void Preencher(List<int> quantidadeMagias, List<Magia> magiasOrdenadas, List<List<Magia>> combinacaoMagias, List<int> combinacaoKi)
        {
            // Preencher com o resto de magias de acordo com a quantidadeMagias
        }
    }
}

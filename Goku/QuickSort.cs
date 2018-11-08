using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goku
{
    class QuickSort
    {
        public static List<Magia> MetodoQuickSort(List<Magia> magias)
        {
            MetodoQuickSort(magias, 0, magias.Count - 1);
            return magias;
        }

        private static void MetodoQuickSort(List<Magia> magias, int inicio, int fim)
        {
            int part;
            if (inicio < fim)
            {
                part = Particao(magias, inicio, fim);
                MetodoQuickSort(magias, inicio, part - 1);
                MetodoQuickSort(magias, part + 1, fim);
            }
        }

        private static int Particao(List<Magia> magias, int inicio, int fim)
        {
            Magia aux;
            Magia pivot = magias[fim];
            int part = inicio - 1;
            for (int i = inicio; i < fim; i++)
            {
                if (magias[i].Dano < pivot.Dano)
                {
                    part = part + 1;
                    aux = magias[part];
                    magias[part] = magias[i];
                    magias[i] = aux;
                }
            }
            aux = magias[part + 1];
            magias[part + 1] = magias[fim];
            magias[fim] = aux;
            return (part + 1);
        }


        public static List<Salao> MetodoQuickSortSaloes(List<Salao> salao)
        {
            MetodoQuickSortSaloes(salao, 0, salao.Count - 1);
            return salao;
        }

        private static void MetodoQuickSortSaloes(List<Salao> salao, int inicio, int fim)
        {
            int part;
            if (inicio < fim)
            {
                part = ParticaoSaloes(salao, inicio, fim);
                MetodoQuickSortSaloes(salao, inicio, part - 1);
                MetodoQuickSortSaloes(salao, part + 1, fim);
            }
        }

        private static int ParticaoSaloes(List<Salao> salao, int inicio, int fim)
        {
            Salao aux;
            Salao pivot = salao[fim];
            int part = inicio - 1;
            for (int i = inicio; i < fim; i++)
            {
                if (salao[i].NumeroSalao < pivot.NumeroSalao)
                {
                    part = part + 1;
                    aux = salao[part];
                    salao[part] = salao[i];
                    salao[i] = aux;
                }
            }
            aux = salao[part + 1];
            salao[part + 1] = salao[fim];
            salao[fim] = aux;
            return (part + 1);
        }
    }
}

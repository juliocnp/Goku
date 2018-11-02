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

    }
}

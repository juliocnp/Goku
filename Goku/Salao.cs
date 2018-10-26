using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goku
{
    class Salao
    {
        public int NumeroSalao;
        public Monstro[] Monstros;
        public Galeria[] Galeria;

        public Salao(int NumeroSalao, Monstro[] Monstros, Galeria[] Galeria)
        {
            this.NumeroSalao = NumeroSalao;
            this.Monstros = Monstros;
            this.Galeria = Galeria;
        }

        public Salao(int NumeroSalao, Monstro[] Monstros)
        {
            this.NumeroSalao = NumeroSalao;
            this.Monstros = Monstros;
        }

        public Salao(int NumeroSalao, Galeria[] Galeria)
        {
            this.NumeroSalao = NumeroSalao;
            this.Galeria = Galeria;
        }

        public Salao(int NumeroSalao)
        {
            this.NumeroSalao = NumeroSalao;
        }
    }
}

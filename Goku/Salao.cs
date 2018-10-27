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
        public List<Monstro> Monstros;
        public List<Galeria> Galeria;

        public Salao(int NumeroSalao, Monstro[] Monstros, Galeria[] Galeria)
        {
            this.NumeroSalao = NumeroSalao;
            this.Monstros = new List<Monstro>();
            this.Galeria = new List<Galeria>();
        }

        public Salao(int NumeroSalao, Monstro[] Monstros)
        {
            this.NumeroSalao = NumeroSalao;
            this.Monstros = new List<Monstro>();
        }

        public Salao(int NumeroSalao, Galeria[] Galeria)
        {
            this.NumeroSalao = NumeroSalao;
            this.Galeria = new List<Galeria>();
        }

        public Salao(int NumeroSalao)
        {
            this.NumeroSalao = NumeroSalao;
        }
    }
}

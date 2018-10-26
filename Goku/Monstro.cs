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
    }
}

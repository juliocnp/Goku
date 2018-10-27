using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goku
{
    class Goku
    {
        public List<Magia> Magias;

        public Goku() {
            Magias = new List<Magia>();
        }

        public Goku(List<Magia> Magias)
        {
            this.Magias = Magias;
        }
    }
}

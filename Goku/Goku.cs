using System.Collections.Generic;

namespace Goku
{
    public class Goku
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

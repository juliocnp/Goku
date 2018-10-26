using System.Collections.Generic;

namespace Goku
{
    class Masmorra
    {
        public List<Galeria> Galerias;
        public Goku Goku;
        public int NumeroMagia;
        public int NumeroGaleria;
        public int NumeroSalao;
        public int NumeroMonstro;

        public Masmorra(int NumeroMagia, int NumeroGaleria, int NumeroSalao, int NumeroMonstro)
        {
            this.NumeroMagia = NumeroMagia;
            this.NumeroGaleria = NumeroGaleria;
            this.NumeroSalao = NumeroSalao;
            this.NumeroMonstro = NumeroMonstro;
            this.Goku = new Goku();
            this.Galerias = new List<Galeria>();
        }
    }
}

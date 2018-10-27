using System.Collections.Generic;

namespace Goku
{
    class CasoDeTeste
    {
        public List<Galeria> Galerias;
        public List<Salao> Saloes;
        public Goku Goku;
        public int NumeroMagia;
        public int NumeroGaleria;
        public int NumeroSalao;
        public int NumeroMonstro;

        public CasoDeTeste(int NumeroMagia, int NumeroSalao, int NumeroGaleria, int NumeroMonstro)
        {
            this.NumeroMagia = NumeroMagia;
            this.NumeroGaleria = NumeroGaleria;
            this.NumeroSalao = NumeroSalao;
            this.NumeroMonstro = NumeroMonstro;
            this.Goku = new Goku();
            this.Galerias = new List<Galeria>();
            this.Saloes = new List<Salao>();
        }
    }
}

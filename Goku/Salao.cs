using System.Collections.Generic;

namespace Goku
{
    public class Salao
    {
        public int NumeroSalao;
        public List<Monstro> Monstros;
        public List<Galeria> Galeria;
        public bool visitado;

        public Salao(int NumeroSalao, List<Monstro> Monstros, List<Galeria> Galeria)
        {
            this.NumeroSalao = NumeroSalao;
            this.Monstros = Monstros;
            this.Galeria = Galeria;
            this.visitado = false;
        }

        public Salao(int NumeroSalao, List<Monstro> Monstros)
        {
            this.NumeroSalao = NumeroSalao;
            this.Monstros = Monstros;
            this.Galeria = new List<Galeria>();
            this.visitado = false;
        }

        public Salao(int NumeroSalao, List<Galeria> Galeria)
        {
            this.NumeroSalao = NumeroSalao;
            this.Monstros = new List<Monstro>();
            this.Galeria = Galeria;
            this.visitado = false;
        }

        public Salao(int NumeroSalao)
        {
            this.NumeroSalao = NumeroSalao;
            this.Monstros = new List<Monstro>();
            this.Galeria = new List<Galeria>();
            this.visitado = false;
        }

        public int Combate (Goku goku, int[,] tabelaDinamica, string metodo)
        {
            int kiNecessario = 0;
            this.Monstros.ForEach(monstro =>
            {
                int melhorKi;
                List<Magia> melhorCombinacaoMagias;
                if (metodo == "FB")
                    monstro.CombaterMonstroForcaBruta(goku, out melhorCombinacaoMagias, out melhorKi);
                else if (metodo == "GL")
                    monstro.CombaterMonstroGuloso(goku, out melhorCombinacaoMagias, out melhorKi);
                else
                    monstro.CombaterMonstroDinamico(tabelaDinamica, out melhorKi);
                kiNecessario += melhorKi;
            });
            return kiNecessario;
        }
    }
}

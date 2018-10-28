﻿using System.Collections.Generic;

namespace Goku
{
    public class Salao
    {
        public int NumeroSalao;
        public List<Monstro> Monstros;
        public List<Galeria> Galeria;

        public Salao(int NumeroSalao, List<Monstro> Monstros, List<Galeria> Galeria)
        {
            this.NumeroSalao = NumeroSalao;
            this.Monstros = Monstros;
            this.Galeria = Galeria;
        }

        public Salao(int NumeroSalao, List<Monstro> Monstros)
        {
            this.NumeroSalao = NumeroSalao;
            this.Monstros = Monstros;
            this.Galeria = new List<Galeria>();
        }

        public Salao(int NumeroSalao, List<Galeria> Galeria)
        {
            this.NumeroSalao = NumeroSalao;
            this.Monstros = new List<Monstro>();
            this.Galeria = Galeria;
        }

        public Salao(int NumeroSalao)
        {
            this.NumeroSalao = NumeroSalao;
            this.Monstros = new List<Monstro>();
            this.Galeria = new List<Galeria>();
        }
    }
}

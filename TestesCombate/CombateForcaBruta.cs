using System;
using System.Collections.Generic;
using Goku;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestesCombate
{
    [TestClass]
    public class CombateForcaBruta
    {
        [TestMethod]
        public void TesteSucesso()
        {
            List<Magia> magias = new List<Magia>();
            magias.Add(new Magia(10, 100));
            magias.Add(new Magia(15, 200));
            magias.Add(new Magia(20, 250));

            Goku.Goku goku = new Goku.Goku(magias);

            Monstro monstro = new Monstro(null, 550);

            List<Magia> melhorCombinacao;
            int melhorKi;

            monstro.CombaterMonstroForcaBruta(goku, out melhorCombinacao, out melhorKi);

            Assert.AreEqual(melhorKi, 45);
        }

        [TestMethod]
        public void TesteSucesso1()
        {
            List<Magia> magias = new List<Magia>();
            magias.Add(new Magia(10, 100));
            magias.Add(new Magia(15, 200));
            magias.Add(new Magia(20, 250));
            magias.Add(new Magia(25, 300));
            magias.Add(new Magia(30, 350));

            Goku.Goku goku = new Goku.Goku(magias);

            Monstro monstro = new Monstro(null, 800);

            List<Magia> melhorCombinacao;
            int melhorKi;

            monstro.CombaterMonstroForcaBruta(goku, out melhorCombinacao, out melhorKi);

            Assert.AreEqual(melhorKi, 60);
        }

        [TestMethod]
        public void TesteSucesso2()
        {
            List<Magia> magias = new List<Magia>();
            magias.Add(new Magia(15, 200));
            magias.Add(new Magia(30, 350));
            magias.Add(new Magia(20, 250));
            magias.Add(new Magia(40, 450));
            magias.Add(new Magia(10, 100));
            magias.Add(new Magia(35, 400));
            magias.Add(new Magia(25, 300));

            Goku.Goku goku = new Goku.Goku(magias);

            Monstro monstro = new Monstro(null, 800);

            List<Magia> melhorCombinacao;
            int melhorKi;

            monstro.CombaterMonstroForcaBruta(goku, out melhorCombinacao, out melhorKi);

            Assert.AreEqual(melhorKi, 60);
        }
    }
}

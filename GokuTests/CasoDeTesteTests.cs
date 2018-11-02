using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Goku.Tests
{
    [TestClass()]
    public class CasoDeTesteTests
    {
        CasoDeTeste caso = new CasoDeTeste(1, 1, 1, 1);
        List<Magia> magias = new List<Magia>();
        Monstro monstro = new Monstro(new Salao(1), 1500);

        [TestMethod()]
        public void CalcularMenorCustoTest1()
        {
            magias.Add(new Magia(100, 1000));
            magias.Add(new Magia(5, 200));

            Assert.AreEqual(25, this.caso.CalcularMenorCusto(this.monstro, this.magias));
        }

        [TestMethod()]
        public void CalcularMenorCustoTest2()
        {
            magias.Add(new Magia(100, 1000));
            magias.Add(new Magia(5, 200));

            Assert.AreEqual(0, this.caso.CalcularMenorCusto(null, this.magias));
        }

        [TestMethod()]
        public void CalcularMenorCustoTest3()
        {
            magias.Add(new Magia(100, 1000));
            magias.Add(new Magia(5, 200));

            Assert.AreEqual(0, this.caso.CalcularMenorCusto(this.monstro, null));
        }

        [TestMethod()]
        public void CalcularMenorCustoTest4()
        {
            magias.Add(null);
            magias.Add(new Magia(5, 200));

            Assert.AreEqual(25, this.caso.CalcularMenorCusto(this.monstro, this.magias));
        }

        [TestMethod()]
        public void CalcularMenorCustoTest5()
        {
            magias.Add(new Magia(5, 200));
            magias.Add(new Magia(100, 1000));

            Assert.AreEqual(25, this.caso.CalcularMenorCusto(this.monstro, this.magias));
        }

        [TestMethod()]
        public void CalcularMenorCustoTest6()
        {
            magias.Add(new Magia(5, 200));

            Assert.AreEqual(25, this.caso.CalcularMenorCusto(this.monstro, this.magias));
        }


        [TestMethod()]
        public void CalcularMenorCustoTest7()
        {
            magias.Add(new Magia(70, 700));
            magias.Add(new Magia(30, 300));

            Assert.AreEqual(100, this.caso.CalcularMenorCusto(this.monstro, this.magias));
        }

        [TestMethod()]
        public void CalcularMenorCustoTest8()
        {
            magias.Add(new Magia(70, 700));
            magias.Add(new Magia(30, 150));

            Assert.AreEqual(130, this.caso.CalcularMenorCusto(this.monstro, this.magias));
        }

        [TestMethod()]
        public void CalcularMenorCustoTest9()
        {
            magias.Add(new Magia(70, 700));

            Assert.AreEqual(140, this.caso.CalcularMenorCusto(this.monstro, this.magias));
        }

        [TestMethod()]
        public void CalcularMenorCustoTest10()
        {
            magias.Add(new Magia(50, 500));
            magias.Add(new Magia(50, 1000));

            Assert.AreEqual(50, this.caso.CalcularMenorCusto(this.monstro, this.magias));
        }

        [TestMethod()]
        public void CalcularMenorCustoTest11()
        {
            magias.Add(new Magia(50, 1000));
            magias.Add(new Magia(50, 500));

            Assert.AreEqual(50, this.caso.CalcularMenorCusto(this.monstro, this.magias));
        }

        [TestMethod()]
        public void CalcularMenorCustoTest12()
        {
            magias.Add(new Magia(100, 1000));
            magias.Add(new Magia(10, 100));
            magias.Add(new Magia(1, 1000));

            Assert.AreEqual(1, this.caso.CalcularMenorCusto(this.monstro, this.magias));
        }

        [TestMethod()]
        public void CalcularMenorCustoTest13()
        {
            magias.Add(new Magia(50, 500));
            magias.Add(new Magia(40, 400));
            magias.Add(new Magia(10, 100));

            Assert.AreEqual(100, this.caso.CalcularMenorCusto(this.monstro, this.magias));
        }

        [TestMethod()]
        public void CalcularMenorCustoTest14()
        {
            magias.Add(new Magia(40, 400));
            magias.Add(new Magia(10, 100));

            Assert.AreEqual(100, this.caso.CalcularMenorCusto(this.monstro, this.magias));
        }

        [TestMethod()]
        public void CalcularMenorCustoTest15()
        {
            magias.Add(new Magia(40, -400));
            magias.Add(new Magia(40, 400));
            magias.Add(new Magia(10, 100));

            Assert.AreEqual(100, this.caso.CalcularMenorCusto(this.monstro, this.magias));
        }

        [TestMethod()]
        public void CalcularMenorCustoTest16()
        {
            magias.Add(new Magia(-40, 400));
            magias.Add(new Magia(40, 400));
            magias.Add(new Magia(10, 100));

            Assert.AreEqual(100, this.caso.CalcularMenorCusto(this.monstro, this.magias));
        }

        [TestMethod()]
        public void CalcularMenorCustoTest17()
        {
            magias.Add(new Magia(-40, -400));
            magias.Add(new Magia(-40, -400));
            magias.Add(new Magia(-10, -100));

            Assert.AreEqual(0, this.caso.CalcularMenorCusto(this.monstro, this.magias));
        }
    }
}
using System;
using System.Collections.Generic;
using Goku;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestesCombate
{
    [TestClass]
    public class TesteCombateDinamico
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
            List<Monstro> listaMonstro = new List<Monstro>();
            listaMonstro.Add(monstro);
            int melhorKi = 0;

            CasoDeTeste casoDeTeste = new CasoDeTeste(3, 1, 0, 1);
            casoDeTeste.Goku = goku;
            casoDeTeste.Saloes.Add(new Salao(1, listaMonstro));

            int[,] tabela = Estruturas.PreencherTabelaDinamica(casoDeTeste);
            casoDeTeste.Saloes.ForEach(s =>
            {
                s.Monstros.ForEach(m =>
                {
                    m.CombaterMonstroDinamico(tabela, out melhorKi);
                });
            });

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
            List<Monstro> listaMonstro = new List<Monstro>();
            listaMonstro.Add(monstro);
            int melhorKi = 0;

            CasoDeTeste casoDeTeste = new CasoDeTeste(3, 1, 0, 1);
            casoDeTeste.Goku = goku;
            casoDeTeste.Saloes.Add(new Salao(1, listaMonstro));

            int[,] tabela = Estruturas.PreencherTabelaDinamica(casoDeTeste);
            casoDeTeste.Saloes.ForEach(s =>
            {
                s.Monstros.ForEach(m =>
                {
                    m.CombaterMonstroDinamico(tabela, out melhorKi);
                });
            });

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
            List<Monstro> listaMonstro = new List<Monstro>();
            listaMonstro.Add(monstro);
            int melhorKi = 0;

            CasoDeTeste casoDeTeste = new CasoDeTeste(3, 1, 0, 1);
            casoDeTeste.Goku = goku;
            casoDeTeste.Saloes.Add(new Salao(1, listaMonstro));

            int[,] tabela = Estruturas.PreencherTabelaDinamica(casoDeTeste);
            casoDeTeste.Saloes.ForEach(s =>
            {
                s.Monstros.ForEach(m =>
                {
                    m.CombaterMonstroDinamico(tabela, out melhorKi);
                });
            });

            Assert.AreEqual(melhorKi, 60);
        }

        [TestMethod]
        public void TesteSucesso3()
        {
            List<Magia> magias = new List<Magia>();
            magias.Add(new Magia(15, 20));
            magias.Add(new Magia(30, 35));
            magias.Add(new Magia(20, 25));
            magias.Add(new Magia(40, 45));
            magias.Add(new Magia(10, 10));
            magias.Add(new Magia(35, 40));
            magias.Add(new Magia(25, 30));
            magias.Add(new Magia(45, 50));
            magias.Add(new Magia(50, 55));
            magias.Add(new Magia(55, 60));
            magias.Add(new Magia(60, 65));
            magias.Add(new Magia(65, 70));
            magias.Add(new Magia(70, 75));
            magias.Add(new Magia(75, 80));
            magias.Add(new Magia(80, 85));
            magias.Add(new Magia(85, 90));
            magias.Add(new Magia(90, 95));
            magias.Add(new Magia(95, 100));
            magias.Add(new Magia(100, 105));
            magias.Add(new Magia(105, 110));
            magias.Add(new Magia(110, 115));
            magias.Add(new Magia(115, 120));
            magias.Add(new Magia(120, 125));
            magias.Add(new Magia(125, 130));
            magias.Add(new Magia(130, 135));
            magias.Add(new Magia(135, 140));
            magias.Add(new Magia(140, 145));
            magias.Add(new Magia(145, 150));
            magias.Add(new Magia(150, 155));
            magias.Add(new Magia(155, 160));
            magias.Add(new Magia(160, 165));

            Goku.Goku goku = new Goku.Goku(magias);

            Monstro monstro = new Monstro(null, 200);
            List<Monstro> listaMonstro = new List<Monstro>();
            listaMonstro.Add(monstro);
            int melhorKi = 0;

            CasoDeTeste casoDeTeste = new CasoDeTeste(3, 1, 0, 1);
            casoDeTeste.Goku = goku;
            casoDeTeste.Saloes.Add(new Salao(1, listaMonstro));

            int[,] tabela = Estruturas.PreencherTabelaDinamica(casoDeTeste);
            casoDeTeste.Saloes.ForEach(s =>
            {
                s.Monstros.ForEach(m =>
                {
                    m.CombaterMonstroDinamico(tabela, out melhorKi);
                });
            });

            Assert.AreEqual(melhorKi, 150);
        }

        [TestMethod]
        public void TesteSucesso4()
        {
            List<Magia> magias = new List<Magia>();
            magias.Add(new Magia(1, 100));
            magias.Add(new Magia(100, 10));

            Goku.Goku goku = new Goku.Goku(magias);

            Monstro monstro = new Monstro(null, 1000);
            List<Monstro> listaMonstro = new List<Monstro>();
            listaMonstro.Add(monstro);
            int melhorKi = 0;

            CasoDeTeste casoDeTeste = new CasoDeTeste(3, 1, 0, 1);
            casoDeTeste.Goku = goku;
            casoDeTeste.Saloes.Add(new Salao(1, listaMonstro));

            int[,] tabela = Estruturas.PreencherTabelaDinamica(casoDeTeste);
            casoDeTeste.Saloes.ForEach(s =>
            {
                s.Monstros.ForEach(m =>
                {
                    m.CombaterMonstroDinamico(tabela, out melhorKi);
                });
            });

            Assert.AreEqual(melhorKi, 10);
        }

        [TestMethod]
        public void TesteErro()
        {
            List<Magia> magias = new List<Magia>();
            magias.Add(new Magia(-1, 100000));
            magias.Add(new Magia(-100, -10));

            Goku.Goku goku = new Goku.Goku(magias);

            Monstro monstro = new Monstro(null, 100000);
            List<Monstro> listaMonstro = new List<Monstro>();
            listaMonstro.Add(monstro);
            int melhorKi = 0;

            CasoDeTeste casoDeTeste = new CasoDeTeste(3, 1, 0, 1);
            casoDeTeste.Goku = goku;
            casoDeTeste.Saloes.Add(new Salao(1, listaMonstro));

            int[,] tabela = Estruturas.PreencherTabelaDinamica(casoDeTeste);
            casoDeTeste.Saloes.ForEach(s =>
            {
                s.Monstros.ForEach(m =>
                {
                    m.CombaterMonstroDinamico(tabela, out melhorKi);
                });
            });

            Assert.AreEqual(melhorKi, 1);
        }

        [TestMethod]
        public void TesteErro1()
        {
            Goku.Goku goku = new Goku.Goku();

            Monstro monstro = new Monstro(null, 1000);
            List<Monstro> listaMonstro = new List<Monstro>();
            listaMonstro.Add(monstro);
            int melhorKi = 0;

            CasoDeTeste casoDeTeste = new CasoDeTeste(3, 1, 0, 1);
            casoDeTeste.Goku = goku;
            casoDeTeste.Saloes.Add(new Salao(1, listaMonstro));

            int[,] tabela = Estruturas.PreencherTabelaDinamica(casoDeTeste);
            casoDeTeste.Saloes.ForEach(s =>
            {
                s.Monstros.ForEach(m =>
                {
                    m.CombaterMonstroDinamico(tabela, out melhorKi);
                });
            });

            Assert.AreEqual(melhorKi, -1);
        }

        [TestMethod]
        public void TesteErro2()
        {
            List<Magia> magias = new List<Magia>();
            magias.Add(new Magia(1, 100));
            magias.Add(new Magia(100, 10));

            Goku.Goku goku = new Goku.Goku(null);

            Monstro monstro = new Monstro(null, 1000);
            List<Monstro> listaMonstro = new List<Monstro>();
            listaMonstro.Add(monstro);
            int melhorKi = 0;

            CasoDeTeste casoDeTeste = new CasoDeTeste(3, 1, 0, 1);
            casoDeTeste.Goku = goku;
            casoDeTeste.Saloes.Add(new Salao(1, listaMonstro));

            int[,] tabela = Estruturas.PreencherTabelaDinamica(casoDeTeste);
            casoDeTeste.Saloes.ForEach(s =>
            {
                s.Monstros.ForEach(m =>
                {
                    m.CombaterMonstroDinamico(tabela, out melhorKi);
                });
            });

            Assert.AreEqual(melhorKi, -1);
        }

        [TestMethod]
        public void TesteErro3()
        {
            List<Magia> magias = new List<Magia>();

            Goku.Goku goku = new Goku.Goku(magias);

            Monstro monstro = new Monstro(null, 1000);
            List<Monstro> listaMonstro = new List<Monstro>();
            listaMonstro.Add(monstro);
            int melhorKi = 0;

            CasoDeTeste casoDeTeste = new CasoDeTeste(3, 1, 0, 1);
            casoDeTeste.Goku = goku;
            casoDeTeste.Saloes.Add(new Salao(1, listaMonstro));

            int[,] tabela = Estruturas.PreencherTabelaDinamica(casoDeTeste);
            casoDeTeste.Saloes.ForEach(s =>
            {
                s.Monstros.ForEach(m =>
                {
                    m.CombaterMonstroDinamico(tabela, out melhorKi);
                });
            });

            Assert.AreEqual(melhorKi, -1);
        }
    }
}

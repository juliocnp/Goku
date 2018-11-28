using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Goku;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestesCombate
{
    [TestClass]
    public class TesteCriarObejtos
    {
        [TestMethod]
        public void TesteSucesso()
        {
            var texto = MockArquivo.Arquivo1();
            Estruturas.LerArquivo(null, texto);
            Testar();
            Testar2();
        }

        

        [TestMethod]
        public void TesteSucesso1()
        {
            var texto = MockArquivo.Arquivo2();
            Estruturas.LerArquivo(null, texto);
            Testar();
            Testar2();
        }

        [TestMethod]
        public void TesteSucesso2()
        {
            var texto = MockArquivo.Arquivo3();
            Estruturas.LerArquivo(null, texto);
            Testar();
            Testar2();
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void TesteErro()
        {
            var texto = MockArquivo.Arquivo4();
            Estruturas.LerArquivo(null, texto);
            Testar();
            Testar2();
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void TesteErro2()
        {
            var texto = MockArquivo.Arquivo5();
            Estruturas.LerArquivo(null, texto);
            Testar();
            Testar2();
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void TesteErro3()
        {
            var texto = MockArquivo.Arquivo6();
            Estruturas.LerArquivo(null, texto);
            Testar();
            Testar2();
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void TesteErro4()
        {
            var texto = MockArquivo.Arquivo7();
            Estruturas.LerArquivo(null, texto);
            Testar();
            Testar2();
        }

        private static void Testar()
        {
            List<CasoDeTeste> casosDeTeste = Estruturas.Casos;
            Assert.IsInstanceOfType(casosDeTeste, typeof(List<CasoDeTeste>));

            casosDeTeste.ForEach(caso =>
            {
                Assert.IsInstanceOfType(caso, typeof(CasoDeTeste));
                Assert.IsInstanceOfType(caso.Galerias, typeof(List<Galeria>));
                Assert.IsInstanceOfType(caso.Goku, typeof(Goku.Goku));
                Assert.IsInstanceOfType(caso.Goku.Magias, typeof(List<Magia>));
                Assert.IsInstanceOfType(caso.NumeroGaleria, typeof(int));
                Assert.IsInstanceOfType(caso.NumeroMagia, typeof(int));
                Assert.IsInstanceOfType(caso.NumeroMonstro, typeof(int));
                Assert.IsInstanceOfType(caso.NumeroSalao, typeof(int));
                Assert.IsInstanceOfType(caso.Saloes, typeof(List<Salao>));
                caso.Galerias.ForEach(galeria =>
                {
                    Assert.IsInstanceOfType(galeria.Salao1, typeof(Salao));
                    Assert.IsInstanceOfType(galeria.Salao2, typeof(Salao));
                    Assert.IsInstanceOfType(galeria.Salao1.Galeria, typeof(List<Galeria>));
                    Assert.IsInstanceOfType(galeria.Salao1.Monstros, typeof(List<Monstro>));
                    Assert.IsInstanceOfType(galeria.Salao1.NumeroSalao, typeof(int));
                    Assert.IsInstanceOfType(galeria.Salao1.visitado, typeof(bool));
                    galeria.Salao1.Monstros.ForEach(monstro =>
                    {
                        Assert.IsInstanceOfType(monstro.KiNecessario, typeof(int));
                        Assert.IsInstanceOfType(monstro.Salao, typeof(Salao));
                        Assert.IsInstanceOfType(monstro.Vida, typeof(int));
                    });
                    Assert.IsInstanceOfType(galeria.Salao2.Galeria, typeof(List<Galeria>));
                    Assert.IsInstanceOfType(galeria.Salao2.Monstros, typeof(List<Monstro>));
                    Assert.IsInstanceOfType(galeria.Salao2.NumeroSalao, typeof(int));
                    Assert.IsInstanceOfType(galeria.Salao2.visitado, typeof(bool));
                    galeria.Salao2.Monstros.ForEach(monstro =>
                    {
                        Assert.IsInstanceOfType(monstro.KiNecessario, typeof(int));
                        Assert.IsInstanceOfType(monstro.Salao, typeof(Salao));
                        Assert.IsInstanceOfType(monstro.Vida, typeof(int));
                    });
                });
                caso.Goku.Magias.ForEach(magia =>
                {
                    Assert.IsInstanceOfType(magia.Dano, typeof(int));
                    Assert.IsInstanceOfType(magia.Ki, typeof(int));
                });
                caso.Saloes.ForEach(salao =>
                {
                    Assert.IsInstanceOfType(salao.Galeria, typeof(List<Galeria>));
                    Assert.IsInstanceOfType(salao.Monstros, typeof(List<Monstro>));
                    Assert.IsInstanceOfType(salao.NumeroSalao, typeof(int));
                    Assert.IsInstanceOfType(salao.visitado, typeof(bool));
                    salao.Monstros.ForEach(monstro =>
                    {
                        Assert.IsInstanceOfType(monstro.KiNecessario, typeof(int));
                        Assert.IsInstanceOfType(monstro.Salao, typeof(Salao));
                        Assert.IsInstanceOfType(monstro.Vida, typeof(int));
                    });
                });
            });
        }

        private static void Testar2()
        {
            List<CasoDeTeste> casosDeTeste = Estruturas.Casos;
            Assert.IsInstanceOfType(casosDeTeste, typeof(List<CasoDeTeste>));

            casosDeTeste.ForEach(caso =>
            {
                Assert.IsNotNull(caso);
                Assert.IsNotNull(caso.Galerias);
                Assert.IsNotNull(caso.Goku);
                Assert.IsNotNull(caso.Goku.Magias);
                Assert.IsNotNull(caso.NumeroGaleria);
                Assert.IsNotNull(caso.NumeroMagia);
                Assert.IsNotNull(caso.NumeroMonstro);
                Assert.IsNotNull(caso.NumeroSalao);
                Assert.IsNotNull(caso.Saloes);
                caso.Galerias.ForEach(galeria =>
                {
                    Assert.IsNotNull(galeria.Salao1);
                    Assert.IsNotNull(galeria.Salao2);
                    Assert.IsNotNull(galeria.Salao1.Galeria);
                    Assert.IsNotNull(galeria.Salao1.Monstros);
                    Assert.IsNotNull(galeria.Salao1.NumeroSalao);
                    Assert.IsNotNull(galeria.Salao1.visitado);
                    galeria.Salao1.Monstros.ForEach(monstro =>
                    {
                        Assert.IsNotNull(monstro.KiNecessario);
                        Assert.IsNotNull(monstro.Salao);
                        Assert.IsNotNull(monstro.Vida);
                    });
                    Assert.IsNotNull(galeria.Salao2.Galeria);
                    Assert.IsNotNull(galeria.Salao2.Monstros);
                    Assert.IsNotNull(galeria.Salao2.NumeroSalao);
                    Assert.IsNotNull(galeria.Salao2.visitado);
                    galeria.Salao2.Monstros.ForEach(monstro =>
                    {
                        Assert.IsNotNull(monstro.KiNecessario);
                        Assert.IsNotNull(monstro.Salao);
                        Assert.IsNotNull(monstro.Vida);
                    });
                });
                caso.Goku.Magias.ForEach(magia =>
                {
                    Assert.IsNotNull(magia.Dano);
                    Assert.IsNotNull(magia.Ki);
                });
                caso.Saloes.ForEach(salao =>
                {
                    Assert.IsNotNull(salao.Galeria);
                    Assert.IsNotNull(salao.Monstros);
                    Assert.IsNotNull(salao.NumeroSalao);
                    Assert.IsNotNull(salao.visitado);
                    salao.Monstros.ForEach(monstro =>
                    {
                        Assert.IsNotNull(monstro.KiNecessario);
                        Assert.IsNotNull(monstro.Salao);
                        Assert.IsNotNull(monstro.Vida);
                    });
                });
            });
        }
    }
}

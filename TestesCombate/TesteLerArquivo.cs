using System;
using System.Collections.Generic;
using Goku;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestesCombate
{
    [TestClass]
    public class TesteLerArquivo
    {
        [TestMethod]
        public void TesteSucesso()
        {
            var texto = MockArquivo.Arquivo1();

            Estruturas.LerArquivo(null, texto);
        }

        [TestMethod]
        public void TesteSucesso1()
        {
            var texto = MockArquivo.Arquivo2();

            Estruturas.LerArquivo(null, texto);
        }

        [TestMethod]
        public void TesteSucesso2()
        {
            var texto = MockArquivo.Arquivo3();

            Estruturas.LerArquivo(null, texto);
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void TesteErro()
        {
            var texto = MockArquivo.Arquivo4();

            Estruturas.LerArquivo(null, texto);
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void TesteErro1()
        {
            var texto = MockArquivo.Arquivo5();

            Estruturas.LerArquivo(null, texto);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void TesteErro2()
        {
            var texto = MockArquivo.Arquivo6();

            Estruturas.LerArquivo(null, texto);
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void TesteErro3()
        {
            var texto = MockArquivo.Arquivo7();

            Estruturas.LerArquivo(null, texto);
        }
    }
}

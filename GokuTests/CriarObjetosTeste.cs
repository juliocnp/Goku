using Goku;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace GokuTests
{
    public class CriarObjetosTeste
    {
        [TestMethod()]
        public void LerArquivoTeste1()
        {
            Arquivo arq = new Arquivo();
            try
            {
                Arquivo.CriarObjetos(null);
                Assert.IsTrue(true);
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }

    }
}

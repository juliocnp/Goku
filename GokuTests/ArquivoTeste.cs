using Goku;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GokuTests
{
    [TestClass()]
    public class ArquivoTeste
    {
        [TestMethod()]
        public void LerArquivoTeste1()
        {
            Arquivo arq = new Arquivo();
            Assert.Equals(null, arq.LerArquivo(null));
        }

    }
}

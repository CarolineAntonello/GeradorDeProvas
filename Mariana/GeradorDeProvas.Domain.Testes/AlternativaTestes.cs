using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GeradorDeProvas.Domain.Testes
{
    [TestClass]
    public class AlternativaTestes
    {
        [TestMethod]
        public void NaoDeveriaPermitirAlternativaComMenosDeQuatroCaracteres()
        {
            try
            {
                Alternativa alternativa = new Alternativa() { Descricao = "" };
                alternativa.Validar();
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Deve ter uma alternativa com mais de 1 caracteres!");
                return;
            }
            Assert.Fail();
        }

        [TestMethod]
        public void NaoDeveriaPermitirAlternativaComMaisDe150Caracteres()
        {
            try
            {
                Alternativa alternativa = new Alternativa() { Descricao = "testanduiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiogdsdfvsvscwgcbwevbwebvshbcvsjbfsgefwagefawfwyafsfuawigfawefawhfbawfegawfyawebefhawfaasafawg" };
                alternativa.Validar();
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Não deve ter uma alternativa com mais de 150 caracteres!");
                return;
            }
            Assert.Fail();
        }

        [TestMethod]
        public void MetodoToStringAlternativa()
        {
            Alternativa alternativa = new Alternativa();

            alternativa.Descricao = "testando";

            Assert.AreEqual(alternativa.ToString(), "testando");

        }

        [TestMethod]
        public void TesteClasseValidarAlternativas()
        {
            try
            {
                Alternativa alternativa = new Alternativa() { Descricao = "testando" };
                alternativa.Validar();
            }
            catch (Exception ex)
            {
                Assert.Fail();
                return;
            }

        }
    }
}

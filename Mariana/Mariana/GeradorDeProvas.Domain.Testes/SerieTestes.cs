using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GeradorDeProvas.Domain.Testes
{
    [TestClass]
    public class SerieTestes
    {
        [TestMethod]
        public void NaoDeveriaPermitirNomeComMaisDeUmCaracteres()
        {
            try
            {
                Serie serie = new Serie() { Nome = "tes" };
                serie.Validar();
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Não deve ter um nome com mais de 1 caractere!");
                return;
            }
            Assert.Fail();
        }
        [TestMethod]
        public void NaoDeveriaPermitirNomeZero()
        {
            try
            {
                Serie serie = new Serie() { Nome = "0" };
                serie.Validar();
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Série inválida, insira uma de 1 a 9");
                return;
            }
            Assert.Fail();
        }
        [TestMethod]
        public void NaoDeveriaPermitirNomeVazio()
        {
            try
            {
                Serie serie = new Serie() { Nome = "" };
                serie.Validar();
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Deve conter um número!");
                return;
            }
            Assert.Fail();
        }
        [TestMethod]
        public void NaoDeveriaPermitirNomeComLetra()
        {
            try
            {
                Serie serie = new Serie() { Nome = "T" };
                serie.Validar();
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Somente permitido numeros");
                return;
            }
            Assert.Fail();
        }
        [TestMethod]
        public void DevePermitirCadastrarUmNumero()
        {
            try
            {
                Serie serie = new Serie() { Nome = "3" };
                serie.Validar();
            }
            catch (Exception)
            {
               Assert.Fail();
                return;
            }
            
        }
        [TestMethod]
        public void NaoDeveriaPermitirMaiorQueNove()
        {
            try
            {
                Serie serie = new Serie() { Nome = "10" };
                serie.Validar();
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Não deve ter um nome com mais de 1 caractere!");
                return;
            }
            Assert.Fail();
        }

        [TestMethod]
        public void MetodoToStringSerie()
        {
            Serie serie = new Serie();

            serie.Nome = "1";

            Assert.AreEqual(serie.ToString(), "1ª série");

        }


    }
}

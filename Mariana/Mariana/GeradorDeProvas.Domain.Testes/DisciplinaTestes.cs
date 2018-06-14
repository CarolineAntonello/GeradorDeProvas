using GeradorDeProvas.Domain;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GeradorDeProvas.Testes
{
    [TestClass]
    public class DisciplinaTestes
    {
        [TestMethod]
        public void NaoDeveriaPermitirNomeComMenosDeQuatroCaracteres()
        {
            try
            {
                Disciplina disciplina = new Disciplina() { Nome = "tes" };
                disciplina.Validar();
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Deve ter um nome com mais de 4 caracteres!");
                return;
            }
            Assert.Fail();
        }

        [TestMethod]
        public void NaoDeveriaPermitirNomeComMaisDe25Caracteres()
        {
            try
            {
                Disciplina disciplina = new Disciplina() { Nome = "testanduiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiio" };
                disciplina.Validar();
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Não deve ter um nome com mais de 25 caracteres!");
                return;
            }
            Assert.Fail();
        }


        [TestMethod]
        public void NaoPodeConterNumeros()
        {
            try
            {
                Disciplina disciplina = new Disciplina() { Nome = "teste1" };
                disciplina.Validar();
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Nome não pode conter numeros!");
                return;
            }
            Assert.Fail();
        }

        [TestMethod]
        public void NaoPodeConterCaracteresEspeciais()
        {
            try
            {
                Disciplina disciplina = new Disciplina() { Nome = "teste@" };
                disciplina.Validar();
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Nome não pode conter caracteres especiais!");
                return;
            }
            Assert.Fail();
        }


        [TestMethod]
        public void MetodoToStringDisciplina()
        {
            Disciplina disciplina = new Disciplina();

            disciplina.Nome = "testando";

            Assert.AreEqual(disciplina.ToString(),"testando");

        }

        [TestMethod]
        public void TesteClasseValidar()
        {
            try
            {
                Disciplina disciplina = new Disciplina() { Nome = "testando" };
                disciplina.Validar();
            }
            catch (Exception ex)
            {
                Assert.Fail();
                return;
            }

        }
    }
}

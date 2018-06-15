using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GeradorDeProvas.Domain.Testes
{
    [TestClass]
    public class MateriaTestes
    {
        [TestMethod]
        public void NaoDeveriaPermitirNomeComMenosDeQuatroCaracteres()
        {
            try
            {
                Materia materia = new Materia() { Nome = "tes" };
                materia.Validar();
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
                Materia materia = new Materia() { Nome = "testanduiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiio" };
                materia.Validar();
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Não deve ter um nome com mais de 25 caracteres!");
                return;
            }
            Assert.Fail();
        }



        [TestMethod]
        public void NaoPodeConterCaracteresEspeciais()
        {
            try
            {
                Materia materia = new Materia() { Nome = "teste@" };
                materia.Validar();
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Nome não pode conter caracteres especiais!");
                return;
            }
            Assert.Fail();
        }

        [TestMethod]
        public void NaoPodeConterDisciplinaVazia()
        {
            try
            {
                Materia materia = new Materia() { Nome = "Matemática" };
                materia.Validar();
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Não pode conter disciplina vazia!");
                return;
            }
            Assert.Fail();
        }

        [TestMethod]
        public void MetodoToStringMateria()
        {
            Materia materia = new Materia();
            
            materia.Nome = "testando";
            Serie serie = new Serie() { Nome = "1" };
            materia.Serie = serie;
            Disciplina disciplina = new Disciplina() { Nome = "2" };
            materia.Disciplina = disciplina;

            Assert.AreEqual(materia.ToString(), "Matéria: testando - Disciplina: 2 - 1ª série");

        }

        [TestMethod]
        public void TesteClasseValidar()
        {
            try
            {
                Disciplina disciplina = new Disciplina() { Nome = "testando" };
                Serie serie = new Serie() { Nome = "1" };
                Materia materia = new Materia() { Nome = "Matemática", Disciplina = disciplina, Serie = serie };
                materia.Validar();
            }
            catch (Exception ex)
            {
                Assert.Fail();
                return;
            }
           
        }
    }
}


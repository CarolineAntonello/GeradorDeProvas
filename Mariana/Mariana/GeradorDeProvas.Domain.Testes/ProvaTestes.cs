using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GeradorDeProvas.Domain.Testes
{
    [TestClass]
    public class ProvaTestes
    {
        [TestMethod]
        public void DeveTerNoMinimoUmaQuestao()
        {
            try
            {
                Prova prova = new Prova() { QuantidadeQuestoes = 0 };
                prova.Validar();
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Deve ter no minimo 1 questão!");
                return;
            }
            Assert.Fail();
        }

        [TestMethod]
        public void DeveTerNoMaximo30Questoes()
        {
            try
            {
                Prova prova = new Prova() { QuantidadeQuestoes = 31 };
                prova.Validar();
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Deve ter no maximo 30 questões!");
                return;
            }
            Assert.Fail();
        }

        [TestMethod]
        public void NaoPodeConterSerieVazia()
        {
            try
            {
                Prova prova = new Prova() { QuantidadeQuestoes = 1, Serie = null};
               
                prova.Validar();
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Não pode conter série vazia!");
                return;
            }
            Assert.Fail();
        }

        [TestMethod]
        public void NaoPodeConterDisciplinaVazia()
        {
            try
            {
                Prova prova = new Prova() { };
                prova.QuantidadeQuestoes = 1;
                prova.Serie = new Serie() { Nome = "1" };
                prova.Disciplina = null;

                prova.Validar();
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Não pode conter disciplina vazia!");
                return;
            }
            Assert.Fail();
        }

        [TestMethod]
        public void NaoPodeConterMateriaVazia()
        {
            try
            {
                Prova prova = new Prova() { };
                prova.QuantidadeQuestoes = 1;
                prova.Serie = new Serie() { Nome = "1" };
                prova.Disciplina = new Disciplina() { Nome = "Matematica"};
                prova.Materia = null;

                prova.Validar();
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Não pode conter matéria vazia!");
                return;
            }
            Assert.Fail();
        }

        [TestMethod]
        public void NaoPodeSalvarProvaSemQuestoes()
        {
            try
            {
                Prova prova = new Prova() { };
                prova.QuantidadeQuestoes = 1;
                prova.Serie = new Serie() { Nome = "1" };
                prova.Disciplina = new Disciplina() { Nome = "Matematica" };
                prova.Materia = new Materia() { Nome = "Questoes Numericas" };
                

                prova.Validar();
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Não pode salvar prova sem questões!");
                return;
            }
            Assert.Fail();
        }

        [TestMethod]
        public void NaoPodeTerQuantidadeQuestoesMaiorQueSolicitada()
        {
            try
            {
                Prova prova = new Prova() { };
                prova.QuantidadeQuestoes = 2;
                prova.Serie = new Serie() { Nome = "1" };
                prova.Disciplina = new Disciplina() { Nome = "Matematica" };
                prova.Materia = new Materia() { Nome = "Questoes Numericas" };
                prova.Questoes.Add(new Questao() { Pergunta = "1 + 1" });
                prova.Validar();
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Número solicitado maior que o número de questões cadastradas");
                return;
            }
            Assert.Fail();
        }

        [TestMethod]
        public void MetodoToStringProva()
        {
            Prova prova = new Prova() { };
            prova.QuantidadeQuestoes = 1;
            prova.Serie = new Serie() { Nome = "1" };
            prova.Disciplina = new Disciplina() { Nome = "Matematica" };
            prova.Materia = new Materia() { Nome = "Questoes Numericas" };
            prova.Questoes.Add(new Questao() { Pergunta = "1 + 1" });
            

            Assert.AreEqual(prova.ToString(), "1ª série  Disciplina: Matematica - Matéria: Questoes Numericas - Nº Questões: 1");

        }

    }
}

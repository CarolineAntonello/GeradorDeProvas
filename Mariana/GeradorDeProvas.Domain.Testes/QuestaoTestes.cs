using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace GeradorDeProvas.Domain.Testes
{
    [TestClass]
    public class QuestaoTestes
    {
        [TestMethod]
        public void NaoDeveriaPermitirNomeComMenosDeQuatroCaracteres()
        {
            try
            {
                Questao questao = new Questao() { Pergunta = "tes" };
                questao.Validar();
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Deve ter uma pergunta com mais de 4 caracteres!");
                return;
            }
            Assert.Fail();
        }

        [TestMethod]
        public void NaoDeveriaPermitirNomeComMaisDeQuinhentosCaracteres()
        {
            try
            {
                Questao questao = new Questao() { Pergunta = "tefrgefjerthjewgjdgrhjmergtuerytreutyehfgrjhgegfjgfhrjfgwehnfgerhjfgrhfgrfhrgfjrwgfjisugfhryfngewnhftgywefnjgwehtfyuewgnfytgewtynfewngtfyuewhgdfuewghtyewhtdfuewghtdfyuewgfduiewgfdewghdfewghdfewghdfewhgdfewhfewhyfewgyfgewyjhfgewfhjegfhewtfyewtfyhewtfyewftyewftyewtfyftewtfewyjftewjftewjyfewtjfewtfjadtfysfteuftwdyftdshfdstfhdshtftdshfdsthfgdstgfhdstfsdhfgedshftewhfgdsfgdsfdshfdshfdshfgdshfgtdsjfgewjyfgewfyjgewfewudgweudyewgyduwedgewydgweudgewdgewgdyuewgdyudgwydgweydgewdgewygdewydgewydewgdewgdyudgewydugwedgewyudgewdyugewyudwgdgdyuegdewgdyeds" };
                questao.Validar();
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Não deve ter uma pergunta com mais de 500 caracteres!");
                return;
            }
            Assert.Fail();
        }

        [TestMethod]
        public void NaoPodeConterAlternativaVazia()
        {
            try
            {
                Questao questao = new Questao() { Pergunta = "Quanto é 100 + 1 ?" };
                questao.Validar();
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Não deve ter alternativas vazias!");
                return;
            }
            Assert.Fail();
        }

        [TestMethod]
        public void NaoPodeConterMateriaVazia()
        {
            try
            {
                Questao questao = new Questao() { Pergunta = "Quanto é 100 + 1 ?" };
                Alternativa alternativa = new Alternativa() { Descricao = "lalalalalalalaaaaaaa" };
                questao.Alternativas.Add(alternativa);
                questao.Validar();
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Não pode conter matéria vazia!");
                return;
            }
            Assert.Fail();
        }

        [TestMethod]
        public void DeveTerPeloMenosDuasAlternativas()
        {
            try
            {
                Questao questao = new Questao() { Pergunta = "Quanto é 100 + 1 ?" };
                Alternativa alternativa = new Alternativa() { Descricao = "lalalalalalalaaaaaaa" };
                Materia materia = new Materia() { Nome = "Matemática" };
                questao.Alternativas.Add(alternativa);
                questao.Materia = materia;
                questao.Validar();
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Cadastre pelo menos duas alternativas!");
                return;
            }
            Assert.Fail();
        }

        [TestMethod]
        public void MetodoToStringQuestaoMenos30Caracteres()
        {
            Questao questao = new Questao() { Pergunta = "wafaewfaevewvvewve" };
            Materia materia = new Materia() { Nome = "Matemática" };
            materia.Serie = new Serie() { Nome = "1" };
            materia.Disciplina = new Disciplina() { Nome = "Aritmética" };
            questao.Materia = materia;
            questao.Bimestre = Enum.Bimestre.Primeiro;


            Assert.AreEqual(questao.ToString(), "Questão: wafaewfaevewvvewve, Matéria: Matemática, Série: 1, Disciplina: Aritmética");

        }

        [TestMethod]
        public void MetodoToStringQuestaoMais30Caracteres()
        {
            Questao questao = new Questao() { Pergunta = "wafaewfaevewvvewvewwwwwwwwwwwwaaawed2rfc3rt5g4y6gfedwrd4y6" };
            Materia materia = new Materia() { Nome = "Matemática" };
            materia.Serie = new Serie() { Nome = "1" };
            materia.Disciplina = new Disciplina() { Nome = "Aritmética" };
            questao.Materia = materia;
            questao.Bimestre = Enum.Bimestre.Primeiro;


            Assert.AreEqual(questao.ToString(), "Questão: wafaewfaevewvvewvewwwwwwwwwwww..., Matéria: Matemática, Série: 1, Disciplina: Aritmética");

        }

        [TestMethod]
        public void ValidaExistenciaAlternativa()
        {
            try
            {
                Questao questao = new Questao() { Pergunta = "Quanto é 100 + 1 ?" };
                Alternativa alternativa = new Alternativa() { Descricao = "lalalalalalalaaaaaaa" };
                questao.Alternativas.Add(alternativa);
                questao.ValidaExistenciaAlternativa("lalalalalalalaaaaaaa");
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Alternativa já cadastrada");
                return;
            }
            Assert.Fail();
        }

        [TestMethod]
        public void MetodoValidarClasseQuestao()
        {
            try
            {
                Questao questao = new Questao() { Pergunta = "wafaewfaevewvvewve" };
                Materia materia = new Materia() { Nome = "Matemática" };
                materia.Serie = new Serie() { Nome = "1" };
                materia.Disciplina = new Disciplina() { Nome = "Aritmética" };
                Alternativa alternativa = new Alternativa() { Descricao = "lalalalalalalaaaaaaa" };
                questao.Materia = materia;
                questao.Alternativas.Add(alternativa);
                alternativa = new Alternativa() { Descricao = "lalallalalaaaaaaadwad" };
                questao.Alternativas.Add(alternativa);
                questao.Bimestre = Enum.Bimestre.Primeiro;
                questao.Validar();
            }
            catch (Exception)
            {
                Assert.Fail();
                return;
            }
        }
    }
}

using GeradorDeProvas.Domain.Abstract;
using System;
using System.Collections.Generic;

namespace GeradorDeProvas.Domain
{
    public class Prova : Entidade
    {
        public Serie Serie { get; set; }
        public Materia Materia { get; set; }
        public Disciplina Disciplina { get; set; }
        public int QuantidadeQuestoes { get; set; }
        public List<Questao> Questoes { get; set; } // Ver depois

        public Prova()
        {
            Questoes = new List<Questao>();
        }

        public override void Validar()
        {
            if (QuantidadeQuestoes < 1)
                throw new Exception("Deve ter no minimo 1 questão!");

            if (QuantidadeQuestoes > 30)
                throw new Exception("Deve ter no maximo 30 questões!");
            
            if (Serie == null)
                throw new Exception("Não pode conter série vazia!");

            if (Disciplina == null)
                throw new Exception("Não pode conter disciplina vazia!");

            if (Materia == null)
                throw new Exception("Não pode conter matéria vazia!");

            if (Questoes.Count == 0)
                throw new Exception("Não pode salvar prova sem questões!");

            if(QuantidadeQuestoes > Questoes.Count)
                throw new Exception("Número solicitado maior que o número de questões cadastradas");
        }

        public override string ToString()
        {
            return string.Format("{0}  Disciplina: {1} - Matéria: {2} - Nº Questões: {3}", this.Serie.ToString(),this.Disciplina.Nome, this.Materia.Nome, this.QuantidadeQuestoes);
        }

    }
}

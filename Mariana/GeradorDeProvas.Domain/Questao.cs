using GeradorDeProvas.Domain.Abstract;
using GeradorDeProvas.Domain.Enum;
using System;
using System.Collections.Generic;

namespace GeradorDeProvas.Domain
{
    public class Questao : Entidade
    {
        public string Pergunta { get; set; }
        public Materia Materia { get; set; }
        public Bimestre Bimestre { get; set; }
        public List<Alternativa> Alternativas { get; set; }

        public Questao()
        {
            Alternativas = new List<Alternativa>();
        }
        public override void Validar()
        {            
          if (Pergunta.Length < 4 || String.IsNullOrEmpty(Pergunta))
                throw new Exception("Deve ter uma pergunta com mais de 4 caracteres!");

            if (Pergunta.Length > 500 || String.IsNullOrEmpty(Pergunta))
                throw new Exception("Não deve ter uma pergunta com mais de 500 caracteres!");

            if (Alternativas.Count <= 0)
                throw new Exception("Não deve ter alternativas vazias!");

            if (Materia == null)
                throw new Exception("Não pode conter matéria vazia!");

            if (Alternativas.Count < 2 )
                throw new Exception("Cadastre pelo menos duas alternativas!");
        }

        public override string ToString()
        {
            const int MaxTamanhoTexto = 30;
            string TextoLimitado;
            if (Pergunta.Length > MaxTamanhoTexto)
            {
                TextoLimitado = Pergunta.Substring(0, MaxTamanhoTexto) + "...";
                return "Questão: " + TextoLimitado + ", Matéria: " + Materia.Nome + ", Série: " + Materia.Serie.Nome +
                        ", Disciplina: " + Materia.Disciplina.Nome;
            }
            else
            {
                return "Questão: " + Pergunta + ", Matéria: " + Materia.Nome + ", Série: " + Materia.Serie.Nome +
                       ", Disciplina: " + Materia.Disciplina.Nome;
            }
        }

        public void ValidaExistenciaAlternativa(string alternativa)
        {
            foreach (var item in Alternativas)
            {
                if (item.Descricao.Equals(alternativa))
                {
                    throw new Exception("Alternativa já cadastrada");
                }
            }
        }
        public override bool Equals(object obj)
        {
            Questao questao = obj as Questao;
            if (questao == null)
                return false;
            else
                return Id.Equals(questao.Id);
        }
    }
}

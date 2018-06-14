using GeradorDeProvas.Domain.Abstract;
using System;

namespace GeradorDeProvas.Domain
{
    public class Alternativa : Entidade
    {
        public string Descricao { get; set; }
        public bool IsVerdadeira { get; set; }
        public int IdQuestao { get; set; }

        public override void Validar()
        {
            if (Descricao.Length < 1 || String.IsNullOrEmpty(Descricao))
                throw new Exception("Deve ter uma alternativa com mais de 1 caracteres!");

            if (Descricao.Length > 150 || String.IsNullOrEmpty(Descricao))
                throw new Exception("Não deve ter uma alternativa com mais de 150 caracteres!");
        }

        public override string ToString()
        {
            return this.Descricao;
        }
    }
}
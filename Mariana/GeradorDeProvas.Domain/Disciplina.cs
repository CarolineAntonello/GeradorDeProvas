using System;
using GeradorDeProvas.Domain.Helper;
using GeradorDeProvas.Domain.Abstract;

namespace GeradorDeProvas.Domain
{
    public class Disciplina : Entidade
    {
        public string Nome { get; set; }
        public override void Validar()
        {
            if (Nome.Length < 4 || String.IsNullOrEmpty(Nome))
                throw new Exception("Deve ter um nome com mais de 4 caracteres!");
            if (Nome.Length > 25 || String.IsNullOrEmpty(Nome))
                throw new Exception("Não deve ter um nome com mais de 25 caracteres!");
            if (Util.VerificarExistenciaNumeros(Nome))
                throw new Exception("Nome não pode conter numeros!");
            if (Util.VerificarExistenciaCaractereExpeciais(Nome))
                throw new Exception("Nome não pode conter caracteres especiais!");

        }

        public override string ToString()
        {
            return this.Nome;
        }
        public override bool Equals(object obj)
        {
            Disciplina disciplina = obj as Disciplina;
            if (disciplina == null)
                return false;
            else
                return Id.Equals(disciplina.Id);
        }
    }
}

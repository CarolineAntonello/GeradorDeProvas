using GeradorDeProvas.Domain.Abstract;
using System;
using GeradorDeProvas.Domain.Helper;

namespace GeradorDeProvas.Domain
{
    public class Materia : Entidade
    {
        public string Nome { get; set; }
        public Disciplina Disciplina { get; set; }
        public Serie Serie { get; set; }
        
        public override void Validar()
        {
            ///campo nome da materia
            if (Nome.Length < 4 || String.IsNullOrEmpty(Nome))
                throw new Exception("Deve ter um nome com mais de 4 caracteres!");

            if (Nome.Length > 25 || String.IsNullOrEmpty(Nome))
                throw new Exception("Não deve ter um nome com mais de 25 caracteres!");

            if (Util.VerificarExistenciaCaractereExpeciaisMateria(Nome))
                throw new Exception("Nome não pode conter caracteres especiais!");

            if (Disciplina == null)
                throw new Exception("Não pode conter disciplina vazia!");
        }

        public override string ToString()
        {
            return string.Format("Matéria: {0} - Disciplina: {1} - {2}", this.Nome, this.Disciplina.Nome, this.Serie.ToString());
        }

        public override bool Equals(object obj)
        {
            Materia materia = obj as Materia;
            if (materia == null)
                return false;
            else
                return Id.Equals(materia.Id);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }
}

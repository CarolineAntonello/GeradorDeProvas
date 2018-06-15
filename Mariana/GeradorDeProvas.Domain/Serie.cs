using GeradorDeProvas.Domain.Abstract;
using GeradorDeProvas.Domain.Helper;
using System;

namespace GeradorDeProvas.Domain
{
    public class Serie : Entidade
    {
        public string Nome { get; set; }
        public override void Validar()
        {
            if (Nome.Length < 1 || String.IsNullOrEmpty(Nome))
                throw new Exception("Deve conter um número!");

            if (Nome.Length > 1 || String.IsNullOrEmpty(Nome))
                throw new Exception("Não deve ter um nome com mais de 1 caractere!");

            if (Util.VerificarExistenciaLetras(Nome) ||Util.VerificarExistenciaCaractereExpeciais(Nome))
                throw new Exception("Somente permitido numeros");

            if (Nome.Equals("0"))
                throw new Exception("Série inválida, insira uma de 1 a 9");
        }

        public override string ToString()
        {
            return this.Nome+"ª série";
        }

        public override bool Equals(object obj)
        {
            Serie serie = obj as Serie;
            if (serie == null)
                return false;
            else
                return Id.Equals(serie.Id);
        }
    }
}

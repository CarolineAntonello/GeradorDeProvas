using System;

namespace GeradorDeProvas.Infra.Excecao
{
    public class DuplicadoException : Exception
    { 
        public DuplicadoException (string message): base(message)
        {
        }
    }
}

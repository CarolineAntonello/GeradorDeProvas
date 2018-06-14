using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeProvas.Infra.Excecao
{
    public class DuplicadoException : Exception
    { 
        public DuplicadoException (string message): base(message)
        {
        }
    }
}

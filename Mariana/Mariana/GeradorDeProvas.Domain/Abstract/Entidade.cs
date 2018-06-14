using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeProvas.Domain.Abstract
{
    public abstract class Entidade
    {
        public int Id { get; set; }

        public abstract void Validar();

    }
}

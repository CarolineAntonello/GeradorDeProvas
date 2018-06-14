using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeProvas.Domain.Interface
{
    public interface IMateriaRepository : IRepository<Materia>
    {
        List<Materia> GetByNome(Materia materia);
    }
}

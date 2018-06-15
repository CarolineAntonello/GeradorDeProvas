using System.Collections.Generic;

namespace GeradorDeProvas.Domain.Interface
{
    public interface IMateriaRepository : IRepository<Materia>
    {
        List<Materia> GetByNome(Materia materia);
    }
}

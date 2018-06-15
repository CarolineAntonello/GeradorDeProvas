using System.Collections.Generic;

namespace GeradorDeProvas.Domain.Interface
{
    public interface IProvaRepository : IRepository<Prova>
    {
        List<Prova> GetByNome(Prova prova);
    }
}

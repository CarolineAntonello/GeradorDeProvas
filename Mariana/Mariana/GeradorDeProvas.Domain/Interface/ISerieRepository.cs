using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeProvas.Domain.Interface
{
    public interface ISerieRepository : IRepository<Serie>
    {
        Serie GetByNome(Serie serie);
        Serie ConfereMateria(int Id);
    }
}

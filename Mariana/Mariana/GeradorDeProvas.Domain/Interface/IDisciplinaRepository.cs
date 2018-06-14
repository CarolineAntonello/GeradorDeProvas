using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeProvas.Domain.Interface
{
    public interface IDisciplinaRepository : IRepository<Disciplina>
    {
        Disciplina ConfereMateria(int Id);

        Disciplina GetByNome(Disciplina disciplina);
    }
}

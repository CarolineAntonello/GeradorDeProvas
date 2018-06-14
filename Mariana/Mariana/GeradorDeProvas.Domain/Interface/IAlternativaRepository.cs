using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeProvas.Domain.Interface
{
    public interface IAlternativaRepository : IRepository<Alternativa>
    {
        void ExcluirByQuestaoID(int Id);

        List<Alternativa> GetByQuestaoID(int id);
    }
}

using System.Collections.Generic;

namespace GeradorDeProvas.Domain.Interface
{
    public interface IAlternativaRepository : IRepository<Alternativa>
    {
        void ExcluirByQuestaoID(int Id);

        List<Alternativa> GetByQuestaoID(int id);
    }
}

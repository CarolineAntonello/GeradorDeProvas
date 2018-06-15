using System.Collections.Generic;

namespace GeradorDeProvas.Domain.Interface
{
    public interface IQuestaoRepository : IRepository<Questao>
    {
        List<Questao> GetByNome(Questao questao);
       
    }
}

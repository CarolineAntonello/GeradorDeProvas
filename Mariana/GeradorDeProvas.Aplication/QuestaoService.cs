using GeradorDeProvas.Aplication.Abstract;
using GeradorDeProvas.Domain;
using GeradorDeProvas.Infra.Excecao;
using GeradorDeProvas.Domain.Interface;
using GeradorDeProvas.Infra.IOC;

namespace GeradorDeProvas.Aplication
{
    public class QuestaoService : Service<Questao>
    {
        public IQuestaoRepository _repository;

        public QuestaoService(IQuestaoRepository repository) : base(RepositorioIOC.questao)
        {
            _repository = repository;
        }

        public void ValidaDuplicado(Questao questao)
        {
            if (_repository.GetByNome(questao).Count > 0)
            {
                throw new DuplicadoException("Pergunta já existe em outra Questão!");
            }
        }
    }
}

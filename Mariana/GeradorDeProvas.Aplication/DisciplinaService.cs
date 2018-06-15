using GeradorDeProvas.Aplication.Abstract;
using GeradorDeProvas.Domain;
using GeradorDeProvas.Infra.Excecao;
using GeradorDeProvas.Domain.Interface;
using GeradorDeProvas.Infra.IOC;

namespace GeradorDeProvas.Aplication
{
    public class DisciplinaService : Service<Disciplina>
    {
        public IDisciplinaRepository _repository;

        public DisciplinaService(IDisciplinaRepository repository) : base(RepositorioIOC.disciplina)
        {
            _repository = repository;
        }

        public void ValidaDuplicado(Disciplina disciplina)
        {
            if (_repository.GetByNome(disciplina) != null)
            {
                throw new DuplicadoException("Disciplina duplicada.");
            }
        }
    }
}

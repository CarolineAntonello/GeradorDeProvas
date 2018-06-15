using GeradorDeProvas.Aplication.Abstract;
using GeradorDeProvas.Domain;
using GeradorDeProvas.Infra.Excecao;
using GeradorDeProvas.Domain.Interface;
using GeradorDeProvas.Infra.IOC;

namespace GeradorDeProvas.Aplication
{
    public class MateriaService : Service<Materia>
    {
        public IMateriaRepository _repository;

        public MateriaService(IMateriaRepository repository) : base(RepositorioIOC.materia)
        {
            _repository = repository;
        }


        public void ValidaDuplicado(Materia materia)
        {
            if (_repository.GetByNome(materia).Count > 0)
            {
                throw new DuplicadoException("Materia duplicada.");
            }
        }
    }
}

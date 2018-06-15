using GeradorDeProvas.Aplication.Abstract;
using GeradorDeProvas.Domain;
using GeradorDeProvas.Infra.Excecao;
using System;
using GeradorDeProvas.Domain.Interface;
using GeradorDeProvas.Infra.IOC;

namespace GeradorDeProvas.Aplication
{
    public class SerieService : Service<Serie>
    {
        public ISerieRepository _repository;

        public SerieService(ISerieRepository repository) : base(RepositorioIOC.serie)
        {
            _repository = repository;
        }

        public Serie TemMateria(Serie serie)
        {
            try
            {
                return _repository.ConfereMateria(serie.Id);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void ValidaDuplicado(Serie serie)
        {
            if (_repository.GetByNome(serie) != null)
            {
                throw new DuplicadoException("Serie duplicada.");
            }
        }

    }
}

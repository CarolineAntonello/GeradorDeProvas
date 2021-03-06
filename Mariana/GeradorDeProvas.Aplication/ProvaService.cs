﻿using GeradorDeProvas.Aplication.Abstract;
using GeradorDeProvas.Domain;
using GeradorDeProvas.Infra.Excecao;
using GeradorDeProvas.Domain.Interface;
using GeradorDeProvas.Infra.IOC;

namespace GeradorDeProvas.Aplication
{
    public class ProvaService : Service<Prova>
    {
        public IProvaRepository _repository;

        public ProvaService(IProvaRepository repository) : base(RepositorioIOC.prova)
        {
            _repository = repository;
        }


        public void ValidaDuplicado(Prova prova)
        {
            if (_repository.GetByNome(prova).Count > 0)
            {
                throw new DuplicadoException("Prova duplicada.");
            }
        }
    }
}

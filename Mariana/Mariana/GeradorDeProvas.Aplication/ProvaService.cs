using GeradorDeProvas.Aplication.Abstract;
using GeradorDeProvas.Domain;
using GeradorDeProvas.Infra.Data;
using GeradorDeProvas.Infra.Excecao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

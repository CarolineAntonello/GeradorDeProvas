using GeradorDeProvas.Domain.Abstract;
using GeradorDeProvas.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeProvas.Aplication.Abstract
{
    public abstract class Service<T> where T : Entidade
    {
        IRepository<T> _repository;

        public Service(IRepository<T> repository)
        {
            _repository = repository;
        }
        public void Adicionar(T entidade)
        {
            try
            {
                entidade.Validar();
                _repository.Adicionar(entidade);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }


        }

        public void Editar(T entidade)
        {
            try
            {
                entidade.Validar();
                _repository.Editar(entidade);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Excluir(T entidade)
        {
            try
            {
                _repository.Excluir(entidade.Id);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<T> PegarTodos()
        {
            try
            {
                return _repository.PegarTodos();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public T Get(int id)
        {
            try
            {
                return _repository.GetById(id);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

       
    }
}

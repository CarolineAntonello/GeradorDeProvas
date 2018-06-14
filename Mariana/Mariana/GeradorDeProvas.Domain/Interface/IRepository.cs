using GeradorDeProvas.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeProvas.Domain.Interface
{
    public interface IRepository<T> where T : Entidade
    {
        T Adicionar(T entidade);

        void Editar(T entidade);

        void Excluir(int Id);

        List<T> PegarTodos();

        T GetById(int Id);

    }
}

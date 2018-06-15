using GeradorDeProvas.Domain.Abstract;
using System.Collections.Generic;

namespace GeradorDeProvas.Domain.Interface
{
    public interface IRepository<T> where T : Entidade
    {
        T Adicionar(T entidade);

        void Editar(T entidade);

        void Excluir(int Id);

        List<T> PegarTodos();

        T GetById(int Id);

        List<T> Pesquisar(string texto);

    }
}

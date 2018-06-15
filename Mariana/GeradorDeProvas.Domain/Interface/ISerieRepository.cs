namespace GeradorDeProvas.Domain.Interface
{
    public interface ISerieRepository : IRepository<Serie>
    {
        Serie GetByNome(Serie serie);
        Serie ConfereMateria(int Id);
    }
}

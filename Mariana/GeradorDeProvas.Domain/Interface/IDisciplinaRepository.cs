namespace GeradorDeProvas.Domain.Interface
{
    public interface IDisciplinaRepository : IRepository<Disciplina>
    {
        Disciplina ConfereMateria(int Id);

        Disciplina GetByNome(Disciplina disciplina);
    }
}

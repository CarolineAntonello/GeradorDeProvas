namespace GeradorDeProvas.Domain.Abstract
{
    public abstract class Entidade
    {
        public int Id { get; set; }

        public abstract void Validar();

    }
}

using CsvHelper.Configuration;
using GeradorDeProvas.Domain;

namespace GeradorDeProvas.Infra.CSV
{
    public sealed class AlternativaMap : ClassMap<Alternativa>
    {
        public AlternativaMap()
        {
            Map(m => m.Descricao).Name("Descrição da Alternativa");
            Map(m => m.IsVerdadeira).Name("Verdadeira?");
        }
    }
}

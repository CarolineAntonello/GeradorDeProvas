using CsvHelper.Configuration;
using GeradorDeProvas.Domain;

namespace GeradorDeProvas.Infra.CSV
{
    public sealed class ProvaMap : ClassMap<Prova>
    {
        public ProvaMap()
        {
            Map(m => m.Id).Name("Id Prova");
            Map(m => m.QuantidadeQuestoes).Name("Quantidade de questões");
        }
    }
}

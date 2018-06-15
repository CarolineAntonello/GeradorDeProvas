using CsvHelper.Configuration;
using GeradorDeProvas.Domain;

namespace GeradorDeProvas.Infra.CSV
{
    public sealed class QuestaoMap : ClassMap<Questao>
    {
        public QuestaoMap()
        {
            Map(m => m.Pergunta).Name("Pergunta");
            Map(m => m.Bimestre).Name("Bimestre");
        }
    }
}

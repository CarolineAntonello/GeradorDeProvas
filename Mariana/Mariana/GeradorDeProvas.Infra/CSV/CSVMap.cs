using GeradorDeProvas.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using CsvHelper.Configuration;

namespace GeradorDeProvas.Infra.CSV
{
    public class CSVMap
    {
        public CSVMap()
        {
            
        }
    }

        public sealed class ProvaMap : ClassMap<Prova>
    {
        public ProvaMap()
        {
            Map(m => m.Id);
            References<SerieMap>(m => m.Serie);
            References<MateriaMap>(m => m.Serie);
            References<DisciplinaMap>(m => m.Disciplina);
            Map(m => m.QuantidadeQuestoes);
            References<QuestoesMap>(m => m.Questoes);
           
        }
    }

    public sealed class SerieMap : ClassMap<Serie>
    {
        public SerieMap()
        {
            Map(m => m.Nome);
        }
    }

    public sealed class MateriaMap : ClassMap<Materia>
    {
        public MateriaMap()
        {
            Map(m => m.Nome);
        }
    }

    public sealed class DisciplinaMap : ClassMap<Disciplina>
    {
        public DisciplinaMap()
        {
            Map(m => m.Nome);
        }
    }

    public sealed class QuestoesMap : ClassMap<Questao>
    {
        public QuestoesMap()
        {
            Map(m => m.Pergunta).Index(1).Name("Pergunta");
            Map(m => m.Bimestre).Index(2).Name("Bimestre");
            //References<AlternativaMap>(m => m.Alternativas);
        }
    }

    public sealed class AlternativaMap : ClassMap<Alternativa>
    {
        public AlternativaMap()
        {
            Map(m => m.Descricao).Index(1).Name("Descrição da Alternativa");
            Map(m => m.IsVerdadeira).Index(2).Name("Verdadeira?");
        }
    }
}

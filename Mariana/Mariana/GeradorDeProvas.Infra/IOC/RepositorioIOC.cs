using GeradorDeProvas.Domain.Interface;
using GeradorDeProvas.Infra.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeProvas.Infra.IOC
{
    public static class RepositorioIOC
    {
        public static IAlternativaRepository alternativa { get; internal set; }
        public static IDisciplinaRepository disciplina { get; internal set; }
        public static IMateriaRepository materia { get; internal set; }
        public static IProvaRepository prova { get; internal set; }
        public static IQuestaoRepository questao { get; internal set; }
        public static ISerieRepository serie { get; internal set; }

        static RepositorioIOC()
        {
            alternativa = SingletonHelper<AlternativaBDRepository>.Instance();
            disciplina = SingletonHelper<DisciplinaBDRepository>.Instance();
            materia = SingletonHelper<MateriaBDRepository>.Instance();
            prova = SingletonHelper<ProvaBDRepository>.Instance();
            questao = SingletonHelper<QuestaoBDRepository>.Instance();
            serie = SingletonHelper<SerieBDRepository>.Instance();
        }
    }
}

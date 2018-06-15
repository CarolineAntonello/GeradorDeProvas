using CsvHelper;
using GeradorDeProvas.Domain;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace GeradorDeProvas.Infra.CSV
{
    public static class CSVExtension
    {
        /// <summary>
        /// Gera uma string serializada em csv de qualquer objeto não estático.
        /// </summary>
        /// <param name="objs"></param>
        /// <returns>String in CSV format</returns>
        public static void Serialize(Prova prova, string path)
        {
            using (var writer = new StreamWriter(path, false, Encoding.UTF8))
            using (var csvWriter = new CsvWriter(writer))
            {
                csvWriter.Configuration.CultureInfo = CultureInfo.GetCultureInfo("pt-BR");

                csvWriter.Configuration.Delimiter = ";";
                csvWriter.Configuration.HasHeaderRecord = true;
                csvWriter.Configuration.RegisterClassMap<ProvaMap>();
                csvWriter.Configuration.RegisterClassMap<QuestaoMap>();
                csvWriter.Configuration.RegisterClassMap<AlternativaMap>();

                csvWriter.WriteRecord(prova);
                csvWriter.NextRecord();
                foreach (Questao questao in prova.Questoes)
                {
                    csvWriter.WriteRecord(questao);
                    csvWriter.NextRecord();
                    foreach (Alternativa alternativa in questao.Alternativas)
                    {
                        csvWriter.WriteRecord(alternativa);
                        csvWriter.NextRecord();
                    }
                }
                csvWriter.NextRecord();
            }
        }
        /// <summary>
        /// Converte um arquivo csv para uma lista de objetos
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="objs"></param>
        /// <returns></returns>
        public static List<T> Deserialize<T>(this List<T> objs, string path)
        {
            using (var reader = new StreamReader(path))
            {
                var csvReader = new CsvReader(reader);
                return csvReader.GetRecords<T>().ToList();
            }
        }

        public static void Valida<T>(T obj)
        {
            if (obj == null)
                throw new Exception("Não existe nada para exportar!");
        }
    }
}

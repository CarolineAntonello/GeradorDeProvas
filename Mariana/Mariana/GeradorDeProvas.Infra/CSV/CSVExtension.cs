using CsvHelper;
using GeradorDeProvas.Domain;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeProvas.Infra.CSV
{
    public static class CSVExtension
    {
        /// <summary>
        /// Gera uma string serializada em csv de qualquer objeto não estático.
        /// </summary>
        /// <param name="objs"></param>
        /// <returns>String in CSV format</returns>
        public static string Serialize<T>(this T objs, string path)
        {
            using (StreamWriter writer = new StreamWriter(path, false, Encoding.UTF8))
            {
                CsvWriter csvWriter = new CsvWriter(writer);
                csvWriter.Configuration.HasHeaderRecord = true;
                csvWriter.Configuration.Delimiter = ";";
                //csvWriter.Configuration.AutoMap<T>();
                csvWriter.Configuration.RegisterClassMap<QuestoesMap>();
                csvWriter.Configuration.RegisterClassMap<AlternativaMap>();
                csvWriter.WriteRecord(objs);
                //csvWriter.WriteRecord(objs);
            }
            return objs.ToString();
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

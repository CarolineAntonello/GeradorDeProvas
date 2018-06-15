using GeradorDeProvas.Domain;
using GeradorDeProvas.Infra.CSV;
using System;

namespace GeradorDeProvas.Aplication
{
    public class CSVService
    {
        public void ExportarCSV(Prova prova, string path)
        {
            try
            {
                CSVExtension.Valida(prova);
                CSVExtension.Serialize(prova, path);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}

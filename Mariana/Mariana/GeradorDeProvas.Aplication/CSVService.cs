using GeradorDeProvas.Domain;
using GeradorDeProvas.Infra.CSV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeProvas.Aplication
{
    public class CSVService
    {
        public void ExportarCSV(Prova prova, string path)
        {
            try
            {
                CSVExtension.Valida(prova);
                CSVExtension.Serialize<Prova>(prova, path);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}

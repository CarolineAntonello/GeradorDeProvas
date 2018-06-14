using GeradorDeProvas.Domain;
using GeradorDeProvas.Infra.Pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeProvas.Aplication
{
    public class PDFService
    {
        GerarPDF _geradorPDF = new GerarPDF();

        public void CriarProva(Prova prova, string path)
        {
            try
            {
                _geradorPDF.Valida(prova);
                _geradorPDF.CriarProva(prova, path);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

    }
}

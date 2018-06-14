using GeradorDeProvas.Domain;
using GeradorDeProvas.Infra.XML;
using System;

namespace GeradorDeProvas.Aplication
{
    public class XMLService
    {
        public void ExportarXML(Prova prova, string path)
        {
            try
            {
                XMLExtension.Valida(prova);
                XMLExtension.Serialize(prova, path);

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}

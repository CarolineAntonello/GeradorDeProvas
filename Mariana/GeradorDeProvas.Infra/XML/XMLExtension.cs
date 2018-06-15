using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace GeradorDeProvas.Infra.XML
{
    public static class XMLExtension
    {
        /// <summary>
        /// Gera uma string serializada em xml de qualquer objeto não estático.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>String in XML format</returns>
        public static string Serialize<T>(this T obj, string path)
        {
            using (var writer = new StreamWriter(path))
            {
                XmlSerializer serializer = new XmlSerializer(obj.GetType());
                serializer.Serialize(writer, obj);
            }
            return obj.ToString();
        }

       

        /// <summary>
        /// Converte uma string em xml para objeto
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static T Deserialize<T>(this string obj)
        {
            using (XmlReader reader = XmlReader.Create(new StringReader(obj)))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                return (T)serializer.Deserialize(reader);
            }
        }
        public static void Valida<T>(T obj)
        {
            if (obj == null)
                throw new Exception("Não existe nada para exportar!");
        }
    }
}

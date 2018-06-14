using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GeradorDeProvas.Domain.Helper
{
    public class Util
    {
        public static string pattern = @"(?i)[^0-9a-z\s]";

        public static bool VerificarExistenciaNumeros(string palavra)
        {
            for (int i = 0; i < palavra.Count(); i++)
            {
                if (Char.IsNumber(palavra.ElementAt(i)))
                {
                    return true;

                }
            }
            return false;

        }

        public static bool VerificarExistenciaCaractereExpeciais(string palavra)
        {
            string especial = @"|\!#$%¨&*()@_+=:;.,~´´[]{ªº]^";

            foreach (var item in especial)
            {
                if (palavra.Contains(item))
                {
                    return true;
                }
            }
            return false;
        }
        public static bool VerificarExistenciaCaractereExpeciaisMateria(string palavra)
        {
            string especial = @"|\!#$%¨&*@_+=;.~´´[]{}]^";

            foreach (var item in especial)
            {
                if (palavra.Contains(item))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool VerificarExistenciaLetras(string palavra)
        {

            for (int i = 0; i < palavra.Count(); i++)
            {
                if (Char.IsLetter(palavra.ElementAt(i)))
                {
                    return true;

                }
            }
            return false;
        }

        public static bool VerificarExistenciaVazio<Object>(Object obj)
        {
            if(obj == null)
                    return true;

            return false;
        }




    }
}

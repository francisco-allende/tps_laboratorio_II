using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblio_Excepciones;

namespace Entidades
{
    public static class Validator
    {
        static Validator()
        {

        }

        public static bool NoContieneNumeros(string text)
        {
            foreach (char letter in text)
            {
                if(int.TryParse(letter.ToString(), out int num))
                {
                    return false;
                }
            }
            return true;
        }

        public static int NoEsNegativoNiCaracter(string input, int num)
        {
            if (!int.TryParse(input, out num))
            {
                throw new FormatException("Error. No se ingreso un caracter numérico");
            }
            if (num < 0)
            {
                throw new NumeroNegativoException();
            }

            return num;
        }

        public static int NoEsCeroNiCaracter(string input, int num)
        {
            if (!int.TryParse(input, out num))
            {
                throw new FormatException("Error. No se ingreso un caracter numérico");
            }
            if (num <= 0)
            {
                throw new NumeroNegativoException();
            }

            return num;
        }
    }
}

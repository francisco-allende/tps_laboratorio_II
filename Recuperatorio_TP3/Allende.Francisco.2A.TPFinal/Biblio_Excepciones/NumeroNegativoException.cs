using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio_Excepciones
{
    public class NumeroNegativoException :  Exception
    {
        public NumeroNegativoException():this("No se pueden ingresar ni el cero ni numeros negativos")
        {

        }

        public NumeroNegativoException(string message)
            : base(message)
        {

        }

        public NumeroNegativoException(string message, Exception innerException)
            : base(message, innerException)
        {

        }
    }
}

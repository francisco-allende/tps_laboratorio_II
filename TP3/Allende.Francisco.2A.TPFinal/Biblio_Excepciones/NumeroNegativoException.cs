using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio_Excepciones
{
    public class NumeroNegativoException :  Exception
    {
        public NumeroNegativoException()
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

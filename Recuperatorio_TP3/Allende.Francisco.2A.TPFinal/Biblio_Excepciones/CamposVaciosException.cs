using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio_Excepciones
{
    public class CamposVaciosException : Exception
    {
        public CamposVaciosException() : this("No se pueden dejar campos vacios")
        {

        }

        public CamposVaciosException(string message)
            : base(message)
        {

        }

        public CamposVaciosException(string message, Exception innerException)
            : base(message, innerException)
        {

        }
    }
}

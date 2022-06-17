using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio_Excepciones
{
    public class ItemNoSeleccionadoException : Exception
    {
        public ItemNoSeleccionadoException()
        {

        }

        public ItemNoSeleccionadoException(string message)
            : base(message)
        {

        }

        public ItemNoSeleccionadoException(string message, Exception innerException)
            : base(message, innerException)
        {

        }
    }
}

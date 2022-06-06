using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio_Excepciones
{
    public class ItemNoSeleccionado : Exception
    {
        public ItemNoSeleccionado()
        {

        }

        public ItemNoSeleccionado(string message)
            : base(message)
        {

        }

        public ItemNoSeleccionado(string message, Exception innerException)
            : base(message, innerException)
        {

        }
    }
}

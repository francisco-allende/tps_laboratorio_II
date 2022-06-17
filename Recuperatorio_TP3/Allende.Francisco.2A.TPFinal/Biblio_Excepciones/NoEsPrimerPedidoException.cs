using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio_Excepciones
{
    public class NoEsPrimerPedidoException : Exception
    {
        public NoEsPrimerPedidoException()
        {

        }

        public NoEsPrimerPedidoException(string message)
            : base(message)
        {

        }

        public NoEsPrimerPedidoException(string message, Exception innerException)
            : base(message, innerException)
        {

        }
    }
}

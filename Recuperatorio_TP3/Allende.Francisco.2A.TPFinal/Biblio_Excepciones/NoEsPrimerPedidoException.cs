using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio_Excepciones
{
    public class NoEsPrimerPedidoException : Exception
    {
        public NoEsPrimerPedidoException() : this("Un pedido a la vez para un mismo cliente.\nMismo cliente, no se modifica el nombre")
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

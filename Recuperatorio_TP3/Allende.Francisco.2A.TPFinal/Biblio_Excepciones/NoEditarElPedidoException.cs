using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio_Excepciones
{
    public class NoEditarElPedidoException : Exception
    {
        public NoEditarElPedidoException()
        {

        }

        public NoEditarElPedidoException(string message)
            : base(message)
        {

        }

        public NoEditarElPedidoException(string message, Exception innerException)
            : base(message, innerException)
        {

        }
    }
}

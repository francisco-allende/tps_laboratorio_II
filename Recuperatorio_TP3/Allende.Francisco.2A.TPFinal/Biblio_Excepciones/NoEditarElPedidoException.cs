using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio_Excepciones
{
    public class NoEditarElPedidoException : Exception
    {
        public NoEditarElPedidoException():this("No edite el pedido en el medio de un proceso de venta. Cancele y vuelva a empezar")
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

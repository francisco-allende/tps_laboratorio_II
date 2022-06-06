using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio_Excepciones
{
    public class NoEditarElPedido : Exception
    {
        public NoEditarElPedido()
        {

        }

        public NoEditarElPedido(string message)
            : base(message)
        {

        }

        public NoEditarElPedido(string message, Exception innerException)
            : base(message, innerException)
        {

        }
    }
}

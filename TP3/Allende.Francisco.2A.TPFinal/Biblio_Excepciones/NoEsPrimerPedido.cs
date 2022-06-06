using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio_Excepciones
{
    public class NoEsPrimerPedido : Exception
    {
        public NoEsPrimerPedido()
        {

        }

        public NoEsPrimerPedido(string message)
            : base(message)
        {

        }

        public NoEsPrimerPedido(string message, Exception innerException)
            : base(message, innerException)
        {

        }
    }
}

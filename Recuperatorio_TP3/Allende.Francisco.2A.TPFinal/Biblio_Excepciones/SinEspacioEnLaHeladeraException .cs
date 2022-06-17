using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio_Excepciones
{
    public class SinEspacioEnLaHeladeraExcepcion : Exception
    {
        public SinEspacioEnLaHeladeraExcepcion():this("No tenemos suficiente stock en la heladera")
        {

        }

        public SinEspacioEnLaHeladeraExcepcion(string message)
            : base(message)
        {

        }

        public SinEspacioEnLaHeladeraExcepcion(string message, Exception innerException)
            : base(message, innerException)
        {

        }
    }
}

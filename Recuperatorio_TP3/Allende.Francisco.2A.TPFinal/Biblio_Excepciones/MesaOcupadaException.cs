using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio_Excepciones
{
    public class MesaOcupadaException :  Exception
    {
        public MesaOcupadaException():this("Mesa ya ocupada")
        {

        }

        public MesaOcupadaException(string message)
            : base(message)
        {

        }

        public MesaOcupadaException(string message, Exception innerException)
            : base(message, innerException)
        {

        }
    }
}

using System;

namespace Biblio_Excepciones
{
    public class ItemNoEncontradoException :  Exception
    {
        public ItemNoEncontradoException()
        {

        }

        public ItemNoEncontradoException(string message)
            : base(message)
        {

        }

        public ItemNoEncontradoException(string message, Exception innerException)
            : base(message, innerException)
        {

        }
    }
}

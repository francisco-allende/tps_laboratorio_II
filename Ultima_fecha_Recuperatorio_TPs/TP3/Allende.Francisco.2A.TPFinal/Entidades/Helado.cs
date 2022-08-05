using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class Helado : Postre
    {
        public Helado()
        {

        }

        public Helado(int id, int cantidadStock, ETipoPostre tipo, string saborH)
            :base(id, cantidadStock, tipo.ToString(), saborH)
        {
            
        }
    }
}

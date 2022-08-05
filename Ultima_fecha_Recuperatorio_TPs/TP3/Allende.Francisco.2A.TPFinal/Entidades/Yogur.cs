using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class Yogur : Postre
    {
        public Yogur()
        {

        }

        public Yogur(int id, int cantidadStock, ETipoPostre tipo, string saborY)
            :base(id, cantidadStock, tipo.ToString(), saborY)
        {
            
        }
    }
}

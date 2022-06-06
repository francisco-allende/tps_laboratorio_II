using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class Yogur : Postre
    {
        private ESaboresYogur saborY;

        public Yogur()
        {

        }

        public ESaboresYogur SaborY { get => this.saborY; set => this.saborY = value; }

        public Yogur(int id, int cantidadStock, ETipoPostre tipo, ESaboresYogur saborY)
            :base(id, cantidadStock, tipo.ToString(), saborY.ToString())
        {
            this.saborY = saborY;
        }
    }
}

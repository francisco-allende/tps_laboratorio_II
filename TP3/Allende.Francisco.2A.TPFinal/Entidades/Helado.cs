using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class Helado : Postre
    {
        private ESaboresHelado saborH;

        public Helado()
        {

        }

        public Helado(int id, int cantidadStock, ETipoPostre tipo, ESaboresHelado saborH)
            :base(id, cantidadStock, tipo.ToString(), saborH.ToString())
        {
            this.saborH = saborH;
        }

        public ESaboresHelado SaborH { get => this.saborH; set => this.saborH = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class Helado : Postre
    {
        private string saborH;

        public Helado()
        {

        }

        //Insert SQL
        public Helado(int cantidadStock, string tipo, string saborH)
           : base(cantidadStock, tipo, saborH)
        {
            this.saborH = saborH;
        }

        public Helado(string tipo, string saborH)
      : base(tipo, saborH)
        {
            this.saborH = saborH;
        }

        public Helado(int id, int cantidadStock, string tipo, string saborH)
            :base(id, cantidadStock, tipo.ToString(), saborH.ToString())
        {
            this.saborH = saborH;
        }

        public string SaborH { get => this.saborH; set => this.saborH = value; }
    }
}

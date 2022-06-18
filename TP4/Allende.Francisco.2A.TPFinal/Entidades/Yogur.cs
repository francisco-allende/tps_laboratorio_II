using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class Yogur : Postre
    {
        private string saborY;

        public Yogur()
        {

        }

        public string SaborY { get => this.saborY; set => this.saborY = value; }

        public Yogur(int id,  int cantidadStock, string tipo, string saborY)
            :base(id, cantidadStock, tipo, saborY)
        {
            this.saborY = saborY;
        }
        
        public Yogur(int cantidadStock, string tipo, string saborY)
           : base(cantidadStock, tipo, saborY)
        {
            this.saborY = saborY;
        }

        public Yogur(string tipo, string saborY)
       : base(tipo, saborY)
        {
            this.saborY = saborY;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ventas 
    {
        private List<Pedido> listaVentas;

        public Ventas()
        {
            
        }

        public List<Pedido> ListaVentas { get => this.listaVentas; set => this.listaVentas = value; }
    }
}

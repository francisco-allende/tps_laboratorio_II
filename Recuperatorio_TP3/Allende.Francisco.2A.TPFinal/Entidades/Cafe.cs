using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblio_Interfaces;

namespace Entidades
{
    public sealed class Cafe : IEsConsumible 
    {
        private ESaborCafe sabor;
        private double cantidadStock;
        private int id;

        public Cafe()
        {
            
        }

        public Cafe(int id, ESaborCafe sabor, double stockUnidades) 
        {
            this.id = id;
            this.sabor = sabor;
            this.cantidadStock = stockUnidades;
        }

        public override string ToString()
        {
            return $"Id: {this.id}\nSabor: {this.sabor}\nCantidad de stock: {this.cantidadStock}\n";
        }

        public ESaborCafe Sabor { get => this.sabor; set => this.sabor = value; }
        public int Id { get => this.id; set => this.id = value; }
        public double CantidadStock { get => this.cantidadStock; set => this.cantidadStock = value; }
    }
}

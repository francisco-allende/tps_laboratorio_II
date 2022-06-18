using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pedido
    {
        private int id;
        private Cliente clienteQuePide; //cada pedido tiene un solo cliente
        private string tipo;
        private string sabor;
        private double cantidad;
        private double precio;

        public int Id { get => this.id; set => this.id = value; }
        public Cliente ClienteQuePide { get => this.clienteQuePide; set => this.clienteQuePide = value; }
        public string Tipo { get => this.tipo; set => this.tipo = value; }
        public string Sabor { get => this.sabor; set => this.sabor = value; }
        public double Cantidad { get => this.cantidad; set => this.cantidad = value; }
        public double Precio { get => this.precio; set => this.precio = value; }

        public Pedido()
        {

        }

        public Pedido(string tipo)
        {
            this.tipo = tipo;
        }

        public Pedido(int id, Cliente clienteQuePide, string tipo, string sabor, double cantidad, double precio)
        {
            this.id = id;
            this.clienteQuePide = clienteQuePide;
            this.tipo = tipo;
            this.sabor = sabor;
            this.cantidad = cantidad;
            this.precio = precio;
        }

        public static int AsignarId()
        {
            Random radnomId = new Random();
            int id = radnomId.Next(1111, 9999); //es max value -1
            return id;
        }

        private static double SumarIva(double retornoPrecio)
        {
            double recargoIva = retornoPrecio * 0.21;
            return retornoPrecio + recargoIva;
        }

        public static double CalcularPrecio(string tipo, double cantidad)
        {
            double precio = 0;

            if (tipo == "Helado")
            {
                switch (cantidad) //1 = 1kilo, 0.5 = un medio, 0.25 = un cuarto
                {
                    case 1:
                        precio = Pedido.SumarIva(800);
                        break;

                    case 0.5:
                        precio = Pedido.SumarIva(500);
                        break;

                    case 0.25:
                        precio = Pedido.SumarIva(300);
                        break;
                }
            }
            else if (tipo == "Yogur")
            {
                switch (cantidad)
                {
                    case 1:
                        precio = Pedido.SumarIva(600);
                        break;

                    case 0.5:
                        precio = Pedido.SumarIva(400);
                        break;

                    case 0.25:
                        precio = Pedido.SumarIva(250);
                        break;
                }
            }

            return precio;
        }

        /// <summary>
        /// Segun tipo y cantidad, retorna la cantidad por escrito
        /// <paramref name="tipo"/>
        /// <paramref name="cantidad"/>
        /// </summary>
        public string RetornarCantidadEscrito(double cantidad)
        {
            switch (cantidad)
            {
                case 1:
                    return "Un Kilo (1)";

                case 0.5:
                    return "Un Medio (1/2)";

                case 0.25:
                    return "Un Cuarto (1/4)";

                default:
                    return cantidad.ToString();

            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Datos del Pedido: \n");
            sb.AppendLine($" Id: {this.id}\n");
            sb.AppendLine($" Tipo de producto a consumir: {this.tipo}\n");
            sb.AppendLine($" Sabor: {this.sabor}\n");
            sb.AppendLine($" Cantidad: {this.RetornarCantidadEscrito(this.cantidad)}\n");
            sb.AppendLine($" Precio: ${this.precio}");
            sb.AppendLine("**********************\n\n\n");

            return sb.ToString();
        }

        public double CalcularTotal(List<Pedido> lista, Pedido pedido)
        {
            double total = 0;

            foreach (Pedido item in lista)
            {
                if(pedido.ClienteQuePide.Dni == item.ClienteQuePide.Dni)
                {
                    total += item.precio;
                }
            }

            return total;
        }
    }
}

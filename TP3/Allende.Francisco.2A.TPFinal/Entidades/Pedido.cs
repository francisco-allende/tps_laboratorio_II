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

        private double SumarIva(double retornoPrecio)
        {
            double recargoIva = retornoPrecio * 0.21;
            return retornoPrecio + recargoIva;
        }

        public static double CalcularPrecio(Pedido pedido)
        {
            double precio = 0;

            switch(pedido.tipo)
            {
                case "Helado":
                    switch(pedido.cantidad) //1 = 1kilo, 0.5 = un medio, 0.25 = un cuarto
                    {
                        case 1:
                            precio = pedido.SumarIva(800);
                            break;

                        case 0.5:
                            precio = pedido.SumarIva(500);
                            break;

                        case 0.25:
                            precio = pedido.SumarIva(300);
                            break;
                    }
                    break;

                case "Yogur":
                    switch (pedido.cantidad)
                    {
                        case 1:
                            precio = pedido.SumarIva(600);
                            break;

                        case 0.5:
                            precio = pedido.SumarIva(400);
                            break;

                        case 0.25:
                            precio = pedido.SumarIva(250);
                            break;
                    }
                    break;

                case "Cafe":
                    switch(pedido.sabor)
                    {
                        case "SinLeche":
                            precio = pedido.SumarIva(pedido.cantidad * 120);
                            break;

                        case "ConLeche":
                            precio = pedido.SumarIva(pedido.cantidad * 140);
                            break;

                        case "ConCrema":
                            precio = pedido.SumarIva(pedido.cantidad * 170);
                            break;
                    }
                    
                    break;
            }

            return precio;
        }

        public string RetornarNroMesa(int nroMesa)
        {
            if (nroMesa != 0)
            {
                return nroMesa.ToString();
            }
            else
            {
                return "-";
            }
        }

        public string RetornarCantidadEscrito(string tipo, double cantidad)
        {
            if (tipo == "Helado" || tipo == "Yogur")
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
            else
            {
                return cantidad.ToString();
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Datos del Pedido: \n");
            sb.AppendLine($" Id: {this.id}\n");
            sb.AppendLine($", Tipo de producto a consumir: {this.tipo}\n");
            sb.AppendLine($", Sabor: {this.sabor}\n");
            sb.AppendLine($", Cantidad: {this.RetornarCantidadEscrito(this.tipo, this.cantidad)}\n");
            sb.AppendLine($", Precio: ${this.precio}\n");

            return sb.ToString();
        }
    }
}

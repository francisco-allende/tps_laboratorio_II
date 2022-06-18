using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente
    {
        private int dni;
        private string nombre;
        private string direccion;

        public int Dni { get => this.dni; set => this.dni = value; }
        public string Nombre { get => this.nombre; set => this.nombre = value; }
        public string Direccion { get => this.direccion; set => this.direccion = value; }        
            
        public Cliente()
        {
            
        }

        public Cliente(int dni, string nombre, string direccion)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.direccion = direccion;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Datos del Cliente: \n");
            sb.AppendLine($"Dni: {this.Dni}\n");
            sb.AppendLine($" Nombre: {this.Nombre}\n");
            sb.AppendLine($" Direccion: {this.Direccion}\n");

            return sb.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente
    {
        private int id;
        private string nombre;
        private List<int> idPedido; //asi lo muestro luego con las mesas
        private string dondeConsume;
        private int nroMesa;
        private double totalAPagar;


        public int Id { get => this.id; set => this.id = value; }
        public string Nombre { get => this.nombre; set => this.nombre = value; }
        public List<int> IdPedido { get => this.idPedido; set => this.idPedido = value; }
        public string DondeConsume { get => this.dondeConsume; set => this.dondeConsume = value; }
        public int NroMesa { get => this.nroMesa; set => this.nroMesa = value; }
        public double TotalAPagar { get => this.totalAPagar; set => this.totalAPagar = value; }
        

        public Cliente()
        {
            
        }

        public Cliente(int id, string nombre, List<int> idPedido, string dondeConsume, int nroMesa, double totalAPagar)
        {
            this.id = id;
            this.nombre = nombre;
            this.idPedido = idPedido;
            this.dondeConsume = dondeConsume;
            this.nroMesa = nroMesa;
            this.totalAPagar = totalAPagar;
        }

        public static int AsignarId()
        {
            Random radnomId = new Random();
            int id = radnomId.Next(9999, 99999); //es max value -1
            return id;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Datos del Cliente: \n");
            sb.AppendLine($"Id: {this.Id}\n");
            sb.AppendLine($" Nombre: {this.Nombre}\n");
            sb.AppendLine($" Donde consume: {this.DondeConsume}\n");
            if(this.nroMesa == 0)
            {
                sb.AppendLine($" Número de mesa: -\n");
            }
            else
            {
                sb.AppendLine($" Número de mesa: {this.nroMesa}\n");
            }
            sb.AppendLine($" Total a pagar (Tomar el ultimo): ${this.TotalAPagar}\n");

            return sb.ToString();
        }
    }
}

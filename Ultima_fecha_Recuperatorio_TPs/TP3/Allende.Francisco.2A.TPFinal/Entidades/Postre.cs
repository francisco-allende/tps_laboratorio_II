using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Xml;
using Biblio_Interfaces;

namespace Entidades
{

    //Le indico que al momento de serialziar tiene que incluir la clase que lo hereda
    [XmlInclude(typeof(Helado))]
    [XmlInclude(typeof(Yogur))]
    public class Postre : IEsConsumible
    {
        protected int id;
        protected double cantidadStock;
        protected string tipo;
        protected string sabor;

        public Postre()
        {

        }

        public Postre(int id, double cantidadStock, string tipo, string sabor)
        {
            this.id = id;
            this.cantidadStock = cantidadStock;
            this.tipo = tipo;
            this.sabor = sabor;
        }

        public int Id { get => id; set => id = value; }
        public double CantidadStock { get => this.cantidadStock; set => this.cantidadStock = value; }
        public string Tipo { get => this.tipo; set => this.tipo = value; }
        public string Sabor { get => this.sabor; set => this.sabor = value; }


        public static Postre findPostre(int index, Heladera<Postre> h)
        {
            for (int i = 0; i < h.ListaGenerica.Count; i++)
            {
                if (index == h.ListaGenerica[i].Id) 
                {
                    return h.ListaGenerica[i];
                }
            }

            return null;
        }

        public static int SortById(Postre postre1, Postre postre2)
        {
            int retorno = 0; //nunca va a retornar 0, no hay dos ids iguales

            if (postre1.Id > postre2.Id)
            {
                retorno = 1;
            }
            else if (postre1.Id < postre2.Id)
            {
                retorno = -1;
            }
            
            return retorno;
        }

        //ordena de mayor a menor
        public static int SortByCantidad(Postre postre1, Postre postre2)
        {
            int retorno = 0;

            if (postre1.CantidadStock > postre2.CantidadStock)
            {
                retorno = -1;
            }
            else if (postre1.CantidadStock < postre2.CantidadStock)
            {
                retorno = 1;
            }
            //si son iguales retorna 0

            return retorno;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Id: {this.Id}");
            sb.AppendLine($"Tipo: {this.Tipo}");
            sb.AppendLine($"Sabor: {this.Sabor}");
            sb.AppendLine($"Cantidad de Stock actual (en kilos): {this.CantidadStock}\n");
            return sb.ToString();
        }
        
    }
}

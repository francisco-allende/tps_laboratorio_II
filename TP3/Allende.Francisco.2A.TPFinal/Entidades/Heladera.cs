using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Heladera<T>
        where T : class
    {
        private double capacidadMaxima;
        private List<T> listaGenerica;
        private double capacidadOcupada;

        public Heladera()
        {

        }

        public double CapacidadMaxima { get => this.capacidadMaxima; set => this.capacidadMaxima = value; }
        public double CapacidadOcupada { get => this.capacidadOcupada; set => this.capacidadOcupada = value; }
        public List<T> ListaGenerica { get => this.listaGenerica; set => this.listaGenerica = value; }

        public Heladera(int capacidadMaxima)
        {
            this.capacidadMaxima = capacidadMaxima;
            this.ListaGenerica = new List<T>();
        }

        public static bool operator +(Heladera<T> heladera, T postre)
        {
            if (heladera.capacidadMaxima > heladera.ListaGenerica.Count)
            {
                heladera.ListaGenerica.Add(postre);
                return true;
            }
            else
            {
                return false;
            }
        }

        private int GetIndice(T postre)
        {
            for (int i = 0; i < this.ListaGenerica.Count; i++)
            {
                if (postre == this.ListaGenerica[i]) //deberia usar equals
                {
                    return i;
                }
            }

            return -1;
        }

        public static bool operator -(Heladera<T> heladera, T postre)
        {
            int indiceTRemover = heladera.GetIndice(postre);
            if (indiceTRemover != -1)
            {
                heladera.ListaGenerica.Remove(postre);
                return true;
            }
            else
            {
                return false;
            }
        }

        //Para usarlos, instancio una heladera, y ahi si agrego el postre
        public bool Agregar(T postre)
        {
            if (postre != null)
            {
                return this + postre;
            }
            else
            {
                throw new NullReferenceException("No se encontro postre con ese Id");
            }
        }

        public bool Remover(T postre)
        {
            if(postre != null)
            {
                return this - postre;
            }
            else
            {
                throw new NullReferenceException("No se encontro postre con ese Id");
            }
        }

        //no hay aca un stack overflow?
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Capacidad máxima: {this.capacidadMaxima}");

            foreach (T item in this.ListaGenerica)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString();
        }
    }
}

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

        /// <summary>
        /// Suma un elemento a la heladera
        /// </summary>
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

        /// <summary>
        /// Retorna el indice del objeto postre enviado
        /// </summary>
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

        /// <summary>
        /// Remueve un postre de la heladera
        /// </summary>
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

        /// <summary>
        /// Llama al la sobrecarga del + para añadir a la lista
        /// </summary>
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

        /// <summary>
        /// Llama a la sobrecarga del - para quitar de la lista
        /// </summary>
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
    }
}

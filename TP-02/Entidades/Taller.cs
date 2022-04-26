using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// No podrá tener clases heredadas.
    /// </summary>
    public class Taller
    {
        
        public enum ETipo
        {
            Ciclomotor, 
            Sedan, 
            SUV, 
            Todos
        }

        private List<Vehiculo> vehiculos;
        private int espacioDisponible;

        #region "Constructores"
        private Taller()
        {
            this.vehiculos = new List<Vehiculo>();
        }
        public Taller(int espacioDisponible) : this()
        {
            this.espacioDisponible = espacioDisponible;
        }
        #endregion

        #region "Sobrecargas"
        /// <summary>
        /// Muestro el estacionamiento y TODOS los vehículos
        /// </summary>
        /// <returns></returns>
        public override string ToString() //sobreescribo el ToString() de C#
        {
            return Taller.Listar(this, ETipo.Todos); //el error este se corregia haciendo static el Listar
        }
        #endregion

        #region "Métodos"

        /// <summary>
        /// Expone los datos del elemento y su lista (incluidas sus herencias)
        /// SOLO del tipo requerido
        /// </summary>
        /// <param name="taller">Elemento a exponer</param>
        /// <param name="ETipo">Tipos de ítems de la lista a mostrar</param>
        /// <returns></returns>
        public static string Listar(Taller taller, ETipo tipo)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Tenemos {0} lugares ocupados de un total de {1} disponibles", taller.vehiculos.Count, taller.espacioDisponible);
            sb.AppendLine("");
            foreach (Vehiculo v in taller.vehiculos)
            {
                switch (tipo) //solo itera tipos, yo necesito mostrar cada vehiculo
                {
                    case ETipo.SUV:
                        if(v.Tamanio == Vehiculo.ETamanio.Grande) //el tipo coincide con el tamaño. Utilizo esto para validar. Accedo con la clase
                        {
                            sb.AppendLine(v.Mostrar());
                        }
                        break;

                    case ETipo.Ciclomotor:
                        if (v.Tamanio == Vehiculo.ETamanio.Chico) 
                        {
                            sb.AppendLine(v.Mostrar());
                        }
                        break;

                    case ETipo.Sedan:
                        if (v.Tamanio == Vehiculo.ETamanio.Mediano) 
                        {
                            sb.AppendLine(v.Mostrar());
                        }
                        break;

                    default:
                        sb.AppendLine(v.Mostrar());
                        break;
                }
            }

            return sb.ToString();
        }
        #endregion

        #region "Operadores"
        /// <summary>
        /// Agregará un elemento a la lista
        /// </summary>
        /// <param name="taller">Objeto donde se agregará el elemento</param>
        /// <param name="vehiculo">Objeto a agregar</param>
        /// <returns></returns>
        public static Taller operator +(Taller taller, Vehiculo vehiculo)
        {
            if(taller.espacioDisponible > taller.vehiculos.Count) //valido que haya espacio disponible
            {
                foreach (Vehiculo v in taller.vehiculos)
                {
                    if (v == vehiculo) //valido que no haya dos iguales, ya sobrecargue el == segun chasis
                    {
                        return taller; //corto el bucle
                    }
                }
                taller.vehiculos.Add(vehiculo); //hay espacio y no esta repetido. Lo agrego al garage
            }

            return taller;
        }
        /// <summary>
        /// Quitará un elemento de la lista
        /// </summary>
        /// <param name="taller">Objeto donde se quitará el elemento</param>
        /// <param name="vehiculo">Objeto a quitar</param>
        /// <returns></returns>
        public static Taller operator -(Taller taller, Vehiculo vehiculo)
        {
            foreach (Vehiculo v in taller.vehiculos)
            {
                if (v == vehiculo)
                {
                    taller.vehiculos.Remove(v); //es el que quiero eliminar
                    return taller;
                }
            }

            return taller;
        }
        #endregion
    }
}

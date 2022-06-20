using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using Entidades;

namespace DAO_y_Archivos
{
    public class GestionarArchivos
    {
        /// <summary>
        /// Antes de escribir en el txt, parseo todos los valores de la lista a un unico string
        /// </summary>
        public static string ParseListToString<T>(List<T> lista)
            where T : class
        {
            StringBuilder sb = new StringBuilder();

            foreach (T item in lista)
            {
                sb.Append(item.ToString());
            }

            return sb.ToString();
        }

        /// <summary>
        /// Escribe la lista parseada a string en txt
        /// </summary>
        public static void Escribir<T>(string nombreFile, List<T> lista)
            where T : class
        {
            string ruta = Serializador.RutaBase + nombreFile;
            string contenido = GestionarArchivos.ParseListToString(lista);

            try
            {
                using (StreamWriter sw = new StreamWriter(ruta))
                {
                    sw.WriteLine(contenido);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error para abrir el archivo ", ex);
            }
        }

        /// <summary>
        /// lee y carga un txt
        /// </summary>
        public static string Leer(string nombreFile)
        {
            string rutaArchivo = Serializador.RutaBase + nombreFile;
            string retorno = String.Empty;

            try
            {
                using (StreamReader sr = new StreamReader(rutaArchivo))
                {
                    retorno = $"{sr.ReadToEnd()}\n";
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error para abrir el archivo ", ex);
            }

            return retorno;
        }


        /// <summary>
        /// Lee la BBDD de postre, la carga y la ordena de mayor a menor cantidad de stock
        /// El sleep se encuentra comentado porque no esta bien visto usarlo, pero si se descomente
        /// Simula la demora en la busqueda a la BBDD a la perfeccion
        /// </summary>
        public static async Task<List<Postre>> CargarYOrdenarPostre()
        {
            List<Postre> list = await Task.Run(() =>
            {
                Thread.Sleep(3000);
                return PostreDAO.Leer();
            });

            //Ordeno de mayor a menor
            await Task.Run(() =>
            {
                Thread.Sleep(2000);
                list.Sort((p1, p2) => p2.CantidadStock - p1.CantidadStock);
            });

            return list;
        }

        /// <summary>
        /// Lee la BBDD de ventas, la carga y la ordena de mayor a menor segun DNI
        /// El sleep se encuentra comentado porque no esta bien visto usarlo, pero si se descomente
        /// Simula la demora en la busqueda a la BBDD a la perfeccion
        /// </summary>
        public static async Task<List<Pedido>> CargarYOrdenarVentas()
        {
            List<Pedido> list = await Task.Run(() =>
            {
                Thread.Sleep(3000);
                return VentasDAO.Leer();
            });

            //Ordeno de mayor a menor DNI
            await Task.Run(() =>
            {
                Thread.Sleep(2000);
                list.Sort((v1, v2) => v2.Dni - v1.Dni);
            });

            return list;
        }
    }
}

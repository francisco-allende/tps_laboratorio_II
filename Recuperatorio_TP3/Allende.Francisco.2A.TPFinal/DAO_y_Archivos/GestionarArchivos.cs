using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; 

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
    }
}

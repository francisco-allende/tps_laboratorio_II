using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml; 
using System.Xml.Serialization;
using System.Text.Json;

namespace Entidades
{
    public class Serializador
    {
        private static string rutaBase;

        public static string RutaBase { get => rutaBase; }

        static Serializador()
        {
            DirectoryInfo info = Directory.CreateDirectory($"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\Archivos_Serializados_TpFinal_Allende_2A\\");
            Serializador.rutaBase = info.FullName;
        }

        /// <summary>
        /// Serializador generico para XML
        /// </summary>
        public static void SerializarXML<T>(string nombreArchivo, List<T> lista)
            where T : class
        {
            string ruta = Serializador.rutaBase + nombreArchivo;

            try
            {
                using (StreamWriter sw = new StreamWriter(ruta))
                {
                    XmlSerializer xml = new XmlSerializer(typeof(List<T>));
                    xml.Serialize(sw, lista);
                }
            }
            catch (Exception)
            {
                throw new Exception("No se pudo guardar el archivo ni los cambios efectuados.\n");
            }

        }

        /// <summary>
        /// Deserealizador generico para xml
        /// </summary>
        public static List<T> DeserializarXML<T>(string nombreArchivo, List<T> lista)
            where T : class
        {
            string ruta = Serializador.rutaBase + nombreArchivo;

            using (StreamReader sr = new StreamReader(ruta))
            {
                XmlSerializer xml = new XmlSerializer(typeof(List<T>));
                lista = xml.Deserialize(sr) as List<T>;
                return lista;
            }
        }

        /// <summary>
        /// Serializador dinamico para json
        /// </summary>
        public static void SerializadorJson<T>(string nombreFile, List<T> lista)
            where T : class
        {
            string ruta = Serializador.rutaBase + nombreFile;

            //seteo el identado
            JsonSerializerOptions opciones = new JsonSerializerOptions();
            opciones.WriteIndented = true;

            using (StreamWriter sw = new StreamWriter(ruta))
            {
                try
                {
                    string miJson = JsonSerializer.Serialize(lista, opciones); //paso obj e identacion
                    sw.WriteLine(miJson);
                }
                catch (Exception)
                {

                    throw new Exception("No se pudo guardar el archivo en formato json");
                }
            }
        }

        public static List<T> DeserealizarJson<T>(string nombreFile, List<T> lista)
        {
            string ruta = Serializador.rutaBase + nombreFile;

            try
            {
                using (StreamReader sr = new StreamReader(ruta))
                {
                    string miJson = sr.ReadToEnd();
                    return JsonSerializer.Deserialize<List<T>>(miJson);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("no se pudo pasar a json", ex);
            }
        }
    }
}

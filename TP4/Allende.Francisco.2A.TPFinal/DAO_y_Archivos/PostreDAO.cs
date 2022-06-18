using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entidades;

namespace DAO_y_Archivos
{
    public static class PostreDAO
    {
        static string connectionString;
        static SqlCommand command;
        static SqlConnection connection;

        static PostreDAO()
        {
            connectionString = @"Server=localhost\SQLEXPRESS;Database=TPFINAL_HELADOS_FRODO;Trusted_Connection=True;";
            command = new SqlCommand();
            connection = new SqlConnection(connectionString);
            command.CommandType = System.Data.CommandType.Text;
            command.Connection = connection;
        }

        public static void Guardar(Postre postre)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"INSERT INTO STOCK (CANTIDAD_STOCK, TIPO, SABOR) " +
                                        $"VALUES (@cantidadStock, @tipo, @sabor)";
                command.Parameters.AddWithValue("@cantidadStock", postre.CantidadStock);
                command.Parameters.AddWithValue("@tipo", postre.Tipo);
                command.Parameters.AddWithValue("@sabor", postre.Sabor);
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }
        
        public static List<Postre> Leer()
        {
            Heladera<Postre> heladera = new Heladera<Postre>();

            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"SELECT * FROM STOCK";

                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        heladera.ListaGenerica.Add(new Postre(
                            Convert.ToInt32(dataReader["ID"]),
                            Convert.ToInt32(dataReader["CANTIDAD_STOCK"]),
                            dataReader["TIPO"].ToString(),
                            dataReader["SABOR"].ToString()
                    ));
                    }
                }

                return heladera.ListaGenerica;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }
        
        public static Postre LeerPorId(int id)
        {
            Postre postre = null;

            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"SELECT * FROM STOCK WHERE ID = @Id";
                command.Parameters.AddWithValue("@Id", id);

                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        postre = new Postre
                        (
                            Convert.ToInt32(dataReader["CANTIDAD_STOCK"]),
                            dataReader["TIPO"].ToString(),
                            dataReader["SABOR"].ToString()
                        );
                    }
                }

                return postre;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public static void Modificar(Postre postre)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = "UPDATE STOCK SET CANTIDAD_STOCK = @cantidadStock, TIPO = @tipo," +
                                       "SABOR = @sabor WHERE ID = @Id";
                command.Parameters.AddWithValue("@cantidadStock", postre.CantidadStock);
                command.Parameters.AddWithValue("@tipo", postre.Tipo);
                command.Parameters.AddWithValue("@sabor", postre.Sabor);
                command.Parameters.AddWithValue("@Id", postre.Id);
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public static void Eliminar(int id)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = "DELETE FROM STOCK WHERE ID = @Id";
                command.Parameters.AddWithValue("@Id", id);
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}

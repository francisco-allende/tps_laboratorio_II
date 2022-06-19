using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data.SqlClient;

namespace DAO_y_Archivos
{
    public static class VentasDAO
    {
        static string connectionString;
        static SqlCommand command;
        static SqlConnection connection;

        static VentasDAO()
        {
            connectionString = @"Server=localhost\SQLEXPRESS;Database=TPFINAL_HELADOS_FRODO;Trusted_Connection=True;";
            command = new SqlCommand();
            connection = new SqlConnection(connectionString);
            command.CommandType = System.Data.CommandType.Text;
            command.Connection = connection;
        }

        public static void Guardar(Pedido pedido)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = "INSERT INTO VENTAS (DNI_CLIENTE, NOMBRE_CLIENTE, DIRECCION_CLIENTE, " +
                                        "TIPO, SABOR, CANTIDAD, PRECIO)"+
                                        "VALUES (@dniCliente, @nombreCliente, @direccionCliente, @tipo, @sabor, @cantidad, @precio)";
                
                command.Parameters.AddWithValue("@dniCliente", pedido.Dni);
                command.Parameters.AddWithValue("@nombreCliente", pedido.Nombre);
                command.Parameters.AddWithValue("@direccionCliente", pedido.Direccion);
                command.Parameters.AddWithValue("@tipo", pedido.Tipo);
                command.Parameters.AddWithValue("@sabor", pedido.Sabor);
                command.Parameters.AddWithValue("@cantidad", pedido.Cantidad);
                command.Parameters.AddWithValue("@precio", pedido.Precio);
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

        public static List<Pedido> Leer()
        {
            List<Pedido> lista = new List<Pedido>();

            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"SELECT * FROM VENTAS";

                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        lista.Add(new Pedido(
                            Convert.ToInt32(dataReader["ID_PEDIDO"]),
                            Convert.ToInt32(dataReader["DNI_CLIENTE"]),
                            dataReader["NOMBRE_CLIENTE"].ToString(),
                            dataReader["DIRECCION_CLIENTE"].ToString(),
                            dataReader["TIPO"].ToString(),
                            dataReader["SABOR"].ToString(),
                            Convert.ToDouble(dataReader["CANTIDAD"]),
                            Convert.ToDouble(dataReader["PRECIO"])
                        ));
                    }
                }

                return lista;
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

        public static Pedido LeerPorId(int id)
        {
            Pedido pedido = null;

            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"SELECT * FROM VENTAS WHERE ID_PEDIDO = @Id";
                command.Parameters.AddWithValue("@Id", id);

                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    { 
                        pedido = new Pedido
                        (
                            Convert.ToInt32(dataReader["DNI_CLIENTE"]),
                            dataReader["NOMBRE_CLIENTE"].ToString(),
                            dataReader["DIRECCION_CLIENTE"].ToString(),
                            dataReader["TIPO"].ToString(),
                            dataReader["SABOR"].ToString(),
                            Convert.ToDouble(dataReader["CANTIDAD"]),
                            Convert.ToDouble(dataReader["PRECIO"])
                        );
                    }
                }

                return pedido;
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

        public static void Modificar(Pedido pedido)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = "UPDATE VENTAS SET DNI_CLIENTE = @dniCliente, NOMBRE_CLIENTE = @nombreCliente, DIRECCION_CLIENTE = @direccionCliente, " +
                                       "TIPO = @tipo, SABOR = @sabor, CANTIDAD = @cantidad, PRECIO = @precio " +
                                       "WHERE ID_PEDIDO = @Id";

                command.Parameters.AddWithValue("@dniCliente", pedido.Dni);
                command.Parameters.AddWithValue("@nombreCliente", pedido.Nombre);
                command.Parameters.AddWithValue("@direccionCliente", pedido.Direccion);
                command.Parameters.AddWithValue("@tipo", pedido.Tipo);
                command.Parameters.AddWithValue("@sabor", pedido.Sabor);
                command.Parameters.AddWithValue("@cantidad", pedido.Cantidad);
                command.Parameters.AddWithValue("@precio", pedido.Precio);
                command.Parameters.AddWithValue("@Id", pedido.Id);
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
                command.CommandText = "DELETE FROM VENTAS WHERE ID_PEDIDO = @Id";
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

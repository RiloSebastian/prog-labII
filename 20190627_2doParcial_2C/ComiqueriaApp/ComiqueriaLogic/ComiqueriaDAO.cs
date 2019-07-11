using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ComiqueriaLogic
{
    public static class ComiqueriaDAO
    {
        public static SqlCommand command;
        public static SqlConnection connection;

        static ComiqueriaDAO()
        {
            try
            {
                SqlCommand command = new SqlCommand();
                SqlConnection connection = new SqlConnection(@"Data Source =.\SQLEXPRESS; Initial Catalog =Comiqueria; Integrated Security = True");
                command.CommandType = System.Data.CommandType.Text;
                command.Connection = connection;
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        public static bool AgregarPaquete(string nuevaDescripcion, double nuevoPrecio, int nuevoStock)
        {
            bool retorno = false;
            try
            {
                command.CommandText = string.Format("INSERT INTO Productos (Descripcion, Precio, Stock) VALUES ('{0}','{1}','{2}')",
                                                nuevaDescripcion, nuevoPrecio, nuevoStock);
                connection.Open();
                command.ExecuteNonQuery();
                retorno= true;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }     
            }
            return retorno;
        }

        public static bool EliminarProducto(Producto productoAEliminar)
        {
            bool retorno = false;
            try
            {
                command.CommandText = string.Format("DELETE FROM Productos WHERE codigo = {0}", productoAEliminar.Codigo);
                connection.Open();
                command.ExecuteNonQuery();
                retorno = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            return retorno;
        }

        public static List<Producto> CargarListaDeBaseDeDatos()
        {
            List<Producto> productos;
            Producto producto;

            try
            {
                command.CommandText = "SELECT * FROM Productos";
                connection.Open();
                SqlDataReader odr = command.ExecuteReader();
                productos = new List<Producto>();
                
                while (odr.Read())
                {
                    productos.Add(producto = new Producto(int.Parse(odr["Codigo"].ToString()), odr["Descripcion"].ToString(),
                                                            int.Parse(odr["Stock"].ToString()), double.Parse(odr["Precio"].ToString())));
                }
            }
            catch(Exception e)
            {
                throw e;
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            return productos;
        }


    }
}


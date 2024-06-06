using Gabriel_Utreras.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

using System.Data;


namespace Gabriel_Utreras.Metodos
{
    public static class ProductoData
    {
        public static List<Producto> ObtenerProducto (int idProducto)
        {
            List<Producto> listaProducto = new List<Producto> ();


            //string connectionString = @"Server=localhost\SQLExpress;Database=SistemaGestion;Trusted_Connection=True;";
            var query = "Select Id, Descripciones, Costo, PrecioVenta, Stock, IdUsuario FROM Producto WHERE Id=@idProducto;";
            using (SqlConnection conexion = ConexionADO.GetConexion()) // se reemplaza el "string connectionString" con la clase ConexionADO que hace lo mismo
            {
                
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    var parametro = new SqlParameter();
                    parametro.ParameterName = "idProducto";
                    parametro.SqlDbType = SqlDbType.Int;
                    parametro.Value = idProducto;

                    comando.Parameters.Add (parametro);

                    using (SqlDataReader dataReader = comando.ExecuteReader()) 
                    {
                        if (dataReader.HasRows)
                        {
                            while (dataReader.Read()) 
                            {
                                var producto = new Producto ();
                                producto.Id = Convert.ToInt32(dataReader["Id"]);
                                producto.Descripcion = dataReader["Descripciones"].ToString();
                                producto.Costo = Convert.ToDouble(dataReader["Costo"]);
                                producto.PrecioVenta= Convert.ToDouble(dataReader["PrecioVenta"]);
                                producto.Stock = Convert.ToInt32(dataReader["Stock"]);
                                producto.IdUsuario = Convert.ToInt32(dataReader["IdUsuario"]);

                                listaProducto.Add (producto);


                            }
                        }
                    }

                }
            }
            return listaProducto;
        }


        public static List<Producto> ListarProductos()
        {
            List<Producto> listaDeProductos = new List<Producto>();
            //string connectionString = @"Server=localhost\SQLExpress;Database=SistemaGestion;Trusted_Connection=True;";
            var query = "Select Id, Descripciones, Costo, PrecioVenta, Stock, IdUsuario FROM Producto";
            using (SqlConnection conexion = ConexionADO.GetConexion())
            {
                //conexion.Open();
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    using (SqlDataReader dataReader = comando.ExecuteReader())
                    {
                        if (dataReader.HasRows)
                        {
                            while (dataReader.Read())
                            {
                                var producto = new Producto();
                                producto.Id = Convert.ToInt32(dataReader["Id"]);
                                producto.Descripcion = dataReader["Descripciones"].ToString();
                                producto.Costo = Convert.ToDouble(dataReader["Costo"]);
                                producto.PrecioVenta = Convert.ToDouble(dataReader["PrecioVenta"]);
                                producto.Stock = Convert.ToInt32(dataReader["Stock"]);
                                producto.IdUsuario = Convert.ToInt32(dataReader["IdUsuario"]);

                                listaDeProductos.Add(producto);


                            }
                        }
                    }

                }
            }
            return listaDeProductos;
        }

        public static void CrearProducto(Producto producto)
        {
            //string connectionString = @"Server=localhost\SQLExpress;Database=SistemaGestion;Trusted_Connection=True;";

            var query = "INSERT INTO Producto (Descripciones, Costo, PrecioVenta, Stock, IdUsuario)" + 
                "VALUES (@Descripcion, @Costo, @PrecioVenta, @Stock, @IdUsuario)";

            using (SqlConnection conexion = ConexionADO.GetConexion())
            {
                //conexion.Open();

                using (SqlCommand comando = new SqlCommand(query, conexion)) 
                {
                    comando.Parameters.Add(new SqlParameter("Descripcion", SqlDbType.VarChar) { Value = producto.Descripcion });
                    comando.Parameters.Add(new SqlParameter("Costo", SqlDbType.Float) { Value = producto.Costo});
                    comando.Parameters.Add(new SqlParameter("PrecioVenta", SqlDbType.Float) { Value = producto.PrecioVenta});
                    comando.Parameters.Add(new SqlParameter("Stock", SqlDbType.Int) { Value = producto.Stock});
                    comando.Parameters.Add(new SqlParameter("IdUsuario", SqlDbType.Int) { Value = producto.IdUsuario});

                    comando.ExecuteNonQuery();

                }
                conexion.Close();
            }

        }

        public static void ModificarProducto(Producto producto)
        {
            //string connectionString = @"Server=localhost\SQLExpress;Database=SistemaGestion;Trusted_Connection=True;";
            var query = "UPDATE Producto " +
                        "SET Descripciones = @Descripcion, " +
                        "Costo = @Costo, " +
                        "PrecioVenta = @PrecioVenta, " +
                        "Stock = @Stock, " +
                        "IdUsuario = @IdUsuario " +
                        "WHERE Id = @Id";

            using (SqlConnection conexion = ConexionADO.GetConexion()) 
            {
                //conexion.Open();
                using (SqlCommand comando = new SqlCommand(query, conexion)) 
                {
                    comando.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = producto.Id });
                    comando.Parameters.Add(new SqlParameter("Descripcion", SqlDbType.VarChar) { Value = producto.Descripcion });
                    comando.Parameters.Add(new SqlParameter("Costo", SqlDbType.Float) { Value = producto.Costo });
                    comando.Parameters.Add(new SqlParameter("PrecioVenta", SqlDbType.Float) { Value = producto.PrecioVenta });
                    comando.Parameters.Add(new SqlParameter("Stock", SqlDbType.Int) { Value = producto.Stock });
                    comando.Parameters.Add(new SqlParameter("IdUsuario", SqlDbType.Int) { Value = producto.IdUsuario });

                    comando.ExecuteNonQuery();
                }
                conexion.Close();
            }   

        }

        public static void EliminarProducto(Producto producto)
        {
            //string connectionString = @"Server=localhost\SQLExpress;Database=SistemaGestion;Trusted_Connection=True;";

            var query = "DELETE FROM Producto WHERE Id= @Id";

            using (SqlConnection conexion = ConexionADO.GetConexion()) 
            {
                //conexion.Open();
                using (SqlCommand comando = new SqlCommand(query, conexion)) 
                {
                    comando.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = producto.Id });

                    comando.ExecuteNonQuery();
                }
                conexion.Close() ;
            }

        }



    }
}

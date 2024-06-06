using Gabriel_Utreras.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gabriel_Utreras.Metodos
{
    public static class ProductoVendidoData
    {
        public static List<ProductoVendido> ObtenerProductoVendido(int idProductoVendido)
        {
            List<ProductoVendido> listaProductoVendido = new List<ProductoVendido>();
            //string connectionString = @"Server=localhost\SQLExpress;Database=SistemaGestion;Trusted_Connection=True;";
            var query = "Select Id, Stock, IdProducto, IdVenta FROM ProductoVendido WHERE Id=@idProductoVendido;";
            using (SqlConnection conexion = ConexionADO.GetConexion()) // se reemplaza el "string connectionString" con la clase ConexionADO que hace lo mismo
            {
                //conexion.Open();
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    var parametro = new SqlParameter();
                    parametro.ParameterName = "idProductoVendido";
                    parametro.SqlDbType = SqlDbType.Int;
                    parametro.Value = idProductoVendido;

                    comando.Parameters.Add(parametro);

                    using (SqlDataReader dataReader = comando.ExecuteReader())
                    {
                        if (dataReader.HasRows)
                        {
                            while (dataReader.Read())
                            {
                                var productoVendido = new ProductoVendido();
                                productoVendido.Id = Convert.ToInt32(dataReader["Id"]);
                                productoVendido.Stock = Convert.ToInt32(dataReader["Stock"]);
                                productoVendido.IdProducto = Convert.ToInt32(dataReader["IdProducto"]);
                                productoVendido.IdVenta = Convert.ToInt32(dataReader["IdVenta"]);


                                listaProductoVendido.Add(productoVendido);


                            }
                        }
                    }

                }

                return listaProductoVendido;
            }
        }

        public static List<ProductoVendido> ListarProductosVendidos()
        {
            List<ProductoVendido> listaProductosVendidos = new List<ProductoVendido>();
            //string connectionString = @"Server=localhost\SQLExpress;Database=SistemaGestion;Trusted_Connection=True;";
            var query = "Select Id, Stock, IdProducto, IdVenta FROM ProductoVendido";
            using (SqlConnection conexion = ConexionADO.GetConexion()) // se reemplaza el "string connectionString" con la clase ConexionADO que hace lo mismo
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
                                var productoVendido = new ProductoVendido();
                                productoVendido.Id = Convert.ToInt32(dataReader["Id"]);
                                productoVendido.Stock = Convert.ToInt32(dataReader["Stock"]);
                                productoVendido.IdProducto = Convert.ToInt32(dataReader["IdProducto"]);
                                productoVendido.IdVenta = Convert.ToInt32(dataReader["IdVenta"]);


                                listaProductosVendidos.Add(productoVendido);


                            }
                        }
                    }

                }
            }
            return listaProductosVendidos;
        }
        public static void CrearProductoVendido(ProductoVendido productoVendido)
        {
            //string connectionString = @"Server=localhost\SQLExpress;Database=SistemaGestion;Trusted_Connection=True;";

            var query = "INSERT INTO ProductoVendido (Stock, IdProducto, IdVenta)" +
                "VALUES (@Stock, @IdProducto, @IdVenta)";

            using (SqlConnection conexion = ConexionADO.GetConexion()) // se reemplaza el "string connectionString" con la clase ConexionADO que hace lo mismo
            {
                //conexion.Open();

                using (SqlCommand comando = new SqlCommand(query, conexion))
                {

                    comando.Parameters.Add(new SqlParameter("Stock", SqlDbType.Int) { Value = productoVendido.Stock });
                    comando.Parameters.Add(new SqlParameter("IdProducto", SqlDbType.Int) { Value = productoVendido.IdProducto });
                    comando.Parameters.Add(new SqlParameter("IdVenta", SqlDbType.Int) { Value = productoVendido.IdVenta });

                    comando.ExecuteNonQuery();

                }
                conexion.Close();
            }

        }
        public static void ModificarProductoVendido(ProductoVendido productoVendido)
        {
            //string connectionString = @"Server=localhost\SQLExpress;Database=SistemaGestion;Trusted_Connection=True;";
            var query = "UPDATE ProductoVendido " +
                        "SET Stock = @Stock, " +
                        "IdProducto = @IdProducto, " +
                        "IdVenta = @IdVenta " +
                        "WHERE Id = @Id";

            using (SqlConnection conexion = ConexionADO.GetConexion()) // se reemplaza el "string connectionString" con la clase ConexionADO que hace lo mismo
            {
                //conexion.Open();
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = productoVendido.Id });
                    comando.Parameters.Add(new SqlParameter("Stock", SqlDbType.Int) { Value = productoVendido.Stock });
                    comando.Parameters.Add(new SqlParameter("IdProducto", SqlDbType.Int) { Value = productoVendido.IdProducto });
                    comando.Parameters.Add(new SqlParameter("IdVenta", SqlDbType.Int) { Value = productoVendido.IdVenta });

                    comando.ExecuteNonQuery();
                }
                conexion.Close();
            }

        }

        public static void EliminarProductoVendido(ProductoVendido productoVendido)
        {
            //string connectionString = @"Server=localhost\SQLExpress;Database=SistemaGestion;Trusted_Connection=True;";

            var query = "DELETE FROM ProductoVendido WHERE Id= @Id";

            using (SqlConnection conexion = ConexionADO.GetConexion()) // se reemplaza el "string connectionString" con la clase ConexionADO que hace lo mismo
            {
                //conexion.Open();
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = productoVendido.Id });

                    comando.ExecuteNonQuery();
                }
                conexion.Close();
            }

        }
    }
}


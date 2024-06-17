using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionData
{
    public static class VentaData
    {
        public static List<Venta> ObtenerVenta(int idVenta)
        {
            List<Venta> listaVenta = new List<Venta>();
            //string connectionString = @"Server=localhost\SQLExpress;Database=SistemaGestion;Trusted_Connection=True;";
            var query = "Select Id, Comentarios, IdUsuario FROM Venta WHERE Id=@IdVenta;";
            using (SqlConnection conexion = ConexionADO.GetConexion())
            {
                //conexion.Open();
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    var parametro = new SqlParameter();
                    parametro.ParameterName = "IdVenta";
                    parametro.SqlDbType = SqlDbType.Int;
                    parametro.Value = idVenta;

                    comando.Parameters.Add(parametro);

                    using (SqlDataReader dataReader = comando.ExecuteReader())
                    {
                        if (dataReader.HasRows)
                        {
                            while (dataReader.Read())
                            {
                                var venta = new Venta();
                                venta.Id = Convert.ToInt32(dataReader["Id"]);
                                venta.Comentarios = dataReader["Comentarios"].ToString();
                                venta.IdUsuario = Convert.ToInt32(dataReader["IdUsuario"]);

                                listaVenta.Add(venta);


                            }
                        }
                    }

                }
            }
            return listaVenta;
        }
        public static List<Venta> ListarVentas()
        {
            List<Venta> listaVenta = new List<Venta>();
            //string connectionString = @"Server=localhost\SQLExpress;Database=SistemaGestion;Trusted_Connection=True;";
            var query = "Select Id, Comentarios, IdUsuario FROM Venta";
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
                                var venta = new Venta();
                                venta.Id = Convert.ToInt32(dataReader["Id"]);
                                venta.Comentarios = dataReader["Comentarios"].ToString();
                                venta.IdUsuario = Convert.ToInt32(dataReader["IdUsuario"]);

                                listaVenta.Add(venta);


                            }
                        }
                    }

                }
            }
            return listaVenta;
        }

        public static void CrearVenta(Venta venta)
        {
            //string connectionString = @"Server=localhost\SQLExpress;Database=SistemaGestion;Trusted_Connection=True;";

            var query = "INSERT INTO Venta (Comentarios, IdUsuario)" +
                "VALUES (@Comentarios, @IdUsuario)";

            using (SqlConnection conexion = ConexionADO.GetConexion())
            {
                //conexion.Open();

                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("Comentarios", SqlDbType.VarChar) { Value = venta.Comentarios });
                    comando.Parameters.Add(new SqlParameter("IdUsuario", SqlDbType.Float) { Value = venta.IdUsuario });

                    comando.ExecuteNonQuery();

                }
                conexion.Close();
            }

        }

        public static void ModificarVenta(Venta venta)
        {
            //string connectionString = @"Server=localhost\SQLExpress;Database=SistemaGestion;Trusted_Connection=True;";
            var query = "UPDATE Venta " +
                        "SET Comentarios = @Comentarios, " +
                        "IdUsuario = @IdUsuario " +
                        "WHERE Id = @Id";

            using (SqlConnection conexion = ConexionADO.GetConexion())
            {
                //conexion.Open();
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = venta.Id });
                    comando.Parameters.Add(new SqlParameter("Comentarios", SqlDbType.VarChar) { Value = venta.Comentarios });
                    comando.Parameters.Add(new SqlParameter("IdUsuario", SqlDbType.Int) { Value = venta.IdUsuario });

                    comando.ExecuteNonQuery();
                }
                conexion.Close();
            }

        }
        public static void EliminarVenta(Venta venta)
        {
            //string connectionString = @"Server=localhost\SQLExpress;Database=SistemaGestion;Trusted_Connection=True;";

            var query = "DELETE FROM Venta WHERE Id= @Id";

            using (SqlConnection conexion = ConexionADO.GetConexion())
            {
                //conexion.Open();
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = venta.Id });

                    comando.ExecuteNonQuery();
                }
                conexion.Close();
            }

        }
    }
}

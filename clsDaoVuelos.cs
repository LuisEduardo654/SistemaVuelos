using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaPasajeros
{
    internal class clsDaoVuelos
    {
        private readonly string conexion =
            "server=localhost;database=Vuelo;uid=root;pwd=root123;";

        /// <summary>
        /// Obtiene un listado completo de los vuelos con información de pasajeros y asientos
        /// </summary>
        /// <returns>Lista de objetos Vuelos con toda la información relevante</returns>
        public List<Vuelos> ObtenerResumenVuelos()
        {
            List<Vuelos> lista = new List<Vuelos>();
            using (MySqlConnection conn = new MySqlConnection(conexion))
            {
                conn.Open();
                string sql = "SELECT * FROM resumenVuelos";  // <- que sea la VISTA, no otra tabla
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new Vuelos
                        {
                            IdBoleto = Convert.ToInt32(reader["IdBoleto"]),
                            IdVuelo = Convert.ToInt32(reader["IdVuelo"]),
                            Origen = reader["Origen"].ToString(),
                            Destino = reader["Destino"].ToString(),
                            FechaSalida = Convert.ToDateTime(reader["FechaSalida"]),
                            HoraSalida = (TimeSpan)reader["HoraSalida"],
                            IdAsiento = Convert.ToInt32(reader["IdAsiento"]),
                            NumeroAsiento = reader["NumeroAsiento"].ToString(),
                            IdPasajero = Convert.ToInt32(reader["IdPasajero"]),
                            Nombre = reader["Nombre"].ToString(),
                            CodigoBarra = reader["CodigoBarras"].ToString(),
                            Llego = Convert.ToBoolean(reader["Llego"])
                        });
                    }
                }
            }
            return lista;
        }

        /// <summary>
        /// Busca un boleto específico por su código de barras
        /// </summary>
        /// <param name="codigoBarras">Código de barras del boleto a buscar</param>
        /// <returns>Objeto Vuelos con la información del boleto encontrado o null si no existe</returns>
        public Vuelos ObtenerBoletoPorCodigo(string codigoBarras)
        {
            using (MySqlConnection conn = new MySqlConnection(conexion))
            {
                conn.Open();
                string query = @"SELECT b.IdAsiento, a.NumeroAsiento, p.Nombre, v.Origen, v.Destino, v.FechaSalida
                    FROM Boletos b
                    INNER JOIN Pasajeros p ON b.IdPasajero = p.IdPasajero
                    INNER JOIN Vuelos v ON b.IdVuelo = v.IdVuelo
                    INNER JOIN Asientos a ON b.IdAsiento = a.IdAsiento
                    WHERE b.CodigoBarras = @codigo";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@codigo", codigoBarras);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    Vuelos vuelo = new Vuelos
                    {
                        NumeroAsiento = reader["NumeroAsiento"].ToString(),
                        Nombre = reader["Nombre"].ToString(),
                        Origen = reader["Origen"].ToString(),
                        Destino = reader["Destino"].ToString(),
                        FechaSalida = Convert.ToDateTime(reader["FechaSalida"])
                    };
                    return vuelo;
                }
                return null;
            }
        }

        /// <summary>
        /// Marca un boleto como "llegado" en la base de datos usando su código de barras
        /// </summary>
        /// <param name="codigoBarras">Código de barras del boleto a marcar</param>
        public void MarcarLlegadaPorCodigo(string codigoBarras)
        {
            using (MySqlConnection conn = new MySqlConnection(conexion))
            {
                conn.Open();
                string query = "UPDATE Boletos SET Llego = TRUE WHERE CodigoBarras = @codigo";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@codigo", codigoBarras);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
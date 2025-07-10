using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace DAO
{
    public class ConexionDB
    {
        private string connectionString = "Server=localhost;Database=SistemaVuelos;Uid=root;Pwd=2218914015;";

        /// <summary>
        /// Constructor de la clase ConexionDB.
        /// </summary>
        public ConexionDB()
        {
        }

        /// <summary>
        /// Crea y retorna una nueva conexión MySQL usando la cadena de conexión definida.
        /// </summary>
        /// <returns>Instancia de MySqlConnection lista para abrir.</returns>
        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        /// <summary>
        /// Ejecuta una consulta SELECT y devuelve los resultados en un DataTable.
        /// </summary>
        /// <param name="query">Consulta SQL SELECT a ejecutar.</param>
        /// <returns>Resultados en un DataTable.</returns>
        public DataTable Consultar(string query)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection connection = GetConnection())
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dt);
                }
            }
            return dt;
        }

        /// <summary>
        /// Ejecuta una instrucción SQL de tipo INSERT, UPDATE o DELETE.
        /// </summary>
        /// <param name="query">Consulta SQL a ejecutar.</param>
        /// <returns>Número de filas afectadas.</returns>
        public int EjecutarComando(string query)
        {
            using (MySqlConnection connection = GetConnection())
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    return command.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Inserta un nuevo pasajero en la base de datos.
        /// </summary>
        /// <param name="nombre">Nombre del pasajero.</param>
        /// <param name="apellido">Apellido del pasajero.</param>
        /// <param name="email">Correo electrónico del pasajero.</param>
        /// <param name="telefono">Teléfono del pasajero.</param>
        /// <returns>ID generado del pasajero insertado, o -1 si falla.</returns>
        public int InsertarPasajero(string nombre, string apellido, string email, string telefono)
        {
            string query = "INSERT INTO Pasajeros (Nombre, Apellido, Email, Telefono) VALUES (@Nombre, @Apellido, @Email, @Telefono); SELECT LAST_INSERT_ID();";

            using (MySqlConnection connection = GetConnection())
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@Apellido", apellido);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Telefono", telefono);
                    connection.Open();
                    object result = command.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : -1;
                }
            }
        }

        /// <summary>
        /// Actualiza el estado de ocupación de un asiento.
        /// </summary>
        /// <param name="idAsiento">ID del asiento.</param>
        /// <param name="ocupado">Estado de ocupación: true si está ocupado, false si está libre.</param>
        public void ActualizarEstadoAsiento(int idAsiento, bool ocupado)
        {
            string query = "UPDATE Asientos SET Ocupado = @Ocupado WHERE IdAsiento = @IdAsiento";
            using (MySqlConnection connection = GetConnection())
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Ocupado", ocupado);
                    command.Parameters.AddWithValue("@IdAsiento", idAsiento);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Inserta un nuevo boleto en la base de datos.
        /// </summary>
        /// <param name="idPasajero">ID del pasajero.</param>
        /// <param name="idVuelo">ID del vuelo.</param>
        /// <param name="idAsiento">ID del asiento.</param>
        /// <param name="precioUnitario">Precio del boleto.</param>
        /// <param name="codigoBarras">Código de barras generado para el boleto.</param>
        /// <returns>ID generado del boleto insertado, o -1 si falla.</returns>
        public int InsertarBoleto(int idPasajero, int idVuelo, int idAsiento, decimal precioUnitario, string codigoBarras)
        {
            string query = "INSERT INTO Boletos (IdPasajero, IdVuelo, IdAsiento, PrecioTotal, CodigoBarras) VALUES (@IdPasajero, @IdVuelo, @IdAsiento, @PrecioUnitario, @CodigoBarras); SELECT LAST_INSERT_ID();";
            using (MySqlConnection connection = GetConnection())
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IdPasajero", idPasajero);
                    command.Parameters.AddWithValue("@IdVuelo", idVuelo);
                    command.Parameters.AddWithValue("@IdAsiento", idAsiento);
                    command.Parameters.AddWithValue("@PrecioUnitario", precioUnitario);
                    command.Parameters.AddWithValue("@CodigoBarras", codigoBarras);
                    connection.Open();
                    object result = command.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : -1;
                }
            }
        }

        /// <summary>
        /// Obtiene los vuelos que coinciden con el origen, destino y fecha especificados.
        /// </summary>
        /// <param name="origen">Ciudad de origen.</param>
        /// <param name="destino">Ciudad de destino.</param>
        /// <param name="fecha">Fecha de salida.</param>
        /// <returns>Tabla con los vuelos encontrados.</returns>
        public DataTable ObtenerVuelos(string origen, string destino, DateTime fecha)
        {
            string query = "SELECT IdVuelo, Origen, Destino, FechaSalida, HoraSalida, Precio FROM Vuelos WHERE Origen = @Origen AND Destino = @Destino AND FechaSalida = @FechaSalida";
            DataTable dt = new DataTable();
            using (MySqlConnection connection = GetConnection())
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Origen", origen);
                    command.Parameters.AddWithValue("@Destino", destino);
                    command.Parameters.AddWithValue("@FechaSalida", fecha.Date);
                    connection.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dt);
                }
            }
            return dt;
        }

        /// <summary>
        /// Obtiene los asientos de un vuelo específico.
        /// </summary>
        /// <param name="idVuelo">ID del vuelo.</param>
        /// <returns>Tabla con los asientos del vuelo (número y estado de ocupación).</returns>
        public DataTable ObtenerAsientosVuelo(int idVuelo)
        {
            string query = "SELECT IdAsiento, NumeroAsiento, Ocupado FROM Asientos WHERE IdVuelo = @IdVuelo";
            DataTable dt = new DataTable();
            using (MySqlConnection connection = GetConnection())
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IdVuelo", idVuelo);
                    connection.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dt);
                }
            }
            return dt;
        }
    }
}

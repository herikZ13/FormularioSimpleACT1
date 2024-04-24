

using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace FormularioSimpleACT1.DataAccess
{
    internal class Conexion
    {
        // IntentoDeConexion hace una conexion a la base de datos usando cadenaDeConexion
        public bool IntentoDeConexion(string cadenaDeConexion)
        {
            try
            {
                // condicion para abrir una conexión a la base de datos 
                using (var conexion = new MySqlConnection(cadenaDeConexion))
                {
                    conexion.Open(); // Se abre la conexión
                    return true; // Se devuelve verdadero si la conexión se abre con éxito
                }
            }
            catch (Exception ex)
            {
                // Si ocurre un error al intentar conectar,  imprime un mensaje de error
                Console.WriteLine("Error al intentar conectar: " + ex.Message);
                return false; // Se devuelve falso si no se puede establecer la conexión
            }
        }

        // ObtenerDatos de la base de datos 
        public DataTable ObtenerDatos(string cadenaDeConexion)
        {
            DataTable dt = new DataTable(); // Se crea un nuevo DataTable para almacenar los datos 
            try
            {
                using (var conexion = new MySqlConnection(cadenaDeConexion))
                {
                    conexion.Open(); 

                    string query = "SELECT * FROM catpersonal"; // Se define la consulta SQL 

                    // Se crea un nuevo MySqlCommand con la consulta SQL y la conexión
                    using (var comando = new MySqlCommand(query, conexion))
                    // Se crea un nuevo MySqlDataAdapter con el comando y la conexión
                    using (var adapter = new MySqlDataAdapter(comando))
                    {
                        adapter.Fill(dt); // Se ejecuta la consulta y se llenan los datos en el DataTable
                    }
                }
            }
            catch (Exception ex)
            {
                // Si ocurre un error al intentar obtener los datos, se imprime un mensaje de error en la consola
                Console.WriteLine("Error al obtener información: " + ex.Message);
            }
            return dt; // Se devuelve el DataTable, que puede contener datos recuperados o estar vacío en caso de error
        }

    }

}


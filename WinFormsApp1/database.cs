using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace WinFormsApp1
{
    public class database
    {


        public MySqlConnection connection;
        public string connectionString;

        // Constructor
        public database()
        {
            // Ajusta con tus credenciales
            connectionString = "Server=localhost;Database=fabtrack;User ID=root;Password=;SslMode=none;";
            connection = new MySqlConnection(connectionString);
        }

        // Abrir conexión
        public bool OpenConnection()
        {
            try
            {
                // Código para abrir conexión
                // Por ejemplo:
                connection.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }


        // Cerrar conexión
        public void CloseConnection()
        {
            if (connection.State == ConnectionState.Open)
                connection.Close();
        }

        // SELECT → retorna DataTable
        public DataTable ExecuteQuery(string query)
        {
            DataTable dt = new DataTable();
            try
            {
                OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en consulta: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return dt;
        }

        // INSERT, UPDATE, DELETE → retorna filas afectadas
        public int ExecuteNonQuery(string query)
        {
            int rowsAffected = 0;
            try
            {
                OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                rowsAffected = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en NonQuery: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return rowsAffected;
        }

        // Para obtener un solo valor (ej. COUNT(*))
        public object ExecuteScalar(string query)
        {
            object result = null;
            try
            {
                OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                result = cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en Scalar: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return result;
        }
    }
}

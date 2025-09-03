using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

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
            //connectionString = "Server=192.168.6.22;Database=fabtrack;User ID=jose;Password=123456789;SslMode=none;";
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
        public Dictionary<string, string> GetEmpleado(string empleadoID)
        {
            Dictionary<string, string> empleado = new Dictionary<string, string>();

            try
            {
                OpenConnection();
                string query = @"SELECT id, nombre, apellido_paterno, apellido_materno, 
                                numero_empleado, telefono, email, turno
                         FROM usuarios 
                         WHERE numero_empleado = @id";
               

                // Copiar automáticamente al portapapeles
               
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@id", empleadoID);
                
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    empleado["id"] = reader["id"].ToString();
                    empleado["nombre"] = reader["nombre"].ToString();
                    empleado["apellido_paterno"] = reader["apellido_paterno"].ToString();
                    empleado["apellido_materno"] = reader["apellido_materno"].ToString();
                    empleado["numero_empleado"] = reader["numero_empleado"].ToString();
                    empleado["telefono"] = reader["telefono"].ToString();
                    empleado["email"] = reader["email"].ToString();
                    empleado["turno"] = reader["turno"].ToString();
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener empleado: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }

            return empleado;
        }
        public Dictionary<string, string> GetLector(string serie)
        {
            Dictionary<string, string> lector = new Dictionary<string, string>();

            try
            {
                OpenConnection();
                string query = "SELECT * FROM lectores WHERE serie = @serie LIMIT 1";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@serie", serie);

                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    lector["idPrimaria"] = reader["id"].ToString();
                    lector["serieÍndice"] = reader["serie"].ToString();
                    lector["nombre"] = reader["nombre"].ToString();
                    lector["fecha_registro"] = reader["fecha_registro"].ToString();
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener lector: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }

            return lector;
        }


    }
}

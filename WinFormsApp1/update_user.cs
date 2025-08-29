using FabTrack;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WinFormsApp1
{
    public partial class update_user : Form
    {
        string id_empleado = null;
       
        public update_user()
        {
            InitializeComponent();
        }
       
        private void button3_Click(object sender, EventArgs e)
        {
            string empleadoID = txtEmpleadoID.Text.Trim();
            database db = new database();

            // Obtener datos del empleado
            var empleado = db.GetEmpleado(empleadoID);
            if (empleado.Count > 0)
            {
                id_empleado = empleado["id"];
                txtNombre.Text = empleado["nombre"];
                txtApellidoP.Text = empleado["apellido_paterno"];
                txtApellidoM.Text = empleado["apellido_materno"];
                txtNumeroEmpleado.Text = empleado["numero_empleado"];
                txtTelefono.Text = empleado["telefono"];
                txtEmail.Text = empleado["email"];
                string turnoEmpleado = empleado["turno"]; // viene de la DB, probablemente "1", "2" o "3"

                if (comboTurno.Items.Contains(turnoEmpleado))
                {
                    comboTurno.SelectedItem = turnoEmpleado;
                }
                else
                {
                    comboTurno.SelectedIndex = -1; // Ninguno seleccionado si no coincide
                }

            }
            else
            {
                MessageBox.Show("Empleado no encontrado");

                txtNombre.Text = "";
                txtApellidoP.Text = "";
                txtApellidoM.Text = "";
                txtNumeroEmpleado.Text = "";
                txtTelefono.Text = "";
                txtEmail.Text = "";

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string paterno = txtApellidoP.Text;
            string materno = txtApellidoM.Text;
            string no_empleado = txtNumeroEmpleado.Text;
            string telefono = txtTelefono.Text;
            string email = txtEmail.Text;
            string turno = comboTurno.SelectedItem.ToString();


            // Construir la sentencia SQL
            string sqlUpdate = $"UPDATE usuarios " +
                    $"SET nombre = '{nombre}', " +
                    $"apellido_paterno = '{paterno}', " +
                    $"apellido_materno = '{materno}', " +
                    $"numero_empleado = '{no_empleado}', " +
                    $"telefono = '{telefono}', " +
                    $"email = '{email}', " +
                    $"turno = '{turno}' " +
                    $"WHERE id = '{id_empleado}'";


            // Ejecutar
            database db = new database();
            if (db.OpenConnection())
            {
                db.ExecuteQuery(sqlUpdate); // Método que ejecuta la consulta
                db.CloseConnection();
                MessageBox.Show("✅ Usuario modficado correctamente!");
            }
            else
            {
                MessageBox.Show("❌ Error en la conexión.");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void button4_Click(object sender, EventArgs e)
        {

           
        }
    }
}

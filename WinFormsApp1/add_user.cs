using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class add_user : Form
    {
        public add_user()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nombre = txtname.Text;
            string paterno = txtpaterno.Text;
            string materno = txtmaterno.Text;
            string no_empleado = txtno_empleado.Text;
            string telefono = txt_telefono.Text;
            string email = txtemail.Text;
            string turno = cb_turno.SelectedItem.ToString();

            // Construir la sentencia SQL
            string sqlInsert = $"INSERT INTO usuarios (nombre, apellido_paterno, apellido_materno, numero_empleado, telefono, email, turno) " +
                               $"VALUES ('{nombre}', '{paterno}', '{materno}', '{no_empleado}', '{telefono}',  '{email}',  '{turno}')";
        

            // Ejecutar
            database db = new database();
            if (db.OpenConnection())
            {
                db.ExecuteQuery(sqlInsert); // Método que ejecuta la consulta
                db.CloseConnection();
                MessageBox.Show("✅ Usuario registrado correctamente!");
            }
            else
            {
                MessageBox.Show("❌ Error en la conexión.");
            }
        }
    }
}

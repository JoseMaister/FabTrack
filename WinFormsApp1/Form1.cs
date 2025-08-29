using FabTrack;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using DPFP;
using DPFP.Capture;

namespace WinFormsApp1
{
    public partial class Form1 : Form, DPFP.Capture.EventHandler
    {
        private Label[] lblLectores;
        private Label[] lblAcciones;
        private Label[] lblUsuarios;
        private string[] serialesLectores;
        private Capture lector;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Inicializamos arrays
            lblLectores = new Label[] { lblLector1, lblLector2, lblLector3, lblLector4 };
            lblAcciones = new Label[] { lblAccion1, lblAccion2, lblAccion3, lblAccion4 };
            lblUsuarios = new Label[] { lblUsuario1, lblUsuario2, lblUsuario3, lblUsuario4 };
            serialesLectores = new string[lblLectores.Length];

            // Cargar lectores desde la BD
            database db = new database();
            string query = "SELECT nombre, serie FROM lectores ORDER BY id ASC LIMIT 4";
            DataTable dt = db.ExecuteQuery(query);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                lblLectores[i].Text = dt.Rows[i]["nombre"].ToString();
                serialesLectores[i] = dt.Rows[i]["serie"].ToString();
                lblAcciones[i].Text = "";
                lblUsuarios[i].Text = "";
            }

            // Inicializar lector
            lector = new Capture();
            if (lector != null)
            {
                lector.EventHandler = this;
                try { lector.StartCapture(); }
                catch { MessageBox.Show("No se pudo iniciar el lector de huellas."); }
            }
        }

        // -------------------------
        // DPFP EventHandler
        // -------------------------
        public void OnComplete(object Capture, string ReaderSerialNumber, Sample Sample)
        {
            // Convertimos la huella a un hash o string único
            string huella = ConvertSampleToString(Sample);

            // Invocamos en UI thread
            this.Invoke(new Action(() =>
            {
                MarcarLector(ReaderSerialNumber, huella);
            }));
        }

        public void OnFingerTouch(object Capture, string ReaderSerialNumber) { }
        public void OnFingerGone(object Capture, string ReaderSerialNumber) { }
        public void OnReaderConnect(object Capture, string ReaderSerialNumber) { }
        public void OnReaderDisconnect(object Capture, string ReaderSerialNumber) { }
        public void OnSampleQuality(object Capture, string ReaderSerialNumber, CaptureFeedback Feedback) { }

        // -------------------------
        // Marcar lector y usuario
        // -------------------------
        private void MarcarLector(string serieLector, string huella)
        {
            int index = Array.IndexOf(serialesLectores, serieLector);
            if (index == -1) return;

            lblAcciones[index].Text = "📌 Tocado";

            // Buscar usuario en BD
            database db = new database();
            string query = "SELECT nombre FROM usuarios WHERE huella1=@h OR huella2=@h OR huella3=@h";
           // var parametros = new Dictionary<string, object> { { "@h", huella } };
            DataTable dt = db.ExecuteQuery(query);

            lblUsuarios[index].Text = (dt.Rows.Count > 0) ? dt.Rows[0]["nombre"].ToString() : "Desconocido";
        }

        // -------------------------
        // Convertir Sample a string único (ejemplo simplificado)
        // -------------------------
        private string ConvertSampleToString(Sample sample)
        {
            // Aquí dependerá del SDK, esto es un ejemplo
            byte[] raw = null;
            sample.Serialize(ref raw);
            return BitConverter.ToString(raw); // string único de la huella
        }

        // -------------------------
        // Menúes
        // -------------------------
        private void altaUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_user frm = new add_user();
            frm.ShowDialog();
        }

        private void verUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuarios frm = new Usuarios();
            frm.ShowDialog();
        }

        private void modificarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            update_user frm = new update_user();
            frm.ShowDialog();
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            database db = new database();
            if (db.OpenConnection())
            {
                MessageBox.Show("✅ Conexión exitosa a la BD!");
                db.CloseConnection();
            }
            else
            {
                MessageBox.Show("❌ Error en la conexión.");
            }
        }

        private void caputarurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_reader frm = new add_reader();
            frm.ShowDialog();
        }
    }
}

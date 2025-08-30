using FabTrack;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using DPFP;
using DPFP.Capture;
using MySql.Data.MySqlClient;

namespace WinFormsApp1
{
    public partial class Form1 : Form, DPFP.Capture.EventHandler
    {
        private Label[] lblLectores;
        private Label[] lblAcciones;
        private Label[] lblUsuarios;
        private string[] serialesLectores;
        private Capture lector;
        private List<Capture> capturadores = new List<Capture>();
        private Dictionary<string, int> dicSerialIndex = new Dictionary<string, int>();

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
                string serie = dt.Rows[i]["serie"].ToString().Trim(); // trim para quitar espacios
                lblLectores[i].Text = dt.Rows[i]["nombre"].ToString();
                serialesLectores[i] = serie;
                lblAcciones[i].Text = "";
                lblUsuarios[i].Text = "";

                // Guardamos en diccionario
                dicSerialIndex[serie] = i;
            }

            IniciarCaptura();
        }


        // -------------------------
        // DPFP EventHandler
        // -------------------------
        public void OnComplete(object Capture, string ReaderSerialNumber, Sample Sample)
        {
            this.Invoke(new Action(() =>
            {
                // Buscar datos del lector en BD
                database db = new database();
                var lectorInfo = db.GetLector(ReaderSerialNumber);

                if (lectorInfo.Count > 0)
                {
                    string info = $"📟 ID: {lectorInfo["idPrimaria"]}\n" +
                                  $"🔑 Serie: {lectorInfo["serieÍndice"]}\n" +
                                  $"📛 Nombre: {lectorInfo["nombre"]}\n" +
                                  $"🕒 Registro: {lectorInfo["fecha_registro"]}";

                    // MessageBox.Show(info, "Información del Lector", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"No se encontró en BD el lector con serie {ReaderSerialNumber}");
                }

                // Aquí sigue tu flujo normal si quieres
                string huella = ConvertSampleToString(Sample);
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
            serieLector = serieLector.Trim();

            int index = -1;
            for (int i = 0; i < serialesLectores.Length; i++)
            {
                if (serialesLectores[i].Trim().Equals(serieLector, StringComparison.OrdinalIgnoreCase))
                {
                    index = i;
                    break;
                }
            }

            if (index == -1)
            {
                MessageBox.Show($"No se encontró el lector con serie '{serieLector}'");
                return;
            }

            // Actualizamos el label de acciones
            lblAcciones[index].Text = $"📌 Tocado - {serieLector}";

            // Buscar usuario por huella en BD
            database db = new database();
            string query = "SELECT nombre FROM usuarios WHERE huella1=@h OR huella2=@h OR huella3=@h";
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
        private void IniciarCaptura()
        {
            try
            {
                // Detectamos todos los lectores conectados
                ReadersCollection readers = new ReadersCollection();

                if (readers.Count == 0)
                {
                    MessageBox.Show("No se detecta ningún lector");
                    return;
                }

                foreach (var reader in readers)
                {
                    try
                    {
                        // inicializar captura para este lector
                        Capture cap = new Capture(reader.Value.SerialNumber);
                        cap.EventHandler = this;
                        cap.StartCapture();

                        capturadores.Add(cap);

                        // Opcional: log para verificar
                        // MessageBox.Show($"Lector {reader.Value.SerialNumber} activado ✅");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"No se pudo iniciar lector {reader.Value.SerialNumber}: {ex.Message}");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al iniciar captura: " + ex.Message);
            }
        }

    }
}

using System;
using System.Windows.Forms;
using DPFP;
using DPFP.Capture;
using MySql.Data.MySqlClient;
using WinFormsApp1;

namespace FabTrack
{
    public partial class add_reader : Form, DPFP.Capture.EventHandler
    {
        private Capture Capturer;

        public add_reader()
        {
            InitializeComponent();
            InitCapturer();
        }

        private void InitCapturer()
        {
            try
            {
                Capturer = new Capture(); // Crear capturador
                if (Capturer != null)
                    Capturer.EventHandler = this; // Suscribirse a eventos
                else
                    MessageBox.Show("No se pudo iniciar el capturador de huellas.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al inicializar el capturador: " + ex.Message);
            }
        }

        private void add_reader_Load(object sender, EventArgs e)
        {
            try
            {
                Capturer.StartCapture(); // Inicia captura para disparar OnReaderConnect
            }
            catch
            {
                MessageBox.Show("No se pudo iniciar el lector");
            }
        }

        // --- DPFP EventHandler ---
        public void OnReaderConnect(object Capture, string ReaderSerialNumber)
        {
            // Este evento se dispara automáticamente cuando el lector está conectado
            if (txtserie.InvokeRequired)
            {
                txtserie.Invoke(new Action(() =>
                {
                    txtserie.Text = ReaderSerialNumber;
                    MessageBox.Show("Lector conectado: " + ReaderSerialNumber);
                }));
            }
            else
            {
                txtserie.Text = ReaderSerialNumber;
                MessageBox.Show("Lector conectado: " + ReaderSerialNumber);
            }
        }

        public void OnComplete(object Capture, string ReaderSerialNumber, DPFP.Sample Sample) { }
        public void OnFingerGone(object Capture, string ReaderSerialNumber) { }
        public void OnFingerTouch(object Capture, string ReaderSerialNumber) { }
        public void OnReaderDisconnect(object Capture, string ReaderSerialNumber) { }
        public void OnSampleQuality(object Capture, string ReaderSerialNumber, DPFP.Capture.CaptureFeedback CaptureFeedback) { }

        // --- Botón Agregar Lector ---
        private void button2_Click(object sender, EventArgs e)
        {
            string nombre = txtname.Text;
            string serie = txtserie.Text;

            if (string.IsNullOrEmpty(serie))
            {
                MessageBox.Show("Conecta primero el lector para obtener la serie.");
                return;
            }

            database db = new database();
            try
            {
                string query = "INSERT INTO lectores (nombre, serie) VALUES (@nombre, @serie)";
                if (db.OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, db.connection);
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@serie", serie);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("✅ Lector registrado correctamente!");
                }
                else
                {
                    MessageBox.Show("❌ Error al conectar con la base de datos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar lector: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (Capturer != null)
            {
                Capturer.StopCapture();
                Capturer = null;
            }
        }
    }
}

using DPFP;
using DPFP.Capture;
using DPFP.Processing;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace FabTrack
{
    internal class HuellaHandler : DPFP.Capture.EventHandler
    {
        private WinFormsApp1.update_user form;
        private byte[] huella1;
        private byte[] huella2;

        public HuellaHandler(WinFormsApp1.update_user frm)
        {
            form = frm;
            huella1 = null;
            huella2 = null;
        }

        public void OnComplete(object Capture, string ReaderSerialNumber, Sample Sample)
        {
            byte[] huellaBytes = ConvertSampleToBytes(Sample);

            if (huella1 == null)
            {
                huella1 = huellaBytes;
                MessageBox.Show("Primera huella capturada. Ahora coloca el segundo dedo.");
            }
            else if (huella2 == null)
            {
                huella2 = huellaBytes;

                // Guardar en la base de datos
                WinFormsApp1.database db = new WinFormsApp1.database();
                if (db.OpenConnection())
                {
                    string query = "UPDATE usuarios SET Huella1=@h1, Huella2=@h2 WHERE id=@id";
                    using (MySqlCommand cmd = new MySqlCommand(query, db.connection))
                    {
                        cmd.Parameters.AddWithValue("@h1", huella1);
                        cmd.Parameters.AddWithValue("@h2", huella2);
                      //  cmd.Parameters.AddWithValue("@id", form.id_empleado); // ahora público
                        cmd.ExecuteNonQuery();
                    }
                    db.CloseConnection();
                    MessageBox.Show("✅ Huellas guardadas correctamente!");
                }
            }
        }

        private byte[] ConvertSampleToBytes(Sample sample)
        {
            FeatureExtraction extractor = new FeatureExtraction();
            FeatureSet features = new FeatureSet();
            CaptureFeedback feedback = CaptureFeedback.None;

            extractor.CreateFeatureSet(sample, DataPurpose.Verification, ref feedback, ref features);
            return features.Bytes;
        }

        public void OnFingerTouch(object Capture, string ReaderSerialNumber) { }
        public void OnFingerGone(object Capture, string ReaderSerialNumber) { }
        public void OnReaderConnect(object Capture, string ReaderSerialNumber) { }
        public void OnReaderDisconnect(object Capture, string ReaderSerialNumber) { }
        public void OnSampleQuality(object Capture, string ReaderSerialNumber, CaptureFeedback CaptureFeedback) { }
    }
}

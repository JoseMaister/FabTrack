namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void altaUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_user frm = new add_user();
            frm.ShowDialog();
        }

        private void verUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            users frm = new users();
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
    }
}

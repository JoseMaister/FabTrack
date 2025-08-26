namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            configToolStripMenuItem = new ToolStripMenuItem();
            accionesToolStripMenuItem = new ToolStripMenuItem();
            altaUsuariosToolStripMenuItem = new ToolStripMenuItem();
            reportesToolStripMenuItem = new ToolStripMenuItem();
            verUsuariosToolStripMenuItem = new ToolStripMenuItem();
            modificarUsuariosToolStripMenuItem = new ToolStripMenuItem();
            tableLayoutPanel1 = new TableLayoutPanel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, configToolStripMenuItem, accionesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(60, 20);
            archivoToolStripMenuItem.Text = "Archivo";
            archivoToolStripMenuItem.Click += archivoToolStripMenuItem_Click;
            // 
            // configToolStripMenuItem
            // 
            configToolStripMenuItem.Name = "configToolStripMenuItem";
            configToolStripMenuItem.Size = new Size(55, 20);
            configToolStripMenuItem.Text = "Config";
            // 
            // accionesToolStripMenuItem
            // 
            accionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { altaUsuariosToolStripMenuItem, reportesToolStripMenuItem, verUsuariosToolStripMenuItem, modificarUsuariosToolStripMenuItem });
            accionesToolStripMenuItem.Name = "accionesToolStripMenuItem";
            accionesToolStripMenuItem.Size = new Size(67, 20);
            accionesToolStripMenuItem.Text = "Acciones";
            // 
            // altaUsuariosToolStripMenuItem
            // 
            altaUsuariosToolStripMenuItem.Name = "altaUsuariosToolStripMenuItem";
            altaUsuariosToolStripMenuItem.Size = new Size(180, 22);
            altaUsuariosToolStripMenuItem.Text = "Alta Usuarios";
            altaUsuariosToolStripMenuItem.Click += altaUsuariosToolStripMenuItem_Click;
            // 
            // reportesToolStripMenuItem
            // 
            reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            reportesToolStripMenuItem.Size = new Size(180, 22);
            reportesToolStripMenuItem.Text = "Reportes";
            // 
            // verUsuariosToolStripMenuItem
            // 
            verUsuariosToolStripMenuItem.Name = "verUsuariosToolStripMenuItem";
            verUsuariosToolStripMenuItem.Size = new Size(180, 22);
            verUsuariosToolStripMenuItem.Text = "Ver usuarios";
            verUsuariosToolStripMenuItem.Click += verUsuariosToolStripMenuItem_Click;
            // 
            // modificarUsuariosToolStripMenuItem
            // 
            modificarUsuariosToolStripMenuItem.Name = "modificarUsuariosToolStripMenuItem";
            modificarUsuariosToolStripMenuItem.Size = new Size(180, 22);
            modificarUsuariosToolStripMenuItem.Text = "Modificar usuarios";
            modificarUsuariosToolStripMenuItem.Click += modificarUsuariosToolStripMenuItem_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Location = new Point(10, 61);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(778, 377);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "FabTrack";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem configToolStripMenuItem;
        private ToolStripMenuItem accionesToolStripMenuItem;
        private ToolStripMenuItem altaUsuariosToolStripMenuItem;
        private ToolStripMenuItem reportesToolStripMenuItem;
        private ToolStripMenuItem verUsuariosToolStripMenuItem;
        private ToolStripMenuItem modificarUsuariosToolStripMenuItem;
        private TableLayoutPanel tableLayoutPanel1;
    }
}

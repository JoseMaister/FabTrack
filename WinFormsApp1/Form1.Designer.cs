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
            caputarurToolStripMenuItem = new ToolStripMenuItem();
            accionesToolStripMenuItem = new ToolStripMenuItem();
            altaUsuariosToolStripMenuItem = new ToolStripMenuItem();
            reportesToolStripMenuItem = new ToolStripMenuItem();
            verUsuariosToolStripMenuItem = new ToolStripMenuItem();
            modificarUsuariosToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            lblUsuario1 = new Label();
            lblAccion1 = new Label();
            lblLector1 = new Label();
            panel2 = new Panel();
            lblUsuario3 = new Label();
            lblAccion3 = new Label();
            lblLector3 = new Label();
            panel3 = new Panel();
            lblUsuario2 = new Label();
            lblAccion2 = new Label();
            lblLector2 = new Label();
            panel4 = new Panel();
            lblUsuario4 = new Label();
            lblAccion4 = new Label();
            lblLector4 = new Label();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
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
            configToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { caputarurToolStripMenuItem });
            configToolStripMenuItem.Name = "configToolStripMenuItem";
            configToolStripMenuItem.Size = new Size(55, 20);
            configToolStripMenuItem.Text = "Config";
            // 
            // caputarurToolStripMenuItem
            // 
            caputarurToolStripMenuItem.Name = "caputarurToolStripMenuItem";
            caputarurToolStripMenuItem.Size = new Size(156, 22);
            caputarurToolStripMenuItem.Text = "Capturar Lector";
            caputarurToolStripMenuItem.Click += caputarurToolStripMenuItem_Click;
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
            altaUsuariosToolStripMenuItem.Size = new Size(172, 22);
            altaUsuariosToolStripMenuItem.Text = "Alta Usuarios";
            altaUsuariosToolStripMenuItem.Click += altaUsuariosToolStripMenuItem_Click;
            // 
            // reportesToolStripMenuItem
            // 
            reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            reportesToolStripMenuItem.Size = new Size(172, 22);
            reportesToolStripMenuItem.Text = "Reportes";
            // 
            // verUsuariosToolStripMenuItem
            // 
            verUsuariosToolStripMenuItem.Name = "verUsuariosToolStripMenuItem";
            verUsuariosToolStripMenuItem.Size = new Size(172, 22);
            verUsuariosToolStripMenuItem.Text = "Ver usuarios";
            verUsuariosToolStripMenuItem.Click += verUsuariosToolStripMenuItem_Click;
            // 
            // modificarUsuariosToolStripMenuItem
            // 
            modificarUsuariosToolStripMenuItem.Name = "modificarUsuariosToolStripMenuItem";
            modificarUsuariosToolStripMenuItem.Size = new Size(172, 22);
            modificarUsuariosToolStripMenuItem.Text = "Modificar usuarios";
            modificarUsuariosToolStripMenuItem.Click += modificarUsuariosToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblUsuario1);
            panel1.Controls.Add(lblAccion1);
            panel1.Controls.Add(lblLector1);
            panel1.Location = new Point(12, 87);
            panel1.Name = "panel1";
            panel1.Size = new Size(380, 148);
            panel1.TabIndex = 3;
            // 
            // lblUsuario1
            // 
            lblUsuario1.AutoSize = true;
            lblUsuario1.FlatStyle = FlatStyle.Flat;
            lblUsuario1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario1.Location = new Point(0, 75);
            lblUsuario1.Name = "lblUsuario1";
            lblUsuario1.Size = new Size(83, 25);
            lblUsuario1.TabIndex = 3;
            lblUsuario1.Text = "Nombre";
            // 
            // lblAccion1
            // 
            lblAccion1.AutoSize = true;
            lblAccion1.FlatStyle = FlatStyle.Flat;
            lblAccion1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAccion1.Location = new Point(0, 40);
            lblAccion1.Name = "lblAccion1";
            lblAccion1.Size = new Size(83, 25);
            lblAccion1.TabIndex = 2;
            lblAccion1.Text = "Nombre";
            // 
            // lblLector1
            // 
            lblLector1.AutoSize = true;
            lblLector1.FlatStyle = FlatStyle.Flat;
            lblLector1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLector1.Location = new Point(0, 0);
            lblLector1.Name = "lblLector1";
            lblLector1.Size = new Size(73, 25);
            lblLector1.TabIndex = 1;
            lblLector1.Text = "Lector1";
            // 
            // panel2
            // 
            panel2.Controls.Add(lblUsuario3);
            panel2.Controls.Add(lblAccion3);
            panel2.Controls.Add(lblLector3);
            panel2.Location = new Point(12, 241);
            panel2.Name = "panel2";
            panel2.Size = new Size(380, 148);
            panel2.TabIndex = 4;
            // 
            // lblUsuario3
            // 
            lblUsuario3.AutoSize = true;
            lblUsuario3.FlatStyle = FlatStyle.Flat;
            lblUsuario3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario3.Location = new Point(0, 75);
            lblUsuario3.Name = "lblUsuario3";
            lblUsuario3.Size = new Size(83, 25);
            lblUsuario3.TabIndex = 3;
            lblUsuario3.Text = "Nombre";
            // 
            // lblAccion3
            // 
            lblAccion3.AutoSize = true;
            lblAccion3.FlatStyle = FlatStyle.Flat;
            lblAccion3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAccion3.Location = new Point(0, 40);
            lblAccion3.Name = "lblAccion3";
            lblAccion3.Size = new Size(83, 25);
            lblAccion3.TabIndex = 2;
            lblAccion3.Text = "Nombre";
            // 
            // lblLector3
            // 
            lblLector3.AutoSize = true;
            lblLector3.FlatStyle = FlatStyle.Flat;
            lblLector3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLector3.Location = new Point(0, 0);
            lblLector3.Name = "lblLector3";
            lblLector3.Size = new Size(76, 25);
            lblLector3.TabIndex = 1;
            lblLector3.Text = "Lector3";
            // 
            // panel3
            // 
            panel3.Controls.Add(lblUsuario2);
            panel3.Controls.Add(lblAccion2);
            panel3.Controls.Add(lblLector2);
            panel3.Location = new Point(408, 87);
            panel3.Name = "panel3";
            panel3.Size = new Size(380, 148);
            panel3.TabIndex = 5;
            // 
            // lblUsuario2
            // 
            lblUsuario2.AutoSize = true;
            lblUsuario2.FlatStyle = FlatStyle.Flat;
            lblUsuario2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario2.Location = new Point(0, 75);
            lblUsuario2.Name = "lblUsuario2";
            lblUsuario2.Size = new Size(83, 25);
            lblUsuario2.TabIndex = 3;
            lblUsuario2.Text = "Nombre";
            // 
            // lblAccion2
            // 
            lblAccion2.AutoSize = true;
            lblAccion2.FlatStyle = FlatStyle.Flat;
            lblAccion2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAccion2.Location = new Point(0, 40);
            lblAccion2.Name = "lblAccion2";
            lblAccion2.Size = new Size(83, 25);
            lblAccion2.TabIndex = 2;
            lblAccion2.Text = "Nombre";
            // 
            // lblLector2
            // 
            lblLector2.AutoSize = true;
            lblLector2.FlatStyle = FlatStyle.Flat;
            lblLector2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLector2.Location = new Point(0, 0);
            lblLector2.Name = "lblLector2";
            lblLector2.Size = new Size(76, 25);
            lblLector2.TabIndex = 1;
            lblLector2.Text = "Lector2";
            // 
            // panel4
            // 
            panel4.Controls.Add(lblUsuario4);
            panel4.Controls.Add(lblAccion4);
            panel4.Controls.Add(lblLector4);
            panel4.Location = new Point(408, 241);
            panel4.Name = "panel4";
            panel4.Size = new Size(380, 148);
            panel4.TabIndex = 6;
            // 
            // lblUsuario4
            // 
            lblUsuario4.AutoSize = true;
            lblUsuario4.FlatStyle = FlatStyle.Flat;
            lblUsuario4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario4.Location = new Point(0, 75);
            lblUsuario4.Name = "lblUsuario4";
            lblUsuario4.Size = new Size(83, 25);
            lblUsuario4.TabIndex = 3;
            lblUsuario4.Text = "Nombre";
            // 
            // lblAccion4
            // 
            lblAccion4.AutoSize = true;
            lblAccion4.FlatStyle = FlatStyle.Flat;
            lblAccion4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAccion4.Location = new Point(0, 40);
            lblAccion4.Name = "lblAccion4";
            lblAccion4.Size = new Size(83, 25);
            lblAccion4.TabIndex = 2;
            lblAccion4.Text = "Nombre";
            // 
            // lblLector4
            // 
            lblLector4.AutoSize = true;
            lblLector4.FlatStyle = FlatStyle.Flat;
            lblLector4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLector4.Location = new Point(0, 0);
            lblLector4.Name = "lblLector4";
            lblLector4.Size = new Size(76, 25);
            lblLector4.TabIndex = 1;
            lblLector4.Text = "Lector4";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "FabTrack";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
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
        private ToolStripMenuItem caputarurToolStripMenuItem;
        private Panel panel1;
        private Label lblUsuario1;
        private Label lblAccion1;
        private Label lblLector1;
        private Panel panel2;
        private Label lblUsuario3;
        private Label lblAccion3;
        private Label lblLector3;
        private Panel panel3;
        private Label lblUsuario2;
        private Label lblAccion2;
        private Label lblLector2;
        private Panel panel4;
        private Label lblUsuario4;
        private Label lblAccion4;
        private Label lblLector4;
    }
}

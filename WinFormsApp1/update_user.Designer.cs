namespace WinFormsApp1
{
    partial class update_user
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel3 = new Panel();
            button2 = new Button();
            button1 = new Button();
            panel2 = new Panel();
            comboTurno = new ComboBox();
            txtEmail = new TextBox();
            txtTelefono = new TextBox();
            txtNumeroEmpleado = new TextBox();
            txtApellidoM = new TextBox();
            txtApellidoP = new TextBox();
            txtNombre = new TextBox();
            panel1 = new Panel();
            label4 = new Label();
            label7 = new Label();
            label1 = new Label();
            label6 = new Label();
            label2 = new Label();
            label5 = new Label();
            label3 = new Label();
            panel4 = new Panel();
            label8 = new Label();
            txtEmpleadoID = new TextBox();
            button3 = new Button();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button1);
            panel3.Location = new Point(204, 375);
            panel3.Name = "panel3";
            panel3.Size = new Size(302, 74);
            panel3.TabIndex = 12;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(159, 16);
            button2.Name = "button2";
            button2.Size = new Size(117, 37);
            button2.TabIndex = 1;
            button2.Text = "Guardar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(8, 16);
            button1.Name = "button1";
            button1.Size = new Size(117, 37);
            button1.TabIndex = 0;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(comboTurno);
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(txtTelefono);
            panel2.Controls.Add(txtNumeroEmpleado);
            panel2.Controls.Add(txtApellidoM);
            panel2.Controls.Add(txtApellidoP);
            panel2.Controls.Add(txtNombre);
            panel2.Location = new Point(335, 74);
            panel2.Name = "panel2";
            panel2.Size = new Size(375, 295);
            panel2.TabIndex = 11;
            // 
            // comboTurno
            // 
            comboTurno.FormattingEnabled = true;
            comboTurno.Items.AddRange(new object[] { "1", "2", "3" });
            comboTurno.Location = new Point(8, 256);
            comboTurno.Name = "comboTurno";
            comboTurno.Size = new Size(265, 23);
            comboTurno.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(8, 221);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(265, 23);
            txtEmail.TabIndex = 5;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(8, 183);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(265, 23);
            txtTelefono.TabIndex = 4;
            // 
            // txtNumeroEmpleado
            // 
            txtNumeroEmpleado.Location = new Point(8, 146);
            txtNumeroEmpleado.Name = "txtNumeroEmpleado";
            txtNumeroEmpleado.Size = new Size(265, 23);
            txtNumeroEmpleado.TabIndex = 3;
            // 
            // txtApellidoM
            // 
            txtApellidoM.Location = new Point(8, 103);
            txtApellidoM.Name = "txtApellidoM";
            txtApellidoM.Size = new Size(265, 23);
            txtApellidoM.TabIndex = 2;
            // 
            // txtApellidoP
            // 
            txtApellidoP.Location = new Point(8, 60);
            txtApellidoP.Name = "txtApellidoP";
            txtApellidoP.Size = new Size(265, 23);
            txtApellidoP.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(8, 20);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(265, 23);
            txtNombre.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(93, 74);
            panel1.Name = "panel1";
            panel1.Size = new Size(236, 295);
            panel1.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(29, 141);
            label4.Name = "label4";
            label4.Size = new Size(199, 25);
            label4.TabIndex = 3;
            label4.Text = "Numero de Empleado";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.FlatStyle = FlatStyle.Flat;
            label7.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(29, 251);
            label7.Name = "label7";
            label7.Size = new Size(61, 25);
            label7.TabIndex = 6;
            label7.Text = "Turno";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(29, 20);
            label1.Name = "label1";
            label1.Size = new Size(83, 25);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(29, 216);
            label6.Name = "label6";
            label6.Size = new Size(59, 25);
            label6.TabIndex = 5;
            label6.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(29, 60);
            label2.Name = "label2";
            label2.Size = new Size(154, 25);
            label2.TabIndex = 1;
            label2.Text = "Apellido Paterno";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(29, 178);
            label5.Name = "label5";
            label5.Size = new Size(85, 25);
            label5.TabIndex = 4;
            label5.Text = "Telefono";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(29, 103);
            label3.Name = "label3";
            label3.Size = new Size(162, 25);
            label3.TabIndex = 2;
            label3.Text = "Apellido Materno";
            // 
            // panel4
            // 
            panel4.Controls.Add(label8);
            panel4.Controls.Add(txtEmpleadoID);
            panel4.Controls.Add(button3);
            panel4.Location = new Point(93, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(617, 64);
            panel4.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.FlatStyle = FlatStyle.Flat;
            label8.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(61, 19);
            label8.Name = "label8";
            label8.Size = new Size(199, 25);
            label8.TabIndex = 4;
            label8.Text = "Numero de Empleado";
            // 
            // txtEmpleadoID
            // 
            txtEmpleadoID.Location = new Point(277, 23);
            txtEmpleadoID.Name = "txtEmpleadoID";
            txtEmpleadoID.Size = new Size(146, 23);
            txtEmpleadoID.TabIndex = 3;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(437, 13);
            button3.Name = "button3";
            button3.Size = new Size(117, 37);
            button3.TabIndex = 2;
            button3.Text = "Buscar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // update_user
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "update_user";
            Text = "Modificar Usuario";
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Button button2;
        private Button button1;
        private Panel panel2;
        private ComboBox comboTurno;
        private TextBox txtEmail;
        private TextBox txtTelefono;
        private TextBox txtNumeroEmpleado;
        private TextBox txtApellidoM;
        private TextBox txtApellidoP;
        private TextBox txtNombre;
        private Panel panel1;
        private Label label4;
        private Label label7;
        private Label label1;
        private Label label6;
        private Label label2;
        private Label label5;
        private Label label3;
        private Panel panel4;
        private Label label8;
        private TextBox txtEmpleadoID;
        private Button button3;
    }
}
namespace ProyectoFinal_Programacionlll.Forms
{
    partial class EditAppointmentForm
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

        private void InitializeComponent()
        {
            lblTitulo = new Label();
            lblFecha = new Label();
            dtpFecha = new DateTimePicker();
            lblMotivo = new Label();
            txtMotivo = new TextBox();
            lblPrecio = new Label();
            txtPrecio = new TextBox();
            btnGuardar = new Button();
            btnCancelar = new Button();
            cmbDoctor = new ComboBox();
            cmbPaciente = new ComboBox();
            lblPaciente = new Label();
            lblDoctor = new Label();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(30, 30, 30);
            lblTitulo.Location = new Point(40, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(400, 40);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Editar Ficha Médica";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 10F);
            lblFecha.Location = new Point(40, 90);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(47, 19);
            lblFecha.TabIndex = 1;
            lblFecha.Text = "Fecha:";
            // 
            // dtpFecha
            // 
            dtpFecha.Font = new Font("Segoe UI", 10F);
            dtpFecha.Location = new Point(150, 85);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(250, 25);
            dtpFecha.TabIndex = 2;
            // 
            // lblMotivo
            // 
            lblMotivo.AutoSize = true;
            lblMotivo.Font = new Font("Segoe UI", 10F);
            lblMotivo.Location = new Point(40, 135);
            lblMotivo.Name = "lblMotivo";
            lblMotivo.Size = new Size(56, 19);
            lblMotivo.TabIndex = 3;
            lblMotivo.Text = "Motivo:";
            // 
            // txtMotivo
            // 
            txtMotivo.Font = new Font("Segoe UI", 10F);
            txtMotivo.Location = new Point(150, 130);
            txtMotivo.Name = "txtMotivo";
            txtMotivo.Size = new Size(250, 25);
            txtMotivo.TabIndex = 4;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI", 10F);
            lblPrecio.Location = new Point(40, 180);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(49, 19);
            lblPrecio.TabIndex = 5;
            lblPrecio.Text = "Precio:";
            // 
            // txtPrecio
            // 
            txtPrecio.Font = new Font("Segoe UI", 10F);
            txtPrecio.Location = new Point(150, 175);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(250, 25);
            txtPrecio.TabIndex = 6;
            txtPrecio.KeyPress += txtPrecio_KeyPress;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(0, 120, 215);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(150, 320);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(110, 35);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Gray;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(290, 320);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(110, 35);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // cmbDoctor
            // 
            cmbDoctor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDoctor.Location = new Point(150, 259);
            cmbDoctor.Name = "cmbDoctor";
            cmbDoctor.Size = new Size(200, 23);
            cmbDoctor.TabIndex = 13;
            //cmbDoctor.SelectedIndexChanged += this.cmbDoctor_SelectedIndexChanged;
            // 
            // cmbPaciente
            // 
            cmbPaciente.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPaciente.Location = new Point(150, 219);
            cmbPaciente.Name = "cmbPaciente";
            cmbPaciente.Size = new Size(200, 23);
            cmbPaciente.TabIndex = 14;
            //cmbPaciente.SelectedIndexChanged += this.cmbPaciente_SelectedIndexChanged;
            // 
            // lblPaciente
            // 
            lblPaciente.AutoSize = true;
            lblPaciente.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPaciente.Location = new Point(40, 219);
            lblPaciente.Name = "lblPaciente";
            lblPaciente.Size = new Size(74, 19);
            lblPaciente.TabIndex = 15;
            lblPaciente.Text = "Paciente :";
            lblPaciente.Click += this.lblPaciente_Click;
            // 
            // lblDoctor
            // 
            lblDoctor.AutoSize = true;
            lblDoctor.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDoctor.Location = new Point(40, 259);
            lblDoctor.Name = "lblDoctor";
            lblDoctor.Size = new Size(63, 19);
            lblDoctor.TabIndex = 16;
            lblDoctor.Text = "Doctor :";
            lblDoctor.Click += lblDoctor_Click;
            // 
            // EditAppointmentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(460, 390);
            Controls.Add(cmbDoctor);
            Controls.Add(cmbPaciente);
            Controls.Add(lblPaciente);
            Controls.Add(lblDoctor);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(txtPrecio);
            Controls.Add(lblPrecio);
            Controls.Add(txtMotivo);
            Controls.Add(lblMotivo);
            Controls.Add(dtpFecha);
            Controls.Add(lblFecha);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditAppointmentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar Ficha Médica";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblMotivo;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private ComboBox cmbDoctor;
        private ComboBox cmbPaciente;
        private Label lblPaciente;
        private Label lblDoctor;
    }
}

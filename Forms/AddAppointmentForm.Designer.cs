namespace ProyectoFinal_Programacionlll.Forms
{
    partial class AddAppointmentForm
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
            lblFecha = new Label();
            dtpFecha = new DateTimePicker();
            lblMotivo = new Label();
            txtMotivo = new TextBox();
            lblPrecio = new Label();
            txtPrecio = new TextBox();
            lblPaciente = new Label();
            lblDoctor = new Label();
            btnGuardar = new Button();
            btnCancelar = new Button();
            cmbPaciente = new ComboBox();
            cmbDoctor = new ComboBox();
            SuspendLayout();
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFecha.Location = new Point(50, 40);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(51, 19);
            lblFecha.TabIndex = 0;
            lblFecha.Text = "Fecha:";
            // 
            // dtpFecha
            // 
            dtpFecha.CalendarForeColor = Color.Black;
            dtpFecha.CalendarMonthBackground = Color.White;
            dtpFecha.Location = new Point(150, 37);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(200, 25);
            dtpFecha.TabIndex = 1;
            // 
            // lblMotivo
            // 
            lblMotivo.AutoSize = true;
            lblMotivo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblMotivo.Location = new Point(50, 100);
            lblMotivo.Name = "lblMotivo";
            lblMotivo.Size = new Size(61, 19);
            lblMotivo.TabIndex = 2;
            lblMotivo.Text = "Motivo:";
            // 
            // txtMotivo
            // 
            txtMotivo.BackColor = Color.White;
            txtMotivo.BorderStyle = BorderStyle.FixedSingle;
            txtMotivo.ForeColor = Color.Black;
            txtMotivo.Location = new Point(150, 97);
            txtMotivo.Multiline = true;
            txtMotivo.Name = "txtMotivo";
            txtMotivo.Size = new Size(200, 60);
            txtMotivo.TabIndex = 3;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPrecio.Location = new Point(50, 180);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(56, 19);
            lblPrecio.TabIndex = 4;
            lblPrecio.Text = "Precio:";
            // 
            // txtPrecio
            // 
            txtPrecio.BackColor = Color.White;
            txtPrecio.BorderStyle = BorderStyle.FixedSingle;
            txtPrecio.ForeColor = Color.Black;
            txtPrecio.Location = new Point(150, 177);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.PlaceholderText = "Solo números";
            txtPrecio.Size = new Size(200, 25);
            txtPrecio.TabIndex = 5;
            txtPrecio.KeyPress += txtPrecio_KeyPress;
            // 
            // lblPaciente
            // 
            lblPaciente.AutoSize = true;
            lblPaciente.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPaciente.Location = new Point(55, 240);
            lblPaciente.Name = "lblPaciente";
            lblPaciente.Size = new Size(74, 19);
            lblPaciente.TabIndex = 6;
            lblPaciente.Text = "Paciente :";
            // 
            // lblDoctor
            // 
            lblDoctor.AutoSize = true;
            lblDoctor.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDoctor.Location = new Point(55, 300);
            lblDoctor.Name = "lblDoctor";
            lblDoctor.Size = new Size(63, 19);
            lblDoctor.TabIndex = 8;
            lblDoctor.Text = "Doctor :";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(46, 134, 222);
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(70, 400);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(120, 40);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "💾 Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(99, 110, 114);
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(220, 400);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(120, 40);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar ❌";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // cmbPaciente
            // 
            cmbPaciente.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPaciente.Location = new Point(150, 240);
            cmbPaciente.Name = "cmbPaciente";
            cmbPaciente.Size = new Size(200, 25);
            cmbPaciente.TabIndex = 1;
            cmbPaciente.SelectedIndexChanged += cmbPaciente_SelectedIndexChanged;
            // 
            // cmbDoctor
            // 
            cmbDoctor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDoctor.Location = new Point(150, 300);
            cmbDoctor.Name = "cmbDoctor";
            cmbDoctor.Size = new Size(200, 25);
            cmbDoctor.TabIndex = 0;
            // 
            // AddAppointmentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 246, 250);
            ClientSize = new Size(420, 520);
            Controls.Add(cmbDoctor);
            Controls.Add(cmbPaciente);
            Controls.Add(lblFecha);
            Controls.Add(dtpFecha);
            Controls.Add(lblMotivo);
            Controls.Add(txtMotivo);
            Controls.Add(lblPrecio);
            Controls.Add(txtPrecio);
            Controls.Add(lblPaciente);
            Controls.Add(lblDoctor);
            Controls.Add(btnGuardar);
            Controls.Add(btnCancelar);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddAppointmentForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Nueva ficha médica";
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Label lblFecha;
        private DateTimePicker dtpFecha;
        private Label lblMotivo;
        private TextBox txtMotivo;
        private Label lblPrecio;
        private TextBox txtPrecio;
        private Label lblPaciente;
        private Label lblDoctor;
        private Button btnGuardar;
        private Button btnCancelar;
        private ComboBox cmbPaciente;
        private ComboBox cmbDoctor;
    }
}
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
            txtPacienteId = new TextBox();
            lblDoctor = new Label();
            txtDoctorId = new TextBox();
            btnGuardar = new Button();
            btnCancelar = new Button();

            SuspendLayout();
            // 
            // AddAppointmentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 246, 250);
            ClientSize = new Size(420, 520);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Nueva ficha médica";
            Font = new Font("Segoe UI", 10F);
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFecha.Location = new Point(50, 40);
            lblFecha.Text = "Fecha:";
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(150, 37);
            dtpFecha.Size = new Size(200, 25);
            dtpFecha.CalendarMonthBackground = Color.White;
            dtpFecha.CalendarForeColor = Color.Black;
            // 
            // lblMotivo
            // 
            lblMotivo.AutoSize = true;
            lblMotivo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblMotivo.Location = new Point(50, 100);
            lblMotivo.Text = "Motivo:";
            // 
            // txtMotivo
            // 
            txtMotivo.Location = new Point(150, 97);
            txtMotivo.Size = new Size(200, 60);
            txtMotivo.Multiline = true;
            txtMotivo.BorderStyle = BorderStyle.FixedSingle;
            txtMotivo.BackColor = Color.White;
            txtMotivo.ForeColor = Color.Black;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPrecio.Location = new Point(50, 180);
            lblPrecio.Text = "Precio:";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(150, 177);
            txtPrecio.Size = new Size(200, 25);
            txtPrecio.BorderStyle = BorderStyle.FixedSingle;
            txtPrecio.BackColor = Color.White;
            txtPrecio.ForeColor = Color.Black;
            txtPrecio.PlaceholderText = "Solo números";
            // 
            // lblPaciente
            // 
            lblPaciente.AutoSize = true;
            lblPaciente.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPaciente.Location = new Point(50, 240);
            lblPaciente.Text = "Paciente ID:";
            // 
            // txtPacienteId
            // 
            txtPacienteId.Location = new Point(150, 237);
            txtPacienteId.Size = new Size(200, 25);
            txtPacienteId.BorderStyle = BorderStyle.FixedSingle;
            txtPacienteId.BackColor = Color.White;
            txtPacienteId.ForeColor = Color.Black;
            // 
            // lblDoctor
            // 
            lblDoctor.AutoSize = true;
            lblDoctor.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDoctor.Location = new Point(50, 300);
            lblDoctor.Text = "Doctor ID:";
            // 
            // txtDoctorId
            // 
            txtDoctorId.Location = new Point(150, 297);
            txtDoctorId.Size = new Size(200, 25);
            txtDoctorId.BorderStyle = BorderStyle.FixedSingle;
            txtDoctorId.BackColor = Color.White;
            txtDoctorId.ForeColor = Color.Black;
            // 
            // btnGuardar
            // 
            btnGuardar.Text = "💾 Guardar";
            btnGuardar.Location = new Point(70, 400);
            btnGuardar.Size = new Size(120, 40);
            btnGuardar.BackColor = Color.FromArgb(46, 134, 222);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Text = "Cancelar ❌";
            btnCancelar.Location = new Point(220, 400);
            btnCancelar.Size = new Size(120, 40);
            btnCancelar.BackColor = Color.FromArgb(99, 110, 114);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.Click += btnCancelar_Click;

            // 
            // Controls
            // 
            Controls.AddRange(new Control[] {
            lblFecha, dtpFecha,
            lblMotivo, txtMotivo,
            lblPrecio, txtPrecio,
            lblPaciente, txtPacienteId,
            lblDoctor, txtDoctorId,
            btnGuardar, btnCancelar
        });

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
        private TextBox txtPacienteId;
        private Label lblDoctor;
        private TextBox txtDoctorId;
        private Button btnGuardar;
        private Button btnCancelar;
    }
}
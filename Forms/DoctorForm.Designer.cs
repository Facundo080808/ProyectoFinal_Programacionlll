namespace ProyectoFinal_Programacionlll.Forms
{
    partial class AddDoctorForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTitulo = new Label();
            lblFullName = new Label();
            txtFullName = new TextBox();
            lblSpecialty = new Label();
            txtSpecialty = new TextBox();
            lblDNI = new Label();
            txtDNI = new TextBox();
            btnGuardar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(30, 30, 30);
            lblTitulo.Location = new Point(90, 18);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(208, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Nuevo / Editar Doctor";
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFullName.Location = new Point(30, 80);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(65, 19);
            lblFullName.TabIndex = 1;
            lblFullName.Text = "Nombre";
            // 
            // txtFullName
            // 
            txtFullName.BackColor = Color.White;
            txtFullName.BorderStyle = BorderStyle.FixedSingle;
            txtFullName.ForeColor = Color.Black;
            txtFullName.Location = new Point(140, 77);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(230, 25);
            txtFullName.TabIndex = 2;
            txtFullName.KeyPress += txtFullName_KeyPress;
            // 
            // lblSpecialty
            // 
            lblSpecialty.AutoSize = true;
            lblSpecialty.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSpecialty.Location = new Point(30, 130);
            lblSpecialty.Name = "lblSpecialty";
            lblSpecialty.Size = new Size(92, 19);
            lblSpecialty.TabIndex = 3;
            lblSpecialty.Text = "Especialidad";
            // 
            // txtSpecialty
            // 
            txtSpecialty.BackColor = Color.White;
            txtSpecialty.BorderStyle = BorderStyle.FixedSingle;
            txtSpecialty.ForeColor = Color.Black;
            txtSpecialty.Location = new Point(140, 127);
            txtSpecialty.Name = "txtSpecialty";
            txtSpecialty.Size = new Size(230, 25);
            txtSpecialty.TabIndex = 4;
            txtSpecialty.KeyPress += txtSpecialty_KeyPress;
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDNI.Location = new Point(30, 180);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(34, 19);
            lblDNI.TabIndex = 5;
            lblDNI.Text = "DNI";
            // 
            // txtDNI
            // 
            txtDNI.BackColor = Color.White;
            txtDNI.BorderStyle = BorderStyle.FixedSingle;
            txtDNI.ForeColor = Color.Black;
            txtDNI.Location = new Point(140, 177);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(230, 25);
            txtDNI.TabIndex = 6;
            txtDNI.KeyPress += txtDNI_KeyPress;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(46, 134, 222);
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(70, 250);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(120, 40);
            btnGuardar.TabIndex = 7;
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
            btnCancelar.Location = new Point(230, 250);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(120, 40);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "✖ Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // AddDoctorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 246, 250);
            ClientSize = new Size(420, 360);
            Controls.Add(lblTitulo);
            Controls.Add(lblFullName);
            Controls.Add(txtFullName);
            Controls.Add(lblSpecialty);
            Controls.Add(txtSpecialty);
            Controls.Add(lblDNI);
            Controls.Add(txtDNI);
            Controls.Add(btnGuardar);
            Controls.Add(btnCancelar);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddDoctorForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Agregar / Editar Doctor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblSpecialty;
        private System.Windows.Forms.TextBox txtSpecialty;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
    }
}

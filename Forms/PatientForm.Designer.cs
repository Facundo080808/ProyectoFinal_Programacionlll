namespace ProyectoFinal_Programacionlll.UserControls
{
    partial class PatientForm
    {
        private TextBox txtFullName;
        private TextBox txtDNI;
        private TextBox txtPhone;
        private TextBox txtAddress;
        private Label lblFullName;
        private Label lblDNI;
        private Label lblPhone;
        private Label lblAddress;
        private Button btnGuardar;
        private Button btnCancelar;

        private void InitializeComponent()
        {
            txtFullName = new TextBox();
            txtDNI = new TextBox();
            txtPhone = new TextBox();
            txtAddress = new TextBox();
            lblFullName = new Label();
            lblDNI = new Label();
            lblPhone = new Label();
            lblAddress = new Label();
            btnGuardar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(150, 20);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(200, 23);
            txtFullName.TabIndex = 1;
            txtFullName.KeyPress += txtFullName_KeyPress;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(150, 60);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(200, 23);
            txtDNI.TabIndex = 3;
            txtDNI.KeyPress += txtDNI_TextChanged;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(150, 100);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(200, 23);
            txtPhone.TabIndex = 5;
            txtPhone.KeyPress += txtPhone_KeyPress;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(150, 140);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(200, 23);
            txtAddress.TabIndex = 7;
            // 
            // lblFullName
            // 
            lblFullName.Location = new Point(20, 20);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(100, 23);
            lblFullName.TabIndex = 0;
            lblFullName.Text = "Nombre Completo:";
            // 
            // lblDNI
            // 
            lblDNI.Location = new Point(20, 60);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(100, 23);
            lblDNI.TabIndex = 2;
            lblDNI.Text = "DNI:";
            // 
            // lblPhone
            // 
            lblPhone.Location = new Point(20, 100);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(100, 23);
            lblPhone.TabIndex = 4;
            lblPhone.Text = "Teléfono:";
            // 
            // lblAddress
            // 
            lblAddress.Location = new Point(20, 140);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(100, 23);
            lblAddress.TabIndex = 6;
            lblAddress.Text = "Dirección:";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(80, 200);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(200, 200);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.Click += btnCancelar_Click;
            // 
            // PatientForm
            // 
            ClientSize = new Size(400, 260);
            Controls.Add(lblFullName);
            Controls.Add(txtFullName);
            Controls.Add(lblDNI);
            Controls.Add(txtDNI);
            Controls.Add(lblPhone);
            Controls.Add(txtPhone);
            Controls.Add(lblAddress);
            Controls.Add(txtAddress);
            Controls.Add(btnGuardar);
            Controls.Add(btnCancelar);
            Name = "PatientForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Paciente";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}

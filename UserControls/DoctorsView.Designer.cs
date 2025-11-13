using ProyectoFinal_Programacionlll.Helpers;

namespace ProyectoFinal_Programacionlll.UserControls
{
    partial class DoctorsView
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dgvDoctors;
        private Button btnAddDoctor;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dgvDoctors = new DataGridView();
            btnAddDoctor = new Button();
            btnAddDoctor.Text = "➕ Nuevo doctor";
            ButtonsStyles.ApplyCreateStyle(btnAddDoctor);
            SuspendLayout();
            // 
            // dgvDoctors
            // 
            dgvDoctors.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDoctors.Location = new Point(20, 70);
            dgvDoctors.Name = "dgvDoctors";
            dgvDoctors.Size = new Size(760, 360);
            dgvDoctors.TabIndex = 0;
            dgvDoctors.ReadOnly = true;
            dgvDoctors.AllowUserToAddRows = false;
            dgvDoctors.AllowUserToDeleteRows = false;
            // 
            // btnAddDoctor
            // 
            btnAddDoctor.Location = new Point(20, 20);
            btnAddDoctor.Name = "btnAddDoctor";
            btnAddDoctor.Size = new Size(140, 35);
            btnAddDoctor.Text = "➕ Nuevo doctor";
            btnAddDoctor.UseVisualStyleBackColor = true;
            btnAddDoctor.Click += BtnAddDoctor_Click;
            // 
            // DoctorsView
            // 
            Controls.Add(dgvDoctors);
            Controls.Add(btnAddDoctor);
            Name = "DoctorsView";
            Size = new Size(800, 450);
            ResumeLayout(false);
        }

        private void BtnAddDoctor_Click(object sender, EventArgs e)
        {
            var form = new Forms.AddDoctorForm();
            if (form.ShowDialog() == DialogResult.OK)
                LoadDoctors();
        }
    }
}

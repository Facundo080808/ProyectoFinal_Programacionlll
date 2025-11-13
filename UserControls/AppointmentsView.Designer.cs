namespace ProyectoFinal_Programacionlll.UserControls
{
    partial class AppointmentsView
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dgvAppointments;
        private Button btnCreateAppointment;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dgvAppointments = new DataGridView();
            btnCreateAppointment = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).BeginInit();
            SuspendLayout();

            // 
            // dgvAppointments
            // 
            dgvAppointments.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvAppointments.Location = new Point(20, 70);
            dgvAppointments.Name = "dgvAppointments";
            dgvAppointments.Size = new Size(760, 360);
            dgvAppointments.TabIndex = 0;
            dgvAppointments.ReadOnly = true;
            dgvAppointments.AllowUserToAddRows = false;
            dgvAppointments.AllowUserToDeleteRows = false;

            // 
            // btnCreateAppointment
            // 
            btnCreateAppointment.Location = new Point(20, 20);
            btnCreateAppointment.Name = "btnCreateAppointment";
            btnCreateAppointment.Size = new Size(140, 35);
            btnCreateAppointment.TabIndex = 1;
            btnCreateAppointment.Text = "➕ Nueva ficha";
            btnCreateAppointment.UseVisualStyleBackColor = true;

            // 
            // AppointmentsView
            // 
            Controls.Add(dgvAppointments);
            Controls.Add(btnCreateAppointment);
            Name = "AppointmentsView";
            Size = new Size(800, 450);
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).EndInit();
            ResumeLayout(false);
        }
    }
}

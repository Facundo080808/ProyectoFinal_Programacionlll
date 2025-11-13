namespace ProyectoFinal_Programacionlll.UserControls
{
    partial class PatientsView
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridView1;
        private Button btnAgregar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            btnAgregar = new Button();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(20, 70);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(640, 350);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(20, 20);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(150, 30);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "➕ Nuevo Paciente";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // PatientsView
            // 
            Controls.Add(dataGridView1);
            Controls.Add(btnAgregar);
            Name = "PatientsView";
            Size = new Size(680, 450);
            ResumeLayout(false);
        }
    }
}

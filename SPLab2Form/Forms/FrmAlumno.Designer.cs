namespace PPLab2Form.Forms
{
    partial class FrmAlumno
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
            this.lbl_bienvenida = new System.Windows.Forms.Label();
            this.btn_materiasCursadas = new System.Windows.Forms.Button();
            this.btn_inscribirseAMaterias = new System.Windows.Forms.Button();
            this.dtgv_datos = new System.Windows.Forms.DataGridView();
            this.btn_inscribirse = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.msi_materiasCursadas = new System.Windows.Forms.ToolStripMenuItem();
            this.msi_inscribirseAMaterias = new System.Windows.Forms.ToolStripMenuItem();
            this.msi_cerrarSesion = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_datos)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_bienvenida
            // 
            this.lbl_bienvenida.AutoSize = true;
            this.lbl_bienvenida.Font = new System.Drawing.Font("Segoe UI", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_bienvenida.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_bienvenida.Location = new System.Drawing.Point(23, 31);
            this.lbl_bienvenida.Name = "lbl_bienvenida";
            this.lbl_bienvenida.Size = new System.Drawing.Size(319, 45);
            this.lbl_bienvenida.TabIndex = 0;
            this.lbl_bienvenida.Text = "Bienvenido alumno";
            this.lbl_bienvenida.Click += new System.EventHandler(this.alumno_lbl_inicio_Click);
            // 
            // btn_materiasCursadas
            // 
            this.btn_materiasCursadas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_materiasCursadas.Location = new System.Drawing.Point(23, 97);
            this.btn_materiasCursadas.Name = "btn_materiasCursadas";
            this.btn_materiasCursadas.Size = new System.Drawing.Size(150, 39);
            this.btn_materiasCursadas.TabIndex = 1;
            this.btn_materiasCursadas.Text = "Materias cursadas";
            this.btn_materiasCursadas.UseVisualStyleBackColor = true;
            this.btn_materiasCursadas.Click += new System.EventHandler(this.btn_materiasCursadas_Click);
            // 
            // btn_inscribirseAMaterias
            // 
            this.btn_inscribirseAMaterias.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_inscribirseAMaterias.Location = new System.Drawing.Point(211, 97);
            this.btn_inscribirseAMaterias.Name = "btn_inscribirseAMaterias";
            this.btn_inscribirseAMaterias.Size = new System.Drawing.Size(150, 39);
            this.btn_inscribirseAMaterias.TabIndex = 3;
            this.btn_inscribirseAMaterias.Text = "Inscribirse a materias";
            this.btn_inscribirseAMaterias.UseVisualStyleBackColor = true;
            this.btn_inscribirseAMaterias.Click += new System.EventHandler(this.btn_inscribirseAMaterias_Click);
            // 
            // dtgv_datos
            // 
            this.dtgv_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_datos.Location = new System.Drawing.Point(23, 162);
            this.dtgv_datos.Name = "dtgv_datos";
            this.dtgv_datos.RowTemplate.Height = 25;
            this.dtgv_datos.Size = new System.Drawing.Size(791, 242);
            this.dtgv_datos.TabIndex = 4;
            // 
            // btn_inscribirse
            // 
            this.btn_inscribirse.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_inscribirse.Location = new System.Drawing.Point(731, 97);
            this.btn_inscribirse.Name = "btn_inscribirse";
            this.btn_inscribirse.Size = new System.Drawing.Size(83, 39);
            this.btn_inscribirse.TabIndex = 5;
            this.btn_inscribirse.Text = "Inscribirse";
            this.btn_inscribirse.UseVisualStyleBackColor = true;
            this.btn_inscribirse.Click += new System.EventHandler(this.btn_inscribirse_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msi_materiasCursadas,
            this.msi_inscribirseAMaterias,
            this.msi_cerrarSesion});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(843, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // msi_materiasCursadas
            // 
            this.msi_materiasCursadas.Name = "msi_materiasCursadas";
            this.msi_materiasCursadas.Size = new System.Drawing.Size(113, 20);
            this.msi_materiasCursadas.Text = "Materias cursadas";
            this.msi_materiasCursadas.Click += new System.EventHandler(this.msi_materiasCursadas_Click);
            // 
            // msi_inscribirseAMaterias
            // 
            this.msi_inscribirseAMaterias.Name = "msi_inscribirseAMaterias";
            this.msi_inscribirseAMaterias.Size = new System.Drawing.Size(129, 20);
            this.msi_inscribirseAMaterias.Text = "Inscribirse a materias";
            this.msi_inscribirseAMaterias.Click += new System.EventHandler(this.msi_inscribirseAMaterias_Click);
            // 
            // msi_cerrarSesion
            // 
            this.msi_cerrarSesion.Name = "msi_cerrarSesion";
            this.msi_cerrarSesion.Size = new System.Drawing.Size(87, 20);
            this.msi_cerrarSesion.Text = "Cerrar sesión";
            this.msi_cerrarSesion.Click += new System.EventHandler(this.msi_cerrarSesion_Click);
            // 
            // FrmAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 450);
            this.Controls.Add(this.btn_inscribirse);
            this.Controls.Add(this.dtgv_datos);
            this.Controls.Add(this.btn_inscribirseAMaterias);
            this.Controls.Add(this.btn_materiasCursadas);
            this.Controls.Add(this.lbl_bienvenida);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmAlumno";
            this.Text = "Alumno";
            this.Load += new System.EventHandler(this.FormAlumno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_datos)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_bienvenida;
        private Button btn_materiasCursadas;
        private Button btn_inscribirseAMaterias;
        private DataGridView dtgv_datos;
        private Button btn_inscribirse;
        private ContextMenuStrip ms_menu;
        private ContextMenuStrip contextMenuStrip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem msi_materiasCursadas;
        private ToolStripMenuItem msi_inscribirseAMaterias;
        private ToolStripMenuItem msi_cerrarSesion;
    }
}
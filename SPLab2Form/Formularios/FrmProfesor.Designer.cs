namespace PPLab2Form.Forms
{
    partial class FrmProfesor
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
            this.dtgv_materias = new System.Windows.Forms.DataGridView();
            this.lbl_materias = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignarNotasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearExamenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msi_cerrarSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_asignarNotas = new System.Windows.Forms.Button();
            this.btn_crearExamen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_materias)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgv_materias
            // 
            this.dtgv_materias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_materias.Location = new System.Drawing.Point(26, 101);
            this.dtgv_materias.Name = "dtgv_materias";
            this.dtgv_materias.RowTemplate.Height = 25;
            this.dtgv_materias.Size = new System.Drawing.Size(746, 236);
            this.dtgv_materias.TabIndex = 0;
            // 
            // lbl_materias
            // 
            this.lbl_materias.AutoSize = true;
            this.lbl_materias.Font = new System.Drawing.Font("Segoe UI", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lbl_materias.Location = new System.Drawing.Point(26, 61);
            this.lbl_materias.Name = "lbl_materias";
            this.lbl_materias.Size = new System.Drawing.Size(219, 30);
            this.lbl_materias.TabIndex = 1;
            this.lbl_materias.Text = "Materias asignadas:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.msi_cerrarSesion});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asignarNotasToolStripMenuItem,
            this.crearExamenToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // asignarNotasToolStripMenuItem
            // 
            this.asignarNotasToolStripMenuItem.Name = "asignarNotasToolStripMenuItem";
            this.asignarNotasToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.asignarNotasToolStripMenuItem.Text = "Asignar notas";
            // 
            // crearExamenToolStripMenuItem
            // 
            this.crearExamenToolStripMenuItem.Name = "crearExamenToolStripMenuItem";
            this.crearExamenToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.crearExamenToolStripMenuItem.Text = "Crear Examen";
            // 
            // msi_cerrarSesion
            // 
            this.msi_cerrarSesion.Name = "msi_cerrarSesion";
            this.msi_cerrarSesion.Size = new System.Drawing.Size(87, 20);
            this.msi_cerrarSesion.Text = "Cerrar sesión";
            this.msi_cerrarSesion.Click += new System.EventHandler(this.msi_cerrarSesion_Click);
            // 
            // btn_asignarNotas
            // 
            this.btn_asignarNotas.Location = new System.Drawing.Point(545, 68);
            this.btn_asignarNotas.Name = "btn_asignarNotas";
            this.btn_asignarNotas.Size = new System.Drawing.Size(97, 23);
            this.btn_asignarNotas.TabIndex = 3;
            this.btn_asignarNotas.Text = "Asignar notas";
            this.btn_asignarNotas.UseVisualStyleBackColor = true;
            this.btn_asignarNotas.Click += new System.EventHandler(this.btn_asignarNotas_Click);
            // 
            // btn_crearExamen
            // 
            this.btn_crearExamen.Location = new System.Drawing.Point(675, 68);
            this.btn_crearExamen.Name = "btn_crearExamen";
            this.btn_crearExamen.Size = new System.Drawing.Size(97, 23);
            this.btn_crearExamen.TabIndex = 4;
            this.btn_crearExamen.Text = "Crear Examen";
            this.btn_crearExamen.UseVisualStyleBackColor = true;
            this.btn_crearExamen.Click += new System.EventHandler(this.btn_crearExamen_Click);
            // 
            // FrmProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_crearExamen);
            this.Controls.Add(this.btn_asignarNotas);
            this.Controls.Add(this.lbl_materias);
            this.Controls.Add(this.dtgv_materias);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmProfesor";
            this.Text = "Profesor";
            this.Load += new System.EventHandler(this.FrmProfesor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_materias)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dtgv_materias;
        private Label lbl_materias;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem asignarNotasToolStripMenuItem;
        private ToolStripMenuItem crearExamenToolStripMenuItem;
        private Button btn_asignarNotas;
        private Button btn_crearExamen;
        private ToolStripMenuItem msi_cerrarSesion;
    }
}
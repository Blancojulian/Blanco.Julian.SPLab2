namespace PPLab2Form.Forms
{
    partial class FrmAdmin
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
            this.components = new System.ComponentModel.Container();
            this.dtgv_materias = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msi_cambiarEstado = new System.Windows.Forms.ToolStripMenuItem();
            this.msi_asignarProfesorAMateria = new System.Windows.Forms.ToolStripMenuItem();
            this.msi_crear = new System.Windows.Forms.ToolStripMenuItem();
            this.msi_crearUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.msi_crearMateria = new System.Windows.Forms.ToolStripMenuItem();
            this.estadisticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msi_calcularCantidadDeAlumnos = new System.Windows.Forms.ToolStripMenuItem();
            this.msi_calcularLaNotaPromedio = new System.Windows.Forms.ToolStripMenuItem();
            this.msi_asignarAlumno = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_materias = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_materias)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgv_materias
            // 
            this.dtgv_materias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_materias.Location = new System.Drawing.Point(52, 99);
            this.dtgv_materias.Name = "dtgv_materias";
            this.dtgv_materias.RowTemplate.Height = 25;
            this.dtgv_materias.Size = new System.Drawing.Size(770, 236);
            this.dtgv_materias.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.cerrarSesiónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(869, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msi_cambiarEstado,
            this.msi_asignarProfesorAMateria,
            this.msi_crear,
            this.estadisticasToolStripMenuItem,
            this.msi_asignarAlumno});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // msi_cambiarEstado
            // 
            this.msi_cambiarEstado.Name = "msi_cambiarEstado";
            this.msi_cambiarEstado.Size = new System.Drawing.Size(213, 22);
            this.msi_cambiarEstado.Text = "Cambiar estado alumnos";
            this.msi_cambiarEstado.Click += new System.EventHandler(this.msi_cambiarEstado_Click);
            // 
            // msi_asignarProfesorAMateria
            // 
            this.msi_asignarProfesorAMateria.Name = "msi_asignarProfesorAMateria";
            this.msi_asignarProfesorAMateria.Size = new System.Drawing.Size(213, 22);
            this.msi_asignarProfesorAMateria.Text = "Asignar profesor a materia";
            this.msi_asignarProfesorAMateria.Click += new System.EventHandler(this.msi_asignarProfesorAMateria_Click);
            // 
            // msi_crear
            // 
            this.msi_crear.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msi_crearUsuario,
            this.msi_crearMateria});
            this.msi_crear.Name = "msi_crear";
            this.msi_crear.Size = new System.Drawing.Size(213, 22);
            this.msi_crear.Text = "Crear";
            // 
            // msi_crearUsuario
            // 
            this.msi_crearUsuario.Name = "msi_crearUsuario";
            this.msi_crearUsuario.Size = new System.Drawing.Size(145, 22);
            this.msi_crearUsuario.Text = "Crear Usuario";
            this.msi_crearUsuario.Click += new System.EventHandler(this.msi_crearUsuario_Click);
            // 
            // msi_crearMateria
            // 
            this.msi_crearMateria.Name = "msi_crearMateria";
            this.msi_crearMateria.Size = new System.Drawing.Size(145, 22);
            this.msi_crearMateria.Text = "Crear Materia";
            this.msi_crearMateria.Click += new System.EventHandler(this.msi_crearMateria_Click);
            // 
            // estadisticasToolStripMenuItem
            // 
            this.estadisticasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msi_calcularCantidadDeAlumnos,
            this.msi_calcularLaNotaPromedio});
            this.estadisticasToolStripMenuItem.Name = "estadisticasToolStripMenuItem";
            this.estadisticasToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.estadisticasToolStripMenuItem.Text = "Estadisticas";
            // 
            // msi_calcularCantidadDeAlumnos
            // 
            this.msi_calcularCantidadDeAlumnos.Name = "msi_calcularCantidadDeAlumnos";
            this.msi_calcularCantidadDeAlumnos.Size = new System.Drawing.Size(299, 22);
            this.msi_calcularCantidadDeAlumnos.Text = "Calcular cantidad de alumnos por profesor";
            //this.msi_calcularCantidadDeAlumnos.Click += new System.EventHandler(this.msi_calcularCantidadDeAlumnos_Click);
            // 
            // msi_calcularLaNotaPromedio
            // 
            this.msi_calcularLaNotaPromedio.Name = "msi_calcularLaNotaPromedio";
            this.msi_calcularLaNotaPromedio.Size = new System.Drawing.Size(299, 22);
            this.msi_calcularLaNotaPromedio.Text = "Calcular la nota promedio de cada alumno";
            this.msi_calcularLaNotaPromedio.Click += new System.EventHandler(this.msi_calcularLaNotaPromedio_Click);
            // 
            // msi_asignarAlumno
            // 
            this.msi_asignarAlumno.Name = "msi_asignarAlumno";
            this.msi_asignarAlumno.Size = new System.Drawing.Size(213, 22);
            this.msi_asignarAlumno.Text = "Asignar alumno a materia";
            this.msi_asignarAlumno.Click += new System.EventHandler(this.msi_asignarAlumno_Click);
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar sesión";
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
            // 
            // lbl_materias
            // 
            this.lbl_materias.AutoSize = true;
            this.lbl_materias.Font = new System.Drawing.Font("Segoe UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lbl_materias.Location = new System.Drawing.Point(52, 50);
            this.lbl_materias.Name = "lbl_materias";
            this.lbl_materias.Size = new System.Drawing.Size(197, 37);
            this.lbl_materias.TabIndex = 2;
            this.lbl_materias.Text = "Lista Materias";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 450);
            this.Controls.Add(this.lbl_materias);
            this.Controls.Add(this.dtgv_materias);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmAdmin";
            this.Text = "Administrador";
            this.Load += new System.EventHandler(this.FrmAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_materias)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dtgv_materias;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private Label lbl_materias;
        private ToolStripMenuItem msi_cambiarEstado;
        private ToolStripMenuItem msi_asignarProfesorAMateria;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem msi_crear;
        private ToolStripMenuItem msi_crearUsuario;
        private ToolStripMenuItem msi_crearMateria;
        private ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private ToolStripMenuItem estadisticasToolStripMenuItem;
        private ToolStripMenuItem msi_calcularCantidadDeAlumnos;
        private ToolStripMenuItem msi_calcularLaNotaPromedio;
        private ToolStripMenuItem msi_asignarAlumno;
    }
}
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
            this.msi_asignarAlumno = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_materias = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.serializaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msi_exportarAJson = new System.Windows.Forms.ToolStripMenuItem();
            this.msi_importarAJson = new System.Windows.Forms.ToolStripMenuItem();
            this.tbx_nombreArchivo = new System.Windows.Forms.TextBox();
            this.lbl_nombreArchivo = new System.Windows.Forms.Label();
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
            this.msi_asignarAlumno,
            this.serializaciónToolStripMenuItem});
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
            // serializaciónToolStripMenuItem
            // 
            this.serializaciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msi_exportarAJson,
            this.msi_importarAJson});
            this.serializaciónToolStripMenuItem.Name = "serializaciónToolStripMenuItem";
            this.serializaciónToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.serializaciónToolStripMenuItem.Text = "Serialización";
            // 
            // msi_exportarAJson
            // 
            this.msi_exportarAJson.Name = "msi_exportarAJson";
            this.msi_exportarAJson.Size = new System.Drawing.Size(155, 22);
            this.msi_exportarAJson.Text = "Exportar a Json";
            this.msi_exportarAJson.Click += new System.EventHandler(this.msi_exportarAJson_Click);
            // 
            // msi_importarAJson
            // 
            this.msi_importarAJson.Name = "msi_importarAJson";
            this.msi_importarAJson.Size = new System.Drawing.Size(155, 22);
            this.msi_importarAJson.Text = "Importar a Json";
            this.msi_importarAJson.Click += new System.EventHandler(this.msi_importarAJson_Click);
            // 
            // tbx_nombreArchivo
            // 
            this.tbx_nombreArchivo.Location = new System.Drawing.Point(685, 37);
            this.tbx_nombreArchivo.Name = "tbx_nombreArchivo";
            this.tbx_nombreArchivo.Size = new System.Drawing.Size(137, 23);
            this.tbx_nombreArchivo.TabIndex = 3;
            // 
            // lbl_nombreArchivo
            // 
            this.lbl_nombreArchivo.AutoSize = true;
            this.lbl_nombreArchivo.Location = new System.Drawing.Point(589, 40);
            this.lbl_nombreArchivo.Name = "lbl_nombreArchivo";
            this.lbl_nombreArchivo.Size = new System.Drawing.Size(93, 15);
            this.lbl_nombreArchivo.TabIndex = 4;
            this.lbl_nombreArchivo.Text = "Nombre archivo";
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 450);
            this.Controls.Add(this.lbl_nombreArchivo);
            this.Controls.Add(this.tbx_nombreArchivo);
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
        private ToolStripMenuItem msi_asignarAlumno;
        private ToolStripMenuItem serializaciónToolStripMenuItem;
        private ToolStripMenuItem msi_exportarAJson;
        private ToolStripMenuItem msi_importarAJson;
        private TextBox tbx_nombreArchivo;
        private Label lbl_nombreArchivo;
    }
}
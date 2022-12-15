namespace PPLab2Form.Forms
{
    partial class FrmAsignarNota
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
            this.dtgv_alumnos = new System.Windows.Forms.DataGridView();
            this.btn_asignarNota = new System.Windows.Forms.Button();
            this.lbl_nota = new System.Windows.Forms.Label();
            this.tbx_nota = new System.Windows.Forms.TextBox();
            this.lbl_materia = new System.Windows.Forms.Label();
            this.btn_volver = new System.Windows.Forms.Button();
            this.cbx_examen = new System.Windows.Forms.ComboBox();
            this.lbl_examen = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_alumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgv_alumnos
            // 
            this.dtgv_alumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_alumnos.Location = new System.Drawing.Point(33, 77);
            this.dtgv_alumnos.Name = "dtgv_alumnos";
            this.dtgv_alumnos.RowTemplate.Height = 25;
            this.dtgv_alumnos.Size = new System.Drawing.Size(565, 231);
            this.dtgv_alumnos.TabIndex = 0;
            // 
            // btn_asignarNota
            // 
            this.btn_asignarNota.Location = new System.Drawing.Point(652, 229);
            this.btn_asignarNota.Name = "btn_asignarNota";
            this.btn_asignarNota.Size = new System.Drawing.Size(102, 23);
            this.btn_asignarNota.TabIndex = 1;
            this.btn_asignarNota.Text = "Asignar nota";
            this.btn_asignarNota.UseVisualStyleBackColor = true;
            this.btn_asignarNota.Click += new System.EventHandler(this.btn_asignarNota_Click);
            // 
            // lbl_nota
            // 
            this.lbl_nota.AutoSize = true;
            this.lbl_nota.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_nota.Location = new System.Drawing.Point(651, 142);
            this.lbl_nota.Name = "lbl_nota";
            this.lbl_nota.Size = new System.Drawing.Size(120, 28);
            this.lbl_nota.TabIndex = 2;
            this.lbl_nota.Text = "Ingrese nota";
            // 
            // tbx_nota
            // 
            this.tbx_nota.Location = new System.Drawing.Point(651, 173);
            this.tbx_nota.Name = "tbx_nota";
            this.tbx_nota.Size = new System.Drawing.Size(100, 23);
            this.tbx_nota.TabIndex = 3;
            this.tbx_nota.TextChanged += new System.EventHandler(this.tbx_nota_TextChanged);
            // 
            // lbl_materia
            // 
            this.lbl_materia.AutoSize = true;
            this.lbl_materia.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_materia.Location = new System.Drawing.Point(33, 27);
            this.lbl_materia.Name = "lbl_materia";
            this.lbl_materia.Size = new System.Drawing.Size(79, 28);
            this.lbl_materia.TabIndex = 4;
            this.lbl_materia.Text = "Materia";
            // 
            // btn_volver
            // 
            this.btn_volver.Location = new System.Drawing.Point(652, 270);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(100, 23);
            this.btn_volver.TabIndex = 5;
            this.btn_volver.Text = "Volver";
            this.btn_volver.UseVisualStyleBackColor = true;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // cbx_examen
            // 
            this.cbx_examen.FormattingEnabled = true;
            this.cbx_examen.Location = new System.Drawing.Point(652, 116);
            this.cbx_examen.Name = "cbx_examen";
            this.cbx_examen.Size = new System.Drawing.Size(102, 23);
            this.cbx_examen.TabIndex = 6;
            // 
            // lbl_examen
            // 
            this.lbl_examen.AutoSize = true;
            this.lbl_examen.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_examen.Location = new System.Drawing.Point(651, 77);
            this.lbl_examen.Name = "lbl_examen";
            this.lbl_examen.Size = new System.Drawing.Size(147, 28);
            this.lbl_examen.TabIndex = 7;
            this.lbl_examen.Text = "Ingrese examen";
            // 
            // FrmAsignarNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_examen);
            this.Controls.Add(this.cbx_examen);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.lbl_materia);
            this.Controls.Add(this.tbx_nota);
            this.Controls.Add(this.lbl_nota);
            this.Controls.Add(this.btn_asignarNota);
            this.Controls.Add(this.dtgv_alumnos);
            this.Name = "FrmAsignarNota";
            this.Text = "Asignar nota a alumnos";
            this.Load += new System.EventHandler(this.FrmAsignarNota_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_alumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dtgv_alumnos;
        private Button btn_asignarNota;
        private Label lbl_nota;
        private TextBox tbx_nota;
        private Label lbl_materia;
        private Button btn_volver;
        private ComboBox cbx_examen;
        private Label lbl_examen;
    }
}
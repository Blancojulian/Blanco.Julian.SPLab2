namespace PPLab2Form.Forms
{
    partial class FrmEstadoAlumno
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
            this.lbl_materia = new System.Windows.Forms.Label();
            this.cbx_estado = new System.Windows.Forms.ComboBox();
            this.btn_confimar = new System.Windows.Forms.Button();
            this.btn_volver = new System.Windows.Forms.Button();
            this.dtgv_alumnos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_alumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_materia
            // 
            this.lbl_materia.AutoSize = true;
            this.lbl_materia.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_materia.Location = new System.Drawing.Point(36, 32);
            this.lbl_materia.Name = "lbl_materia";
            this.lbl_materia.Size = new System.Drawing.Size(118, 37);
            this.lbl_materia.TabIndex = 0;
            this.lbl_materia.Text = "Materia";
            // 
            // cbx_estado
            // 
            this.cbx_estado.FormattingEnabled = true;
            this.cbx_estado.Location = new System.Drawing.Point(547, 81);
            this.cbx_estado.Name = "cbx_estado";
            this.cbx_estado.Size = new System.Drawing.Size(99, 23);
            this.cbx_estado.TabIndex = 1;
            // 
            // btn_confimar
            // 
            this.btn_confimar.Location = new System.Drawing.Point(547, 149);
            this.btn_confimar.Name = "btn_confimar";
            this.btn_confimar.Size = new System.Drawing.Size(99, 30);
            this.btn_confimar.TabIndex = 2;
            this.btn_confimar.Text = "Confirmar";
            this.btn_confimar.UseVisualStyleBackColor = true;
            this.btn_confimar.Click += new System.EventHandler(this.btn_confimar_Click);
            // 
            // btn_volver
            // 
            this.btn_volver.Location = new System.Drawing.Point(547, 230);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(99, 30);
            this.btn_volver.TabIndex = 3;
            this.btn_volver.Text = "Volver";
            this.btn_volver.UseVisualStyleBackColor = true;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // dtgv_alumnos
            // 
            this.dtgv_alumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_alumnos.Location = new System.Drawing.Point(36, 81);
            this.dtgv_alumnos.Name = "dtgv_alumnos";
            this.dtgv_alumnos.RowTemplate.Height = 25;
            this.dtgv_alumnos.Size = new System.Drawing.Size(470, 255);
            this.dtgv_alumnos.TabIndex = 4;
            this.dtgv_alumnos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_alumnos_CellClick);
            // 
            // FrmEstadoAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 450);
            this.Controls.Add(this.dtgv_alumnos);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.btn_confimar);
            this.Controls.Add(this.cbx_estado);
            this.Controls.Add(this.lbl_materia);
            this.Name = "FrmEstadoAlumno";
            this.Text = "Cambiar estado de alumno";
            this.Load += new System.EventHandler(this.FrmEstadoAlumno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_alumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_materia;
        private ComboBox cbx_estado;
        private Button btn_confimar;
        private Button btn_volver;
        private DataGridView dtgv_alumnos;
    }
}
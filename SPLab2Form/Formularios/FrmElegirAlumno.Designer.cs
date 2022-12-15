namespace PPLab2Form.Forms
{
    partial class FrmElegirAlumno
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
            this.dtgv_profesores = new System.Windows.Forms.DataGridView();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_asignar = new System.Windows.Forms.Button();
            this.lbl_materia = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_profesores)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgv_profesores
            // 
            this.dtgv_profesores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_profesores.Location = new System.Drawing.Point(23, 53);
            this.dtgv_profesores.Name = "dtgv_profesores";
            this.dtgv_profesores.RowTemplate.Height = 25;
            this.dtgv_profesores.Size = new System.Drawing.Size(625, 222);
            this.dtgv_profesores.TabIndex = 0;
            this.dtgv_profesores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_cancelar.Location = new System.Drawing.Point(671, 153);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(117, 54);
            this.btn_cancelar.TabIndex = 5;
            this.btn_cancelar.Text = "Volver";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_asignar
            // 
            this.btn_asignar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_asignar.Location = new System.Drawing.Point(671, 53);
            this.btn_asignar.Name = "btn_asignar";
            this.btn_asignar.Size = new System.Drawing.Size(117, 54);
            this.btn_asignar.TabIndex = 4;
            this.btn_asignar.Text = "Asignar alumno";
            this.btn_asignar.UseVisualStyleBackColor = true;
            // 
            // lbl_materia
            // 
            this.lbl_materia.AutoSize = true;
            this.lbl_materia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_materia.Location = new System.Drawing.Point(56, 13);
            this.lbl_materia.Name = "lbl_materia";
            this.lbl_materia.Size = new System.Drawing.Size(52, 21);
            this.lbl_materia.TabIndex = 6;
            this.lbl_materia.Text = "label1";
            // 
            // FrmElegirAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_materia);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_asignar);
            this.Controls.Add(this.dtgv_profesores);
            this.Name = "FrmElegirAlumno";
            this.Text = "FrmElegirAlumno";
            this.Load += new System.EventHandler(this.FrmElegirAlumno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_profesores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dtgv_profesores;
        private Button btn_cancelar;
        private Button btn_asignar;
        private Label lbl_materia;
    }
}
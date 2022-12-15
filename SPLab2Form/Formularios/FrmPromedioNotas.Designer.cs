namespace PPLab2Form.Forms
{
    partial class FrmPromedioNotas
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
            this.dtgv_promedios = new System.Windows.Forms.DataGridView();
            this.btn_volver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_promedios)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgv_promedios
            // 
            this.dtgv_promedios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_promedios.Location = new System.Drawing.Point(67, 73);
            this.dtgv_promedios.Name = "dtgv_promedios";
            this.dtgv_promedios.RowTemplate.Height = 25;
            this.dtgv_promedios.Size = new System.Drawing.Size(656, 260);
            this.dtgv_promedios.TabIndex = 0;
            // 
            // btn_volver
            // 
            this.btn_volver.Location = new System.Drawing.Point(579, 18);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(136, 27);
            this.btn_volver.TabIndex = 1;
            this.btn_volver.Text = "Volver";
            this.btn_volver.UseVisualStyleBackColor = true;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // FrmPromedioNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.dtgv_promedios);
            this.Name = "FrmPromedioNotas";
            this.Text = "Promedio notas alumnos por materia";
            this.Load += new System.EventHandler(this.FrmPromedioNotas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_promedios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dtgv_promedios;
        private Button btn_volver;
    }
}
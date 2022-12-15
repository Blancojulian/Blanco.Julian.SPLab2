namespace PPLab2Form.Forms
{
    partial class FrmCrearMateria
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
            this.lbl_materiaCorrelativa = new System.Windows.Forms.Label();
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.tbx_codigo = new System.Windows.Forms.TextBox();
            this.lbl_cuatrimestre = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.tbx_nombre = new System.Windows.Forms.TextBox();
            this.cbx_materiaCorrelativa = new System.Windows.Forms.ComboBox();
            this.chbx_materiaCorrelativa = new System.Windows.Forms.CheckBox();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.cbx_cuatrimestre = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbl_materiaCorrelativa
            // 
            this.lbl_materiaCorrelativa.AutoSize = true;
            this.lbl_materiaCorrelativa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_materiaCorrelativa.Location = new System.Drawing.Point(265, 185);
            this.lbl_materiaCorrelativa.Name = "lbl_materiaCorrelativa";
            this.lbl_materiaCorrelativa.Size = new System.Drawing.Size(140, 21);
            this.lbl_materiaCorrelativa.TabIndex = 21;
            this.lbl_materiaCorrelativa.Text = "Materia correlativa";
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_codigo.Location = new System.Drawing.Point(265, 70);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(60, 21);
            this.lbl_codigo.TabIndex = 18;
            this.lbl_codigo.Text = "Codigo";
            // 
            // tbx_codigo
            // 
            this.tbx_codigo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbx_codigo.Location = new System.Drawing.Point(265, 94);
            this.tbx_codigo.Name = "tbx_codigo";
            this.tbx_codigo.Size = new System.Drawing.Size(121, 25);
            this.tbx_codigo.TabIndex = 17;
            // 
            // lbl_cuatrimestre
            // 
            this.lbl_cuatrimestre.AutoSize = true;
            this.lbl_cuatrimestre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_cuatrimestre.Location = new System.Drawing.Point(447, 70);
            this.lbl_cuatrimestre.Name = "lbl_cuatrimestre";
            this.lbl_cuatrimestre.Size = new System.Drawing.Size(100, 21);
            this.lbl_cuatrimestre.TabIndex = 16;
            this.lbl_cuatrimestre.Text = "Cuatrimestre";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_nombre.Location = new System.Drawing.Point(75, 70);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(68, 21);
            this.lbl_nombre.TabIndex = 14;
            this.lbl_nombre.Text = "Nombre";
            // 
            // tbx_nombre
            // 
            this.tbx_nombre.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbx_nombre.Location = new System.Drawing.Point(75, 94);
            this.tbx_nombre.Name = "tbx_nombre";
            this.tbx_nombre.Size = new System.Drawing.Size(121, 25);
            this.tbx_nombre.TabIndex = 13;
            // 
            // cbx_materiaCorrelativa
            // 
            this.cbx_materiaCorrelativa.FormattingEnabled = true;
            this.cbx_materiaCorrelativa.Location = new System.Drawing.Point(265, 209);
            this.cbx_materiaCorrelativa.Name = "cbx_materiaCorrelativa";
            this.cbx_materiaCorrelativa.Size = new System.Drawing.Size(121, 23);
            this.cbx_materiaCorrelativa.TabIndex = 12;
            this.cbx_materiaCorrelativa.SelectedIndexChanged += new System.EventHandler(this.cbx_materiaCorrelativa_SelectedIndexChanged);
            // 
            // chbx_materiaCorrelativa
            // 
            this.chbx_materiaCorrelativa.AutoSize = true;
            this.chbx_materiaCorrelativa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chbx_materiaCorrelativa.Location = new System.Drawing.Point(75, 206);
            this.chbx_materiaCorrelativa.Name = "chbx_materiaCorrelativa";
            this.chbx_materiaCorrelativa.Size = new System.Drawing.Size(159, 25);
            this.chbx_materiaCorrelativa.TabIndex = 22;
            this.chbx_materiaCorrelativa.Text = "Materia correlativa";
            this.chbx_materiaCorrelativa.UseVisualStyleBackColor = true;
            this.chbx_materiaCorrelativa.CheckedChanged += new System.EventHandler(this.chbx_materiaCorrelativa_CheckedChanged);
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_confirmar.Location = new System.Drawing.Point(75, 277);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(121, 32);
            this.btn_confirmar.TabIndex = 23;
            this.btn_confirmar.Text = "Confirmar";
            this.btn_confirmar.UseVisualStyleBackColor = true;
            this.btn_confirmar.Click += new System.EventHandler(this.btn_confirmar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_cancelar.Location = new System.Drawing.Point(447, 277);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(121, 32);
            this.btn_cancelar.TabIndex = 24;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // cbx_cuatrimestre
            // 
            this.cbx_cuatrimestre.FormattingEnabled = true;
            this.cbx_cuatrimestre.Location = new System.Drawing.Point(447, 96);
            this.cbx_cuatrimestre.Name = "cbx_cuatrimestre";
            this.cbx_cuatrimestre.Size = new System.Drawing.Size(121, 23);
            this.cbx_cuatrimestre.TabIndex = 25;
            // 
            // FrmCrearMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 340);
            this.Controls.Add(this.cbx_cuatrimestre);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_confirmar);
            this.Controls.Add(this.chbx_materiaCorrelativa);
            this.Controls.Add(this.lbl_materiaCorrelativa);
            this.Controls.Add(this.lbl_codigo);
            this.Controls.Add(this.tbx_codigo);
            this.Controls.Add(this.lbl_cuatrimestre);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.tbx_nombre);
            this.Controls.Add(this.cbx_materiaCorrelativa);
            this.Name = "FrmCrearMateria";
            this.Text = "Crear materia";
            this.Load += new System.EventHandler(this.FrmCrearMateria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_materiaCorrelativa;
        private Label lbl_codigo;
        private TextBox tbx_codigo;
        private Label lbl_cuatrimestre;
        private Label lbl_nombre;
        private TextBox tbx_nombre;
        private ComboBox cbx_materiaCorrelativa;
        private CheckBox chbx_materiaCorrelativa;
        private Button btn_confirmar;
        private Button btn_cancelar;
        private ComboBox cbx_cuatrimestre;
    }
}
namespace PPLab2Form.Forms
{
    partial class FrmCrearUsuario
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cbx_tipoUsuario = new System.Windows.Forms.ComboBox();
            this.tbx_nombre = new System.Windows.Forms.TextBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.tbx_apellido = new System.Windows.Forms.TextBox();
            this.lbl_dni = new System.Windows.Forms.Label();
            this.tbx_dni = new System.Windows.Forms.TextBox();
            this.lbl_contrasenia = new System.Windows.Forms.Label();
            this.tbx_contrasenia = new System.Windows.Forms.TextBox();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.lbl_tipoUsuario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbx_tipoUsuario
            // 
            this.cbx_tipoUsuario.FormattingEnabled = true;
            this.cbx_tipoUsuario.Location = new System.Drawing.Point(144, 249);
            this.cbx_tipoUsuario.Name = "cbx_tipoUsuario";
            this.cbx_tipoUsuario.Size = new System.Drawing.Size(121, 23);
            this.cbx_tipoUsuario.TabIndex = 0;
            // 
            // tbx_nombre
            // 
            this.tbx_nombre.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbx_nombre.Location = new System.Drawing.Point(46, 72);
            this.tbx_nombre.Name = "tbx_nombre";
            this.tbx_nombre.Size = new System.Drawing.Size(121, 25);
            this.tbx_nombre.TabIndex = 1;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_nombre.Location = new System.Drawing.Point(46, 48);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(68, 21);
            this.lbl_nombre.TabIndex = 2;
            this.lbl_nombre.Text = "Nombre";
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.AutoSize = true;
            this.lbl_apellido.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_apellido.Location = new System.Drawing.Point(234, 48);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(67, 21);
            this.lbl_apellido.TabIndex = 4;
            this.lbl_apellido.Text = "Apellido";
            // 
            // tbx_apellido
            // 
            this.tbx_apellido.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbx_apellido.Location = new System.Drawing.Point(234, 72);
            this.tbx_apellido.Name = "tbx_apellido";
            this.tbx_apellido.Size = new System.Drawing.Size(121, 25);
            this.tbx_apellido.TabIndex = 3;
            // 
            // lbl_dni
            // 
            this.lbl_dni.AutoSize = true;
            this.lbl_dni.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_dni.Location = new System.Drawing.Point(46, 138);
            this.lbl_dni.Name = "lbl_dni";
            this.lbl_dni.Size = new System.Drawing.Size(37, 21);
            this.lbl_dni.TabIndex = 6;
            this.lbl_dni.Text = "DNI";
            // 
            // tbx_dni
            // 
            this.tbx_dni.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbx_dni.Location = new System.Drawing.Point(46, 162);
            this.tbx_dni.Name = "tbx_dni";
            this.tbx_dni.Size = new System.Drawing.Size(121, 25);
            this.tbx_dni.TabIndex = 5;
            // 
            // lbl_contrasenia
            // 
            this.lbl_contrasenia.AutoSize = true;
            this.lbl_contrasenia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_contrasenia.Location = new System.Drawing.Point(234, 138);
            this.lbl_contrasenia.Name = "lbl_contrasenia";
            this.lbl_contrasenia.Size = new System.Drawing.Size(89, 21);
            this.lbl_contrasenia.TabIndex = 8;
            this.lbl_contrasenia.Text = "Contraseña";
            // 
            // tbx_contrasenia
            // 
            this.tbx_contrasenia.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbx_contrasenia.Location = new System.Drawing.Point(234, 162);
            this.tbx_contrasenia.Name = "tbx_contrasenia";
            this.tbx_contrasenia.PasswordChar = '*';
            this.tbx_contrasenia.Size = new System.Drawing.Size(121, 25);
            this.tbx_contrasenia.TabIndex = 7;
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_confirmar.Location = new System.Drawing.Point(46, 322);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(121, 38);
            this.btn_confirmar.TabIndex = 9;
            this.btn_confirmar.Text = "Confirmar";
            this.btn_confirmar.UseVisualStyleBackColor = true;
            this.btn_confirmar.Click += new System.EventHandler(this.btn_confirmar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_cancelar.Location = new System.Drawing.Point(234, 322);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(121, 38);
            this.btn_cancelar.TabIndex = 10;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // lbl_tipoUsuario
            // 
            this.lbl_tipoUsuario.AutoSize = true;
            this.lbl_tipoUsuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_tipoUsuario.Location = new System.Drawing.Point(144, 225);
            this.lbl_tipoUsuario.Name = "lbl_tipoUsuario";
            this.lbl_tipoUsuario.Size = new System.Drawing.Size(96, 21);
            this.lbl_tipoUsuario.TabIndex = 11;
            this.lbl_tipoUsuario.Text = "Tipo usuario";
            // 
            // FrmCrearUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 397);
            this.Controls.Add(this.lbl_tipoUsuario);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_confirmar);
            this.Controls.Add(this.lbl_contrasenia);
            this.Controls.Add(this.tbx_contrasenia);
            this.Controls.Add(this.lbl_dni);
            this.Controls.Add(this.tbx_dni);
            this.Controls.Add(this.lbl_apellido);
            this.Controls.Add(this.tbx_apellido);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.tbx_nombre);
            this.Controls.Add(this.cbx_tipoUsuario);
            this.Name = "FrmCrearUsuario";
            this.Text = "Crear Usuario";
            this.Load += new System.EventHandler(this.FrmCrearUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ComboBox cbx_tipoUsuario;
        private TextBox tbx_nombre;
        private Label lbl_nombre;
        private Label lbl_apellido;
        private TextBox tbx_apellido;
        private Label lbl_dni;
        private TextBox tbx_dni;
        private Label lbl_contrasenia;
        private TextBox tbx_contrasenia;
        private Button btn_confirmar;
        private Button btn_cancelar;
        private Label lbl_tipoUsuario;
    }
}
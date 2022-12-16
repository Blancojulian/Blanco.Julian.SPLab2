namespace PPLab2Form.Forms
{
    partial class FrmLogin
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
            this.lbl_inicio = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_contrasenia = new System.Windows.Forms.Label();
            this.tbx_nombre = new System.Windows.Forms.TextBox();
            this.tbx_contrasenia = new System.Windows.Forms.TextBox();
            this.login_btn_aceptar = new System.Windows.Forms.Button();
            this.login_btn_cancelar = new System.Windows.Forms.Button();
            this.tbx_dni = new System.Windows.Forms.TextBox();
            this.lbl_dni = new System.Windows.Forms.Label();
            this.lbl_completarDatos = new System.Windows.Forms.Label();
            this.cbx_tipoUsuario = new System.Windows.Forms.ComboBox();
            this.btn_cargarDatos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_inicio
            // 
            this.lbl_inicio.AutoSize = true;
            this.lbl_inicio.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_inicio.Location = new System.Drawing.Point(306, 26);
            this.lbl_inicio.Name = "lbl_inicio";
            this.lbl_inicio.Size = new System.Drawing.Size(185, 46);
            this.lbl_inicio.TabIndex = 0;
            this.lbl_inicio.Text = "Bienvenido";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_nombre.Location = new System.Drawing.Point(262, 103);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(81, 25);
            this.lbl_nombre.TabIndex = 1;
            this.lbl_nombre.Text = "Nombre";
            // 
            // lbl_contrasenia
            // 
            this.lbl_contrasenia.AutoSize = true;
            this.lbl_contrasenia.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_contrasenia.Location = new System.Drawing.Point(262, 202);
            this.lbl_contrasenia.Name = "lbl_contrasenia";
            this.lbl_contrasenia.Size = new System.Drawing.Size(108, 25);
            this.lbl_contrasenia.TabIndex = 2;
            this.lbl_contrasenia.Text = "Contraseña";
            // 
            // tbx_nombre
            // 
            this.tbx_nombre.Location = new System.Drawing.Point(393, 103);
            this.tbx_nombre.Name = "tbx_nombre";
            this.tbx_nombre.Size = new System.Drawing.Size(138, 23);
            this.tbx_nombre.TabIndex = 3;
            // 
            // tbx_contrasenia
            // 
            this.tbx_contrasenia.Location = new System.Drawing.Point(393, 202);
            this.tbx_contrasenia.Name = "tbx_contrasenia";
            this.tbx_contrasenia.PasswordChar = '*';
            this.tbx_contrasenia.Size = new System.Drawing.Size(138, 23);
            this.tbx_contrasenia.TabIndex = 4;
            // 
            // login_btn_aceptar
            // 
            this.login_btn_aceptar.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.login_btn_aceptar.Location = new System.Drawing.Point(266, 283);
            this.login_btn_aceptar.Name = "login_btn_aceptar";
            this.login_btn_aceptar.Size = new System.Drawing.Size(105, 44);
            this.login_btn_aceptar.TabIndex = 5;
            this.login_btn_aceptar.Text = "Ingresar";
            this.login_btn_aceptar.UseVisualStyleBackColor = true;
            this.login_btn_aceptar.Click += new System.EventHandler(this.login_btn_aceptar_Click);
            // 
            // login_btn_cancelar
            // 
            this.login_btn_cancelar.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.login_btn_cancelar.Location = new System.Drawing.Point(426, 283);
            this.login_btn_cancelar.Name = "login_btn_cancelar";
            this.login_btn_cancelar.Size = new System.Drawing.Size(105, 44);
            this.login_btn_cancelar.TabIndex = 6;
            this.login_btn_cancelar.Text = "Cancelar";
            this.login_btn_cancelar.UseVisualStyleBackColor = true;
            this.login_btn_cancelar.Click += new System.EventHandler(this.login_btn_cancelar_Click);
            // 
            // tbx_dni
            // 
            this.tbx_dni.Location = new System.Drawing.Point(393, 152);
            this.tbx_dni.Name = "tbx_dni";
            this.tbx_dni.Size = new System.Drawing.Size(138, 23);
            this.tbx_dni.TabIndex = 8;
            // 
            // lbl_dni
            // 
            this.lbl_dni.AutoSize = true;
            this.lbl_dni.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_dni.Location = new System.Drawing.Point(262, 152);
            this.lbl_dni.Name = "lbl_dni";
            this.lbl_dni.Size = new System.Drawing.Size(44, 25);
            this.lbl_dni.TabIndex = 7;
            this.lbl_dni.Text = "DNI";
            // 
            // lbl_completarDatos
            // 
            this.lbl_completarDatos.AutoSize = true;
            this.lbl_completarDatos.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_completarDatos.Location = new System.Drawing.Point(600, 98);
            this.lbl_completarDatos.Name = "lbl_completarDatos";
            this.lbl_completarDatos.Size = new System.Drawing.Size(151, 25);
            this.lbl_completarDatos.TabIndex = 9;
            this.lbl_completarDatos.Text = "Completar datos";
            // 
            // cbx_tipoUsuario
            // 
            this.cbx_tipoUsuario.FormattingEnabled = true;
            this.cbx_tipoUsuario.Location = new System.Drawing.Point(600, 152);
            this.cbx_tipoUsuario.Name = "cbx_tipoUsuario";
            this.cbx_tipoUsuario.Size = new System.Drawing.Size(151, 23);
            this.cbx_tipoUsuario.TabIndex = 10;
            // 
            // btn_cargarDatos
            // 
            this.btn_cargarDatos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_cargarDatos.Location = new System.Drawing.Point(600, 201);
            this.btn_cargarDatos.Name = "btn_cargarDatos";
            this.btn_cargarDatos.Size = new System.Drawing.Size(151, 26);
            this.btn_cargarDatos.TabIndex = 11;
            this.btn_cargarDatos.Text = "Cargar datos";
            this.btn_cargarDatos.UseVisualStyleBackColor = true;
            this.btn_cargarDatos.Click += new System.EventHandler(this.btn_cargarDatos_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_cargarDatos);
            this.Controls.Add(this.cbx_tipoUsuario);
            this.Controls.Add(this.lbl_completarDatos);
            this.Controls.Add(this.tbx_dni);
            this.Controls.Add(this.lbl_dni);
            this.Controls.Add(this.login_btn_cancelar);
            this.Controls.Add(this.login_btn_aceptar);
            this.Controls.Add(this.tbx_contrasenia);
            this.Controls.Add(this.tbx_nombre);
            this.Controls.Add(this.lbl_contrasenia);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.lbl_inicio);
            this.Name = "FrmLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_inicio;
        private Label lbl_nombre;
        private Label lbl_contrasenia;
        private TextBox tbx_nombre;
        private TextBox tbx_contrasenia;
        private Button login_btn_aceptar;
        private Button login_btn_cancelar;
        private TextBox tbx_dni;
        private Label lbl_dni;
        private Label lbl_completarDatos;
        private ComboBox cbx_tipoUsuario;
        private Button btn_cargarDatos;
    }
}
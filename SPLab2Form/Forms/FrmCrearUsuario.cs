using BibliotecaEntidades.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPLab2Form.Forms
{
    public partial class FrmCrearUsuario : Form
    {
        private Usuario _usuario;
        public FrmCrearUsuario()
        {

            InitializeComponent();
        }

        private void FrmCrearUsuario_Load(object sender, EventArgs e)
        {
            
            this.cbx_tipoUsuario.DataSource = Enum.GetValues(typeof(ENivelUsuario));
            this.cbx_tipoUsuario.SelectedItem = ENivelUsuario.Alumno;

            ConfiguarForm();


        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            int dni;
            ENivelUsuario nivelUsuario = (ENivelUsuario)this.cbx_tipoUsuario.SelectedItem;

            if ( !string.IsNullOrWhiteSpace(tbx_nombre.Text) &&
                !string.IsNullOrWhiteSpace(tbx_apellido.Text) &&
                !string.IsNullOrWhiteSpace(tbx_contrasenia.Text) &&
                !string.IsNullOrWhiteSpace(tbx_dni.Text) )
            {
                if (int.TryParse(this.tbx_dni.Text, out dni))
                {
                    switch (nivelUsuario)
                    {
                        case ENivelUsuario.Admin:
                            this._usuario = new Admin(tbx_nombre.Text, tbx_apellido.Text, dni);
                            break;
                        case ENivelUsuario.Profesor:
                            this._usuario = new Profesor(tbx_nombre.Text, tbx_apellido.Text, dni);
                            break;
                        case ENivelUsuario.Alumno:
                            this._usuario = new Alumno(tbx_nombre.Text, tbx_apellido.Text, dni);
                            break;
                        default:
                            break;
                    }
                    
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("DNI invalido");
                }

            }
            else
            {
                MessageBox.Show("Debe completar todos campos");
            }
            
        }
        private void ConfiguarForm()
        {
            this.BackColor = Color.FromArgb(55, 94, 151);
        }

        public Usuario Usuario { get { return this._usuario; } }

        

    }
}

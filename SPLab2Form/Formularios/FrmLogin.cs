using BibliotecaEntidades.Entidades;
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
    public partial class FrmLogin : Form
    {
        private NivelUsuario _nivelUsuario;
        private Usuario _usuario;

        public NivelUsuario NivelUsuario { get => _nivelUsuario; }
        public Usuario Usuario { get => _usuario; }

        public FrmLogin()
        {
            InitializeComponent();
        }


        private void login_btn_aceptar_Click(object sender, EventArgs e)
        {
            int dni;
            
            if(int.TryParse(this.tbx_dni.Text, out dni))
            {
                Usuario? usuario = Sistema.Usuarios.ComprobarLogin(this.tbx_nombre.Text, this.tbx_contrasenia.Text, dni);
                
                if (usuario is not null)
                {
                    
                    switch (usuario.NivelUsuario)
                    {
                        case NivelUsuario.Admin:


                            //FrmAdmin frmAAdmin = new FrmAdmin((Admin)usuario);
                            //frmAAdmin.Show();
                            //this.Hide();
                            _nivelUsuario = NivelUsuario.Admin;
                            _usuario = usuario;
                            this.Close();
                            break;
                        case NivelUsuario.Profesor:
                            //FrmProfesor frmProfesor = new FrmProfesor((Profesor)usuario);
                            //frmProfesor.Show();
                            //this.Hide();
                            _nivelUsuario = NivelUsuario.Profesor;
                            _usuario = usuario;
                            this.Close();
                            break;
                        case NivelUsuario.Alumno:
                            //FrmAlumno frmAlumno = new FrmAlumno((Alumno)usuario);
                            //frmAlumno.Show();
                            //this.Hide();
                            _nivelUsuario = NivelUsuario.Alumno;
                            _usuario = usuario;
                            this.Close();
                            break;
                        default:
                            break;
                    }
                
                }
                else
                {
                    MessageBox.Show("El usuario no existe");
                }
            
            }
            else
            {
                MessageBox.Show("DNI invalido");
            }

        }

        private void login_btn_cancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            ConfiguarForm();
            cbx_tipoUsuario.DataSource = Enum.GetValues(typeof(NivelUsuario));
            cbx_tipoUsuario.SelectedItem = NivelUsuario.Alumno;
        }

        private void btn_cargarDatos_Click(object sender, EventArgs e)
        {
            List<Usuario> listaUsuarios = Sistema.Usuarios.GetLista;
            List<Usuario> listaPorTipo = new List<Usuario>();
            Usuario? usuario = null;
            NivelUsuario nivelUsuario = (NivelUsuario)this.cbx_tipoUsuario.SelectedItem;

            foreach (Usuario u in listaUsuarios)
            {
                if (u.NivelUsuario == nivelUsuario)
                {
                    listaPorTipo.Add(u);
                }
            }

            if (listaPorTipo.Count > 0)
            {
                usuario = listaPorTipo[0];
            }
            else
            {
                MessageBox.Show("No hay cargado usuario de ese tipo");
            }

            if (usuario is not null)
            {
                tbx_nombre.Text = usuario.Nombre;
                tbx_dni.Text = $"{usuario.Dni}";
                tbx_contrasenia.Text = Usuario.RecuperarContrasenia(usuario);

            }

        }

        private void ConfiguarForm()
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ControlBox = false;
            this.ShowIcon = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Color.FromArgb(255,255,255);
        }
    }
}

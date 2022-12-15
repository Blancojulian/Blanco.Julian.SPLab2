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
    public partial class FrmMenuPrincipal : Form
    {
        private NivelUsuario _nivelUsuario;
        private FrmAdmin? _frmAdmin;
        private FrmProfesor? _frmProfesor;
        private FrmAlumno? _frmAlumno;
        private FrmLogin? _frmLogin;

        public NivelUsuario NivelUsuario { get => _nivelUsuario; set => _nivelUsuario = value; }

        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            if (_frmLogin is null)
            {
                _frmLogin = new FrmLogin();
                _frmLogin.MdiParent = this;
                _frmLogin.FormClosed += new FormClosedEventHandler(CerrarLogin);
                _frmLogin.Dock = DockStyle.Fill;
                _frmLogin.Show();
                _frmLogin.WindowState = FormWindowState.Maximized;


            }
            this.ShowIcon = false;
        }
        private void CerrarLogin(object sender, FormClosedEventArgs e)
        {
            
            if (_frmLogin is not null)
            {
                
                switch (_frmLogin.NivelUsuario)
                {
                    case NivelUsuario.Admin:
                        AbrirFormAdmin((Admin)_frmLogin.Usuario);
                        break;
                    case NivelUsuario.Profesor:
                        AbrirFormProfesor((Profesor)_frmLogin.Usuario);
                        break;
                    case NivelUsuario.Alumno:
                        AbrirFormAlumno((Alumno)_frmLogin.Usuario);
                        break;
                    default:
                        break;
                }
                _frmLogin = null;
            }
            else
            {
                MessageBox.Show("Error, frmLogin es null");

            }
        }
        private void CerrarForms(object sender, FormClosedEventArgs e)
        {
            _frmAdmin = null;
            _frmProfesor = null;
            _frmAlumno = null;

            if (_frmLogin is null)
            {
                _frmLogin = new FrmLogin();
                _frmLogin.MdiParent = this;
                _frmLogin.FormClosed += new FormClosedEventHandler(CerrarLogin);
                _frmLogin.Dock = DockStyle.Fill;
                _frmLogin.Show();
                _frmLogin.WindowState = FormWindowState.Maximized;


            }
        }
       
        private void AbrirFormAdmin(Admin admin)
        {
            _frmLogin = null;
            _frmProfesor = null;
            _frmAlumno = null;

            if (_frmAdmin is null)
            {
                _frmAdmin = new FrmAdmin(admin);
                _frmAdmin.MdiParent = this;
                _frmAdmin.FormClosed += new FormClosedEventHandler(CerrarForms);
                _frmAdmin.Dock = DockStyle.Fill;
                _frmAdmin.Show();
                _frmAdmin.WindowState = FormWindowState.Maximized;

                
            }
        }

        private void AbrirFormProfesor(Profesor profesor)
        {
            _frmLogin = null;
            _frmAdmin = null;
            _frmAlumno = null;

            if (_frmProfesor is null)
            {
                _frmProfesor = new FrmProfesor(profesor);
                _frmProfesor.MdiParent = this;
                _frmProfesor.FormClosed += new FormClosedEventHandler(CerrarForms);
                _frmProfesor.Dock = DockStyle.Fill;
                _frmProfesor.Show();
                _frmProfesor.WindowState = FormWindowState.Maximized;


            }
        }

        private void AbrirFormAlumno(Alumno alumno)
        {
            _frmLogin = null;
            _frmAdmin = null;
            _frmProfesor = null;

            if (_frmAlumno is null)
            {
                _frmAlumno = new FrmAlumno(alumno);
                _frmAlumno.MdiParent = this;
                _frmAlumno.FormClosed += new FormClosedEventHandler(CerrarForms);
                _frmAlumno.Dock = DockStyle.Fill;
                _frmAlumno.Show();
                _frmAlumno.WindowState = FormWindowState.Maximized;


            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaEntidades.Clases;
using BibliotecaEntidades.DAO;

namespace PPLab2Form.Forms
{
    public partial class FrmAlumno : Form
    {
        
        private Alumno _alumno;
        private EEstadoFrmAlumno _estado;
       
        private enum EEstadoFrmAlumno
        {
            Inscripcion,
            Materias
        }
        public FrmAlumno(Alumno alumno)
        {
            this._alumno = alumno;
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void FormAlumno_Load(object sender, EventArgs e)
        {
            this.lbl_bienvenida.Text = $"Bienvenido {this._alumno.Apellido} {this._alumno.Nombre}";
            ConfiguarForm();
            ConfigurarDataGrid();
            ConfigurarParaVerMateriasCursadas();
            dtgv_datos.ClearSelection();
            
        }

        private void alumno_lbl_inicio_Click(object sender, EventArgs e)
        {

        }

       

        private void ConfigurarParaInscribirse()
        {
            EstadoAlumno? estaAlumno;
            _estado = EEstadoFrmAlumno.Inscripcion;

            btn_inscribirse.Enabled = true;
            btn_inscribirse.Visible = true;

            List<Materia> materias = ClaseDAO.MateriaDao.GetAll();//Sistema.Materias.GetLista;
            List<Materia> materiasSinCursar = new List<Materia>();

            foreach (var m in materias)
            {
                estaAlumno = ClaseDAO.MateriaDao.Get(m.CodigoMateria, _alumno.Dni);
                if(estaAlumno is null)
                {
                    materiasSinCursar.Add(m);
                }
            }

            dtgv_datos.DataSource = materiasSinCursar;


            dtgv_datos.Columns["CodigoMateria"].HeaderText = "Codigo Materia";
            dtgv_datos.Columns["Nombre"].HeaderText = "Nombre Materia";
            dtgv_datos.Columns["MostrarMateriaCorrelativa"].HeaderText = "Materia Correlativa";


            dtgv_datos.Columns["MateriaCorrelativa"].Visible = false;
            dtgv_datos.Columns["Alumnos"].Visible = false;
            dtgv_datos.Columns["ListaAlumnos"].Visible = false;
            dtgv_datos.Columns["PrimerExamen"].Visible = false;
            dtgv_datos.Columns["SegundoExamen"].Visible = false;



            dtgv_datos.Update();
            dtgv_datos.Refresh();
            dtgv_datos.ClearSelection();

            
        }

        private void ConfigurarParaVerMateriasCursadas()
        {
            _estado = EEstadoFrmAlumno.Materias;

            btn_inscribirse.Enabled = false;
            btn_inscribirse.Visible = false;

            List<Materia> materias = ClaseDAO.MateriaDao.ListarMateriasDelAlumno(_alumno.Dni);
            EstadoAlumno? estadoAlumno;
            List<EstadoAlumno> listaEstados = new List<EstadoAlumno>();//ClaseDAO.MateriaDao.Get(_materia.CodigoMateria);

            foreach (Materia materia in materias)
            {
                estadoAlumno = ClaseDAO.MateriaDao.Get(materia.CodigoMateria, _alumno.Dni);
                if(estadoAlumno is not null)
                {
                    listaEstados.Add(estadoAlumno);
                }

            }
            dtgv_datos.DataSource = listaEstados;

            dtgv_datos.Columns["PrimerExamen"].Visible = false;
            dtgv_datos.Columns["SegundoExamen"].Visible = false;

            dtgv_datos.Columns["NotaPrimerExamen"].HeaderText = "Nota Primer Examen";
            dtgv_datos.Columns["NotaSegundoExamen"].HeaderText = "Nota Segundo Examen";
            

            dtgv_datos.Update();
            dtgv_datos.Refresh();
            dtgv_datos.ClearSelection();

            

        }

        
        private void ConfigurarDataGrid()
        {
            //selecciona toda la fila
            this.dtgv_datos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //selecciona de a uno
            this.dtgv_datos.MultiSelect = false;
            //cambia a solamente lectura
            this.dtgv_datos.ReadOnly = true;
            //le saca la flechita que tiene al costado la fila
            this.dtgv_datos.RowHeadersVisible = false;
            //ajusta el tamaño de las columnas para ocupar todo el data griw view
            this.dtgv_datos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            this.dtgv_datos.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            this.dtgv_datos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            //el usuario podra agregar filas o no
            this.dtgv_datos.AllowUserToAddRows = false;


            dtgv_datos.ClearSelection();


        }

        private void btn_materiasCursadas_Click(object sender, EventArgs e)
        {
            ConfigurarParaVerMateriasCursadas();
        }

        private void btn_inscribirse_Click(object sender, EventArgs e)
        {
            if(dtgv_datos.SelectedRows.Count > 0 && _estado == EEstadoFrmAlumno.Inscripcion)
            {
                Materia materia = (Materia)dtgv_datos.CurrentRow.DataBoundItem;

                if (Alumno.InscribirseAMateria(materia.CodigoMateria, _alumno) > 0)
                {
                    MessageBox.Show($"Se inscribio a la materia {materia.Nombre}");
                }
                else
                {
                    MessageBox.Show("Fallo la inscripcion");
                }

                ConfigurarParaInscribirse();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una materia");
            }
        }

        private void btn_inscribirseAMaterias_Click(object sender, EventArgs e)
        {
            ConfigurarParaInscribirse();
        }


        private void msi_materiasCursadas_Click(object sender, EventArgs e)
        {
            ConfigurarParaVerMateriasCursadas();
        }

        private void msi_inscribirseAMaterias_Click(object sender, EventArgs e)
        {
            ConfigurarParaInscribirse();
        }
        private void ConfiguarForm()
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ControlBox = false;
            this.ShowIcon = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Color.FromArgb(222, 122, 34);
        }

        private void msi_cerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

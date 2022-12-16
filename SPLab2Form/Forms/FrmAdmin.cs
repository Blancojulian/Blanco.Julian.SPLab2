using BibliotecaEntidades.Clases;
using BibliotecaEntidades.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPLab2Form.Forms
{
    public partial class FrmAdmin : Form
    {
        delegate bool SerializarAlumnos(List<Alumno> alumnos, string materia);
        delegate List<Alumno> DeserializarAlumnos(string materia);

        SerializarAlumnos serializarJson = JSON.SerializarJSON;
        SerializarAlumnos serializarXML = XML.SerializarXml;

        DeserializarAlumnos deserializarJson = JSON.DeserializarJSON;
        DeserializarAlumnos deserializarXML = XML.DeserializarXml;


        private Admin _admin;

        public FrmAdmin(Admin admin)
        {
            InitializeComponent();
            _admin = admin;
        }

        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            ConfiguarForm();
            ConfigurarDataGrid();
            CargarDataGrid();

        }

        private void Refrescar()
        {
            //CargarDataGrid();
            this.dtgv_materias.DataSource = ClaseDAO.MateriaDao.GetAll();
            dtgv_materias.Update();
            dtgv_materias.Refresh();

            dtgv_materias.ClearSelection();


        }
        private void ConfigurarDataGrid()
        {
            //selecciona toda la fila
            this.dtgv_materias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //selecciona de a uno
            this.dtgv_materias.MultiSelect = false;
            //cambia a solamente lectura
            this.dtgv_materias.ReadOnly = true;
            //le saca la flechita que tiene al costado la fila
            this.dtgv_materias.RowHeadersVisible = false;
            //ajusta el tamaño de las columnas para ocupar todo el data griw view
            this.dtgv_materias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            this.dtgv_materias.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            this.dtgv_materias.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;



        }

        private void CargarDataGrid()
        {
            this.dtgv_materias.DataSource = ClaseDAO.MateriaDao.GetAll();


            this.dtgv_materias.Columns["CodigoMateria"].HeaderText = "Codigo Materia";
            this.dtgv_materias.Columns["Nombre"].HeaderText = "Nombre Materia";
            this.dtgv_materias.Columns["MostrarMateriaCorrelativa"].HeaderText = "Materia Correlativa";


            this.dtgv_materias.Columns["MateriaCorrelativa"].Visible = false;
            this.dtgv_materias.Columns["ListaAlumnos"].Visible = false;
            this.dtgv_materias.Columns["PrimerExamen"].Visible = false;
            this.dtgv_materias.Columns["SegundoExamen"].Visible = false;




            dtgv_materias.ClearSelection();
        }

        private void msi_crearUsuario_Click(object sender, EventArgs e)
        {
            FrmCrearUsuario frm = new FrmCrearUsuario();
            DialogResult respuesta = frm.ShowDialog();

            if (respuesta == DialogResult.OK && _admin.CrearUsuario(frm.Usuario) > 0)
            {
                MessageBox.Show($"Se creo el {frm.Usuario.NivelUsuario} {frm.Usuario.Apellido} {frm.Usuario.Nombre} con exito");
                Refrescar();
            }
            else if (respuesta == DialogResult.Cancel)
            {
                MessageBox.Show($"Se cancelo la operación");

            }
        }

        private void msi_crearMateria_Click(object sender, EventArgs e)
        {
            FrmCrearMateria frm = new FrmCrearMateria();
            DialogResult respuesta = frm.ShowDialog();

            if (respuesta == DialogResult.OK && _admin.CrearMateria(frm.Materia) > 0)
            {
                MessageBox.Show($"Se creo la {frm.Materia.Nombre} con exito");
                Refrescar();
            }
            else if (respuesta == DialogResult.Cancel)
            {
                MessageBox.Show($"Se cancelo la operación");

            }
        }

        private void msi_cambiarEstado_Click(object sender, EventArgs e)
        {
            if (dtgv_materias.SelectedRows.Count > 0)
            {
                Materia materia = (Materia)dtgv_materias.CurrentRow.DataBoundItem;
                FrmEstadoAlumno frm = new FrmEstadoAlumno(_admin, materia);
                DialogResult respuesta = frm.ShowDialog();

                if (respuesta == DialogResult.OK)
                {
                    string texto = frm.Cambios ? "Se modificaron con exito" : "No se realizaron cambios";
                    MessageBox.Show(texto);
                    Refrescar();
                }
                else if (respuesta == DialogResult.Cancel)
                {
                    MessageBox.Show("Se cancelo la operación");
                }

            }
            else
            {
                MessageBox.Show("Tiene que seleccionar una materia");

            }
        }

        private void msi_asignarProfesorAMateria_Click(object sender, EventArgs e)
        {
            if (dtgv_materias.SelectedRows.Count > 0)
            {
                Materia materia = (Materia)dtgv_materias.CurrentRow.DataBoundItem;
                FrmElegirProfesor frm = new FrmElegirProfesor(materia.Nombre);
                DialogResult respuesta = frm.ShowDialog();

                if (respuesta == DialogResult.OK)
                {

                    if (frm.Profesor is not null && _admin.AgregarProfesorAMateria(materia.CodigoMateria, frm.Profesor.Dni) > 0)
                    {
                        MessageBox.Show($"Se agrego el profesor {frm.Profesor.Apellido} {frm.Profesor.Nombre} a la materia {materia.Nombre}");
                        Refrescar();
                    }
                }
                else if (respuesta == DialogResult.Cancel)
                {
                    MessageBox.Show("Se cancelo la operación");
                }

            }
            else
            {
                MessageBox.Show("Tiene que seleccionar una materia");

            }
        }



        private void ConfiguarForm()
        {
            this.Dock = DockStyle.Fill;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ControlBox = false;
            this.ShowIcon = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Color.FromArgb(55, 94, 151);
        }


        private void msi_asignarAlumno_Click(object sender, EventArgs e)
        {
            if (dtgv_materias.SelectedRows.Count > 0)
            {
                Materia materia = (Materia)dtgv_materias.CurrentRow.DataBoundItem;
                FrmElegirAlumno frm = new FrmElegirAlumno(materia.Nombre);
                DialogResult respuesta = frm.ShowDialog();

                if (respuesta == DialogResult.OK)
                {

                    if (frm.Alumno is not null && Alumno.InscribirseAMateria(materia.CodigoMateria, frm.Alumno) > 0)
                    {
                        MessageBox.Show($"Se agrego el profesor {frm.Alumno.Apellido} {frm.Alumno.Nombre} a la materia {materia.Nombre}");
                        Refrescar();
                    }
                }
                else if (respuesta == DialogResult.Cancel)
                {
                    MessageBox.Show("Se cancelo la operación");
                }

            }
            else
            {
                MessageBox.Show("Tiene que seleccionar una materia");

            }
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void msi_exportarAJson_Click(object sender, EventArgs e)
        {
            if (dtgv_materias.SelectedRows.Count > 0)
            {
                try
                {
                    Materia materia = (Materia)dtgv_materias.CurrentRow.DataBoundItem;
                    List<Alumno> alumnos = ClaseDAO.MateriaDao.ListarAlumnoDeMateria(materia.CodigoMateria);

                    if (string.IsNullOrEmpty(tbx_nombreArchivo.Text))
                    {
                        throw new Exception("Error, debe escribir un numbre para el archivo");
                    }

                    if (serializarJson(alumnos, tbx_nombreArchivo.Text))
                    {
                        MessageBox.Show("Se serializo correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                MessageBox.Show("Tiene que seleccionar una materia");

            }
        }

        private void msi_importarAJson_Click(object sender, EventArgs e)
        {
            if (dtgv_materias.SelectedRows.Count > 0)
            {
                try
                {
                    Materia materia = (Materia)dtgv_materias.CurrentRow.DataBoundItem;
                    List<Alumno> alumnos;// = new List<Alumno>();//ClaseDAO.MateriaDao.ListarAlumnoDeMateria(materia.CodigoMateria);

                    if (string.IsNullOrEmpty(tbx_nombreArchivo.Text))
                    {
                        throw new Exception("Error, debe escribir un nombre del archivo que desea serealizar");
                    }

                    alumnos = deserializarJson(tbx_nombreArchivo.Text);
                    if (alumnos.Count > 0)
                    {
                        foreach (Alumno alumno in alumnos)
                        {
                            ClaseDAO.UsuarioDao.Add(alumno);
                            ClaseDAO.MateriaDao.Add(materia.CodigoMateria, alumno.Dni, new EstadoAlumno());
                        }
                        MessageBox.Show("Se ha deserializado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                MessageBox.Show("Tiene que seleccionar una materia a la que se van a cargar los alumnos");

            }
        }
    }
}

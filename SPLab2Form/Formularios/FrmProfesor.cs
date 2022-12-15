using BibliotecaEntidades.Clases;
using BibliotecaEntidades.DAO;
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
    public partial class FrmProfesor : Form
    {
        private Profesor _profesor;
        public FrmProfesor(Profesor profesor)
        {
            _profesor = profesor;
            InitializeComponent();
        }

        private void FrmProfesor_Load(object sender, EventArgs e)
        {
            ConfiguarForm();
            ConfigurarDataGrid();
            CargarDataGrid();
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

            this.dtgv_materias.DataSource = ClaseDAO.MateriaDao.ListarMateriasDelProfesor(_profesor.Dni);


            this.dtgv_materias.Columns["CodigoMateria"].HeaderText = "Codigo Materia";
            this.dtgv_materias.Columns["Nombre"].HeaderText = "Nombre Materia";

            this.dtgv_materias.Columns["PrimerExamen"].Visible = false;
            this.dtgv_materias.Columns["SegundoExamen"].Visible = false;
            this.dtgv_materias.Columns["ListaAlumnos"].Visible = false;
            this.dtgv_materias.Columns["MostrarMateriaCorrelativa"].Visible = false;
            this.dtgv_materias.Columns["MateriaCorrelativa"].Visible = false;

            dtgv_materias.ClearSelection();
        }

        private void btn_asignarNotas_Click(object sender, EventArgs e)
        {
            if (dtgv_materias.SelectedRows.Count > 0)
            {
                Materia materia = (Materia)dtgv_materias.CurrentRow.DataBoundItem;

                FrmAsignarNota frmAsignarNota = new FrmAsignarNota(materia, _profesor);
                DialogResult respuesta = frmAsignarNota.ShowDialog();

                if (respuesta == DialogResult.OK)
                {
                    string texto = frmAsignarNota.Cambios ? "Se modificaron con exito" : "No se realizaron cambios";
                    MessageBox.Show(texto);
                    CargarDataGrid();
                }
                else if (respuesta == DialogResult.Cancel)
                {
                    MessageBox.Show("Se cancelo la operación");
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una materia");
            }
        }

        private void btn_crearExamen_Click(object sender, EventArgs e)
        {
            if (dtgv_materias.SelectedRows.Count > 0)
            {
                Materia materia = (Materia)dtgv_materias.CurrentRow.DataBoundItem;

                FrmCrearExamen frmExamen = new FrmCrearExamen();
                DialogResult respuesta = frmExamen.ShowDialog();

                if (respuesta == DialogResult.OK)
                {
                    Examen? examen = frmExamen.Examen;
                    bool boolean = examen is not null;

                    if (materia.PrimerExamenAsignado && boolean && _profesor.AgregarExamen(materia.CodigoMateria, EExamen.Primer) > 0)
                    {
                        MessageBox.Show("Primer examen asignado");

                    }
                    else if (materia.SegundoExamenAsignado && boolean && _profesor.AgregarExamen(materia.CodigoMateria, EExamen.Segundo) > 0)
                    {
                        MessageBox.Show("Segundo examen asignado");

                    }
                    else
                    {
                        MessageBox.Show("Tiene los dos examenes asignados");
                    }
                    CargarDataGrid();
                }
                else if (respuesta == DialogResult.Cancel)
                {
                    MessageBox.Show("Se cancelo la creacion del examen");
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una materia");
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
            this.BackColor = Color.FromArgb(134, 44, 132);
        }

        private void msi_cerrarSesion_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
    }
}

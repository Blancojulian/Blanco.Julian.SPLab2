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
    public partial class FrmElegirProfesor : Form
    {
        private Profesor? _profesor;
        private string _materia;

        public Profesor? Profesor { get => _profesor; }

        public FrmElegirProfesor(string materia)
        {
            _materia = materia;
            InitializeComponent();
        }

        private void FrmElegirProfesor_Load(object sender, EventArgs e)
        {
            ConfiguarForm();
            ConfigurarDataGrid();
            this.lbl_materia.Text = $"Asignar un profesores a la {_materia}";
            this.dtgv_profesores.DataSource = ClaseDAO.UsuarioDao.GetAll<Profesor>();
            this.dtgv_profesores.Columns["NivelUsuario"].HeaderText = "Tipo de usuario";
            this.dtgv_profesores.ClearSelection();
        }

        private void Refrescar()
        {
            dtgv_profesores.DataSource = ClaseDAO.UsuarioDao.GetAll<Profesor>();
            dtgv_profesores.Columns["NivelUsuario"].HeaderText = "Tipo de usuario";
            dtgv_profesores.Update();
            dtgv_profesores.Refresh();
            dtgv_profesores.ClearSelection();
        }
        

        private void btn_asignar_Click(object sender, EventArgs e)
        {
            if (dtgv_profesores.SelectedRows.Count > 0)
            {
                Profesor profesor = (Profesor)dtgv_profesores.SelectedRows[0].DataBoundItem;

                DialogResult respuesta = MessageBox.Show($"Esta seguro de asignar el profesor {profesor.Nombre} {profesor.Apellido} la materia {_materia}", "Confirmar", MessageBoxButtons.YesNo);

                if (respuesta == DialogResult.Yes)
                {
                    _profesor = profesor;
                    this.DialogResult = DialogResult.OK;


                }
                else if (respuesta == DialogResult.No)
                {
                    MessageBox.Show("Se cancelo la carga");

                }
                Refrescar();
            }
            else
            {
                MessageBox.Show("Tiene que seleccionar un profesor");

            }
        }

        private void ConfigurarDataGrid()
        {
            //selecciona toda la fila
            this.dtgv_profesores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //selecciona de a uno
            this.dtgv_profesores.MultiSelect = false;
            //cambia a solamente lectura
            this.dtgv_profesores.ReadOnly = true;
            //le saca la flechita que tiene al costado la fila
            this.dtgv_profesores.RowHeadersVisible = false;
            //ajusta el tamaño de las columnas para ocupar todo el data griw view
            this.dtgv_profesores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            this.dtgv_profesores.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            this.dtgv_profesores.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            //el usuario podra agregar filas o no
            this.dtgv_profesores.AllowUserToAddRows = false;


            dtgv_profesores.ClearSelection();


        }


        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void ConfiguarForm()
        {
            this.BackColor = Color.FromArgb(55, 94, 151);
        }
    }
}

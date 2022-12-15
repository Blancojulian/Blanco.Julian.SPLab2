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
    public partial class FrmEstadoAlumno : Form
    {
        
        private Admin _admin;
        private Materia _materia;
        private bool _cambios;

        public bool Cambios { get => _cambios; }

        public FrmEstadoAlumno(Admin admin, Materia materia)
        {
            InitializeComponent();
            this._admin = admin;
            this._materia = materia;
            _cambios = false;
            
        }

        private void FrmEstadoAlumno_Load(object sender, EventArgs e)
        {
            this.lbl_materia.Text = $"{_materia.CodigoMateria} - {_materia.Nombre}";

            this.cbx_estado.DataSource = Enum.GetValues( typeof(EEstadoAlumno) );
            this.cbx_estado.SelectedIndex = 0;

            ConfiguarForm();
            ConfigurarDataGrid();
            CargarDatagrid();
        }
        

        private void btn_confimar_Click(object sender, EventArgs e)
        {
           
            try
            {
                if (dtgv_alumnos.SelectedRows.Count > 0)
                {

                    string? nombre = dtgv_alumnos.SelectedRows[0].Cells["Nombre"].Value.ToString();
                    int dni = int.Parse(dtgv_alumnos.SelectedRows[0].Cells["DNI"].Value.ToString());
                    

                    EEstadoAlumno estado = (EEstadoAlumno)cbx_estado.SelectedValue;
                    Alumno? alumno = ClaseDAO.UsuarioDao.Get<Alumno>(dni);


                    if (alumno is not null)
                    {
                        DialogResult respuesta = MessageBox.Show($"Esta seguro de asignar la nota {estado} al alumno {nombre}", "Confirmar", MessageBoxButtons.YesNo);

                        if (respuesta == DialogResult.Yes)
                        {
                            if (this._admin.CambiarEstadoAlumno(this._materia.CodigoMateria, alumno.Dni, estado) > 0)
                            {
                                MessageBox.Show("Se cambio el estado");
                                _cambios = true;
                            }
                            else
                            {
                                MessageBox.Show("FALLO al cargar la nota");

                            }
                            CargarDatagrid();


                        }
                        else if (respuesta == DialogResult.No)
                        {
                            MessageBox.Show("Se cancelo la carga");

                        }

                    }


                }
                else
                {
                    MessageBox.Show("Tiene que seleccionar una persona");

                }
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Ingrese un numero valido\n");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Refrescar()
        {
            dtgv_alumnos.Update();
            dtgv_alumnos.Refresh();
            dtgv_alumnos.ClearSelection();
        }
        private void CargarDatagrid()
        {
            List<EstadoAlumno> listaAlumnos = ClaseDAO.MateriaDao.GetAll(_materia.CodigoMateria);

            dtgv_alumnos.DataSource = listaAlumnos;

            dtgv_alumnos.Columns["PrimerExamen"].Visible = false;
            dtgv_alumnos.Columns["SegundoExamen"].Visible = false;

            dtgv_alumnos.Columns["NotaPrimerExamen"].HeaderText = "Nota Primer Examen";
            dtgv_alumnos.Columns["NotaSegundoExamen"].HeaderText = "Nota Segundo Examen";

            

            Refrescar();
        }

        private void ConfigurarDataGrid()
        {
            //selecciona toda la fila
            this.dtgv_alumnos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //selecciona de a uno
            this.dtgv_alumnos.MultiSelect = false;
            //cambia a solamente lectura
            this.dtgv_alumnos.ReadOnly = true;
            //le saca la flechita que tiene al costado la fila
            this.dtgv_alumnos.RowHeadersVisible = false;
            //ajusta el tamaño de las columnas para ocupar todo el data griw view
            this.dtgv_alumnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //el contenido se ajusta a la celda
            this.dtgv_alumnos.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            //ver bien que hacer si pasa la cantidad que entra
            this.dtgv_alumnos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            //el usuario podra agregar filas o no
            this.dtgv_alumnos.AllowUserToAddRows = false;


            dtgv_alumnos.ClearSelection();


        }

        
        

        private void dtgv_alumnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgv_alumnos.SelectedRows.Count > 0)
            {


                EEstadoAlumno estado;
                if (Enum.TryParse<EEstadoAlumno>(dtgv_alumnos.SelectedRows[0].Cells["Estado Alumno"].Value.ToString(), out estado))
                {
                    cbx_estado.SelectedItem = estado;
                }
                else
                {
                    MessageBox.Show("fallo al parsear el estado");
                }
            }
        }
        private void ConfiguarForm()
        {
            this.BackColor = Color.FromArgb(55, 94, 151);
        }

    }
}

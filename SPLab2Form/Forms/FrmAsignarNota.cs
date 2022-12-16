using BibliotecaEntidades.Clases;
using BibliotecaEntidades.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPLab2Form.Forms
{
    public partial class FrmAsignarNota : Form
    {
        private Materia _materia;
        private Profesor _profesor;
        private bool _cambios;

        public bool Cambios { get => _cambios; }

        public FrmAsignarNota(Materia materia, Profesor profesor)
        {
            _materia = materia;
            _profesor = profesor;
            _cambios = false;
            InitializeComponent();

        }

        private void FrmAsignarNota_Load(object sender, EventArgs e)
        {
            btn_asignarNota.Enabled = false;

            ConfiguarForm();
            ConfigurarComboBox();
            ConfigurarDataGrid();
            CargarDatagrid();
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

            this.dtgv_alumnos.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            //ver bien que hacer si pasa la cantidad que entra
            this.dtgv_alumnos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            //el usuario podra agregar filas o no
            this.dtgv_alumnos.AllowUserToAddRows = false;


            dtgv_alumnos.ClearSelection();


        }

        private void ConfigurarComboBox()
        {
            cbx_examen.DataSource = Enum.GetValues(typeof(EExamen));
            cbx_examen.SelectedIndex = 0;
        }

        private void btn_asignarNota_Click(object sender, EventArgs e)
        {
           
            try
            {
                if (dtgv_alumnos.SelectedRows.Count > 0)
                {
                    
                    string? nombre = dtgv_alumnos.SelectedRows[0].Cells["Nombre"].Value.ToString();
                    int dni = int.Parse(dtgv_alumnos.SelectedRows[0].Cells["DNI"].Value.ToString());
                    int nota = int.Parse(tbx_nota.Text);
                    EExamen examen = (EExamen)cbx_examen.SelectedItem;
                    Alumno? alumno = ClaseDAO.UsuarioDao.Get<Alumno>(dni);//(Alumno?)Sistema.Usuarios.Get(dni);


                    if( nota >= 1 && nota <= 10 && alumno is not null)
                    {
                        DialogResult respuesta = MessageBox.Show($"Esta seguro de asignar nota {tbx_nota.Text} al alumno {nombre}", "Confirmar", MessageBoxButtons.YesNo);

                        if (respuesta == DialogResult.Yes)
                        {
                            if (_profesor.AgregarNota(_materia.CodigoMateria, alumno.Dni, examen, nota) > 0)
                            {
                                MessageBox.Show("Se cargo la nota");
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
                MessageBox.Show("Es null exception: " + ex.Message);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Ingrese un numero valido");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        


        private void tbx_nota_TextChanged(object sender, EventArgs e)
        {
            btn_asignarNota.Enabled = true;
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void ConfiguarForm()
        {
            this.BackColor = Color.FromArgb(134, 44, 132);
        }
    }
}

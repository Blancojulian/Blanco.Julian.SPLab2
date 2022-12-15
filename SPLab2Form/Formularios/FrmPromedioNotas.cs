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
    public partial class FrmPromedioNotas : Form
    {
        public FrmPromedioNotas()
        {
            InitializeComponent();
        }

        private void FrmPromedioNotas_Load(object sender, EventArgs e)
        {
            ConfiguarForm();
            ConfigurarDataGrid();
            Refrescar();
        }

        private void Refrescar()
        {
            CargarDataGridView();
            dtgv_promedios.Update();
            dtgv_promedios.Refresh();
            dtgv_promedios.ClearSelection();
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CargarDataGridView()
        {
            Dictionary<Materia, string> lista = CalcularPromediosAlumnos();
            DataTable dt = new DataTable();

            dt.Columns.Add("Materia");
            dt.Columns.Add("Promedios Alumnos");

            foreach (KeyValuePair<Materia, string> item in lista)
            {
           
                dt.Rows.Add($"{item.Key.CodigoMateria} - {item.Key.Nombre}", item.Value);
            }

            dtgv_promedios.DataSource = dt;
        }

        private Dictionary<Materia, string> CalcularPromediosAlumnos()
        {
            
            List<Materia> listaMateria = Sistema.Materias.GetLista;
            Dictionary<Materia, string> promedios = new Dictionary<Materia, string>();

            foreach (var materia in listaMateria)
            {
                var sb = new StringBuilder();
                foreach (var alumno in materia.ListaAlumnos)
                {

                    float promedio = Materia.CalcularNotaPromedio(materia, alumno.Key);
                    sb.Append($"{alumno.Key.Apellido} {alumno.Key.Apellido} promedio: {promedio} ");
                    if (alumno.Value.PrimerExamen.Rendido && alumno.Value.SegundoExamen.Rendido)
                    {
                        sb.AppendLine("rindio 2 parciales");

                    }
                    else if (alumno.Value.PrimerExamen.Rendido)
                    {
                        sb.AppendLine("rindio solo el primer parcial");

                    }
                    else
                    {
                        sb.AppendLine("no rindio los parciales");

                    }

                }
                promedios.Add(materia, sb.ToString());
            }

            return promedios;
        }

        private void ConfigurarDataGrid()
        {
            //selecciona toda la fila
            this.dtgv_promedios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //selecciona de a uno
            this.dtgv_promedios.MultiSelect = false;
            //cambia a solamente lectura
            this.dtgv_promedios.ReadOnly = true;
            //le saca la flechita que tiene al costado la fila
            this.dtgv_promedios.RowHeadersVisible = false;
            //ajusta el tamaño de las columnas para ocupar todo el data griw view
            this.dtgv_promedios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            this.dtgv_promedios.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            this.dtgv_promedios.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            //el usuario podra agregar filas o no
            this.dtgv_promedios.AllowUserToAddRows = false;


            dtgv_promedios.ClearSelection();


        }

        private void ConfiguarForm()
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ControlBox = false;
            this.ShowIcon = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Color.FromArgb(55, 94, 151);
        }
    }
}

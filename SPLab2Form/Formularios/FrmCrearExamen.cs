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
    public partial class FrmCrearExamen : Form
    {
        private Examen? _examen;

        public Examen? Examen { get => _examen; }

        public FrmCrearExamen()
        {
            InitializeComponent();
        }

        private void FrmCrearExamen_Load(object sender, EventArgs e)
        {
            ConfiguarForm();
            DateTime fechaHoy = DateTime.Today;
            DateTime fechaMax = fechaHoy.AddMonths(1);
            dtp_fecha.MinDate = fechaHoy;
            dtp_fecha.MaxDate = fechaMax;

            dtp_fecha.Format = DateTimePickerFormat.Custom;
            dtp_fecha.CustomFormat = "dd/MM/yyyy";


        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            DateTime fecha = dtp_fecha.Value;

            if (!string.IsNullOrWhiteSpace(tbx_nombre.Text) &&
                dtp_fecha.Checked)
            {
                _examen = new Examen(tbx_nombre.Text, fecha);
                this.DialogResult = DialogResult.OK;
                this.Close();
                

            }
            else
            {
                MessageBox.Show("Debe completar el campo nombre y seleccionar una fecha");
            }
        }

        private void ConfiguarForm()
        {
            this.BackColor = Color.FromArgb(134, 44, 132);
        }
    }
}

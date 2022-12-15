using BibliotecaEntidades.Clases;
using BibliotecaEntidades.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPLab2Form.Forms
{
    public partial class FrmCrearMateria : Form
    {
        private Materia _materia;
        public FrmCrearMateria()
        {
            InitializeComponent();
        }

        private void chbx_materiaCorrelativa_CheckedChanged(object sender, EventArgs e)
        {
            if (chbx_materiaCorrelativa.Checked)
            {
                int materiaCorrelativa;
                

                this.cbx_materiaCorrelativa.Enabled = true;
                if(int.TryParse(this.cbx_materiaCorrelativa.Text, out materiaCorrelativa))
                {
                    Materia? materia = ClaseDAO.MateriaDao.Get(materiaCorrelativa);//Sistema.Materias.Get(materiaCorrelativa);
                
                    if (materia is not null)
                    {
                        this.lbl_materiaCorrelativa.Text = "Materia Correlativa: " + materia.Nombre;
                    }
                }
            }
            else
            {
                this.cbx_materiaCorrelativa.Enabled = false;
                this.lbl_materiaCorrelativa.Text = "Materia Correlativa";
            }
        }

        private void FrmCrearMateria_Load(object sender, EventArgs e)
        {
            List<Materia> materias = ClaseDAO.MateriaDao.GetAll();//Sistema.Materias.GetLista;

            if (materias.Count > 0)
            {
                this.cbx_materiaCorrelativa.Enabled = false;
            }
            ConfiguarForm();
            CargarComboBoxs();
        }

        private void CargarComboBoxs()
        {
            List<Materia> materias = ClaseDAO.MateriaDao.GetAll();//Sistema.Materias.GetLista;
            List<int> codigosMaterias = new List<int>();

            foreach (Materia materia in materias)
            {
                codigosMaterias.Add(materia.CodigoMateria);
            }
            
            this.cbx_materiaCorrelativa.DataSource = codigosMaterias;
            this.cbx_materiaCorrelativa.SelectedIndex = 0;

            this.cbx_cuatrimestre.DataSource = Enum.GetValues(typeof(ECuatrimestre));
            this.cbx_materiaCorrelativa.SelectedIndex = 0;

        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            int codigo;
            int materiaCorrelativa;
            ECuatrimestre cuatrimestre = (ECuatrimestre)cbx_cuatrimestre.SelectedItem;

            if (!string.IsNullOrWhiteSpace(tbx_nombre.Text) &&
                !string.IsNullOrWhiteSpace(tbx_codigo.Text))
            {
                if (int.TryParse(this.tbx_codigo.Text, out codigo))
                {
                    Materia? materia = ClaseDAO.MateriaDao.Get(codigo);//Sistema.Materias.Get(codigo);
                    bool error = false;
                    if(materia is not null)
                    {
                        error = true;
                        MessageBox.Show($"ERROR, el codigo materia {codigo} corresponde a la materia {materia.Nombre}");
                    }

                    if (!error && this.chbx_materiaCorrelativa.Checked && int.TryParse(this.cbx_materiaCorrelativa.Text, out materiaCorrelativa))
                    {
                        this._materia = new Materia(codigo, tbx_nombre.Text, cuatrimestre.ToString(), materiaCorrelativa,false, false);
                        DialogResult = DialogResult.OK;
                    }
                    else if (!error && !this.chbx_materiaCorrelativa.Checked)
                    {
                        this._materia = new Materia(codigo, tbx_nombre.Text, cuatrimestre.ToString(), false, false);
                        DialogResult = DialogResult.OK;
                    }
                }
                else
                {
                    MessageBox.Show("Codigo invalido");
                }

            }
            else
            {
                MessageBox.Show("Debe completar todos campos");
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        private void cbx_materiaCorrelativa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chbx_materiaCorrelativa.Checked)
            {
                int materiaCorrelativa;

                if (int.TryParse(this.cbx_materiaCorrelativa.Text, out materiaCorrelativa))
                {
                    Materia? materia = ClaseDAO.MateriaDao.Get(materiaCorrelativa);

                    if (materia is not null)
                    {
                        this.lbl_materiaCorrelativa.Text = "Materia Correlativa: " + materia.Nombre;
                    }
                }
            }
        }

        private void ConfiguarForm()
        {
            this.BackColor = Color.FromArgb(55, 94, 151);
        }

        public Materia Materia { get { return this._materia; } }

        
    }
}

using BibliotecaEntidades.Clases;
using BibliotecaEntidades.DAO;

namespace SPLab2Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //selecciona toda la fila
            this.dtgv_usuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //selecciona de a uno
            this.dtgv_usuarios.MultiSelect = false;
            //cambia a solamente lectura
            this.dtgv_usuarios.ReadOnly = true;
            //le saca la flechita que tiene al costado la fila
            this.dtgv_usuarios.RowHeadersVisible = false;
            //ajusta el tamaño de las columnas para ocupar todo el data griw view
            this.dtgv_usuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //List<Profesor> lista = (Profesor)UsuarioDao.GetAll<Profesor>();
            List<Usuario> lista = new List<Usuario>();
            lista.Add(new Profesor(0, "no funciona", "hola", 1234));
            this.dtgv_usuarios.DataSource = new List<Usuario>() { UsuarioDao<Usuario>.Get(1) };

            //dtgv_usuarios.Columns["CantidadMaterias"].DisplayIndex = dtgv_usuarios.Columns.Count - 1;

            dtgv_usuarios.ClearSelection();
        }

        private void Refrescar()
        {
            dtgv_usuarios.DataSource = UsuarioDao<Alumno>.GetAll();
            dtgv_usuarios.Update();
            dtgv_usuarios.Refresh();

            dtgv_usuarios.ClearSelection();
            //this.btn_click.Enabled = false;


        }
    }
}
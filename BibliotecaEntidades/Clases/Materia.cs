using BibliotecaEntidades.DAO;
using BibliotecaEntidades.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BibliotecaEntidades.Clases
{
    public class Materia
    {
        private int? _id;
        private int _codigoMateria;
        private string _nombre;
        private string _cuatrimestre;
       
        private bool _primerExamenAsignado;
        private bool _segundoExamenAsignado;

        private int _materiaCorrelativa;

        public Materia(int id, int codigoMateria, string nombre, string cuatrimestre, int idMateriaCorrelativa, bool primerExamen, bool segundoExamen)
        {
            this._id = id;
            this._codigoMateria = codigoMateria;
            this._nombre = nombre.ToLower() ?? throw new ArgumentNullException(nameof(nombre));
            this._cuatrimestre = cuatrimestre.ToLower() ?? throw new ArgumentNullException(nameof(cuatrimestre));
            this._materiaCorrelativa = idMateriaCorrelativa;
            
        }


        public Materia(int id, int codigoMateria, string nombre, string cuatrimestre, bool primerExamen, bool segundoExamen) : this(id, codigoMateria, nombre, cuatrimestre, 0, primerExamen, segundoExamen)
        {
        }
        public Materia(int codigoMateria, string nombre, string cuatrimestre, int idMateriaCorrelativa, bool primerExamen, bool segundoExamen) : this(0, codigoMateria, nombre, cuatrimestre, idMateriaCorrelativa, primerExamen, segundoExamen)
        {

        }
        public Materia(int codigoMateria, string nombre, string cuatrimestre, bool primerExamen, bool segundoExamen) : this(0, codigoMateria, nombre, cuatrimestre, 0, primerExamen, segundoExamen)
        {

        }

        public static explicit operator Materia(SqlDataReader r)
        {
            Materia m = new Materia(
                Convert.ToInt32(r["id"]),
                Convert.ToInt32(r["codigo_materia"]),
                r["nombre"].ToString() ?? "",
                r["cuatrimestre"].ToString() ?? "",
                Convert.ToInt32(r["id_materia_correlativa"]),
                Convert.ToBoolean(r["primer_parcial_asignado"]),
                Convert.ToBoolean(r["segundo_parcial_asignado"])
                );

            return m;
        }
        
        public int CodigoMateria { get { return this._codigoMateria; } }

        public int MateriaCorrelativa { get { return this._materiaCorrelativa; } }

        public string Nombre { get { return this._nombre; } }

        public string Cuatrimestre { get { return this._cuatrimestre; } }

        
        public int? Id { get => _id; set => _id = value; }
        public string MostrarPrimerExamenAsignado { get => _primerExamenAsignado ? "Asignado" : "No asignado"; }
        public string MostrarSegundoExamenAsignado { get => _segundoExamenAsignado ? "Asignado" : "No asignado"; }

        public string MostrarMateriaCorrelativa
        {
            get
            {
                string retorno = "No tiene materia correlativa";
                Materia? m;

                if (MateriaCorrelativa > 0 && (m = ClaseDAO.MateriaDao.Get(MateriaCorrelativa)) is not null)
                {
                    retorno = m.Nombre;
                }

                return retorno;
            }
        }
        public string Alumnos
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                List<EstadoAlumno> lista = ClaseDAO.MateriaDao.GetAll(this.CodigoMateria);

                for (int i = 0; i < lista.Count; i++)
                {
                    if (lista.Count - 1 == i)
                    {
                        sb.Append($"{lista[i].NombreCompleto}.");
                    }
                    else
                    {
                        sb.Append($"{lista[i].NombreCompleto}, ");
                    }
                }

                if (string.IsNullOrEmpty(sb.ToString()))
                {
                    sb.Append("No tiene alumnos inscriptos");
                }

                return sb.ToString();
            }
        }

        public string Profesores
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                List<Profesor> lista = ClaseDAO.MateriaDao.GetAllProfesores(this.CodigoMateria);

                for (int i = 0; i < lista.Count; i++)
                {
                    if (lista.Count - 1 == i)
                    {
                        sb.Append($"{lista.ElementAt(i).ToString()}.");
                    }
                    else
                    {
                        sb.Append($"{lista.ElementAt(i).ToString()}, ");
                    }
                }

                if (string.IsNullOrEmpty(sb.ToString()))
                {
                    sb.Append("No tiene profesores asigandos");
                }

                return sb.ToString();
            }
        }

        public bool SegundoExamenAsignado { get => _segundoExamenAsignado; set => _segundoExamenAsignado = value; }
        public bool PrimerExamenAsignado { get => _primerExamenAsignado; set => _primerExamenAsignado = value; }
    }
}

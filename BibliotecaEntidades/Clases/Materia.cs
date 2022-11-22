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
        int _id;
        private int _codigoMateria;
        private string _nombre;
        private string _cuatrimestre;
        private List<int> _profesores;
        private Dictionary<Alumno, EstadoAlumno> _alumnos;
        private Dictionary<int, EstadoAlumno> _estadosAlumnos;
        private Examen _primerExamen;
        private Examen _segundoExamen;


        private List<Examen> _examenes;
        private int _materiaCorrelativa;

        public Materia(int id, int codigoMateria, string nombre, string cuatrimestre, int idMateriaCorrelativa)
        {
            if (codigoMateria < 0)
            {
                codigoMateria = 1;
            }
            this._id = id;
            this._codigoMateria = codigoMateria;
            this._nombre = nombre.ToLower() ?? throw new ArgumentNullException(nameof(nombre));
            this._cuatrimestre = cuatrimestre.ToLower() ?? throw new ArgumentNullException(nameof(cuatrimestre));
            this._materiaCorrelativa = idMateriaCorrelativa;
            this._profesores = new List<int>();
            this._alumnos = new Dictionary<Alumno, EstadoAlumno>();
            this._examenes = new List<Examen>();
        }

        public Materia(int id, int codigoMateria, string nombre, string cuatrimestre) : this(id, codigoMateria, nombre, cuatrimestre, 0)
        {
        }
        public Materia(int codigoMateria, string nombre, string cuatrimestre, int idMateriaCorrelativa) : this(0, codigoMateria, nombre, cuatrimestre, idMateriaCorrelativa)
        {

        }

        public static explicit operator Materia(SqlDataReader r)
        {
            Materia m = new Materia(
                Convert.ToInt32(r["id"]),
                Convert.ToInt32(r["codigo_materia"]),
                r["nombre"].ToString() ?? "",
                r["cuatrimestre"].ToString() ?? "",
                Convert.ToInt32(r["id_materia_correlativa"])
                );

            return m;
        }
        public static bool operator ==(Materia m1, Materia m2)
        {
            bool retorno = false;

            if (m1.CodigoMateria == m2.CodigoMateria)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Materia m1, Materia m2)
        {
            return !(m1 == m2);
        }


        public static bool operator ==(Materia m, Alumno a)
        {
            bool retorno = false;

            foreach (KeyValuePair<Alumno, EstadoAlumno> alumno in m._alumnos)
            {
                if (alumno.Key == a)
                {
                    retorno = true;
                    break;
                }
            }

            return retorno;
        }

        public static bool operator !=(Materia m, Alumno a)
        {
            return !(m == a);
        }

        public static bool operator +(Materia m, Alumno a)
        {
            bool retorno = false;

            if (m != a)
            {

                if (m.MateriaCorrelativa == 0 || a == m.MateriaCorrelativa)
                {
                    m._alumnos.Add(a, new EstadoAlumno());
                    retorno = true;
                }

            }

            return retorno;
        }

        public static bool operator ==(Materia m, Profesor p)
        {
            bool retorno = false;

            foreach (int profesor in m._profesores)
            {
                if (profesor == p.Id)
                {
                    retorno = true;
                    break;
                }
            }

            return retorno;
        }

        public static bool operator !=(Materia m, Profesor p)
        {
            return !(m == p);
        }

        public static bool operator +(Materia m, Profesor p)
        {
            bool retorno = false;

            if (m != p && p + m)
            {
                m._profesores.Add(p.Id);
                retorno = true;
            }

            return retorno;
        }

        public static bool operator ==(Materia m, Examen e)
        {
            bool retorno = false;

            foreach (Examen examen in m._examenes)
            {
                if (examen == e)
                {
                    retorno = true;
                    break;
                }
            }

            return retorno;
        }

        public static bool operator !=(Materia m, Examen e)
        {
            return !(m == e);
        }

        public static bool operator +(Materia m, Examen e)
        {
            bool retorno = false;

            if (m != e)
            {
                m._examenes.Add(e);
                retorno = true;
            }

            return retorno;
        }
        public static bool DarNota(Materia m, Profesor p, Alumno a, bool primerExamen, int nota)
        {
            bool retorno = false;

            if (m == p)
            {
                foreach(KeyValuePair<int, EstadoAlumno>alumno in m._estadosAlumnos)
                {
                    if (alumno.Key == a.Id )
                    {
                        if (alumno.Value.PrimerExamen != null && primerExamen)
                        {
                            alumno.Value.PrimerExamen.Nota = nota;
                            retorno = true;
                            break;

                        }
                        if (alumno.Value.SegundoExamen != null && !primerExamen)
                        {
                            alumno.Value.PrimerExamen.Nota = nota;
                            retorno = true;
                            break;

                        }
                    }
                }
                
            }


            return retorno;
        }
        public static bool DarAsistencia(Materia m, Alumno a)
        {
            bool retorno = false;

            foreach (KeyValuePair<Alumno, EstadoAlumno> alumno in m._alumnos)
            {
                if (alumno.Key == a)
                {
                    alumno.Value.Asistencia = true;
                    retorno = true;
                    break;
                }
            }

            return retorno;
        }

        public static EstadoAlumno? GetEstado(Materia m, Alumno a)
        {

            EstadoAlumno? estado = null;

            foreach (KeyValuePair<Alumno, EstadoAlumno> alumno in m._alumnos)
            {
                if (alumno.Key == a)
                {
                    estado = alumno.Value;
                    break;
                }
            }

            return estado;
        }
        public static EEstadoMateria GetEstadoMateriaAlumno(Materia m, Alumno a)
        {
            EEstadoMateria estado = EEstadoMateria.Cursando;

            foreach (KeyValuePair<Alumno, EstadoAlumno> alumno in m._alumnos)
            {
                if (alumno.Key == a)
                {
                    estado = alumno.Value.EstadoMateria;
                    break;
                }
            }

            return estado;
        }

        public static bool SetEstadoMateriaAlumno(Materia m, Alumno a, EEstadoMateria estado)
        {
            bool retorno = false;

            foreach (KeyValuePair<Alumno, EstadoAlumno> alumno in m._alumnos)
            {
                if (alumno.Key == a)
                {
                    alumno.Value.EstadoMateria = estado;
                    retorno = true;
                    break;
                }
            }

            return retorno;
        }

        public static EEstadoAlumno GetEstadoAlumno(Materia m, Alumno a)
        {
            //ver
            EEstadoAlumno estado = EEstadoAlumno.Regular;

            foreach (KeyValuePair<Alumno, EstadoAlumno> alumno in m._alumnos)
            {
                if (alumno.Key == a)
                {
                    estado = alumno.Value.Estado;
                    break;
                }
            }

            return estado;
        }

        public static bool SetEstadoAlumno(Materia m, Alumno a, EEstadoAlumno estado)
        {
            bool retorno = false;

            foreach (KeyValuePair<Alumno, EstadoAlumno> alumno in m._alumnos)
            {
                if (alumno.Key == a)
                {
                    alumno.Value.Estado = estado;
                    retorno = true;
                    break;
                }
            }

            return retorno;
        }
        public int CodigoMateria { get { return this._codigoMateria; } }

        public int MateriaCorrelativa { get { return this._materiaCorrelativa; } }

        public string Nombre { get { return this._nombre; } }

        public string Cuatrimestre { get { return this._cuatrimestre; } }

        public Dictionary<int, EstadoAlumno> EstadosAlumnos { get => _estadosAlumnos; set => _estadosAlumnos = value; }
    }
}

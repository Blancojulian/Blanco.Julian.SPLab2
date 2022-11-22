using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaEntidades.Clases
{
    
    public class EstadoAlumno
    {
        private EEstadoMateria _estadoMateria;
        private bool _asistencia;
        private EEstadoAlumno _estadoAlumno;
        private Examen? _primerExamen;
        private Examen? _segundoExamen;


        public EstadoAlumno(EEstadoMateria estadoMateria, bool asistencia, EEstadoAlumno estadoAlumno)
        {
            this._estadoMateria = estadoMateria;
            this._asistencia = asistencia;
            this._estadoAlumno = estadoAlumno;
        }

        public EstadoAlumno() : this(EEstadoMateria.Cursando, false, EEstadoAlumno.Regular)
        {

        }

        private EstadoAlumno(EEstadoMateria estadoMateria, bool asistencia, EEstadoAlumno estadoAlumno, Examen? primerExamen, Examen? segundoExamen) : this(estadoMateria, asistencia, estadoAlumno)
        {
            PrimerExamen = primerExamen ?? null;
            SegundoExamen = segundoExamen ?? null;
        }

        public static explicit operator EstadoAlumno(SqlDataReader r)
        {
            return new EstadoAlumno(
                (EEstadoMateria)Convert.ToInt32(r["id_estado_materia"]), 
                Convert.ToBoolean(r["asistencia"]), 
                (EEstadoAlumno)Convert.ToInt32(r["id_estado_alumno"]), (Examen)r, (Examen)r);
        }
        public EEstadoAlumno Estado
        {
            get { return this._estadoAlumno; }
            set { this._estadoAlumno = value; }
        }

        public EEstadoMateria EstadoMateria
        {
            get { return this._estadoMateria; }
            set
            {
                if (this._estadoMateria == EEstadoMateria.Aprobada && value != EEstadoMateria.Aprobada)
                {
                    value = EEstadoMateria.Aprobada;
                }
                this._estadoMateria = value;
            }
        }

        public bool Asistencia
        {
            get { return this._asistencia; }
            set { this._asistencia = value; }
        }

        public Examen? PrimerExamen { get => _primerExamen; set => _primerExamen ??= value; }
        public Examen? SegundoExamen { get => _segundoExamen; set => _segundoExamen ??= value; }
    }
}

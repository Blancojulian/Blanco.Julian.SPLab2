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
        private string? _nombreCompleto;
        private string? _nombreMateria;
        private EEstadoMateria _estadoMateria;
        private bool _asistencia;
        private EEstadoAlumno _estadoAlumno;
        private EstadoExamen _primerExamen;
        private EstadoExamen _segundoExamen;

        public EstadoAlumno(EEstadoMateria estadoMateria, bool asistencia, EEstadoAlumno estadoAlumno,
            int notaPrimerExamen, bool rendidoPrimerParcial,
            int notaSegundoExamen, bool rendidoSegundoParcial,
            string nombreMateria, string nombreCompleto)
        {
            this._estadoMateria = estadoMateria;
            this._asistencia = asistencia;
            this._estadoAlumno = estadoAlumno;
            _primerExamen = new EstadoExamen(notaPrimerExamen, rendidoPrimerParcial);
            _segundoExamen = new EstadoExamen(notaSegundoExamen, rendidoSegundoParcial);
            _nombreMateria = nombreMateria;
            _nombreCompleto = nombreCompleto;
        }
        public EstadoAlumno(EEstadoMateria estadoMateria, bool asistencia, EEstadoAlumno estadoAlumno,
            int notaPrimerExamen, bool rendidoPrimerParcial,
            int notaSegundoExamen, bool rendidoSegundoParcial)
        {
            this._estadoMateria = estadoMateria;
            this._asistencia = asistencia;
            this._estadoAlumno = estadoAlumno;
            _primerExamen = new EstadoExamen(notaPrimerExamen, rendidoPrimerParcial);
            _segundoExamen = new EstadoExamen(notaSegundoExamen, rendidoSegundoParcial);
        }
        public EstadoAlumno() : this(EEstadoMateria.Cursando, false, EEstadoAlumno.Regular, 0, false, 0, false)
        {
           
        }
        

        public static explicit operator EstadoAlumno(SqlDataReader r)
        {
            return new EstadoAlumno((EEstadoMateria)Convert.ToInt32(r["id_estado_materia"]), Convert.ToBoolean(r["asistencia"]), 
                (EEstadoAlumno)Convert.ToInt32(r["id_estado_alumno"]), Convert.ToInt32(r["primer_nota"]),
                Convert.ToBoolean(r["primero_rendido"]), Convert.ToInt32(r["segunda_nota"]), Convert.ToBoolean(r["segundoo_rendido"]),
                r["nombre_materia"].ToString() ?? "", r["nombre_completo"].ToString() ?? "");
        }

        public string? NombreCompleto { get => _nombreCompleto ?? "Sin asignar"; set => _nombreCompleto = value; }
        public string? NombreMateria { get => _nombreMateria ?? "Sin asignar"; set => _nombreMateria = value; }
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

        public EstadoExamen PrimerExamen { get => _primerExamen; set => _primerExamen ??= value; }
        public EstadoExamen SegundoExamen { get => _segundoExamen; set => _segundoExamen ??= value; }

        public string NotaPrimerExamen { 
            get
            {
                string retorno = "Sin rendir";
                if (PrimerExamen.Rendido)
                {
                    retorno = $"{PrimerExamen.Nota}";
                }
                return retorno;
            } 
        }
        public string NotaSegundoExamen
        {
            get
            {
                string retorno = "Sin rendir";
                if (SegundoExamen.Rendido)
                {
                    retorno = $"{SegundoExamen.Nota}";
                }
                return retorno;
            }
        }

    }
}

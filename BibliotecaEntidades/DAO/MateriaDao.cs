using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaEntidades.Clases;
using BibliotecaEntidades.Interfaces;

namespace BibliotecaEntidades.DAO
{
    public class MateriaDao : BaseDAO, IClaseDAO<Materia>, IEstadoEnMateriaDAO
    {
        
        public MateriaDao() : base()
        {
        }
        public List<Materia> GetAll()
        {
            List<Materia> datos = new List<Materia>();

            try
            {
                _sqlCommand.CommandText = "SELECT * FROM materias";
                _sqlConnection.Open();

                using (SqlDataReader dataReader = _sqlCommand.ExecuteReader())
                {
                    while (dataReader.Read())
                    {

                        datos.Add((Materia)dataReader);

                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (_sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    _sqlConnection.Close();
                }
            }

            return datos;
        }
        public Materia? Get(int codigoMateria)
        {
            Materia? materia = null;

            try
            {
                _sqlCommand.Parameters.Clear();

                _sqlCommand.CommandText = "SELECT * FROM materias WHERE codigo_materia = @codigoMateria";

                _sqlCommand.Parameters.AddWithValue("@codigoMateria", codigoMateria);

                _sqlConnection.Open();

                using (SqlDataReader dataReader = _sqlCommand.ExecuteReader())
                {
                    if (dataReader.Read())
                    {
                        materia = (Materia)dataReader;
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (_sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    _sqlConnection.Close();
                }
            }

            return materia;
        }
        public int Add(Materia datos)
        {
            int filas = 0;
            try
            {
                _sqlCommand.Parameters.Clear();

                _sqlConnection.Open();

                _sqlCommand.CommandText = "INSERT INTO materias VALUES" +
                    "(@nombre, @cuatrimestre, @codigo_materia, @id_materia_correlativa)";

                _sqlCommand.Parameters.AddWithValue("@nombre", datos.Nombre);
                _sqlCommand.Parameters.AddWithValue("@cuatrimestre", datos.Cuatrimestre);
                _sqlCommand.Parameters.AddWithValue("@codigo_materia", datos.CodigoMateria);
                _sqlCommand.Parameters.AddWithValue("@id_materia_correlativa", datos.MateriaCorrelativa);

                filas = _sqlCommand.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (_sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    _sqlConnection.Close();
                }
            }

            return filas;
        }

        public int Update(int id, Materia datos)
        {
            int filas = 0;
            try
            {
                _sqlCommand.Parameters.Clear();

                _sqlConnection.Open();
                //(nombre, apellido, dni, id_nivel_usuario)
                _sqlCommand.CommandText = "UPDATE materias SET nombre = @nombre, " +
                    "cuatrimestre = @cuatrimestre, codigo_materia = @codigo_materia, " +
                    "id_materia_correlativa = @id_materia_correlativa WHERE id = @id";

                _sqlCommand.Parameters.AddWithValue("@nombre", datos.Nombre);
                _sqlCommand.Parameters.AddWithValue("@cuatrimestre", datos.Cuatrimestre);
                _sqlCommand.Parameters.AddWithValue("@codigo_materia", datos.CodigoMateria);
                _sqlCommand.Parameters.AddWithValue("@id_materia_correlativa", datos.MateriaCorrelativa);
                _sqlCommand.Parameters.AddWithValue("@id", id);

                filas = _sqlCommand.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (_sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    _sqlConnection.Close();
                }
            }

            return filas;
        }

        public int Delete(int id)
        {
            int filas = 0;
            try
            {
                _sqlCommand.Parameters.Clear();

                _sqlConnection.Open();

                _sqlCommand.CommandText = "DELETE FROM materias WHERE id = @id";

                _sqlCommand.Parameters.AddWithValue("@id", id);

                filas = _sqlCommand.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (_sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    _sqlConnection.Close();
                }
            }

            return filas;
        }


        //metodos estado alumno

        public List<EstadoAlumno> GetAll(int codigoMateria)
        {
            List<EstadoAlumno> datos = new List<EstadoAlumno>();

            try
            {
                _sqlCommand.Parameters.Clear();

                _sqlCommand.CommandText = "SELECT e.*, m.nombre AS nombre_materia, CONCAT(u.apellido, ' ', u.nombre) AS nombre_completo" +
                    "FROM estado_alumno_en_materia AS e" +
                    "INNER JOIN usuarios AS u ON e.id_alumno = u.id_usuario" +
                    "INNER JOIN materias AS m ON e.id_materia = m.id_materia" +
                    "WHERE m.codigo_materia = @codigoMateria";

                _sqlCommand.Parameters.AddWithValue("@codigoMateria", codigoMateria);

                _sqlConnection.Open();

                using (SqlDataReader dataReader = _sqlCommand.ExecuteReader())
                {
                    while (dataReader.Read())
                    {

                        datos.Add((EstadoAlumno)dataReader);

                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (_sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    _sqlConnection.Close();
                }
            }

            return datos;
        }

        public EstadoAlumno? Get(int codigoMateria, int dniAlumno)
        {
            EstadoAlumno? datos = null;

            try
            {
                _sqlCommand.Parameters.Clear();

                _sqlCommand.CommandText = "SELECT e.*, m.nombre AS nombre_materia, CONCAT(u.apellido, ' ', u.nombre) AS nombre_completo" +
                    "FROM estado_alumno_en_materia AS e" +
                    "INNER JOIN usuarios AS u ON e.id_alumno = u.id_usuario" +
                    "INNER JOIN materias AS m ON e.id_materia = m.id_materia" +
                    "WHERE m.codigo_materia = @codigoMateria AND u.dni = @dniAlumno";

                _sqlCommand.Parameters.AddWithValue("@codigoMateria", codigoMateria);
                _sqlCommand.Parameters.AddWithValue("@dniAlumno", dniAlumno);


                _sqlConnection.Open();

                using (SqlDataReader dataReader = _sqlCommand.ExecuteReader())
                {
                    if (dataReader.Read())
                    {

                        datos = (EstadoAlumno)dataReader;

                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (_sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    _sqlConnection.Close();
                }
            }

            return datos;
        }

        public int Add(int codigoMateria, int dniAlumno, EstadoAlumno datos)
        {
            int filas = 0;
            try
            {
                
                _sqlCommand.Parameters.Clear();

                _sqlConnection.Open();

                _sqlCommand.CommandText = "INSERT INTO estado_alumno_en_materia" +
                    "(id_materia, id_usuario, primero_rendido, primer_nota, segundo_rendido, " +
                    "segunda_nota, asistencia, id_estado_materia, id_estado_alumno)" +
                    "SELECT m.id_materia, a.id_usuario, @primerParcialRendido" +
                    "@primerParcialNota, @segundoParcialRendido, @segundoParcialNota, " +
                    "@asistencia, @estadoMateria, @estadoAlumno" +
                    "FROM usuarios AS a" +
                    "CROSS JOIN materias AS m" +
                    "WHERE m.codigo_materia = @codigoMateria AND u.dni = @dniAlumno";

                _sqlCommand.Parameters.AddWithValue("@dniAlumno", dniAlumno);
                _sqlCommand.Parameters.AddWithValue("@codigoMateria", codigoMateria);

                _sqlCommand.Parameters.AddWithValue("@primerParcialRendido", datos.PrimerExamen.Rendido);
                _sqlCommand.Parameters.AddWithValue("@primerParcialNota", datos.PrimerExamen.Nota);
                _sqlCommand.Parameters.AddWithValue("@segundoParcialRendido", datos.SegundoExamen.Rendido);
                _sqlCommand.Parameters.AddWithValue("@segundoParcialNota", datos.SegundoExamen.Nota);
                _sqlCommand.Parameters.AddWithValue("@segundoParcialNota", datos.Asistencia);
                _sqlCommand.Parameters.AddWithValue("@segundoParcialNota", (int)datos.EstadoMateria);
                _sqlCommand.Parameters.AddWithValue("@segundoParcialNota", (int)datos.Estado);


                filas = _sqlCommand.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (_sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    _sqlConnection.Close();
                }
            }

            return filas;
        }

        public int Update(int codigoMateria, int dniAlumno, EstadoAlumno datos)
        {
            int filas = 0;
            try
            {

                _sqlCommand.Parameters.Clear();

                _sqlConnection.Open();

                _sqlCommand.CommandText = "UPDATE ea SET ea.primero_rendido = @primerParcialRendido, " +
                    "ea.primer_nota = @primerParcialNota, ea.segundo_rendido = @segundoParcialRendido, " +
                    "ea.segunda_nota = @segundoParcialNota, ea.asistencia = @asistencia, " +
                    "ea.id_estado_materia = @estadoMateria, ea.id_estado_alumno = @estadoAlumno" +
                    "FROM estado_alumno_en_materia AS ea" +
                    "CROSS usuarios AS a" +
                    "CROSS JOIN materias AS m" +
                    "WHERE m.codigo_materia = @codigoMateria AND u.dni = @dniAlumno " +
                    "AND ea.id_materia = m.id AND ea.id_alumno = a.id";



                _sqlCommand.Parameters.AddWithValue("@dniAlumno", dniAlumno);
                _sqlCommand.Parameters.AddWithValue("@codigoMateria", codigoMateria);

                _sqlCommand.Parameters.AddWithValue("@primerParcialRendido", datos.PrimerExamen.Rendido);
                _sqlCommand.Parameters.AddWithValue("@primerParcialNota", datos.PrimerExamen.Nota);
                _sqlCommand.Parameters.AddWithValue("@segundoParcialRendido", datos.SegundoExamen.Rendido);
                _sqlCommand.Parameters.AddWithValue("@segundoParcialNota", datos.SegundoExamen.Nota);
                _sqlCommand.Parameters.AddWithValue("@asistencia", datos.Asistencia);
                _sqlCommand.Parameters.AddWithValue("@estadoMateria", (int)datos.EstadoMateria);
                _sqlCommand.Parameters.AddWithValue("@estadoAlumno", (int)datos.Estado);


                filas = _sqlCommand.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (_sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    _sqlConnection.Close();
                }
            }

            return filas;
        }

        public int AgregarExamen(int codigoMateria, EExamen examen)
        {
            int filas = 0;
            string command = "";
            try
            {
                if(examen == EExamen.Primer)
                {
                    command = "UPDATE materias SET primer_parcial_asginado = @parcialAsignado " +
                    "WHERE materias = @codigoMateria";
                } 
                else if (examen == EExamen.Segundo)
                {
                    command = "UPDATE materias SET segundo_parcial_asginado = @parcialAsignado " +
                    "WHERE materias = @codigoMateria";
                }
                _sqlCommand.Parameters.Clear();

                _sqlConnection.Open();

                _sqlCommand.CommandText = command;
                    


                _sqlCommand.Parameters.AddWithValue("@codigoMateria", codigoMateria);
                _sqlCommand.Parameters.AddWithValue("@parcialAsignado", true);

                

                filas = _sqlCommand.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (_sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    _sqlConnection.Close();
                }
            }

            return filas;
        }

        public int AgregarProfesor(int codigoMateria, int dniProfesor)
        {
            int filas = 0;
            try
            {

                _sqlCommand.Parameters.Clear();

                _sqlConnection.Open();

                _sqlCommand.CommandText = "INSERT INTO profesores_en_materia" +
                    "(id_profesor, id_materia)" +
                    "SELECT m.id_materia, a.id_usuario" +
                    "FROM usuarios AS a" +
                    "CROSS JOIN materias AS m" +
                    "WHERE m.codigo_materia = @codigoMateria AND u.dni = @dniAlumno";

                _sqlCommand.Parameters.AddWithValue("@dniAlumno", dniProfesor);
                _sqlCommand.Parameters.AddWithValue("@codigoMateria", codigoMateria);
               

                filas = _sqlCommand.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (_sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    _sqlConnection.Close();
                }
            }

            return filas;
        }

        public List<Profesor> GetAllProfesores(int codigoMateria)
        {
            List<Profesor> datos = new List<Profesor>();

            try
            {
                _sqlCommand.Parameters.Clear();

                _sqlCommand.CommandText = "SELECT u.*" +
                    "FROM profesores_en_materias AS pm" +
                    "INNER JOIN usuarios AS u ON u.id_usuario = pm.id_profesor" +
                    "INNER JOIN materias AS m ON m.id_materia = pm.id_materia" +
                    "WHERE m.codigo_materia = @codigoMateria";

                _sqlCommand.Parameters.AddWithValue("@codigoMateria", codigoMateria);

                _sqlConnection.Open();

                using (SqlDataReader dataReader = _sqlCommand.ExecuteReader())
                {
                    while (dataReader.Read())
                    {

                        datos.Add((Profesor)dataReader);

                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (_sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    _sqlConnection.Close();
                }
            }

            return datos;
        }

        public List<Materia> ListarMateriasDelAlumno(int dni)
        {
            List<Materia> datos = new List<Materia>();

            try
            {
                _sqlCommand.Parameters.Clear();
                _sqlCommand.CommandText = "SELECT m.* FROM materias AS m" +
                    "INNER JOIN usuarios AS u ON m.id_alumno = u.id" +
                    "INNER JOIN estado_alumno_en_materia AS ea ON ea.id_alumno = u.id" +
                    "WHERE u.dni = @dni";
                _sqlCommand.Parameters.AddWithValue("@dni", dni);

                _sqlConnection.Open();

                using (SqlDataReader dataReader = _sqlCommand.ExecuteReader())
                {
                    while (dataReader.Read())
                    {

                        datos.Add((Materia)dataReader);

                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (_sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    _sqlConnection.Close();
                }
            }

            return datos;
        }
        public List<Materia> ListarMateriasDelProfesor(int dni)
        {
            List<Materia> datos = new List<Materia>();

            try
            {
                _sqlCommand.Parameters.Clear();
                _sqlCommand.CommandText = "SELECT m.* FROM materias AS m" +
                    "INNER JOIN profesores_en_materia AS pm ON pm.id_materia = m.id" +
                    "INNER JOIN usuarios AS u ON u.id = pm.id_profesor" +
                    "WHERE u.dni = @dni";
                _sqlCommand.Parameters.AddWithValue("@dni", dni);

                _sqlConnection.Open();

                using (SqlDataReader dataReader = _sqlCommand.ExecuteReader())
                {
                    while (dataReader.Read())
                    {

                        datos.Add((Materia)dataReader);

                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (_sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    _sqlConnection.Close();
                }
            }

            return datos;
        }
    }
}

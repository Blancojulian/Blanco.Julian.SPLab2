using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaEntidades.Clases
{
    public static class ListaMaterias
    {
        private static List<Materia> _lista;
        private static int _id;

        static ListaMaterias()
        {
            _id = 0;
            _lista = new List<Materia>();

        }

        public static int GetId()
        {
            _id++;
            return _id;
        }
        public static List<Materia> Lista { get { return new List<Materia>(_lista); } }

        
        private static bool MateriaExiste(Materia m)
        {
            bool retorno = false;

            foreach (Materia materia in _lista)
            {
                if (materia == m)
                {
                    retorno = true;
                    break;
                }
            }

            return retorno;
        }

        private static bool MateriaExiste(int codigoMateria)
        {
            bool retorno = false;

            foreach (Materia materia in _lista)
            {
                if (materia.CodigoMateria == codigoMateria)
                {
                    retorno = true;
                    break;
                }
            }

            return retorno;
        }

        private static Materia GetMateria(int codigoMateria)
        {
            Materia retorno = null;

            foreach (Materia materia in _lista)
            {
                if (materia.CodigoMateria == codigoMateria)
                {
                    retorno = materia;
                    break;
                }
            }

            return retorno;
        }

        public static bool AgregarMateria(Materia m)
        {
            bool retorno = false;

            if (!MateriaExiste(m))
            {
                _lista.Add(m);
                retorno = true;
            }

            return retorno;
        }

        public static bool EliminarMateria(Materia m)
        {
            bool retorno = false;

            if (MateriaExiste(m))
            {
                _lista.Remove(m);
                retorno = true;
            }

            return retorno;
        }
    }
}

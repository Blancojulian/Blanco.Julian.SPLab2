using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaEntidades.DAO
{
    public static class ClaseDAO
    {
        private static UsuarioDao _usuarioDao;
        private static MateriaDao _materiaDao;

        static ClaseDAO()
        {
            _usuarioDao = new UsuarioDao();
            _materiaDao = new MateriaDao();
        }

        public static UsuarioDao UsuarioDao { get => _usuarioDao; }
        public static MateriaDao MateriaDao { get => _materiaDao; }
    }
}

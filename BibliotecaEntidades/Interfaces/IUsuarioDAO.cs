using BibliotecaEntidades.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaEntidades.Interfaces
{
    public interface IUsuarioDAO<R>
    {
        public List<T> GetAll<T>() where T : R;
        public T? Get<T>(int id) where T : R;

        public int Add<T>(T datos, string contrasenia) where T : R;
    }
}

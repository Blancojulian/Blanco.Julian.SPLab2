using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaEntidades.Interfaces
{
    public interface IClaseDAO <T>
    {
        public List<T> GetAll();
        public T? Get(int id);
        public int Add(T datos);
        public int Update(int id, T datos);
        public int Delete(int id);
    }
}

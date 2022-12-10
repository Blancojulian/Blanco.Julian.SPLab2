using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaEntidades.Interfaces
{
    public interface IClaseDAO <T>
    {
        public static List<T> GetAll();
        public T Get(int id);
        public void Add(T datos);
        public void Update(int id, T datos);
        public void Delete(int id);
    }
}

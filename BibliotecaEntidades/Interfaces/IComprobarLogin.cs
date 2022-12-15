using BibliotecaEntidades.Clases;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaEntidades.Interfaces
{
    public interface IComprobarLogin
    {
        public T? ComprobarLogin<T>(string nombre, string contrasenia, int dni) where T : Usuario;/*
        {

            foreach (Usuario usuario in _lista)
            {
                if (usuario.Nombre == nombre && usuario.Dni == dni && 
                    Usuario.ComprobarContrasenia(usuario, contrasenia))
                {
                    return usuario;
                }
            }


            return null;
        }*/
    }
}

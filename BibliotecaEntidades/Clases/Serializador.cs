using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WinFormsPrueba.Clases
{
    public static class Serializador<T>
    {
        private static string _ruta;

        static Serializador()
        {
            _ruta = Path.GetFullPath(Directory.GetCurrentDirectory() + @"\..\..\..\Serializaciones");
        }

        public static void CambiarRuta(string ruta)
        {
            _ruta = ruta + @"\Serializaciones";
        }

        public static void CambiarRutaPredeterminada()
        {
            string ruta = Path.GetFullPath(Directory.GetCurrentDirectory() + @"\..\..\..\Serializaciones");
            if (!Directory.Exists(ruta))
            {
                Directory.CreateDirectory(ruta);
                _ruta = ruta;
            }
        }

        public static void EscribirXml(T datos, string nombre)
        {
            string rutaCompleta = _ruta + @$"\{nombre}.xml";

            
            try
            {
                if (!Directory.Exists(_ruta))
                {
                    Directory.CreateDirectory(_ruta);
                }

                using(StreamWriter sw = new StreamWriter(rutaCompleta))
                {
                    XmlSerializer xml = new XmlSerializer(typeof(T));
                    xml.Serialize(sw, datos);
                }

                MessageBox.Show(Path.GetFullPath(_ruta));
            }
            catch (Exception)
            {
                throw new Exception($"Error en el archivo {rutaCompleta}");
            }
        }

        public static void EscribirJson(T datos, string nombre)
        {
            string rutaCompleta = _ruta + @$"\{nombre}.json";
            
            try
            {
                if (!Directory.Exists(_ruta))
                {
                    Directory.CreateDirectory(_ruta);
                }

                
                string objetoJson = JsonSerializer.Serialize(datos, typeof(T));

                File.WriteAllText(rutaCompleta, objetoJson);

                //MessageBox.Show(Path.GetFullPath(_ruta));
                MessageBox.Show(Environment.CurrentDirectory);

            }
            catch (Exception)
            {
                throw new Exception($"Error en el archivo {rutaCompleta}");
            }
        }
        public static void EscribirCsv<U>(List<U> datos, string nombre) where U : T, IImprimirCsv
        {
            string rutaCompleta = _ruta + @$"\{nombre}.csv";


            try
            {
                if (!Directory.Exists(_ruta))
                {
                    Directory.CreateDirectory(_ruta);
                }

                using (StreamWriter sw = new StreamWriter(rutaCompleta))
                {
                    if (datos.Count > 0 && datos[0] is not null)
                    {
                        sw.WriteLine(datos[0].ImprimirPropiedadesEnCsv());
                    }

                    foreach (var item in datos)
                    {
                        sw.WriteLine(item.ImprimirDatosEnCsv());
                    }

                }

                MessageBox.Show(_ruta);
            }
            catch (Exception)
            {
                throw new Exception($"Error al crear el archivo {nombre}");

            }
        }
        public static void EscribirCsv<U>(U datos, string nombre) where U : T, IImprimirCsv
        {
            string rutaCompleta = _ruta + @$"\{nombre}.csv";


            try
            {
                if (!Directory.Exists(_ruta))
                {
                    Directory.CreateDirectory(_ruta);
                }

                using (StreamWriter sw = new StreamWriter(rutaCompleta))
                {
                    sw.WriteLine(datos.ImprimirPropiedadesEnCsv());

                   
                    sw.WriteLine(datos.ImprimirDatosEnCsv());
                   

                }

                MessageBox.Show(_ruta);
            }
            catch (Exception)
            {
                throw new Exception($"Error al crear el archivo {nombre}");

            }
        }
        /*
        public static void EscribirCsv<U, R>(U datos, string nombre) where R : T, IImprimirCsv
            where U :  List<R>
        {
            string rutaCompleta = _ruta + @$"\{nombre}.csv";


            try
            {
                if (!Directory.Exists(_ruta))
                {
                    Directory.CreateDirectory(_ruta);
                }

                using (StreamWriter sw = new StreamWriter(rutaCompleta))
                {
                    sw.WriteLine(datos[0].ImprimirPropiedadesEnCsv());

                    foreach (var item in datos)
                    {
                        sw.WriteLine(item.ImprimirDatosEnCsv());
                    }

                }

                MessageBox.Show(_ruta);
            }
            catch (Exception)
            {
                throw new Exception($"Error al crear el archivo {nombre}");

            }
        }*/

        public static T LeerJson(string nombre)
        {
            string archivo = string.Empty;
            T? datos = default;

            try
            {
                if (Directory.Exists(_ruta))
                {
                    string[] archivosEnRuta = Directory.GetFiles(_ruta);

                    foreach (string archivoEnRuta in archivosEnRuta)
                    {
                        if (archivoEnRuta.Contains(nombre + ".json"))
                        {
                            archivo = archivoEnRuta;
                            break;
                        }
                    }

                    if(archivo != null)
                    {
                        string archivoJson = File.ReadAllText(archivo);
                        datos = JsonSerializer.Deserialize<T>(archivoJson);
                    }
                }

                return datos;
            }
            catch (Exception)
            {

                throw new Exception($"Error en el archivo {archivo}");
            }
        }

        public static T LeerXml(string nombre)
        {
            string archivo = string.Empty;
            T datos = default;

            try
            {
                if (Directory.Exists(_ruta))
                {
                    string[] archivosEnRuta = Directory.GetFiles(_ruta);

                    foreach (string archivoEnRuta in archivosEnRuta)
                    {
                        if (archivoEnRuta.Contains(nombre + ".json"))
                        {
                            archivo = archivoEnRuta;
                            break;
                        }
                    }

                    if (archivo != null)
                    {
                        using (StreamReader sr = new StreamReader(archivo) )
                        {
                            XmlSerializer xml = new XmlSerializer(typeof(T));

                            datos = (T)xml.Deserialize(sr);
                        }
                    }
                }

                return datos;
            }
            catch (Exception)
            {

                throw new Exception($"Error en el archivo {archivo}");
            }

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BibliotecaEntidades.Clases
{
    public static class JSON
    {
        public static StreamWriter writer;
        public static StreamReader reader;
        public static string path;
        public static string jsonDefaultPath;
        static JSON()
        {
            JSON.path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            jsonDefaultPath = JSON.path;
        }

        public static bool SerializarJSON(List<Alumno> lista, string materia)
        {
            bool retorno = false;

            try
            {
                JSON.path = jsonDefaultPath += $"\\{materia}.json";

                using (JSON.writer = new StreamWriter(JSON.path))
                {

                    string json = JsonSerializer.Serialize(lista);

                    JSON.writer.Write(json);
                    retorno = true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return retorno;
        }

        public static List<Alumno> DeserializarJSON(string materia)
        {
            List<Alumno> datos = new List<Alumno>();
            try
            {
                JSON.path = jsonDefaultPath += $"\\{materia}.json";

                using (JSON.reader = new StreamReader(JSON.path))
                {
                    string json = JSON.reader.ReadToEnd();

                    datos = JsonSerializer.Deserialize<List<Alumno>>(json);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return datos;
        }
    }
}

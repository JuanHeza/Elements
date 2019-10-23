using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Elements
{
    class Contenido
    {
        public Contenido Padre { get; set; }
        public List<Contenido> Hijo { get; set; }
        public string Nombre { get; set; }

        public Contenido(string nombre)
        {
            Nombre = nombre;
        }

        public static List<string> GetComic(string x)
        {
            List<string> files = new List<string>();
            files.AddRange(Directory.GetFiles(x, "*.cbr"));
            files.AddRange(Directory.GetFiles(x, "*.cbz"));
            files.Sort();
            return files;
        }

        public void GetContent()
        {
            List<string> files = new List<string>();
            List<string> dirs = new List<string>();
            List<Contenido> valor = new List<Contenido>();
            string thumb;
            Console.WriteLine("\t=== Simulacro Iniciando ===");
            dirs.AddRange(Directory.GetDirectories(this.Nombre));
            dirs.Sort();
            foreach (string dir in dirs)
            {
                Contenido aux = new Contenido(dir);
                aux.Padre = this;
                Console.WriteLine("\t#" + dir);
                files = GetComic(dir);
                if (files.Count() < 1)
                {
                    thumb = "def";
                }
                else
                {
                    thumb = "\t\t" + files[0];
                }
                Console.WriteLine(thumb);
                valor.Add(aux);
            }
            this.Hijo = valor;
            Console.WriteLine("\t === Simulacro Terminado ===");
        }

        public static string GetActualFile(string dir)
        {
            /*
            aqui hay que poner algo para abrir el CB y saque la primer imagen 
        usar mongoDB para controlar los status
            asi mantener actualizada la miniatura de cada carpeta

            hacer que los tiles leidos sean mas transparentes como ocultos
            */
            return "";
        }
    }
}

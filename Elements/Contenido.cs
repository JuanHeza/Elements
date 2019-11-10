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
        public static Dictionary<string, List<String>> DirMap = new Dictionary<string, List<String>>();
        public Contenido Padre { get; set; }
        public List<Contenido> Hijo { get; set; }
        public string Nombre { get; set; }
        public bool IsDir { get; set; }
        public Contenido(string nombre)
        {
            Nombre = nombre;
        }

        public static List<Contenido> ComicCont
        {
            set;
            get;
        }

        public static void InitComicCont()
        {
            ComicCont = new List<Contenido>(); 
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
            //Console.WriteLine("\t&{0} &{1}", files.Count, dirs.Count);
            dirs.AddRange(Directory.GetDirectories(this.Nombre));
            //dirs.Sort();
            foreach (string dir in dirs)
            {
                Contenido aux = new Contenido(dir);
                aux.Padre = this;
                //Console.WriteLine("\t#" + dir);
                files = GetComic(dir);
                if (files.Count() < 1)
                {
                    thumb = "def";
                    continue;
                }
                else
                {
                    thumb = "\t\t" + files[0];
                }
                aux.IsDir = true;
                valor.Add(aux);
            }
            files = GetComic(this.Nombre);
            foreach (string file in files)
            {
                Contenido aux = new Contenido(file);
                aux.Padre = this;
                aux.IsDir = false;
                valor.Add(aux);
            }
            this.Hijo = valor;
            Console.WriteLine("\t=== Simulacro Terminado ===");
        }

        public static void AddtoDir(string cat, string dir){
            DirMap[cat].Add(dir);
            List<string> val = DirMap["Comic"];
            string[] Dirs = Directory.GetFiles(val[0], "*.cb*");
            string[] dirss = Directory.GetDirectories(val[0]);
        }

        public static void InitDir()
        {
            List<string> X = new List<string>();
            DirMap.Add("Comic", X);
            DirMap.Add("Musica", X);
            DirMap.Add("Video", X);
            DirMap.Add("Ebook", X);
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

        public static void agregarComicDirs(Contenido D)
        {
            bool Exist = false;
            foreach(Contenido x in ComicCont)
            {
                if (D.Nombre == x.Nombre)
                {
                    Exist = true;
                    break;
                }
            }
            if (!Exist)
            {
                ComicCont.Add(D);
            }
        }


    }
}
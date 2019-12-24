using System;
using MongoDB.Bson;
using System.Linq;
using System.Text.RegularExpressions;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Elements
{
    public class Contenido
    {
        public static Dictionary<string, List<String>> DirMap = new Dictionary<string, List<String>>();
        public Contenido Padre { get; set; }
        public List<Contenido> Hijo { get; set; }
        public string Nombre { get; set; }
        public bool IsDir { get; set; }
        public Contenido(string nombre)
        {
            Nombre = nombre;
            Hijo = new List<Contenido>();
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

        private static Dictionary<string, List<String>> DirFilter = new Dictionary<string, List<String>>();
        public static List<string> GetByFilter(string dir, string filter)
        {
            List<string> files = new List<string>();
            foreach(string type in DirFilter[filter])
                files.AddRange(Directory.GetFiles(dir, type));
            files.Sort();
            return files;
        }

        public void GetContent(string filter)
        {
            List<string> AuxContent = new List<string>();
                Console.WriteLine("\t=== Simulacro Iniciando ===");
            AuxContent.AddRange(Directory.GetDirectories(this.Nombre));
            foreach (string dir in AuxContent)
            {
                //var files = GetComic(dir);
                var files = GetByFilter(dir,filter);
                if (files.Count > 0)
                {
                    Contenido aux = new Contenido(dir);
                    aux.Padre = this;
                    aux.IsDir = true;
                    this.Hijo.Add(aux);
                }
            }
            AuxContent = GetByFilter(this.Nombre, filter);
            foreach (string file in AuxContent)
            {
                Contenido aux = new Contenido(file);
                aux.Padre = this;
                aux.IsDir = false;
                this.Hijo.Add(aux);
            }
            List<BsonValue> Hijos = new List<BsonValue>();
            foreach (Contenido hijo in this.Hijo)
            {
                Hijos.Add(BsonValue.Create(hijo.Nombre));
                if (!Mongo.Exist(hijo.Nombre))
                {
                    var DirDoc = new BsonDocument
                    {
                        {"Nombre", BsonValue.Create(hijo.Nombre)},
                        {"Padre", BsonValue.Create(this.Nombre)},
                        {"Hijo",  new BsonArray(new List<string>())},
                        {"IsDir", BsonValue.Create(hijo.IsDir)}
                    };
                    Mongo.AddNew(DirDoc, "Contenido");
                }
            }
           var Doc = new BsonDocument
            {
                {"Nombre", BsonValue.Create(this.Nombre)},
                {"Padre", BsonValue.Create(this.Padre==null ? "." : this.Padre.Nombre)},
                {"Hijo", BsonValue.Create(Hijos)},
                {"IsDir", BsonValue.Create(this.IsDir)}
            };
            if (!Mongo.Exist(this.Nombre))
                Mongo.AddNew(Doc, "Contenido");
            else
                Mongo.Update(Doc, "Contenido");
            Console.WriteLine("\t=== Simulacro Terminado ===");
        }

        public static void InitDir()
        {
            List<string> X = new List<string>();
            DirMap.Add("Comic", X);
            DirMap.Add("Musica", X);
            DirMap.Add("Video", X);
            DirMap.Add("Ebook", X);
            DirFilter.Add("Comic", new List<string>() { "*.cbr","*.cbz" });
            DirFilter.Add("Musica", new List<string>() { "*.mp3" });
            DirFilter.Add("Video", new List<string>() { "" });
            DirFilter.Add("Ebook", new List<string>() { "*.epub","*.prc","*.mobi"});//", *.azw"
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
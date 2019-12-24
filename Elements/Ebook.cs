using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;
using VersOne.Epub;
using System.Threading.Tasks;

namespace Elements
{
    class Ebook
    {
        string Nombre;
        string Titulo;
        List<string> Autor;

        public Ebook(Contenido File)
        {
            Nombre = File.Nombre.Replace(File.Padre.Nombre, "");
            EpubBook book = EpubReader.ReadBook(File.Nombre);
            Titulo = book.Title;
            /*
            // Book's authors (comma separated list)
            string author = book.Author;
            */
            Autor = book.AuthorList;
        }

        public static Image GetThumb(string dir, int Wd, int Ht)
        {
            Image coverImage = new Bitmap("C:/Users/JuanEnrique/documents/visual studio 2015/Projects/Elements/Elements/Resources/The Incal.jpg");
            EpubBook book = EpubReader.ReadBook(dir);
            byte[] coverImageContent = book.CoverImage;
            if (coverImageContent != null)
            {
                using (MemoryStream coverImageStream = new MemoryStream(coverImageContent))
                {
                    coverImage = Image.FromStream(coverImageStream);
                }
            }
            return coverImage.GetThumbnailImage(Wd, Ht, null, IntPtr.Zero);
        }


    }
}

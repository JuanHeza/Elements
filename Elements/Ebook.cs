using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;
using VersOne.Epub;
using System.Threading.Tasks;
using PdfSharp.SharpZipLib;
using PdfSharp;

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
            Image coverImage = global::Elements.Properties.Resources.Thwomp;
            byte[] coverImageContent = null;//Elements.Properties.Resources.Thwomp;
            if (dir.Contains(".epub"))
            {
                EpubBook book = EpubReader.ReadBook(dir);
                coverImageContent = book.CoverImage;
            }
            if (dir.Contains(".prc"))   {}
            if (dir.Contains(".mobi"))  {}
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

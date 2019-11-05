using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpCompress.Archives;
using System.Drawing;
using System.Drawing.Imaging;

namespace Elements
{
    public class Comic
    {

        public static IArchive openArchive(String filename)
        {
            IArchive archive;
            try
            {
                archive = ArchiveFactory.Open(filename);
                /*
                foreach (IArchiveEntry entry in archive.Entries)
                {
                    if (!entry.IsDirectory)
                    {
                        Console.WriteLine(entry.Key);
                    }
                }
                */
            return archive;
            }
            catch (InvalidOperationException ioe)
            {
                Console.WriteLine("Error opening file" + ioe.Message);
                //DialogResult result = MetroMessageBox.Show(this, "Please try another.", "Error Opening File.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public static Image GetThumb(string dir,int Wd, int Ht)
        {
            Bitmap Img = new Bitmap("C:/Users/JuanEnrique/documents/visual studio 2015/Projects/Elements/Elements/Resources/The Incal.jpg");
            IArchive archive = openArchive(dir);
            foreach (IArchiveEntry AZ in archive.Entries)
            {
                if (!AZ.IsDirectory && !AZ.Key.ToLower().Contains("txt"))
                {
                    try
                    {
                        Console.WriteLine(AZ.Key);
                        System.Threading.Thread.Sleep(5000);
                        Img = (Bitmap)Bitmap.FromStream(AZ.OpenEntryStream());
                        break;
                    }
                    catch (InvalidOperationException ioe)
                    {
                        Console.WriteLine("Error opening file" + ioe.Message);
                        break;
                    }
                }
            }
            return Img.GetThumbnailImage(Wd, Ht, null, IntPtr.Zero); ;
        }
    }
}

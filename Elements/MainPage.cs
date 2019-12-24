using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace Elements
{
    public partial class MainPage : MetroFramework.Controls.MetroUserControl
    {
        bool metroStatus = false;
        public static string Filtro;
        public MainPage()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //
            tileOpciones.Text = (metroStatus == true) ? " " : "Opciones";
            tileOpciones.UseTileImage = metroStatus;
            tileOpciones.Refresh();
            //
            tileNube.Text = (metroStatus == true) ? " " : "Salir";
            tileNube.UseTileImage = metroStatus;
            tileNube.Refresh();
            //
            tileEbook.Text = (metroStatus == true) ? " " : "Ebook";
            tileEbook.UseTileImage = metroStatus;
            tileEbook.Refresh();
            //
            tileComic.Text = (metroStatus == true) ? " " : "Comic";
            tileComic.UseTileImage = metroStatus;
            tileComic.Refresh();
            //
            tileMusica.Text = (metroStatus == true) ? " " : "Musica";
            tileMusica.UseTileImage = metroStatus;
            tileMusica.Refresh();
            //
            tileVideo.Text = (metroStatus == true) ? " " : "Video";
            tileVideo.UseTileImage = metroStatus;
            tileVideo.Refresh();
            metroStatus = !metroStatus;
        }

        private void UserControl1_SizeChanged(object sender, EventArgs e)
        {
            System.Drawing.Size a, c, b;
            Point d;
            a = ClientSize;
            b = new System.Drawing.Size((a.Width * 3661) / 10000, (a.Height * 1923) / 10000);
            c = new System.Drawing.Size((a.Width * 0845) / 10000, (a.Height * 0865) / 10000);
            tileComic.Location = new System.Drawing.Point((c.Width), (c.Height) + 35);
            tileComic.Size = new System.Drawing.Size((b.Width), (b.Height));
            d = tileComic.Location;
            tileEbook.Location = new System.Drawing.Point((c.Width), (d.Y + b.Height + c.Height));
            tileEbook.Size = new System.Drawing.Size((b.Width), (b.Height));
            d = tileEbook.Location;
            tileOpciones.Location = new System.Drawing.Point((c.Width), (d.Y + b.Height + c.Height));
            tileOpciones.Size = new System.Drawing.Size((b.Width), (b.Height));
            d = tileComic.Location;
            tileVideo.Location = new System.Drawing.Point((d.X + b.Width + c.Width), (c.Height) + 35);
            tileVideo.Size = new System.Drawing.Size((b.Width), (b.Height));
            d = tileVideo.Location;
            tileMusica.Location = new System.Drawing.Point((d.X), (d.Y + b.Height + c.Height));
            tileMusica.Size = new System.Drawing.Size((b.Width), (b.Height));
            d = tileMusica.Location;
            tileNube.Location = new System.Drawing.Point((d.X), (d.Y + b.Height + c.Height));
            tileNube.Size = new System.Drawing.Size((b.Width), (b.Height));
        }

        private void tileComic_Click(object sender, EventArgs e)
        {
            //check metro UserControl
            Console.WriteLine("Click Comic");
            Form1._instance.Style = (sender as MetroFramework.Controls.MetroTile).Style;
            MainPage.Filtro = "Comic"; 
            if (Contenido.DirMap["Comic"].Count <= 0)
            {
                DialogResult result = MetroMessageBox.Show(this, "\t\t ¿Desea Configurar Alguna?", "Error, No hay Libreria Configurada", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (result == DialogResult.Yes)
                {
                    Mongo.AddPath("Comic", "C:/Users/JuanEnrique/Google Drive/comic/");
                }
            }
            else
            {
                if (!Form1.Instance.MetroContainer.Controls.ContainsKey("ComicControl"))
                {
                    ComicControl ComicCtrl = new ComicControl();
                    ComicCtrl.Dock = DockStyle.Fill;
                    //Add UserControl to Metro Panel
                    Form1.Instance.MetroContainer.Controls.Add(ComicCtrl);
                }
                Form1.Instance.MetroContainer.Controls["ComicControl"].BringToFront();
                Form1.Instance.metroHome.Visible = true;
            }
        }

        private void tileEbook_Click(object sender, EventArgs e)
        {
            //check metro UserControl
            Console.WriteLine("Click Ebook");
            Form1._instance.Style = (sender as MetroFramework.Controls.MetroTile).Style;
            MainPage.Filtro = "Ebook";
            if (Contenido.DirMap["Ebook"].Count <= 0)
            {
                DialogResult result = MetroMessageBox.Show(this, "\t\t ¿Desea Configurar Alguna?", "Error, No hay Libreria Configurada", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (result == DialogResult.Yes)
                {
                    //////////////////////////////////////////////
                    Mongo.AddPath("Ebook", "C:/Users/JuanEnrique/Desktop/DAKOTA/Library");
                    //////////////////////////////////////////////
                }
            }
            else
            {
                foreach (string dat in Contenido.DirMap["Ebook"])
                    Console.WriteLine(dat);
                if (!Form1.Instance.MetroContainer.Controls.ContainsKey("ComicControl"))
                {
                    ComicControl EbookCtrl = new ComicControl();
                    EbookCtrl.Dock = DockStyle.Fill;
                    //Add UserControl to Metro Panel
                    Form1.Instance.MetroContainer.Controls.Add(EbookCtrl);
                }
                Form1.Instance.MetroContainer.Controls["ComicControl"].BringToFront();
                Form1.Instance.metroHome.Visible = true;
            }
        }

        private void tileOpciones_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Click Configuraciones");
            Form1._instance.Style = (sender as MetroFramework.Controls.MetroTile).Style;
            if (!Form1.Instance.MetroContainer.Controls.ContainsKey("ConfigControl"))
            {
                ConfigControl ConfigCtrl = new ConfigControl();
                ConfigCtrl.Dock = DockStyle.Fill;
                //Add UserControl to Metro Panel
                Form1.Instance.MetroContainer.Controls.Add(ConfigCtrl);
            }
            Form1.Instance.MetroContainer.Controls["ConfigControl"].BringToFront();
            Form1.Instance.metroHome.Visible = true;
        }
    }
}
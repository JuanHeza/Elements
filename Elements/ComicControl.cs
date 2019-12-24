using System;
using System.Threading;
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
    public partial class ComicControl : MetroFramework.Controls.MetroUserControl
    {
        System.Threading.Semaphore Sem;
        static int sepY = 20;
        List<MetroFramework.Controls.MetroTile> Teselas = new List<MetroFramework.Controls.MetroTile>();
        int Min = 6;
        int Max = 9;
        string Filtro;

        public ComicControl()
        {
            InitializeComponent();
        }

        private void ComicControl_Load(object sender, EventArgs e)
        {
            Contenido.InitComicCont();
            Sem = new System.Threading.Semaphore(Min, Min);
            foreach (string DR in Contenido.DirMap[MainPage.Filtro])
            {
                Contenido cont = new Contenido(DR);
                TilesCreate(cont);
            }
        }

        public void TilesCreate(Contenido cont) {
            Form1.actualFolder = cont;
            Form1.visualBack();
            Console.WriteLine("CREANDO TILES DE {0}", cont.Nombre);
            Contenido.agregarComicDirs(cont);
            if (cont.Hijo.Count < 1)
                cont.GetContent(MainPage.Filtro);
            int index = -1;
            foreach (Contenido hijo in cont.Hijo)
            {
                Contenido.agregarComicDirs(hijo);
                MetroFramework.Controls.MetroTile X = new MetroFramework.Controls.MetroTile();
                X.Text = hijo.Nombre.Replace(cont.Nombre, "");
                X.Name = hijo.Nombre;
                X.Style = MetroFramework.MetroColorStyle.Magenta;
                X.MinimumSize = new System.Drawing.Size(120, 180);
                X.MaximumSize = new System.Drawing.Size(200, 300);
                X.ActiveControl = null;
                X.Visible = true;
                X.TabIndex = ++index;
                new Thread(() => TilesGrid(hijo.IsDir, Min-1, X,false)).Start();
            }
            while (Teselas.Count < cont.Hijo.Count)
            {
                Thread.Sleep(100);
            }
            foreach (MetroFramework.Controls.MetroTile Tesela in Teselas)
            {
                this.Controls.Add(Tesela);
            }
            this.Refresh();
        }
   
        private void RecreateTeselas(object sender, EventArgs e)
        {
            if (Teselas.Count < 1)
            {
                Console.WriteLine("NO HAY TESELAS");
            }
            else
            {
                foreach (MetroFramework.Controls.MetroTile Tesela in Teselas)
                {
                    bool dir = Tesela.Style == MetroFramework.MetroColorStyle.Magenta;
                    TilesGrid(dir, Min, Tesela, true);
                    if (!dir)
                    {
                        Tesela.TileImage = Tesela.TileImage.GetThumbnailImage(Tesela.Size.Width,Tesela.Size.Height, null, IntPtr.Zero);
                    }
                }
            }
            this.Refresh();
        }

        private MetroFramework.Controls.MetroTile TilesGrid(bool IsDir, int N, MetroFramework.Controls.MetroTile X, bool Update)
        {
            Sem.WaitOne();
            int Wdh = this.Width;
            int sz = Wdh / N;
            while (sz > X.MaximumSize.Width && N <= Max)
            {
                N++;
                sz = Wdh / N;
            }
            int SX = (sz + (Wdh % N)) / N;
            int SY = ComicControl.sepY;
            X.Size = new System.Drawing.Size(sz, (int)(sz * 1.5));
            int LocX = (SX * (1 + (X.TabIndex % (N - 1)))) + (sz * (X.TabIndex % (N - 1)));
            int LocY = (SY * (1 + (X.TabIndex / (N - 1)))) + ((int)(sz * 1.5) * (X.TabIndex / (N - 1)));
            X.Location = new System.Drawing.Point(LocX, LocY);
            if(!Update){
                if (!IsDir)
                {
                    X.Style = MetroColorStyle.Green;
                    switch (MainPage.Filtro)
                    {
                        case "Comic":
                            X.TileImage = Comic.GetThumb(X.Name, X.Size.Width, X.Size.Height);
                            break;
                        case "Ebook":
                            X.TileImage = Ebook.GetThumb(X.Name, X.Size.Width, X.Size.Height);
                            break;
                        default:
                            Image coverImage = new Bitmap("C:/Users/JuanEnrique/documents/visual studio 2015/Projects/Elements/Elements/Resources/The Incal.jpg");
                            X.TileImage = coverImage.GetThumbnailImage(X.Size.Width, X.Size.Height, null, IntPtr.Zero);
                            break;
                    }
                    X.UseTileImage = true;
                    X.Click += new System.EventHandler(Comic_Click);
                }
                else
                {
                    X.Click += new System.EventHandler(Carpeta_Click);
                }
                Teselas.Add(X);
            }
            Sem.Release();
            return X;
        }

        private void Comic_Click(object sender, EventArgs e)
        {
            var Q = (sender as MetroFramework.Controls.MetroTile);
            string a = Q.Name;
            List<Contenido> Tsx = Contenido.ComicCont;
            Contenido T = new Contenido ("");
            foreach(Contenido t in Tsx)
            {
                if (t.Nombre == a)
                {
                    T = t;
                    break;
                }
            }
            List<string> bros = new List<string>(); 
            if (Q.TabIndex > 0)
            {
                bros.Add(this.Controls[Q.TabIndex-1].Name);
            }
            else
            {
                bros.Add("");
            }

            if(Q.TabIndex < this.Controls.Count)
            {
                bros.Add(this.Controls[Q.TabIndex+1].Name);
            }
            else
            {
                bros.Add("");
            }

            ComicReader ComicRDR = new ComicReader(Form1._instance.Width, Form1._instance.Height, T, bros);
            ComicRDR.Dock = DockStyle.Fill;
            //Add UserControl to Metro Panel
            Form1._instance.MetroUserReader.Controls.Add(ComicRDR);
            Form1._instance.MetroUserReader.Visible = true;
        }

        private void Carpeta_Click(object sender, EventArgs e)
        {
            List<Contenido> Tsx = Contenido.ComicCont;
            Contenido X;
            string a = (sender as MetroFramework.Controls.MetroTile).Name;
            TilesDestroy();
            foreach (Contenido t in Tsx)
            {
                if (t.Nombre == a)
                {
                    X = t;
                    TilesCreate(X);
                    break;
                }
            }
        }

        public void TilesDestroy()
        {
            Contenido.InitComicCont();
            this.Controls.Clear();
            this.Refresh();
            Teselas.Clear();
        }
    }
}
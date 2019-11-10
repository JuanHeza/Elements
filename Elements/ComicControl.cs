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
        String ActiveDir = "";
        public ComicControl()
        {
            InitializeComponent();
        }

        private void ComicControl_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Dirmap Comic {0}", Contenido.DirMap["Comic"].Count);
            Contenido.InitComicCont();
            Sem = new System.Threading.Semaphore(Min, Min);
            foreach (string DR in Contenido.DirMap["Comic"])
            {
                TilesCreate(DR);
            }
            Form1.ModStyle("Green");
        }

        public void TilesCreate(string DR) { 
            Contenido cont = new Contenido(DR);
            Console.WriteLine("CREANDO TILES DE {0}", DR);
            Contenido.agregarComicDirs(cont);
            cont.GetContent();
            int index = -1;
            foreach (Contenido hijo in cont.Hijo)
            {
                Contenido.agregarComicDirs(hijo);
                MetroFramework.Controls.MetroTile X = new MetroFramework.Controls.MetroTile();
                X.Text = hijo.Nombre.Replace(DR, "");
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
            int Wdh = Form1.ControlSize.Width;
            int sz = Wdh / N;
            //Console.WriteLine("SZ {0} \t WDH {1}", sz, Wdh);
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
            //Console.WriteLine("\tTile Index {0}\tSize {1}\tLocation {2}\tLocX {3}\tLocY {4}", X.TabIndex, X.Size, X.Location, X.TabIndex % (N - 1), X.TabIndex / (N - 1));
            if(!Update){
                if (!IsDir)
                {
                    X.Style = MetroColorStyle.Green;
                    X.TileImage = Comic.GetThumb(X.Name, X.Size.Width, X.Size.Height);
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
            string a = (sender as MetroFramework.Controls.MetroTile).Name;
            List<Contenido> Tsx = Contenido.ComicCont;
            foreach(Contenido t in Tsx)
            {
                if (t.Nombre == a)
                {
                    Console.WriteLine( "{0}\t{1}", t.Nombre,t.Padre.Nombre);
                    break;
                }
            }
        }

        private void Carpeta_Click(object sender, EventArgs e)
        {
            List<Contenido> Tsx = Contenido.ComicCont;
            Contenido X;
            string a = (sender as MetroFramework.Controls.MetroTile).Name;
            foreach (Contenido t in Tsx)
            {
                if (t.Nombre == a)
                {
                    X = t;
                    Console.WriteLine("{0}\t{1}", X.Nombre, X.Padre);
                    break;
                }
            }
            TilesDestroy();
            String ActiveDir = a;
            TilesCreate(a);
        }

        private void TilesDestroy()
        {
            Contenido.InitComicCont();
            this.Controls.Clear();
            this.Refresh();
            Teselas.Clear();
        }


    }
}
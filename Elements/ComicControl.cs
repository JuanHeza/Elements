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
        public ComicControl()
        {
            InitializeComponent();
        }


        private void ComicControl_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Dirmap Comic {0}", Contenido.DirMap["Comic"].Count);
            Sem = new System.Threading.Semaphore(Min, Min);
            TilesCreate();
            Form1.ModStyle("Green");
            timer1.Start();
        }

        public void TilesCreate() { 
            foreach (string DR in Contenido.DirMap["Comic"]) { 
                Contenido cont = new Contenido(DR);
                cont.GetContent();
                int index = -1;
                foreach (Contenido hijo in cont.Hijo)
                {
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
        }

        private void timer1_Tick(object sender, EventArgs e)
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
                    if (!dir)
                    {
                        Tesela.TileImage = Tesela.TileImage.GetThumbnailImage(Tesela.Size.Width,Tesela.Size.Height, null, IntPtr.Zero);
                    }
                    TilesGrid(dir, 5, Tesela, true);
                }
            }
            this.Refresh();
        }

        private MetroFramework.Controls.MetroTile TilesGrid(bool IsDir, int N, MetroFramework.Controls.MetroTile X, bool Update)
        {
            Sem.WaitOne();
            int Wdh = Form1.ControlSize.Width;
            int sz = Wdh / N;
            while (sz > X.MaximumSize.Width)
            {
                N++;
                sz = Wdh / N;
            }
            int SX = (sz + (Wdh % N)) / N;
            int SY = ComicControl.sepY;
            X.Size = new System.Drawing.Size(sz, (int)(sz * 1.5));
            int LocX = (SX * (1 + (X.TabIndex % N))) + (sz * (X.TabIndex % N));
            int LocY = (SY * (1 + (X.TabIndex / N))) + ((int)(sz * 1.5) * (X.TabIndex / N));
            X.Location = new System.Drawing.Point(LocX, LocY);
            Console.WriteLine("\tTile Index {0}\tLocation {1}\tLocation {2}\tLocX {3}\tLocY {4}", X.TabIndex, X.Size, X.Location, X.TabIndex % N, X.TabIndex / N);
            if(!Update){
                if (!IsDir)
                {
                    X.Style = MetroColorStyle.Green;
                    X.TileImage = Comic.GetThumb(X.Name, X.Size.Width, X.Size.Height);
                    X.UseTileImage = true;
                }
                Teselas.Add(X);
            }
            Sem.Release();
            return X;
        }
    }
}
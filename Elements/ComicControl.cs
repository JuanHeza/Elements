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
    public partial class ComicControl : MetroFramework.Controls.MetroUserControl
    {
        public ComicControl()
        {
            InitializeComponent();
        }

        List<MetroFramework.Controls.MetroTile> Teselas = new List<MetroFramework.Controls.MetroTile>();

        private void ComicControl_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Dirmap Comic {0}", Contenido.DirMap["Comic"].Count);
            TilesCreate();
            timer1.Start();
        }

        public void TilesCreate() { 
            foreach (string DR in Contenido.DirMap["Comic"]) { 
                Contenido cont = new Contenido(DR);
                cont.GetContent();
                int num = 6; // N + 1 donde N son los cuadros por fila, numero variable, fijo para pruebas
                Form1.ModStyle("Green");
                int Wdh = Form1.ControlSize.Width;
                int sz = Wdh / num;
                int sepX = (sz + (Wdh % num)) / num;
                int posX = sepX;
                int fila = 0;
                int sepY = 20;
                int posY = sepY;
            
                foreach (Contenido hijo in cont.Hijo)
                {
                    //Console.WriteLine("\t\t\tBEEP Pos = {0} Size = ( {1} , {2} )", posX, sz, (int)(sz * 1.5));
                    MetroFramework.Controls.MetroTile X = new MetroFramework.Controls.MetroTile();
                    X.Location = new System.Drawing.Point(posX, posY);
                    X.Text = hijo.Nombre;
                    X.Name = hijo.Nombre;
                    X.Style = MetroFramework.MetroColorStyle.Green;
                    X.Size = new System.Drawing.Size(sz, (int)(sz * 1.5));
                    X.MinimumSize = new System.Drawing.Size(120, 180);
                    X.ActiveControl = null;
                    X.Visible = true;
                    this.Controls.Add(X);
                    this.Refresh();
                    fila++;
                    if (fila >= num - 1)
                    {
                        fila = 0;
                        posY += sepY + (int)(sz * 1.5);
                        posX = sepX;
                    }
                    else { 
                        posX += sepX + sz;
                    }
                    Teselas.Add(X);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Size = Form1.ControlSize;
            int NewWidth = 120;
            Image originalImage = global::Elements.Properties.Resources.What_If___Spider_Man_House_Of_M_Vol_1;
            Image thumbnail = originalImage.GetThumbnailImage(NewWidth, (NewWidth * originalImage.Height) / originalImage.Width, null, IntPtr.Zero);
            //X.TileImage = thumbnail;
            //X.UseTileImage = true;
            //X.Text = thumbnail.Size.Width.ToString() + "," + thumbnail.Size.Height .ToString();
            
            this.Refresh();
        }

        private List<MetroFramework.Controls.MetroTile> TilesGrid()
        {
            List<MetroFramework.Controls.MetroTile> Tiles = new List<MetroFramework.Controls.MetroTile>();

            return Tiles;
        }
    }
}
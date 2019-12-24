using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework.Controls;
using MetroFramework;
using System.IO;

namespace Elements
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public static Form1 _instance;
        public static System.Drawing.Size ControlSize;
        public static Form1 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Form1();
                return _instance;
            }
        }
        public static Contenido actualFolder;

        public MetroFramework.Controls.MetroPanel MetroContainer
        {
            get { return metroPanel1; }
            set { metroPanel1 = value; }
        }
        public MetroFramework.Controls.MetroPanel MetroUserReader
        {
            get { return UserReader; }
            set { UserReader = value; }
        }
        /* public MetroFramework.Controls.MetroLink MetroHome
        {
            get { return metroHome; }
            set { metroHome = value; }
        }
        */
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _instance = this;
            Mongo.Conect();
            MainPage MP = new MainPage();
            MP.Dock = DockStyle.Fill;
            metroPanel1.Controls.Add(MP);
            //Contenido.InitDir();
        }

        private void metroHome_Click(object sender, EventArgs e)
        {
            //MetroMessageBox.Show(this, "Your message here.", "Title Here", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);
            metroPanel1.Controls["MainPage"].BringToFront();
            metroPanel1.Controls.RemoveAt(1);
            metroHome.Visible = false;
            _instance.Style = MetroFramework.MetroColorStyle.Silver;
            _instance.Refresh();
        }

        private void metroPanel1_SizeChanged(object sender, EventArgs e)
        {
        }

        private void metroBack_Click(object sender, EventArgs e)
        {
            rootFolder(); 
            visualBack();
        }

        private void rootFolder()
        {
            Contenido Root = actualFolder.Padre;
            Control X = metroPanel1.Controls[0];
            switch (X.ToString())
            {
                case "Elements.ComicControl":
                    ComicControl cmcctrl = (ComicControl)X;
                    cmcctrl.TilesDestroy();
                    cmcctrl.TilesCreate(Root);
                    break;
            }
            actualFolder = Root;
        }

        public static void visualBack()
        {
            if (actualFolder != null)
            {
                if (actualFolder.Padre != null)
                {
                   _instance.metroBack.Visible = true;
                }
                else
                {
                   _instance.metroBack.Visible = false;
                }
            }
        }
    }
}
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

        public MetroFramework.Controls.MetroPanel MetroContainer
        {
            get { return metroPanel1; }
            set { metroPanel1 = value; }
        }

        public MetroFramework.Controls.MetroLink MetroBack
        {
            get { return metroBack; }
            set { metroBack = value; }
        }
        /*
        public static object DirMap1
        {
            get {   return DirMap;  }
            set {   DirMap = value; }
        }
        */
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            metroBack.Visible = false;
            timer1.Start();
            //Console.WriteLine("Form1 Size {0}", this.Size);
            _instance = this;
            MainPage MP = new MainPage();
            MP.Dock = DockStyle.Fill;
            metroPanel1.Controls.Add(MP);
            Contenido.InitDir();
        }

        private void metroBack_Click(object sender, EventArgs e)
        {
            //MetroMessageBox.Show(this, "Your message here.", "Title Here", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);
            metroPanel1.Controls["MainPage"].BringToFront();
            metroBack.Visible = false;
        }

        public static void ModStyle(string style)
        {
            switch (style)
            {
                case "Green":
                    _instance.Style = MetroFramework.MetroColorStyle.Green;
                    _instance.Refresh();
                    break;
                default:
                    _instance.Style = MetroFramework.MetroColorStyle.Blue;
                    break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ControlSize = new System.Drawing.Size(this.Size.Width, (int)(this.Size.Height * 0.88));
            this.metroPanel1.Size = ControlSize;
        }
    }
}
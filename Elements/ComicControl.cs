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

        private void ComicControl_Load(object sender, EventArgs e)
        {
            Form1.GetAll();
            Form1.ModStyle("Green");
            MetroFramework.Controls.MetroTile X = new MetroFramework.Controls.MetroTile();
            X.Location = new System.Drawing.Point(220, 200);
            X.Text = "test";
            X.Name = "Test";
            X.Style = MetroFramework.MetroColorStyle.Green;
            X.Size = new System.Drawing.Size(120, 100);
            X.ActiveControl = null;
            X.Visible = true;
            this.Controls.Add(X);
            this.Refresh();
        }


    }
}

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

namespace Elements
{
    public partial class Notable : Form
    {
        public Notable()
        {
            InitializeComponent();
            customizar();
        }

        private void customizar()
        {
            metroPanel3.Visible = false;
            metroPanel4.Visible = false;

        }
        private void hidesubmenu()
        {
            if (metroPanel3.Visible)
            {
                metroPanel3.Visible = false;
            }
            if (metroPanel4.Visible)
            {
                metroPanel4.Visible = false;
            }
        }

        private void showsubmenu(MetroFramework.Controls.MetroPanel panel)
        {
            if (!panel.Visible)
            {
                hidesubmenu();
                panel.Visible = true;
            }
            else
            {
                panel.Visible = false;
            }
        }

        private void Notable_Load(object sender, EventArgs e)
        {

        }

        #region panel3
        private void metroButton1_Click(object sender, EventArgs e)
        {
            showsubmenu(metroPanel3);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //showform(new ComicReader(30, 40, new Contenido("HOLA")));
            hidesubmenu();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hidesubmenu();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            hidesubmenu();

        }
        #endregion

        #region panel4
        private void metroButton2_Click(object sender, EventArgs e)
        {
            showsubmenu(metroPanel4);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            hidesubmenu();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            hidesubmenu();

        }
        #endregion

        #region botonsolo
        private void metroButton3_Click(object sender, EventArgs e)
        {
            hidesubmenu();
        }
        #endregion

        private MetroFramework.Controls.MetroUserControl formulario = null;
        private void showform(MetroFramework.Controls.MetroUserControl child)
        {
            if (formulario != null)
            {
                formulario.Dispose();
            }
            formulario = child;
            child.Dock = DockStyle.Fill;
            metroPanel6.Controls.Add(child);
            metroPanel6.Tag = child;
            child.BringToFront();
            child.Show();
        }
    }
}

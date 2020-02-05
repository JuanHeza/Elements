using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elements
{
    public partial class EbookReader : MetroFramework.Controls.MetroUserControl
    {
        public EbookReader()
        {
            InitializeComponent();
        }
        public EbookReader(int w, int h, Contenido File)
        {
            InitializeComponent();
            
            Form1._instance.metroHome.Visible = false;
        }
        private void htmlPanel1_Click(object sender, EventArgs e)
        {
        }
    }
}

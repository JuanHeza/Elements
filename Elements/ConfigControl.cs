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
    public partial class ConfigControl : MetroFramework.Controls.MetroUserControl
    {
        private List<MetroFramework.Controls.MetroPanel> Paneles = new List<MetroFramework.Controls.MetroPanel>();
        public ConfigControl()
        {
            InitializeComponent();
            customizar();
        }

        #region Comic
        private void ComicButton_Click(object sender, EventArgs e)
        {
            showsubmenu(ComicPanel);
        }

        private void ComicConfig_Click(object sender, EventArgs e)
        {
            hidesubmenu();
          //Mongo.Test();
        }
        #endregion

        #region Ebook
        private void EbookButton_Click(object sender, EventArgs e)
        {
            showsubmenu(EbookPanel);
        }

        private void EbookConfig_Click(object sender, EventArgs e)
        {
            hidesubmenu();

        }
        #endregion

        #region Video
        private void VideoButton_Click(object sender, EventArgs e)
        {
            showsubmenu(VideoPanel);
        }

        private void VideoConfig_Click(object sender, EventArgs e)
        {
            hidesubmenu();

        }
        #endregion

        #region Musica
        private void MusicButton_Click(object sender, EventArgs e)
        {
            showsubmenu(MusicPanel);
        }

        private void MusicConfig_Click(object sender, EventArgs e)
        {
            hidesubmenu();

        }
        #endregion

        #region General
        private void GeneralButton_Click(object sender, EventArgs e)
        {
            showsubmenu(GeneralPanel);
        }

        private void GeneralConfig_Click(object sender, EventArgs e)
        {
            hidesubmenu();

        }
        #endregion

        #region Nube
        private void NubeButton_Click(object sender, EventArgs e)
        {
            showsubmenu(NubePanel);
        }

        private void NubeConfig_Click(object sender, EventArgs e)
        {
            hidesubmenu();

        }
        #endregion

        private void hidesubmenu()
        {
            foreach (MetroFramework.Controls.MetroPanel panel in Paneles)
            {
                if (panel.Visible)
                {
                    panel.Visible = false;
                }
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

        private void customizar()
        {
            Paneles.Add(ComicPanel);
            Paneles.Add(MusicPanel);
            Paneles.Add(VideoPanel);
            Paneles.Add(EbookPanel);
            Paneles.Add(GeneralPanel);
            Paneles.Add(NubePanel);
            foreach (MetroFramework.Controls.MetroPanel panel in Paneles)
            {
                panel.Visible = false;
            }
        }

    }
}

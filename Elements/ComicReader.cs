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
    public partial class ComicReader : MetroFramework.Controls.MetroUserControl
    {
        private Comic ActualFile;

        public ComicReader(int w, int h, Contenido File, List<string> Bros)
        {
            InitializeComponent();
            PreLoadFile(File,Bros);
            Form1._instance.metroHome.Visible = false;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            PanelHeader.Visible = !PanelHeader.Visible;
            PanelControls.Visible = !PanelControls.Visible;
            PanelAvanza.Visible = !PanelAvanza.Visible;
            PanelRetrocede.Visible = !PanelRetrocede.Visible;
        }

        private void Avanza_Click(object sender, EventArgs e)
        {
            if (ProgressBar.Value < ProgressBar.Maximum)
            {
                ProgressBar.Value += 1;
                this.BackgroundImage = ActualFile.Paginas[ProgressBar.Value - 1];
            }
        }
        private void SetCover(object sender, EventArgs e)
        {
            Mongo.UpdateCover(ActualFile.Titulo, ActualFile.Paginas[ProgressBar.Value - 1]);
        }

        private void Atras_Click(object sender, EventArgs e)
        {
            if (ProgressBar.Value > ProgressBar.Minimum)
            {
                ProgressBar.Value -= 1;
                this.BackgroundImage = ActualFile.Paginas[ProgressBar.Value - 1];
            }
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            Form1._instance.MetroUserReader.Visible = false;
            Form1._instance.metroHome.Visible = true;
            Form1._instance.MetroUserReader.Controls.RemoveAt(0);
        }

        private void Feliz_Click(object sender, EventArgs e)
        {
            this.BackgroundImageLayout = ImageLayout.Center;
        }

        private void Triste_Click(object sender, EventArgs e)
        {
            this.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void PreLoadFile(Contenido File, List<string> Bros)
        {
            ActualFile = new Comic(File, Bros);
            ProgressBar.Maximum = ActualFile.Paginas.Count;
            this.BackgroundImage = ActualFile.Portada;
        }

    }
}

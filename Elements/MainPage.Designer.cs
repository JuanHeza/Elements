namespace Elements
{
    partial class MainPage
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tileComic = new MetroFramework.Controls.MetroTile();
            this.tileVideo = new MetroFramework.Controls.MetroTile();
            this.tileMusica = new MetroFramework.Controls.MetroTile();
            this.tileEbook = new MetroFramework.Controls.MetroTile();
            this.tileNube = new MetroFramework.Controls.MetroTile();
            this.tileOpciones = new MetroFramework.Controls.MetroTile();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // tileComic
            // 
            this.tileComic.ActiveControl = null;
            this.tileComic.BackColor = System.Drawing.Color.ForestGreen;
            this.tileComic.Location = new System.Drawing.Point(60, 75);
            this.tileComic.MinimumSize = new System.Drawing.Size(26, 10);
            this.tileComic.Name = "tileComic";
            this.tileComic.Size = new System.Drawing.Size(260, 100);
            this.tileComic.Style = MetroFramework.MetroColorStyle.Green;
            this.tileComic.TabIndex = 6;
            this.tileComic.Text = "Comic";
            this.tileComic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileComic.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileComic.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileComic.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.tileComic.UseSelectable = true;
            this.tileComic.UseStyleColors = true;
            this.tileComic.Click += new System.EventHandler(this.tileComic_Click);
            // 
            // tileVideo
            // 
            this.tileVideo.ActiveControl = null;
            this.tileVideo.BackColor = System.Drawing.Color.DarkViolet;
            this.tileVideo.Location = new System.Drawing.Point(390, 75);
            this.tileVideo.MinimumSize = new System.Drawing.Size(26, 10);
            this.tileVideo.Name = "tileVideo";
            this.tileVideo.Size = new System.Drawing.Size(260, 100);
            this.tileVideo.Style = MetroFramework.MetroColorStyle.Purple;
            this.tileVideo.TabIndex = 7;
            this.tileVideo.Text = "Video";
            this.tileVideo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileVideo.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileVideo.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileVideo.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.tileVideo.UseSelectable = true;
            this.tileVideo.UseStyleColors = true;
            // 
            // tileMusica
            // 
            this.tileMusica.ActiveControl = null;
            this.tileMusica.BackColor = System.Drawing.Color.RoyalBlue;
            this.tileMusica.Location = new System.Drawing.Point(390, 220);
            this.tileMusica.MinimumSize = new System.Drawing.Size(26, 10);
            this.tileMusica.Name = "tileMusica";
            this.tileMusica.Size = new System.Drawing.Size(260, 100);
            this.tileMusica.Style = MetroFramework.MetroColorStyle.Teal;
            this.tileMusica.TabIndex = 9;
            this.tileMusica.Text = "Musica";
            this.tileMusica.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileMusica.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileMusica.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileMusica.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.tileMusica.UseSelectable = true;
            this.tileMusica.UseStyleColors = true;
            // 
            // tileEbook
            // 
            this.tileEbook.ActiveControl = null;
            this.tileEbook.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.tileEbook.Location = new System.Drawing.Point(60, 220);
            this.tileEbook.MinimumSize = new System.Drawing.Size(26, 10);
            this.tileEbook.Name = "tileEbook";
            this.tileEbook.Size = new System.Drawing.Size(260, 100);
            this.tileEbook.Style = MetroFramework.MetroColorStyle.Orange;
            this.tileEbook.TabIndex = 8;
            this.tileEbook.Text = "Ebook";
            this.tileEbook.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileEbook.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileEbook.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileEbook.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.tileEbook.UseSelectable = true;
            this.tileEbook.UseStyleColors = true;
            // 
            // tileNube
            // 
            this.tileNube.ActiveControl = null;
            this.tileNube.BackColor = System.Drawing.Color.Firebrick;
            this.tileNube.Location = new System.Drawing.Point(390, 365);
            this.tileNube.MinimumSize = new System.Drawing.Size(26, 10);
            this.tileNube.Name = "tileNube";
            this.tileNube.Size = new System.Drawing.Size(260, 100);
            this.tileNube.Style = MetroFramework.MetroColorStyle.Red;
            this.tileNube.TabIndex = 11;
            this.tileNube.Text = "Nube";
            this.tileNube.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileNube.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileNube.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileNube.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.tileNube.UseSelectable = true;
            this.tileNube.UseStyleColors = true;
            // 
            // tileOpciones
            // 
            this.tileOpciones.ActiveControl = null;
            this.tileOpciones.BackColor = System.Drawing.Color.DimGray;
            this.tileOpciones.Location = new System.Drawing.Point(60, 365);
            this.tileOpciones.MinimumSize = new System.Drawing.Size(26, 10);
            this.tileOpciones.Name = "tileOpciones";
            this.tileOpciones.Size = new System.Drawing.Size(260, 100);
            this.tileOpciones.Style = MetroFramework.MetroColorStyle.Silver;
            this.tileOpciones.TabIndex = 10;
            this.tileOpciones.Text = "Opciones";
            this.tileOpciones.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileOpciones.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileOpciones.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileOpciones.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.tileOpciones.UseSelectable = true;
            this.tileOpciones.UseStyleColors = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.tileNube);
            this.Controls.Add(this.tileOpciones);
            this.Controls.Add(this.tileMusica);
            this.Controls.Add(this.tileEbook);
            this.Controls.Add(this.tileVideo);
            this.Controls.Add(this.tileComic);
            this.Font = new System.Drawing.Font("Strasua", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MinimumSize = new System.Drawing.Size(71, 52);
            this.Name = "MainPage";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(710, 520);
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile tileComic;
        private MetroFramework.Controls.MetroTile tileVideo;
        private MetroFramework.Controls.MetroTile tileMusica;
        private MetroFramework.Controls.MetroTile tileEbook;
        private MetroFramework.Controls.MetroTile tileNube;
        private MetroFramework.Controls.MetroTile tileOpciones;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}

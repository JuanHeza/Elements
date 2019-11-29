namespace Elements
{
    partial class ComicReader
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
            this.LabelTitulo = new MetroFramework.Controls.MetroLabel();
            this.PanelHeader = new MetroFramework.Controls.MetroPanel();
            this.PanelControls = new MetroFramework.Controls.MetroPanel();
            this.ButtonTriste = new MetroFramework.Controls.MetroButton();
            this.ButtonFeliz = new MetroFramework.Controls.MetroButton();
            this.ButtonCerrar = new MetroFramework.Controls.MetroButton();
            this.ButtonAvanza = new MetroFramework.Controls.MetroButton();
            this.ButtonRetrocede = new MetroFramework.Controls.MetroButton();
            this.ProgressBar = new MetroFramework.Controls.MetroTrackBar();
            this.PanelRetrocede = new MetroFramework.Controls.MetroPanel();
            this.PanelAvanza = new MetroFramework.Controls.MetroPanel();
            this.PanelHeader.SuspendLayout();
            this.PanelControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelTitulo
            // 
            this.LabelTitulo.AutoSize = true;
            this.LabelTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelTitulo.Location = new System.Drawing.Point(0, 0);
            this.LabelTitulo.Name = "LabelTitulo";
            this.LabelTitulo.Size = new System.Drawing.Size(81, 19);
            this.LabelTitulo.TabIndex = 4;
            this.LabelTitulo.Text = "metroLabel1";
            // 
            // PanelHeader
            // 
            this.PanelHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelHeader.BackColor = System.Drawing.Color.Transparent;
            this.PanelHeader.Controls.Add(this.LabelTitulo);
            this.PanelHeader.HorizontalScrollbarBarColor = true;
            this.PanelHeader.HorizontalScrollbarHighlightOnWheel = false;
            this.PanelHeader.HorizontalScrollbarSize = 10;
            this.PanelHeader.Location = new System.Drawing.Point(0, 0);
            this.PanelHeader.Name = "PanelHeader";
            this.PanelHeader.Size = new System.Drawing.Size(600, 60);
            this.PanelHeader.TabIndex = 5;
            this.PanelHeader.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.PanelHeader.VerticalScrollbarBarColor = true;
            this.PanelHeader.VerticalScrollbarHighlightOnWheel = false;
            this.PanelHeader.VerticalScrollbarSize = 10;
            this.PanelHeader.Visible = false;
            // 
            // PanelControls
            // 
            this.PanelControls.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelControls.BackColor = System.Drawing.Color.Transparent;
            this.PanelControls.Controls.Add(this.ButtonTriste);
            this.PanelControls.Controls.Add(this.ButtonFeliz);
            this.PanelControls.Controls.Add(this.ButtonCerrar);
            this.PanelControls.Controls.Add(this.ButtonAvanza);
            this.PanelControls.Controls.Add(this.ButtonRetrocede);
            this.PanelControls.Controls.Add(this.ProgressBar);
            this.PanelControls.HorizontalScrollbarBarColor = true;
            this.PanelControls.HorizontalScrollbarHighlightOnWheel = false;
            this.PanelControls.HorizontalScrollbarSize = 10;
            this.PanelControls.Location = new System.Drawing.Point(0, 440);
            this.PanelControls.Name = "PanelControls";
            this.PanelControls.Size = new System.Drawing.Size(600, 60);
            this.PanelControls.TabIndex = 5;
            this.PanelControls.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.PanelControls.VerticalScrollbarBarColor = true;
            this.PanelControls.VerticalScrollbarHighlightOnWheel = false;
            this.PanelControls.VerticalScrollbarSize = 10;
            this.PanelControls.Visible = false;
            // 
            // ButtonTriste
            // 
            this.ButtonTriste.AutoSize = true;
            this.ButtonTriste.DisplayFocus = true;
            this.ButtonTriste.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.ButtonTriste.Location = new System.Drawing.Point(350, 30);
            this.ButtonTriste.Name = "ButtonTriste";
            this.ButtonTriste.Size = new System.Drawing.Size(40, 30);
            this.ButtonTriste.TabIndex = 7;
            this.ButtonTriste.Text = ":(";
            this.ButtonTriste.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ButtonTriste.UseSelectable = true;
            this.ButtonTriste.Click += new System.EventHandler(this.Triste_Click);
            // 
            // ButtonFeliz
            // 
            this.ButtonFeliz.AutoSize = true;
            this.ButtonFeliz.DisplayFocus = true;
            this.ButtonFeliz.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.ButtonFeliz.Location = new System.Drawing.Point(275, 30);
            this.ButtonFeliz.Name = "ButtonFeliz";
            this.ButtonFeliz.Size = new System.Drawing.Size(40, 30);
            this.ButtonFeliz.TabIndex = 6;
            this.ButtonFeliz.Text = ":)";
            this.ButtonFeliz.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ButtonFeliz.UseSelectable = true;
            this.ButtonFeliz.Click += new System.EventHandler(this.Feliz_Click);
            // 
            // ButtonCerrar
            // 
            this.ButtonCerrar.AutoSize = true;
            this.ButtonCerrar.DisplayFocus = true;
            this.ButtonCerrar.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.ButtonCerrar.Location = new System.Drawing.Point(185, 30);
            this.ButtonCerrar.Name = "ButtonCerrar";
            this.ButtonCerrar.Size = new System.Drawing.Size(40, 30);
            this.ButtonCerrar.TabIndex = 5;
            this.ButtonCerrar.Text = "X";
            this.ButtonCerrar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ButtonCerrar.UseSelectable = true;
            this.ButtonCerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // ButtonAvanza
            // 
            this.ButtonAvanza.AutoSize = true;
            this.ButtonAvanza.DisplayFocus = true;
            this.ButtonAvanza.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.ButtonAvanza.Location = new System.Drawing.Point(105, 30);
            this.ButtonAvanza.Name = "ButtonAvanza";
            this.ButtonAvanza.Size = new System.Drawing.Size(40, 30);
            this.ButtonAvanza.TabIndex = 4;
            this.ButtonAvanza.Text = ">";
            this.ButtonAvanza.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ButtonAvanza.UseSelectable = true;
            this.ButtonAvanza.Click += new System.EventHandler(this.Avanza_Click);
            // 
            // ButtonRetrocede
            // 
            this.ButtonRetrocede.AutoSize = true;
            this.ButtonRetrocede.DisplayFocus = true;
            this.ButtonRetrocede.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.ButtonRetrocede.Location = new System.Drawing.Point(20, 30);
            this.ButtonRetrocede.Name = "ButtonRetrocede";
            this.ButtonRetrocede.Size = new System.Drawing.Size(40, 30);
            this.ButtonRetrocede.TabIndex = 3;
            this.ButtonRetrocede.Text = "<";
            this.ButtonRetrocede.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ButtonRetrocede.UseSelectable = true;
            this.ButtonRetrocede.Click += new System.EventHandler(this.Atras_Click);
            // 
            // ProgressBar
            // 
            this.ProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.ProgressBar.Location = new System.Drawing.Point(10, 0);
            this.ProgressBar.Maximum = 20;
            this.ProgressBar.Minimum = 1;
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.ProgressBar.Size = new System.Drawing.Size(580, 30);
            this.ProgressBar.TabIndex = 2;
            this.ProgressBar.Text = "metroTrackBar1";
            this.ProgressBar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ProgressBar.Value = 1;
            // 
            // PanelRetrocede
            // 
            this.PanelRetrocede.BackColor = System.Drawing.Color.Transparent;
            this.PanelRetrocede.BackgroundImage = global::Elements.Properties.Resources.icons8_chevron_izquierda_en_círculo_64;
            this.PanelRetrocede.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PanelRetrocede.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelRetrocede.HorizontalScrollbarBarColor = true;
            this.PanelRetrocede.HorizontalScrollbarHighlightOnWheel = false;
            this.PanelRetrocede.HorizontalScrollbarSize = 10;
            this.PanelRetrocede.Location = new System.Drawing.Point(0, 0);
            this.PanelRetrocede.Name = "PanelRetrocede";
            this.PanelRetrocede.Size = new System.Drawing.Size(200, 500);
            this.PanelRetrocede.TabIndex = 6;
            this.PanelRetrocede.UseCustomBackColor = true;
            this.PanelRetrocede.VerticalScrollbarBarColor = true;
            this.PanelRetrocede.VerticalScrollbarHighlightOnWheel = false;
            this.PanelRetrocede.VerticalScrollbarSize = 10;
            this.PanelRetrocede.Click += new System.EventHandler(this.Atras_Click);
            // 
            // PanelAvanza
            // 
            this.PanelAvanza.BackColor = System.Drawing.Color.Transparent;
            this.PanelAvanza.BackgroundImage = global::Elements.Properties.Resources.icons8_chevron_derecha_en_círculo_64;
            this.PanelAvanza.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PanelAvanza.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelAvanza.HorizontalScrollbarBarColor = true;
            this.PanelAvanza.HorizontalScrollbarHighlightOnWheel = false;
            this.PanelAvanza.HorizontalScrollbarSize = 10;
            this.PanelAvanza.Location = new System.Drawing.Point(400, 0);
            this.PanelAvanza.Name = "PanelAvanza";
            this.PanelAvanza.Size = new System.Drawing.Size(200, 500);
            this.PanelAvanza.TabIndex = 7;
            this.PanelAvanza.UseCustomBackColor = true;
            this.PanelAvanza.VerticalScrollbarBarColor = true;
            this.PanelAvanza.VerticalScrollbarHighlightOnWheel = false;
            this.PanelAvanza.VerticalScrollbarSize = 10;
            this.PanelAvanza.Click += new System.EventHandler(this.Avanza_Click);
            // 
            // ComicReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.BackgroundImage = global::Elements.Properties.Resources.EKZ0HhiUEAAr7k9;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.PanelAvanza);
            this.Controls.Add(this.PanelRetrocede);
            this.Controls.Add(this.PanelControls);
            this.Controls.Add(this.PanelHeader);
            this.Name = "ComicReader";
            this.Size = new System.Drawing.Size(600, 500);
            this.Click += new System.EventHandler(this.metroButton1_Click);
            this.PanelHeader.ResumeLayout(false);
            this.PanelHeader.PerformLayout();
            this.PanelControls.ResumeLayout(false);
            this.PanelControls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroLabel LabelTitulo;
        private MetroFramework.Controls.MetroPanel PanelHeader;
        private MetroFramework.Controls.MetroPanel PanelControls;
        private MetroFramework.Controls.MetroButton ButtonTriste;
        private MetroFramework.Controls.MetroButton ButtonFeliz;
        private MetroFramework.Controls.MetroButton ButtonCerrar;
        private MetroFramework.Controls.MetroButton ButtonAvanza;
        private MetroFramework.Controls.MetroButton ButtonRetrocede;
        private MetroFramework.Controls.MetroTrackBar ProgressBar;
        private MetroFramework.Controls.MetroPanel PanelRetrocede;
        private MetroFramework.Controls.MetroPanel PanelAvanza;
    }
}

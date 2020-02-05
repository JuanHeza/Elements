namespace Elements
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.UserReader = new MetroFramework.Controls.MetroPanel();
            this.metroBack = new MetroFramework.Controls.MetroLink();
            this.metroHome = new MetroFramework.Controls.MetroLink();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel1.AutoScroll = true;
            this.metroPanel1.HorizontalScrollbar = true;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 50);
            this.metroPanel1.MinimumSize = new System.Drawing.Size(71, 46);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(710, 450);
            this.metroPanel1.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroPanel1.TabIndex = 1;
            this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel1.VerticalScrollbar = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = true;
            this.metroPanel1.VerticalScrollbarSize = 10;
            this.metroPanel1.SizeChanged += new System.EventHandler(this.metroPanel1_SizeChanged);
            // 
            // UserReader
            // 
            this.UserReader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UserReader.BackColor = System.Drawing.Color.Transparent;
            this.UserReader.HorizontalScrollbarBarColor = true;
            this.UserReader.HorizontalScrollbarHighlightOnWheel = false;
            this.UserReader.HorizontalScrollbarSize = 10;
            this.UserReader.Location = new System.Drawing.Point(0, 0);
            this.UserReader.Name = "UserReader";
            this.UserReader.Size = new System.Drawing.Size(710, 520);
            this.UserReader.Style = MetroFramework.MetroColorStyle.Silver;
            this.UserReader.TabIndex = 4;
            this.UserReader.Theme = MetroFramework.MetroThemeStyle.Light;
            this.UserReader.UseCustomBackColor = true;
            this.UserReader.VerticalScrollbarBarColor = true;
            this.UserReader.VerticalScrollbarHighlightOnWheel = false;
            this.UserReader.VerticalScrollbarSize = 10;
            this.UserReader.Visible = false;
            // 
            // metroBack
            // 
            this.metroBack.BackColor = System.Drawing.Color.Transparent;
            this.metroBack.BackgroundImage = global::Elements.Properties.Resources.ChevronIzquierdaCírculo;
            this.metroBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.metroBack.DisplayFocus = true;
            this.metroBack.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.metroBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metroBack.Location = new System.Drawing.Point(45, 20);
            this.metroBack.Name = "metroBack";
            this.metroBack.Size = new System.Drawing.Size(30, 30);
            this.metroBack.Style = MetroFramework.MetroColorStyle.Green;
            this.metroBack.TabIndex = 3;
            this.metroBack.UseCustomBackColor = true;
            this.metroBack.UseCustomForeColor = true;
            this.metroBack.UseSelectable = true;
            this.metroBack.Visible = false;
            this.metroBack.Click += new System.EventHandler(this.metroBack_Click);
            // 
            // metroHome
            // 
            this.metroHome.BackColor = System.Drawing.Color.Transparent;
            this.metroHome.BackgroundImage = global::Elements.Properties.Resources.Cabaña;
            this.metroHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.metroHome.DisplayFocus = true;
            this.metroHome.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.metroHome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metroHome.Location = new System.Drawing.Point(10, 20);
            this.metroHome.Name = "metroHome";
            this.metroHome.Size = new System.Drawing.Size(30, 30);
            this.metroHome.Style = MetroFramework.MetroColorStyle.Green;
            this.metroHome.TabIndex = 2;
            this.metroHome.UseCustomBackColor = true;
            this.metroHome.UseCustomForeColor = true;
            this.metroHome.UseSelectable = true;
            this.metroHome.Visible = false;
            this.metroHome.Click += new System.EventHandler(this.metroHome_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(710, 520);
            this.Controls.Add(this.UserReader);
            this.Controls.Add(this.metroBack);
            this.Controls.Add(this.metroHome);
            this.Controls.Add(this.metroPanel1);
            this.Font = new System.Drawing.Font("Strasua", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(710, 520);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(29, 93, 29, 31);
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "00:00";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Right;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroPanel metroPanel1;
        public MetroFramework.Controls.MetroLink metroHome;
        public MetroFramework.Controls.MetroLink metroBack;
        private MetroFramework.Controls.MetroPanel UserReader;
    }
}


namespace Elements
{
    partial class EbookReader
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
            this.htmlPanel1 = new MetroFramework.Drawing.Html.HtmlPanel();
            this.SuspendLayout();
            // 
            // htmlPanel1
            // 
            this.htmlPanel1.AutoScroll = true;
            this.htmlPanel1.AutoScrollMinSize = new System.Drawing.Size(625, 18);
            this.htmlPanel1.BackColor = System.Drawing.SystemColors.Window;
            this.htmlPanel1.Location = new System.Drawing.Point(10, 0);
            this.htmlPanel1.Name = "htmlPanel1";
            this.htmlPanel1.Size = new System.Drawing.Size(600, 465);
            this.htmlPanel1.TabIndex = 0;
            this.htmlPanel1.Text = "htmlPanel1";
            this.htmlPanel1.Click += new System.EventHandler(this.htmlPanel1_Click);
            // 
            // EbookReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.htmlPanel1);
            this.Name = "EbookReader";
            this.Size = new System.Drawing.Size(620, 463);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Drawing.Html.HtmlPanel htmlPanel1;
    }
}

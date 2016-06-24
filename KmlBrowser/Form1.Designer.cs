namespace KmlBrowser
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLoad = new System.Windows.Forms.Button();
            this.tbOut = new System.Windows.Forms.TextBox();
            this.tBKmlDateiName = new System.Windows.Forms.TextBox();
            this.btnFileAuswahl = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(12, 12);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Show";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // tbOut
            // 
            this.tbOut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbOut.Location = new System.Drawing.Point(12, 41);
            this.tbOut.Multiline = true;
            this.tbOut.Name = "tbOut";
            this.tbOut.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbOut.Size = new System.Drawing.Size(722, 403);
            this.tbOut.TabIndex = 1;
            // 
            // tBKmlDateiName
            // 
            this.tBKmlDateiName.Location = new System.Drawing.Point(93, 14);
            this.tBKmlDateiName.Name = "tBKmlDateiName";
            this.tBKmlDateiName.Size = new System.Drawing.Size(551, 20);
            this.tBKmlDateiName.TabIndex = 2;
            this.tBKmlDateiName.Text = "..\\..\\..\\Daten\\Ideen.kml";
            // 
            // btnFileAuswahl
            // 
            this.btnFileAuswahl.Location = new System.Drawing.Point(659, 11);
            this.btnFileAuswahl.Name = "btnFileAuswahl";
            this.btnFileAuswahl.Size = new System.Drawing.Size(75, 23);
            this.btnFileAuswahl.TabIndex = 3;
            this.btnFileAuswahl.Text = "Auswahl";
            this.btnFileAuswahl.UseVisualStyleBackColor = true;
            this.btnFileAuswahl.Click += new System.EventHandler(this.btnFileAuswahl_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 456);
            this.Controls.Add(this.btnFileAuswahl);
            this.Controls.Add(this.tBKmlDateiName);
            this.Controls.Add(this.tbOut);
            this.Controls.Add(this.btnLoad);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TextBox tbOut;
        private System.Windows.Forms.TextBox tBKmlDateiName;
        private System.Windows.Forms.Button btnFileAuswahl;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}


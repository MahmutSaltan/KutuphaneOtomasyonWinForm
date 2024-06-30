namespace KutuphaneOtomasyonWinForm
{
    partial class IslemPaneli
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IslemPaneli));
            this.panel1 = new System.Windows.Forms.Panel();
            this.silKullanicibtn = new System.Windows.Forms.Button();
            this.güncelleKullanicibtn = new System.Windows.Forms.Button();
            this.ekleKullanicibtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.kullaniciBilgiPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.silKullanicibtn);
            this.panel1.Controls.Add(this.güncelleKullanicibtn);
            this.panel1.Controls.Add(this.ekleKullanicibtn);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(177, 680);
            this.panel1.TabIndex = 0;
            // 
            // silKullanicibtn
            // 
            this.silKullanicibtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.silKullanicibtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.silKullanicibtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.silKullanicibtn.Image = ((System.Drawing.Image)(resources.GetObject("silKullanicibtn.Image")));
            this.silKullanicibtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.silKullanicibtn.Location = new System.Drawing.Point(0, 225);
            this.silKullanicibtn.Name = "silKullanicibtn";
            this.silKullanicibtn.Size = new System.Drawing.Size(177, 75);
            this.silKullanicibtn.TabIndex = 3;
            this.silKullanicibtn.Text = "   Sil";
            this.silKullanicibtn.UseVisualStyleBackColor = false;
            this.silKullanicibtn.Click += new System.EventHandler(this.silKullanicibtn_Click);
            // 
            // güncelleKullanicibtn
            // 
            this.güncelleKullanicibtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.güncelleKullanicibtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.güncelleKullanicibtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.güncelleKullanicibtn.Image = ((System.Drawing.Image)(resources.GetObject("güncelleKullanicibtn.Image")));
            this.güncelleKullanicibtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.güncelleKullanicibtn.Location = new System.Drawing.Point(0, 150);
            this.güncelleKullanicibtn.Name = "güncelleKullanicibtn";
            this.güncelleKullanicibtn.Size = new System.Drawing.Size(177, 75);
            this.güncelleKullanicibtn.TabIndex = 2;
            this.güncelleKullanicibtn.Text = "  Güncelle";
            this.güncelleKullanicibtn.UseVisualStyleBackColor = false;
            // 
            // ekleKullanicibtn
            // 
            this.ekleKullanicibtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.ekleKullanicibtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ekleKullanicibtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ekleKullanicibtn.Image = ((System.Drawing.Image)(resources.GetObject("ekleKullanicibtn.Image")));
            this.ekleKullanicibtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ekleKullanicibtn.Location = new System.Drawing.Point(0, 75);
            this.ekleKullanicibtn.Name = "ekleKullanicibtn";
            this.ekleKullanicibtn.Size = new System.Drawing.Size(177, 75);
            this.ekleKullanicibtn.TabIndex = 1;
            this.ekleKullanicibtn.Text = "   Ekle";
            this.ekleKullanicibtn.UseVisualStyleBackColor = false;
            this.ekleKullanicibtn.Click += new System.EventHandler(this.ekleKullanicibtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 75);
            this.button1.TabIndex = 0;
            this.button1.Text = "      Kullanıcılar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // kullaniciBilgiPanel
            // 
            this.kullaniciBilgiPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.kullaniciBilgiPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.kullaniciBilgiPanel.Location = new System.Drawing.Point(177, 0);
            this.kullaniciBilgiPanel.Name = "kullaniciBilgiPanel";
            this.kullaniciBilgiPanel.Size = new System.Drawing.Size(1037, 75);
            this.kullaniciBilgiPanel.TabIndex = 1;
            // 
            // IslemPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 680);
            this.Controls.Add(this.kullaniciBilgiPanel);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "IslemPaneli";
            this.Text = "İslem Paneli";
            this.Load += new System.EventHandler(this.IslemPaneli_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel kullaniciBilgiPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ekleKullanicibtn;
        private System.Windows.Forms.Button silKullanicibtn;
        private System.Windows.Forms.Button güncelleKullanicibtn;
    }
}
namespace zeytur2
{
    partial class AnaEkran
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.msSorgu = new System.Windows.Forms.ToolStripMenuItem();
            this.msPersonelInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.msMusteriInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriKayıtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msSorgu,
            this.msPersonelInfo,
            this.msMusteriInfo,
            this.müşteriKayıtToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // msSorgu
            // 
            this.msSorgu.Name = "msSorgu";
            this.msSorgu.Size = new System.Drawing.Size(96, 24);
            this.msSorgu.Text = "Bilet Sorgu";
            this.msSorgu.Click += new System.EventHandler(this.msSorgu_Click);
            // 
            // msPersonelInfo
            // 
            this.msPersonelInfo.Name = "msPersonelInfo";
            this.msPersonelInfo.Size = new System.Drawing.Size(112, 24);
            this.msPersonelInfo.Text = "Personel Bilgi";
            this.msPersonelInfo.Click += new System.EventHandler(this.msPersonelInfo_Click);
            // 
            // msMusteriInfo
            // 
            this.msMusteriInfo.Name = "msMusteriInfo";
            this.msMusteriInfo.Size = new System.Drawing.Size(106, 24);
            this.msMusteriInfo.Text = "Müşteri Bilgi";
            this.msMusteriInfo.Click += new System.EventHandler(this.msMusteriInfo_Click);
            // 
            // müşteriKayıtToolStripMenuItem
            // 
            this.müşteriKayıtToolStripMenuItem.Name = "müşteriKayıtToolStripMenuItem";
            this.müşteriKayıtToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.müşteriKayıtToolStripMenuItem.Text = "Yolcu Kaydet";
            this.müşteriKayıtToolStripMenuItem.Click += new System.EventHandler(this.müşteriKayıtToolStripMenuItem_Click);
            // 
            // AnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AnaEkran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnaEkran";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AnaEkran_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem msSorgu;
        private System.Windows.Forms.ToolStripMenuItem msPersonelInfo;
        private System.Windows.Forms.ToolStripMenuItem msMusteriInfo;
        private System.Windows.Forms.ToolStripMenuItem müşteriKayıtToolStripMenuItem;
    }
}
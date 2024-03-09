namespace zeytur2
{
    partial class PersonelInfo
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAra = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtRol = new System.Windows.Forms.TextBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.dgvListele = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListele)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "Şifre :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Rol :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Ad Soyad :";
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAra.Location = new System.Drawing.Point(814, 54);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(140, 33);
            this.btnAra.TabIndex = 20;
            this.btnAra.Text = "Personel Ara";
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Tomato;
            this.btnSil.Location = new System.Drawing.Point(151, 456);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(236, 35);
            this.btnSil.TabIndex = 19;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnGuncelle.Location = new System.Drawing.Point(151, 401);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(236, 33);
            this.btnGuncelle.TabIndex = 18;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.YellowGreen;
            this.btnKaydet.Location = new System.Drawing.Point(151, 340);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(236, 33);
            this.btnKaydet.TabIndex = 17;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(230, 252);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(157, 22);
            this.txtSifre.TabIndex = 16;
            // 
            // txtRol
            // 
            this.txtRol.Location = new System.Drawing.Point(230, 176);
            this.txtRol.Name = "txtRol";
            this.txtRol.Size = new System.Drawing.Size(157, 22);
            this.txtRol.TabIndex = 15;
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(230, 106);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(157, 22);
            this.txtAdSoyad.TabIndex = 14;
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(563, 59);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(205, 22);
            this.txtAra.TabIndex = 13;
            // 
            // dgvListele
            // 
            this.dgvListele.AllowUserToAddRows = false;
            this.dgvListele.AllowUserToDeleteRows = false;
            this.dgvListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListele.Location = new System.Drawing.Point(447, 106);
            this.dgvListele.Name = "dgvListele";
            this.dgvListele.ReadOnly = true;
            this.dgvListele.RowHeadersWidth = 51;
            this.dgvListele.RowTemplate.Height = 24;
            this.dgvListele.Size = new System.Drawing.Size(731, 496);
            this.dgvListele.TabIndex = 12;
            this.dgvListele.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListele_CellDoubleClick_1);
            // 
            // PersonelInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1209, 645);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtRol);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.dgvListele);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PersonelInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel_Info";
            this.Load += new System.EventHandler(this.PersonelInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListele)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtRol;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.DataGridView dgvListele;
    }
}
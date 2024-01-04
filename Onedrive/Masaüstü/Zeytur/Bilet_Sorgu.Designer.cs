namespace zeytur2
{
    partial class Bilet_Sorgu
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
            this.btnSorgu = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIptal = new System.Windows.Forms.Button();
            this.dgvListele = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListele)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSorgu
            // 
            this.btnSorgu.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSorgu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSorgu.Location = new System.Drawing.Point(76, 176);
            this.btnSorgu.Name = "btnSorgu";
            this.btnSorgu.Size = new System.Drawing.Size(212, 38);
            this.btnSorgu.TabIndex = 9;
            this.btnSorgu.Text = "Bilet Ara";
            this.btnSorgu.UseVisualStyleBackColor = false;
            this.btnSorgu.Click += new System.EventHandler(this.btnSorgu_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(173, 127);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(122, 22);
            this.txtId.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Yolcu Id :";
            // 
            // btnIptal
            // 
            this.btnIptal.BackColor = System.Drawing.Color.IndianRed;
            this.btnIptal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnIptal.Location = new System.Drawing.Point(76, 218);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(212, 44);
            this.btnIptal.TabIndex = 6;
            this.btnIptal.Text = "Bileti İptal Et";
            this.btnIptal.UseVisualStyleBackColor = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // dgvListele
            // 
            this.dgvListele.AllowUserToAddRows = false;
            this.dgvListele.AllowUserToDeleteRows = false;
            this.dgvListele.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListele.Location = new System.Drawing.Point(318, 66);
            this.dgvListele.Name = "dgvListele";
            this.dgvListele.ReadOnly = true;
            this.dgvListele.RowHeadersWidth = 51;
            this.dgvListele.RowTemplate.Height = 24;
            this.dgvListele.Size = new System.Drawing.Size(600, 374);
            this.dgvListele.TabIndex = 5;
            this.dgvListele.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListele_CellDoubleClick);
            // 
            // Bilet_Sorgu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 469);
            this.Controls.Add(this.btnSorgu);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.dgvListele);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Bilet_Sorgu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bilet_Sorgu";
            this.Load += new System.EventHandler(this.Bilet_Sorgu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListele)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSorgu;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.DataGridView dgvListele;
    }
}
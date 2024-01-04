using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zeytur2
{
    public partial class AnaEkran : Form
    {
        public AnaEkran()
        {
            InitializeComponent();
        }
        public string KullaniciRolu { get; set; }
        private void msSorgu_Click(object sender, EventArgs e)
        {
            FormKontrol(new Bilet_Sorgu());
        }

        private void msPersonelInfo_Click(object sender, EventArgs e)
        {
            FormKontrol(new PersonelInfo());
        }

        private void msMusteriInfo_Click(object sender, EventArgs e)
        {
            FormKontrol(new MüsteriInfo());
        }

        private void müşteriKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKontrol(new YolcuKayıt());
        }

        private void AnaEkran_Load(object sender, EventArgs e)
        {
            if (KullaniciRolu == "Satış Elemanı")
            {
                msMusteriInfo.Enabled = false;
                msPersonelInfo.Enabled = false;
            }
        }
        public void FormKontrol(Form form)
        {
            bool AcikMi = false;
            foreach (var item in this.MdiChildren)
            {
                if (item.Name == form.Name)
                {
                    AcikMi = true;
                }
            }
            if (!AcikMi)
            {
                form.MdiParent = this;
                form.Show();

            }
        }
    }
}

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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            zeyturEntities db = new zeyturEntities();
            if (db.TBLLoginScreen.Any(x => x.adSoyad == txtAdSoyad.Text && x.sifre == txtSifre.Text))
            {
                AnaEkran frm = new AnaEkran();
                frm.KullaniciRolu = db.TBLLoginScreen.Where(x => x.adSoyad == txtAdSoyad.Text && x.sifre == txtSifre.Text).First().rol;

                frm.Show();
                this.Hide();
            }
            else
            {
                txtAdSoyad.BackColor = Color.Red;
                txtSifre.BackColor = Color.Red;
                MessageBox.Show("Giriş Başarısız");
            }
        }

        private void txtAdSoyad_KeyUp(object sender, KeyEventArgs e)
        {
            txtAdSoyad.BackColor = Color.White;
        }

        private void txtSifre_KeyUp(object sender, KeyEventArgs e)
        {
            txtAdSoyad.BackColor = Color.White;
        }
    }
}

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
    public partial class YolcuKayıt : Form
    {
        public static YolcuKayıt instance;
        TBLTrip_Info Yolcular = new TBLTrip_Info();
        
        public YolcuKayıt()
        {
            InitializeComponent();
         
            
        }
        zeyturEntities db = new zeyturEntities();
        private void btnSwitch_Click(object sender, EventArgs e)//Switch butonu
        {
            lblSwitch.Text = cbNereye.Text;
            cbNereye.Text = cbNereden.Text;
            cbNereden.Text = lblSwitch.Text;
        }
         private void cbNereye_TextChanged(object sender, EventArgs e)//herhangi bir yeri boş bırakırsak ne olur.
        {
            if( cbNereden.Text.Trim() == "" || cbNereye.Text.Trim() == "")
            {
                MessageBox.Show("Lütfen istikameti belirtiniz");
            }
        }

        private void rezerveEtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Yolcular.kalkıs = cbNereden.Text;
            Yolcular.inis = cbNereye.Text;
            Yolcular.saat = cbSaat.Text;
            Yolcular.tarih = dtpTarih.Text;
            string buttonName = "";
            if (sender is Button)
            {
                buttonName = ((Button)sender).Name;
                txtKoltuk.Text = buttonName.Trim();
                Yolcular.koltukNo = int.Parse(((Button)sender).Text);
               
                
            }
            else
            {
                return;
            }
            

            if (cbNereden.Text.Trim() ==""||  cbNereye.Text.Trim() =="" || dtpTarih.Text.Trim() ==""|| cbSaat.Text.Trim() == "")//tüm boşluklar doldurulmadıysa kayıt işlemine geçmeye izin vermez.
            {
                MessageBox.Show("Lütfen gerekli alanları doldurunuz");
                return;
            }
            MüsteriKayıt form = new MüsteriKayıt();
            form.yolcular = Yolcular;
            DialogResult sonuc = form.ShowDialog();// Müşteri kayıt formu açıkken arkadaki formda işlem yapmamızı engeller.
        }

       
    }
}

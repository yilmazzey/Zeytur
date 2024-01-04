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
    public partial class MüsteriKayıt : Form
    {
        TBLPassanger data = new TBLPassanger();
        public TBLTrip_Info yolcular;

        public MüsteriKayıt()
        {
            InitializeComponent();
          
        }
        zeyturEntities db = new zeyturEntities();



        private void btnDevam_Click(object sender, EventArgs e)
        {
            OdemeAl frm = new OdemeAl();
            frm.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            data.adSoyad = txtAdSoyad.Text;
            data.tcNo = txtTCKimlik.Text;
            data.telNo = txtTelno.Text;
            data.cinsiyet = txtCinsiyet.Text;
            OdemeAl form = new OdemeAl();
            form.GelenData = data;
            form.yolcular = yolcular;
            form.indirimOzelligi = txtIndirim.Text;
            DialogResult sonuc = form.ShowDialog();

        }
    }
}

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
    public partial class OdemeAl : Form
    {
        zeyturEntities db = new zeyturEntities();
        public TBLPassanger GelenData;
        public string indirimOzelligi;
        public TBLTrip_Info yolcular;
        public OdemeAl()
        {
            InitializeComponent();
        }

        private TextBox GetTxtKartSahibi()
        {
            return txtKartSahibi;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            TBLPayment tbl = new TBLPayment();
            tbl.kartIsim = txtKartSahibi.Text;
            tbl.kartNo = txtKartNo.Text;
            tbl.skt = txtSkt.Text;
            tbl.cvv = txtCvv.Text;
            db.TBLPayment.Add(tbl);
            db.SaveChanges();



            GelenData.payment_id = db.TBLPayment.OrderByDescending(x => x.id).FirstOrDefault().id;
            GelenData.odenenUcret = int.Parse(textBox1.Text);
            db.TBLPassanger.Add(GelenData);
            db.SaveChanges();



            
            yolcular.pass_id = db.TBLPassanger.OrderByDescending(x => x.Id).FirstOrDefault().Id;
            db.TBLTrip_Info.Add(yolcular);
            db.SaveChanges();

            MessageBox.Show("İşlem Başarılı");
            this.Hide();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void OdemeAl_Load(object sender, EventArgs e)
        {
            if (indirimOzelligi == "İndirimli")
            {
                textBox1.Text = "180";
            }
            else if (indirimOzelligi == "İndirimsiz")
            {
                textBox1.Text = "210";
            }
        }
    }
}

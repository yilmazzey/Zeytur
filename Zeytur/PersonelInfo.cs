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
    public partial class PersonelInfo : Form
    {
        public PersonelInfo()
        {
            InitializeComponent();
        }
        zeyturEntities db = new zeyturEntities();
        private void doldur()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("#");
            dt.Columns.Add("Kullanıcı Adı");
            dt.Columns.Add("Şifre");
            dt.Columns.Add("Yetki");

            foreach (var item in db.TBLLoginScreen.ToList())
            {
                dt.Rows.Add(item.Id, item.adSoyad, item.sifre, item.rol);
            }
            dgvListele.DataSource = dt;
        }
        private void PersonelInfo_Load(object sender, EventArgs e)
        {
            doldur();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            TBLLoginScreen tbl = new TBLLoginScreen();
            tbl.adSoyad = txtAdSoyad.Text;
            tbl.sifre = txtSifre.Text;
            tbl.rol = txtRol.Text;
            db.SaveChanges();
            db.TBLLoginScreen.Add(tbl);
            MessageBox.Show("kayıt başarılı");
        }
        int AlinanId = 0;
        private void dgvListele_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AlinanId = int.Parse(dgvListele.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtAdSoyad.Text = dgvListele.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtSifre.Text = dgvListele.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtRol.Text = dgvListele.Rows[e.RowIndex].Cells[3].Value.ToString();

        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (AlinanId != 0)
            {
                TBLLoginScreen tbl = db.TBLLoginScreen.Find(AlinanId);
                tbl.adSoyad = txtAdSoyad.Text;
                tbl.sifre = txtSifre.Text;
                tbl.rol = txtRol.Text;
                db.SaveChanges();
                doldur();
                MessageBox.Show("güncelleme başarılı");

            }
            else
            {
                MessageBox.Show("lütfen veri seçiniz");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (AlinanId != 0)
            {
                TBLLoginScreen tbl = db.TBLLoginScreen.Find(AlinanId);
                db.TBLLoginScreen.Remove(tbl);
                db.SaveChanges();
                MessageBox.Show("Veri Silindi");
                doldur();
                AlinanId = 0;
            }
            else
            {
                MessageBox.Show("Lütfen Veri Seçiniz.");
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            string searchValue = txtAra.Text;

            dgvListele.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridViewRow row in dgvListele.Rows)
                {
                    if (row.Cells[1].Value.ToString().Equals(searchValue))
                    {
                        row.Selected = true;
                        break;
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void dgvListele_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            AlinanId = int.Parse(dgvListele.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtAdSoyad.Text = dgvListele.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtSifre.Text = dgvListele.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtRol.Text = dgvListele.Rows[e.RowIndex].Cells[3].Value.ToString();
        }
    }
}

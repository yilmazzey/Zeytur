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
    public partial class Bilet_Sorgu : Form
    {
        zeyturEntities db= new zeyturEntities();
        public Bilet_Sorgu()
        {
            InitializeComponent();
        }

        private void Bilet_Sorgu_Load(object sender, EventArgs e)
        {
            doldur();
        }
        private void doldur()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("#");
            dt.Columns.Add("Kalkış Yeri");
            dt.Columns.Add("Varış Yeri");
            dt.Columns.Add("Tarih");
            dt.Columns.Add("Saat");
            dt.Columns.Add("Kapı No");
            dt.Columns.Add("Koltuk No");
           

            foreach (var item in db.TBLTrip_Info.ToList())
            {
                dt.Rows.Add(item.pass_id,  item.kalkıs, item.inis, item.tarih, item.saat, item.kapıNo, item.koltukNo);
            }
            dgvListele.DataSource = dt;

        }

        private void btnSorgu_Click(object sender, EventArgs e)
        {
            string searchValue = txtId.Text;

            dgvListele.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridViewRow row in dgvListele.Rows)
                {
                    if (row.Cells[7].Value.ToString().Equals(searchValue))
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

        private void btnIptal_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                TBLTrip_Info tbl = new TBLTrip_Info();
                db.TBLTrip_Info.Remove(tbl);
                db.SaveChanges();
                doldur();
                MessageBox.Show("İşlem Başarılı");
            }
            else
            {
                MessageBox.Show("Lütfen Veri Seçiniz.");
            }
        }

        private void dgvListele_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvListele.Rows[e.RowIndex].Cells[0].Value.ToString();
        }
    }
}

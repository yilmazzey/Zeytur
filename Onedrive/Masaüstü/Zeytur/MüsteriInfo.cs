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
    public partial class MüsteriInfo : Form
    {
        public MüsteriInfo()
        {
            InitializeComponent();
        }
        zeyturEntities db = new zeyturEntities();
        private void doldur()
        {
            TBLPassanger tbl = new TBLPassanger();
            DataTable dt = new DataTable();
            dt.Columns.Add("#");
            dt.Columns.Add("Müşteri Adı");
            dt.Columns.Add("Telefon Numarası");
            dt.Columns.Add("TCKimlik Numarası");
            dt.Columns.Add("Cinsiyet");
     

            foreach (var item in db.TBLPassanger.ToList())
            {
                dt.Rows.Add(item.Id, item.adSoyad, item.telNo, item.tcNo, item.cinsiyet);
            }
            dgvListele.DataSource = dt;
        }

        private void MüsteriInfo_Load(object sender, EventArgs e)
        {
            doldur();
        }

        private void btnAra_Click_1(object sender, EventArgs e)
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
    }
}

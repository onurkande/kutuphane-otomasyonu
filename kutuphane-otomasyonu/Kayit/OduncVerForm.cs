using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kutuphane_otomasyonu.Kayit
{
    public partial class OduncVerForm : Form
    {
        public OduncVerForm()
        {
            InitializeComponent();
        }

        KutuphaneOtomasyonEntities db = new KutuphaneOtomasyonEntities();

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var kayitList = db.Kayitlar.ToList();
            dataGridView1.DataSource = kayitList.ToList();
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[6].Visible = false;

            dataGridView1.Columns[1].HeaderText = "Kullanici";
            dataGridView1.Columns[2].HeaderText = "Kaynak Ad";
        }
    }
}

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
    public partial class GeriAlForm : Form
    {
        public GeriAlForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        KutuphaneOtomasyonEntities db = new KutuphaneOtomasyonEntities();
        private void GeriAlForm_Load(object sender, EventArgs e)
        {
            var kayitlar=db.Kayitlar.Where(x=>x.durum==false).ToList();
            dataGridView1.DataSource = kayitlar.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int secilenKayit = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
            var kayit=db.Kayitlar.Where(x=>x.kayit_id==secilenKayit).FirstOrDefault();
            kayit.durum = true;
            db.SaveChanges();

            //liste yenileme
            var kayitlar = db.Kayitlar.Where(x => x.durum == false).ToList();
            dataGridView1.DataSource = kayitlar.ToList();
            

        }
    }
}

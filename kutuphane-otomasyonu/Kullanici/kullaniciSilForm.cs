using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kutuphane_otomasyonu.Kullanici
{
    public partial class kullaniciSilForm : Form
    {
        public kullaniciSilForm()
        {
            InitializeComponent();
        }
        KutuphaneOtomasyonEntities db=new KutuphaneOtomasyonEntities();
        public void Listele()
        {

            var kullanicilar = db.Kullanicilar.ToList();
            dataGridView1.DataSource = kullanicilar.ToList();
        }

        private void kullaniciSilForm_Load(object sender, EventArgs e)
        {
            Listele();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            int secilenId = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);

            var kullanici = db.Kullanicilar.FirstOrDefault(x => x.kullanici_id == secilenId);


            db.Kullanicilar.Remove(kullanici);
            db.SaveChanges();
            Listele();

        }

    }
}

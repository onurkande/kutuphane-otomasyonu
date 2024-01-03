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
            //kayıtları listeledik
            var kayitList = db.Kayitlar.ToList();
            dataGridView1.DataSource = kayitList.ToList();

            //listeledik(kaynaklar)
            var kaynakList=db.Kaynaklar.ToList();
            dataGridView2.DataSource = kaynakList.ToList();

            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;

            dataGridView1.Columns[1].HeaderText = "Kullanici";
            dataGridView1.Columns[2].HeaderText = "Kaynak Ad";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string arananSecilen = TCBultxt.Text;
            var kullaniciVarMi=db.Kullanicilar.Where(x=>x.kullanici_tc==arananSecilen).FirstOrDefault();
            if (kullaniciVarMi != null)
                label2.Text = kullaniciVarMi.kullanici_ad + " " + kullaniciVarMi.kullanici_soyad;
            else
                label2.Text = "Böyle bir kullanıcı yok";
        }

        private void TCBultxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string gelenAd = textBox1.Text;
            var bulunanKaynaklar=db.Kaynaklar.Where(x=>x.kaynak_ad.Contains(gelenAd));
            dataGridView2.DataSource = bulunanKaynaklar;
        }
    }
}

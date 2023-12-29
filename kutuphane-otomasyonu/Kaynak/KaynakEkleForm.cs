using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kutuphane_otomasyonu.Kaynak
{
    public partial class KaynakEkleForm : Form
    {
        public KaynakEkleForm()
        {
            InitializeComponent();
        }

        KutuphaneOtomasyonEntities db = new KutuphaneOtomasyonEntities();
        private void KaynakEkleForm_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dataSet1.Kaynaklar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.kaynaklarTableAdapter.Fill(this.dataSet1.Kaynaklar);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kaynaklar kaynaklar = new Kaynaklar();
            kaynaklar.kaynak_ad = adKaynaktxt.Text;
            kaynaklar.kaynak_yazar = yazarKaynaktxt.Text;
            kaynaklar.kaynak_yayinci=yayinciKaynakTxt.Text;
            kaynaklar.kaynak_sayfa_sayisi = Convert.ToInt16(numericUpDown1.Value);
            kaynaklar.kaynak_basim_tarihi =dateTimePicker1.Value;
            db.Kaynaklar.Add(kaynaklar); 
            db.SaveChanges();

            var kliste = db.Kaynaklar.ToList();
            dataGridView1.DataSource = kliste.ToList();
        }
    }
}

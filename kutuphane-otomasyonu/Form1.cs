using System.Windows.Forms;
using System;
using System.Linq;

namespace kutuphane_otomasyonu
{
    public partial class Form1 : Form
    {
        KutuphaneOtomasyonEntities db = new KutuphaneOtomasyonEntities(); //databse'den yeni nesne üretildi
        public Form1()
        {
            InitializeComponent();
        }

        private void personelGiris_Click_1(object sender, EventArgs e)
        {
            string gelenAd = personelAd.Text; // ada girilen degeri aldýk
            string gelenSifre = personelSifre.Text; //sifreye girilen degeri aldýk

            var personel = db.personal.Where(x => x.personal_ad.Equals(gelenAd) && x.personal_sifre.Equals(gelenSifre)).FirstOrDefault(); //personellerden x nesnesi olusturuldu

            if (personel == null)
            {
                MessageBox.Show("Giriş başarısız,girdiğiniz bilgileri kontrol edin!");
            }
            else
            {
                MessageBox.Show("Giriş Başarılı"); //Ekrana mesajý gösteren kod
                IslemPaneli panel = new IslemPaneli();
                panel.Show();
                this.Hide();
            }
        }

        private void personelAd_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void personelSifre_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
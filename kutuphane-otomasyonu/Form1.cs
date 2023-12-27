using System.Windows.Forms;
using System;

namespace kutuphane_otomasyonu
{
    public partial class Form1 : Form
    {
        KutuphaneOtomasyonEntities db = new KutuphaneOtomasyonEntities(); //databse'den yeni nesne üretildi
        public Form1()
        {
            InitializeComponent();
        }

        private void personelGiris_Click(object sender, EventArgs e)
        {
            string gelenAd = personelAd.Text; // ada girilen degeri aldýk
            string gelenSifre = personelSifre.Text; //sifreye girilen degeri aldýk

            var personel = db.Personeller.Where(x => x.personel_ad.Equels(gelenAd) && x.personel_sifre.Equels(gelenSifre)).FirstOrDefault(); //personellerden x nesnesi olusturuldu

            if (personel == null)
            {
                MessageBox.Show("Giriþ baþarýsýz,girdiðiniz bilgileri kontrol edin!");
            }
            else
            {
                MessageBox.Show("Giriþ baþarýlý"); //Ekrana mesajý gösteren kod
                IslemPaneli panel = new IslemPaneli();
                panel.Show();
                this.Hide();
            }
        }

        private void personelAd_TextChanged(object sender, EventArgs e)
        {

        }

        private void personelSifre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
using kutuphane_otomasyonu.Kaynak;
using kutuphane_otomasyonu.Kullanici;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kutuphane_otomasyonu
{
    public partial class IslemPaneli : Form
    {
        public IslemPaneli()
        {
            InitializeComponent();
        }
        KutuphaneOtomasyonEntities db = new KutuphaneOtomasyonEntities();

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void IslemPaneli_Load(object sender, EventArgs e)
        {
            ekleKullanicibtn.Visible = false;
            guncelleKullanicibtn.Visible=false; 
            silKullanicibtn.Visible= false;
            
            ekleKaynakbtn.Visible= false;
            GuncelKaynakbtn.Visible = false;
            silKaynakbtn.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(ekleKullanicibtn.Visible==false)
            {
                ekleKullanicibtn.Visible = true;
                guncelleKullanicibtn.Visible = true;
                silKullanicibtn.Visible = true;
            }
            else
            {
                ekleKullanicibtn.Visible = false;
                guncelleKullanicibtn.Visible = false;
                silKullanicibtn.Visible = false;
            }
            KullaniciListeForm klisteform=new KullaniciListeForm();
            klisteform.MdiParent = this;    
            klisteform.Show();
        }

        private void ekleKullanicibtn_Click(object sender, EventArgs e)
        {
            KullaniciEkleForm ekleForm=new KullaniciEkleForm();
            ekleForm.MdiParent = this;
            ekleForm.Show();    
        }

        private void silKullanicibtn_Click(object sender, EventArgs e)
        {
            kullaniciSilForm ksil=new kullaniciSilForm();
            ksil.MdiParent = this;
            ksil.Show();
        }

        private void guncelleKullanicibtn_Click(object sender, EventArgs e)
        {
            KullaniciGuncellemeForm kGuncel=new KullaniciGuncellemeForm();
            kGuncel.MdiParent= this;
            kGuncel.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            KaynakEkleForm kaynakEkle=new KaynakEkleForm();
            kaynakEkle.MdiParent=this;
            kaynakEkle.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kaynaklarbtn_Click(object sender, EventArgs e)
        {
            if(ekleKaynakbtn.Visible == false)
            {
                ekleKaynakbtn.Visible = true;
                GuncelKaynakbtn.Visible = true;
                silKaynakbtn.Visible=true;
            }
            else
            {
                ekleKaynakbtn.Visible = false;
                GuncelKaynakbtn.Visible = false;
                silKaynakbtn.Visible=false;


            }

            KaynakListeForm kliste = new KaynakListeForm();
            kliste.MdiParent = this;
            kliste.Show();
        }

        private void silKaynakbtn_Click(object sender, EventArgs e)
        {
            KaynakSilForm kSil = new KaynakSilForm();
            kSil.MdiParent = this;
            kSil.Show();
        }
    }
}
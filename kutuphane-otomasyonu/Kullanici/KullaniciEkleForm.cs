﻿using System;
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
    public partial class KullaniciEkleForm : Form
    {
        public KullaniciEkleForm()
        {
            InitializeComponent();
        }
        KutuphaneOtomasyonEntities db = new KutuphaneOtomasyonEntities();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        public void Listele()
        {
            
            var kullanicilar = db.Kullanicilar.ToList();
            dataGridView1.DataSource = kullanicilar.ToList();
        }

        private void KullaniciEkleForm_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kullanicilar kullanicilar=new Kullanicilar();
            kullanicilar.kullanici_ad=kullaniciAdtxt.Text;
            kullanicilar.kullanici_soyad=kullaniciSoyadtxt.Text;
            kullanicilar.kullanici_tc = kullaniciTCtxt.Text;
            kullanicilar.kullanici_tel= kullaniciTeltxt.Text;
            kullanicilar.kullanici_mail=kullaniciMailtxt.Text;  
            kullanicilar.kullanici_ceza= Convert.ToDouble( kullaniciCezatxt.Text); 
            db.Kullanicilar.Add(kullanicilar);
            db.SaveChanges();
            Listele();
        }
    }
}

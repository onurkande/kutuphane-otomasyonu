﻿using System;
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
    public partial class KaynakListeForm : Form
    {
        public KaynakListeForm()
        {
            InitializeComponent();
        }

        KutuphaneOtomasyonEntities db=new KutuphaneOtomasyonEntities();
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var kaynaklar = db.Kaynaklar.ToList();
            dataGridView1.DataSource = kaynaklar.ToList();
        }
    }
}

﻿using BizimCafe.DATA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BizimCafe.UI
{
    public partial class AnaForm : Form
    {
        KafeVeri db = new KafeVeri();
        public AnaForm()
        {
            InitializeComponent();
            VerileriYukle();
            MasalariOlustur();
        }
        private void VerileriYukle()
        {
            try
            {
                string json = File.ReadAllText("veri.json");
                db = JsonSerializer.Deserialize<KafeVeri>(json);
            }
            catch (Exception)
            {
                OrnekleriYukle();
            }
        }
        private void OrnekleriYukle()
        {
            db.Urunler.Add(new Urun() { UrunAd = "Kola", BirimFiyat = 7.00m });
            db.Urunler.Add(new Urun() { UrunAd = "Ayran", BirimFiyat = 6.50m });
        }
        private void MasalariOlustur()
        {
            for (int i = 1; i <= db.MasaAdet; i++)
            {
                ListViewItem item = new ListViewItem($"MASA {i}");
                //item.ImageKey = "bos";
                item.ImageKey = db.AktifSiparisler.Any(x => x.MasaNo == i) ? "dolu" : "bos";
                item.Tag = i;
                lvwMasalar.Items.Add(item);
            }
        }

        private void lvwMasalar_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem lvi = lvwMasalar.SelectedItems[0]; 
            int masaNo = (int)lvwMasalar.SelectedItems[0].Tag;
            //MessageBox.Show(masaNo.ToString());
            //MessageBox.Show(lvwMasalar.SelectedItems[0].Text);
            Siparis siparis = db.AktifSiparisler.FirstOrDefault(x => x.MasaNo == masaNo);
            if(siparis == null)
            {
                siparis = new Siparis() { MasaNo = masaNo };
                db.AktifSiparisler.Add(siparis);
                lvi.ImageKey = "dolu";
            }

            var frmSiparis = new SiparisForm(db, siparis);
            //frmSiparis.ShowDialog();
            DialogResult sonuc = frmSiparis.ShowDialog();

            if (sonuc == DialogResult.OK)
            {
                lvi.ImageKey = "bos";
            }
        }

        private void tsmiGecmisSiparisler_Click(object sender, EventArgs e)
        {
            new GecmisSiparislerForm(db).ShowDialog();
        }

        private void tsmiUrunler_Click(object sender, EventArgs e)
        {
            new UrunlerForm(db).ShowDialog();
        }

        private void AnaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            string json = JsonSerializer.Serialize(db);
            File.WriteAllText("veri.json", json);
        }
    }
}

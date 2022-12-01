using BizimCafe.DATA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BizimCafe.UI
{
    public partial class UrunlerForm : Form
    {
        private readonly KafeVeri _db;
        public UrunlerForm(KafeVeri db)
        {
            InitializeComponent();
            _db = db;
            UrunleriListele();
        }

        private void UrunleriListele()
        {
            dGridUrunEkle.DataSource = _db.Urunler.ToList();
        }

        private void btnYeniUrunEkle_Click(object sender, EventArgs e)
        {
            if (txtUrunAd.Text.Trim() == "") // string.IsNullOrEmpty(txtUrunAd.Text) => Bu da başka bir sorgu olabilir.
            {
                MessageBox.Show("Lütfen Ürün Adı Giriniz...");
                return;
            }
            if (btnYeniUrunEkle.Text == "EKLE")
            {

                if (nmrcBirimFiyat.Value == 0)
                {
                    MessageBox.Show("Lütfen Ürün Fiyatı Giriniz...");
                    return;
                }

                _db.Urunler.Add(new Urun() { UrunAd = txtUrunAd.Text, BirimFiyat = (decimal)nmrcBirimFiyat.Value });
                UrunleriListele();
            }
            else
            {
                DataGridViewRow satir = dGridUrunEkle.SelectedRows[0];
                Urun urun = (Urun)satir.DataBoundItem;
                urun.UrunAd = txtUrunAd.Text;
                urun.BirimFiyat = nmrcBirimFiyat.Value;
                UrunleriListele();
                btnYeniUrunEkle.Text = "EKLE";
                btnIptal.Enabled = false;
            }
            txtUrunAd.Clear();
            nmrcBirimFiyat.Value = 0;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dGridUrunEkle.SelectedRows.Count == 0)
            {
                MessageBox.Show("Önce Ürün Seçiniz.");
                return;
            }
            DialogResult dr = MessageBox.Show("Seçili ürünü silmek istedğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No)
            {
                return;
            }
            DataGridViewRow satir = dGridUrunEkle.SelectedRows[0];
            Urun urun = (Urun)satir.DataBoundItem;
            _db.Urunler.Remove(urun);
            UrunleriListele();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (dGridUrunEkle.SelectedRows.Count == 0)
            {
                MessageBox.Show("Önce Ürün Seçiniz.");
                return;
            }
            btnYeniUrunEkle.Text = "KAYDET";
            btnIptal.Visible = true;
            DataGridViewRow satir = dGridUrunEkle.SelectedRows[0];
            Urun urun = (Urun)satir.DataBoundItem;
            txtUrunAd.Text = urun.UrunAd;
            nmrcBirimFiyat.Value = urun.BirimFiyat;
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            btnYeniUrunEkle.Text = "EKLE";
            btnIptal.Visible = false;
            txtUrunAd.Clear();
            nmrcBirimFiyat.Value = 0;
        }
    }
}

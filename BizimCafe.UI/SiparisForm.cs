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
    public partial class SiparisForm : Form
    {
        private readonly KafeVeri _db;
        private readonly Siparis _siparis;
        public SiparisForm(KafeVeri db, Siparis siparis)
        {
            InitializeComponent();
            _db = db;
            _siparis = siparis;
            BilgileriGuncelle();
            UrunleriListele();
        }
        private void UrunleriListele()
        {
            cbxUrun.DataSource = _db.Urunler;
        }

        private void BilgileriGuncelle()
        {
            Text = $"Masa {_siparis.MasaNo}";
            lblMasaNo.Text = _siparis.MasaNo.ToString("00");
            lblOdemeTutari.Text = _siparis.ToplamTutarTL;
            dGridSiparisGoster.DataSource = _siparis.SiparisDetaylar.ToList();
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            Urun urun = (Urun)cbxUrun.SelectedItem;

            if (urun == null)
                return;

            SiparisDetay sd = _siparis.SiparisDetaylar.FirstOrDefault
                (x => x.UrunAd == urun.UrunAd);

            if (sd != null)
            {
                sd.Adet += (int)nmrUrunAdet.Value;
            }
            else
            {
                sd = new SiparisDetay()
                {
                    UrunAd = urun.UrunAd,
                    BirimFiyat = urun.BirimFiyat,
                    Adet = (int)nmrUrunAdet.Value
                };
                _siparis.SiparisDetaylar.Add(sd);
            }

            nmrUrunAdet.Value = nmrUrunAdet.Minimum;
            BilgileriGuncelle();
        }

        private void btnAnaSayfaDon_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOdemeAl_Click(object sender, EventArgs e)
        {
            SiparisiKapat(_siparis.ToplamTutar(), SiparisDurum.Odendi);
        }

        private void btnSiparisIptal_Click(object sender, EventArgs e)
        {
            SiparisiKapat(0, SiparisDurum.Iptal);
        }

        private void SiparisiKapat(decimal odenenTutar, SiparisDurum yeniDurum)
        {
            _siparis.KapanisZamani = DateTime.Now;
            _siparis.OdenenTutar = odenenTutar;
            _siparis.Durum = yeniDurum;
            _db.AktifSiparisler.Remove(_siparis);
            _db.GecmisSiparisler.Add(_siparis);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}

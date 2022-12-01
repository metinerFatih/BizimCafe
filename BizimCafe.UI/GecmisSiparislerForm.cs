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
    public partial class GecmisSiparislerForm : Form
    {
        private readonly KafeVeri _db;
        public GecmisSiparislerForm(KafeVeri db)
        {
            _db = db;
            InitializeComponent();
            dGridSiparisler.DataSource = _db.GecmisSiparisler;
        }

        private void dGridSiparisler_SelectionChanged(object sender, EventArgs e)
        {
            if (dGridSiparisler.SelectedRows.Count == 0)
            {
                dGridSiparisDetaylari.DataSource = null;
            }
            else
            {
                DataGridViewRow secilenSatir = dGridSiparisler.SelectedRows[0];
                Siparis secilenSiparis = (Siparis)secilenSatir.DataBoundItem;
                dGridSiparisDetaylari.DataSource = secilenSiparis.SiparisDetaylar;
            }
        }
    }
}

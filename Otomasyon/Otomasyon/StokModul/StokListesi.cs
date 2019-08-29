using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Otomasyon.StokModul
{
    public partial class frm_StokListesi : DevExpress.XtraEditors.XtraForm
    {
        StokDatabaseDataContext db = new StokDatabaseDataContext();
        public frm_StokListesi()
        {
            InitializeComponent();
        }

        private void Frm_StokListesi_Load(object sender, EventArgs e)
        {
            VeriListele();
        }

        void VeriListele()
        {
            var veriListe = from t in db.TBL_STOKLAR select t;
            gridControl1.DataSource = veriListe;
        }

        void Temizle()
        {
            txt_StokKodu.Text = "";
            txt_StokAdi.Text = "";
            txt_BarkodNumarasi.Text = "";
        }

        void Ara()
        {
            var sonuc = from t in db.TBL_STOKLAR
                        where t.STOKADI.Contains(txt_StokAdi.Text)
                        && t.STOKKODU.Contains(txt_StokKodu.Text)
                        && t.STOKBARKOD.Contains(txt_BarkodNumarasi.Text)
                        select t;
            gridControl1.DataSource = sonuc;
        }

        private void Btn_Ara_Click(object sender, EventArgs e)
        {
            Ara();
            Temizle();
        }
    }
}
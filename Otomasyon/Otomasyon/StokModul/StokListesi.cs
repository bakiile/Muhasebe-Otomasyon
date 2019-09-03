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
        Fonksiyonlar.StokDatabaseDataContext db = new Fonksiyonlar.StokDatabaseDataContext();
        public bool secim = false;
        public frm_StokListesi()
        {
            InitializeComponent();
        }

        private void Frm_StokListesi_Load(object sender, EventArgs e)
        {
            stokListele();
        }

        void stokListele()
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

        private void GridView1_DoubleClick(object sender, EventArgs e)
        {
            if (secim == true)
                Secim();
                
        }

        void Secim()
        {
            int secilenID = Convert.ToInt16(gridView1.GetFocusedRowCellValue("STOKID"));
            frm_Anasayfa.AktarilanID = secilenID;
            secim = false;
            this.Close();
        }
    }
}
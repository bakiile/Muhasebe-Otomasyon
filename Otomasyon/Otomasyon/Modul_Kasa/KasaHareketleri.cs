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

namespace Otomasyon.Modul_Kasa
{
    public partial class frm_KasaHareketleri : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.StokDatabaseDataContext db = new Fonksiyonlar.StokDatabaseDataContext();
        int hareketID = -1;
        int evrakID = -1;
        int KasaID = -1;
        string evrakTuru;
        public bool secim = false;
        public frm_KasaHareketleri()
        {
            InitializeComponent();
        }

        private void TextEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            Fonksiyonlar.FormYonetici.KasaListesiAc(true);
            KasaID = frm_Anasayfa.AktarilanID;

            if (KasaID > -1)
                Ac(KasaID);
        }

        void Ac(int ID)
        {
            try
            {
                KasaID = ID;
                txt_KasaKodu.Text = db.TBL_KASALAR.First(t => t.KASAID == KasaID).KASAKODU.ToString();
                txt_KasaAdi.Text = db.TBL_KASALAR.First(t => t.KASAID == KasaID).KASAADI.ToString();
                DurumGetir();
                Listele();
            }
            catch (Exception err)
            {
                Fonksiyonlar.Mesajlar.HataMesaj(err);
            }
            
        }
        void DurumGetir()
        {
            Fonksiyonlar.VW_KASADURUM durum = db.VW_KASADURUM.First(t => t.KASAID == KasaID);
            txt_Giris.Text = durum.GIRIS.Value.ToString();
            txt_Cikis.Text = durum.CIKIS.Value.ToString();
            txt_Bakiye.Text = durum.BAKIYE.Value.ToString();
        }

        void Listele()
        {
            var liste = from t in db.VW_KASAHAREKETLERI
                        where t.KASAID == KasaID
                        select t;
            gridControl1.DataSource = liste;
        }

        private void ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            Sec();
            if (evrakTuru == "Kasa Devir Kartı")
            {
                ctxDevirKarti.Enabled = true;
                ctxTahsilat.Enabled = false;
            }
            else if (evrakTuru == "Kasa Tahsilat" || evrakTuru == "Kasa Ödeme") 
            {
                ctxDevirKarti.Enabled = false;
                ctxTahsilat.Enabled = true;
            }
        }

        void Sec()
        {
            try
            {
                hareketID = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
                //evrakID = int.Parse(gridView1.GetFocusedRowCellValue("EVRAKID").ToString());
                evrakTuru = gridView1.GetFocusedRowCellValue("EVRAKTURU").ToString();
            }
            catch (Exception err)
            {
                Fonksiyonlar.Mesajlar.HataMesaj(err);
            }
        }

        private void CtxDevirKarti_Click(object sender, EventArgs e)
        {
            Fonksiyonlar.FormYonetici.KasaDevirIslemAc(true, hareketID);
            Listele();
        }

        private void CtxTahsilat_Click(object sender, EventArgs e)
        {
            Fonksiyonlar.FormYonetici.KasaTahsilatOdemeAc(true, hareketID);
            Listele();
        }
    }
}
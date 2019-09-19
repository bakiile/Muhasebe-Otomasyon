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

namespace Otomasyon.KasaModul
{
    public partial class frm_KasaTahsilatOdeme : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.StokDatabaseDataContext db = new Fonksiyonlar.StokDatabaseDataContext();
        public bool secim = false;
        int KasaID = -1;
        int islemID = -1;
        int CariHareketID = -1;
        int CariID = -1;

        public frm_KasaTahsilatOdeme()
        {
            InitializeComponent();
        }


        private void Frm_KasaTahsilatOdeme_Load(object sender, EventArgs e)
        {
            txt_Tarih.Text = DateTime.Now.ToShortDateString();
        }

        private void Txt_KasaKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            Fonksiyonlar.FormYonetici.KasaListesiAc(true);
            KasaID = frm_Anasayfa.AktarilanID;

            if (KasaID > -1) 
                KasaAc(KasaID);
        }

        private void Txt_CariKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            Fonksiyonlar.FormYonetici.CariListesiAc(true);
            CariID = frm_Anasayfa.AktarilanID;

            if (CariID > -1)
                CariAc(CariID);
        }

        private void Btn_Kaydet_Click(object sender, EventArgs e)
        {
            Kaydet();
        }

        private void Btn_Guncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void Btn_Sil_Click(object sender, EventArgs e)
        {
            Sil();
        }

        private void Btn_Cikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void Kaydet()
        {
            try
            {
                Fonksiyonlar.TBL_KASAHAREKETLERI kasaHareket = new Fonksiyonlar.TBL_KASAHAREKETLERI();
                kasaHareket.BELGENO = txt_BelgeNo.Text;
                kasaHareket.ACIKLAMA = txt_Aciklama.Text;
                kasaHareket.KASAID = KasaID;
                kasaHareket.CARIID = CariID;
                kasaHareket.EVRAKTURU = txt_IslemTuru.SelectedItem.ToString();
                if (txt_IslemTuru.SelectedIndex == 0) kasaHareket.GCKODU = "G";
                else if (txt_IslemTuru.SelectedIndex == 1) kasaHareket.GCKODU = "C";
                kasaHareket.SAVEDATE = DateTime.Now;
                kasaHareket.SAVEUSER = frm_Anasayfa.userID;
                kasaHareket.TARIH = DateTime.Parse(txt_Tarih.Text);
                kasaHareket.TUTAR = decimal.Parse(txt_Tutar.Text);

                if (Fonksiyonlar.Mesajlar.OnayMesaj() == DialogResult.Yes)
                {
                    db.TBL_KASAHAREKETLERI.InsertOnSubmit(kasaHareket);
                    db.SubmitChanges();
                    Fonksiyonlar.Mesajlar.MesajGoster(txt_IslemTuru.SelectedItem.ToString() + " işlemi yeni kasa hareketi olarak kaydedilmiştir.");


                    Fonksiyonlar.TBL_CARIHAREKETLERI cariHareket = new Fonksiyonlar.TBL_CARIHAREKETLERI();
                    cariHareket.ACIKLAMA = txt_BelgeNo.Text + " belge numaralı " + txt_IslemTuru.SelectedItem.ToString() + " işlemi";
                    if (txt_IslemTuru.SelectedIndex == 0) cariHareket.ALACAK = decimal.Parse(txt_Tutar.Text);
                    else if (txt_IslemTuru.SelectedIndex == 1) cariHareket.BORC = decimal.Parse(txt_Tutar.Text);
                    cariHareket.CARIID = CariID;
                    cariHareket.EVRAKID = kasaHareket.ID;
                    cariHareket.EVRAKTURU = txt_IslemTuru.SelectedItem.ToString();
                    cariHareket.TARIH = DateTime.Parse(txt_Tarih.Text);
                    if (txt_IslemTuru.SelectedIndex == 0) cariHareket.TIP = "KT";
                    else if (txt_IslemTuru.SelectedIndex == 1) cariHareket.TIP = "KÖ";
                    cariHareket.SAVEDATE = DateTime.Now;
                    cariHareket.SAVEUSER = frm_Anasayfa.userID;
                    db.TBL_CARIHAREKETLERI.InsertOnSubmit(cariHareket);
                    db.SubmitChanges();
                    Fonksiyonlar.Mesajlar.MesajGoster("Yeni cari hareketi kaydedilmiştir.");
                    Temizle();
                }
                
            }
            catch (Exception err)
            {
                Fonksiyonlar.Mesajlar.HataMesaj(err);
            }
        }

        void Guncelle()
        {
            try
            {
                Fonksiyonlar.TBL_KASAHAREKETLERI kasaHareket = db.TBL_KASAHAREKETLERI.First(t => t.ID == islemID);

                kasaHareket.BELGENO = txt_BelgeNo.Text;
                kasaHareket.KASAID = KasaID;
                kasaHareket.CARIID = CariID;
                kasaHareket.EVRAKTURU = txt_IslemTuru.SelectedItem.ToString();
                if (txt_IslemTuru.SelectedIndex == 0) kasaHareket.GCKODU = "G";
                else if (txt_IslemTuru.SelectedIndex == 1) kasaHareket.GCKODU = "C";
                kasaHareket.EDITDATE = DateTime.Now;
                kasaHareket.EDITUSER = frm_Anasayfa.userID;
                kasaHareket.TARIH = DateTime.Parse(txt_Tarih.Text);
                kasaHareket.TUTAR = decimal.Parse(txt_Tutar.Text);
                kasaHareket.ACIKLAMA = txt_Aciklama.Text;

                if (Fonksiyonlar.Mesajlar.OnayMesaj() == DialogResult.Yes)
                {
                    db.SubmitChanges();
                    Fonksiyonlar.Mesajlar.MesajGoster("Kasa hareketi " + txt_IslemTuru.SelectedItem.ToString() + " işlemi olarak güncellenmiştir..");

                    Fonksiyonlar.TBL_CARIHAREKETLERI cariHareket = db.TBL_CARIHAREKETLERI.First(t => t.ID == CariHareketID);

                    cariHareket.ACIKLAMA = txt_BelgeNo.Text + " belge numaralı " + txt_IslemTuru.SelectedItem.ToString() + " işlemi";
                    if (txt_IslemTuru.SelectedIndex == 0) cariHareket.ALACAK = decimal.Parse(txt_Tutar.Text);
                    else if (txt_IslemTuru.SelectedIndex == 1) cariHareket.BORC = decimal.Parse(txt_Tutar.Text);
                    cariHareket.CARIID = CariID;
                    cariHareket.EVRAKID = kasaHareket.ID;
                    cariHareket.EVRAKTURU = txt_IslemTuru.SelectedItem.ToString();
                    cariHareket.TARIH = DateTime.Parse(txt_Tarih.Text);
                    if (txt_IslemTuru.SelectedIndex == 0) cariHareket.TIP = "KT";
                    else if (txt_IslemTuru.SelectedIndex == 1) cariHareket.TIP = "KÖ";
                    cariHareket.EDITDATE = DateTime.Now;
                    cariHareket.EDITUSER = frm_Anasayfa.userID;
                    db.SubmitChanges();
                    Fonksiyonlar.Mesajlar.MesajGoster("Cari Hareketi Güncellenmiştir.");
                    Temizle();
                }

            }
            catch (Exception err)
            {
                Fonksiyonlar.Mesajlar.HataMesaj(err);
            }
        }

        void Sil()
        {
            try
            {
                if (Fonksiyonlar.Mesajlar.OnayMesaj() == DialogResult.Yes)
                {
                    db.TBL_KASAHAREKETLERI.DeleteOnSubmit(db.TBL_KASAHAREKETLERI.First(t => t.ID == islemID));
                    db.TBL_CARIHAREKETLERI.DeleteOnSubmit(db.TBL_CARIHAREKETLERI.First(t => t.ID == CariHareketID));
                    Fonksiyonlar.Mesajlar.MesajGoster("Silme işlemi başarılı.");
                    Temizle();
                }

            }
            catch (Exception err)
            {
                Fonksiyonlar.Mesajlar.HataMesaj(err);
            }
        }

        public void Ac(int kasaHareketID)
        {
            try
            {
                islemID = kasaHareketID;
                Fonksiyonlar.TBL_KASAHAREKETLERI kasaHareket = db.TBL_KASAHAREKETLERI.First(t => t.ID == islemID);
                CariHareketID = db.TBL_CARIHAREKETLERI.First(t => t.EVRAKTURU == kasaHareket.EVRAKTURU && t.EVRAKID.Value == islemID).ID;
                txt_BelgeNo.Text = kasaHareket.BELGENO.ToString();
                txt_Aciklama.Text = kasaHareket.ACIKLAMA.ToString();
                if (kasaHareket.EVRAKTURU.ToString() == "Kasa Tahsilat") txt_IslemTuru.SelectedIndex = 0;
                else if (kasaHareket.EVRAKTURU.ToString() == "Kasa Ödeme") txt_IslemTuru.SelectedIndex = 1;
                txt_Tarih.Text = kasaHareket.TARIH.Value.ToShortDateString();
                txt_Tutar.Text = kasaHareket.TUTAR.Value.ToString();
                KasaAc(kasaHareket.KASAID.Value);
                CariAc(kasaHareket.CARIID.Value);
                btn_Guncelle.Enabled = true;
                btn_Sil.Enabled = true;
            }
            catch (Exception err)
            {
                Fonksiyonlar.Mesajlar.HataMesaj(err);
                Temizle();
            }
            
        }
        void KasaAc(int ID)
        {
            try
            {
                KasaID = ID;
                txt_KasaKodu.Text = db.TBL_KASALAR.First(t => t.KASAID == KasaID).KASAKODU.ToString();
                txt_KasaAdi.Text = db.TBL_KASALAR.First(t => t.KASAID == KasaID).KASAADI.ToString();
            }
            catch (Exception err)
            {
                Fonksiyonlar.Mesajlar.HataMesaj(err);
            }
            
        }

        void CariAc(int ID)
        {
            try
            {
                CariID = ID;
                txt_CariKodu.Text = db.TBL_CARILER.First(t => t.CARIID == CariID).CARIKODU.ToString();
                txt_CariAdi.Text = db.TBL_CARILER.First(t => t.CARIID == CariID).CARIADI.ToString();
            }
            catch (Exception err)
            {
                Fonksiyonlar.Mesajlar.HataMesaj(err);
            }
            
        }
        void Temizle()
        {
            foreach (Control control in groupControl1.Controls)
            {
                if (control is DevExpress.XtraEditors.TextEdit || control is DevExpress.XtraEditors.ButtonEdit)
                    control.Text = "";
            }
            foreach (Control control in groupControl2.Controls)
            {
                if (control is DevExpress.XtraEditors.TextEdit || control is DevExpress.XtraEditors.DateEdit || control is DevExpress.XtraEditors.MemoEdit)
                    control.Text = "";
            }

            txt_IslemTuru.SelectedIndex = 0;
            txt_Tarih.Text = DateTime.Now.ToShortDateString();
            frm_Anasayfa.AktarilanID = -1;
            KasaID = -1;
            CariHareketID = -1;
            CariID = -1;
            islemID = -1;
            btn_Guncelle.Enabled = false;
            btn_Sil.Enabled = false;
        }
    }
}
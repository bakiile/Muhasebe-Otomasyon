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

namespace Otomasyon.Modul_Cek
{
    public partial class frm_MusteriCek : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.StokDatabaseDataContext db = new Fonksiyonlar.StokDatabaseDataContext();
        Fonksiyonlar.FormYonetici formRouter = new Fonksiyonlar.FormYonetici();

        int CariID = -1;
        int CekID = -1;
        public frm_MusteriCek()
        {
            InitializeComponent();
        }

        private void Frm_MusteriCek_Load(object sender, EventArgs e)
        {
            txt_VadeTarihi.Text = DateTime.Now.ToShortDateString();
        }

        private void Txt_BelgeNo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

        private void Txt_CariNo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            formRouter.CariListesiAc(true);
            CariID = frm_Anasayfa.AktarilanID;
            if(CariID > -1)
            {
                CariAc(CariID);
                frm_Anasayfa.AktarilanID = -1;
                btn_Guncelle.Enabled = true;
                btn_Sil.Enabled = true;
            }
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
                Fonksiyonlar.TBL_CEKLER yeniCek = new Fonksiyonlar.TBL_CEKLER();
                yeniCek.ACIKLAMA = txt_Aciklama.Text;
                if (txt_CekTuru.SelectedIndex == 0) yeniCek.ACKODU = "A";
                if (txt_CekTuru.SelectedIndex == 1) yeniCek.ACKODU = "C";
                yeniCek.ALINANCARIID = CariID;
                yeniCek.BANKA = txt_Banka.Text;
                yeniCek.BELGENO = txt_BelgeNo.Text;
                yeniCek.CEKNO = txt_CekNo.Text;
                yeniCek.DURUM = "Portföy";
                yeniCek.HESAPNO = txt_HesapNo.Text;
                yeniCek.SUBE = txt_Sube.Text;
                yeniCek.TAHSIL = "Hayır";
                yeniCek.TARIH = DateTime.Now;
                yeniCek.VADETARIHI = DateTime.Parse(txt_VadeTarihi.Text);
                yeniCek.TUTAR = decimal.Parse(txt_Tutar.Text);
                yeniCek.TIP = "Müşteri Çeki";
                yeniCek.ASILBORCLU = txt_AsilBorclu.Text;
                yeniCek.SAVEDATE = DateTime.Now;
                yeniCek.SAVEUSER = frm_Anasayfa.userID;
                

                if (Fonksiyonlar.Mesajlar.OnayMesaj() == DialogResult.Yes)
                {
                    db.TBL_CEKLER.InsertOnSubmit(yeniCek);
                    db.SubmitChanges();

                    Fonksiyonlar.TBL_CARIHAREKETLERI cariHareket = new Fonksiyonlar.TBL_CARIHAREKETLERI();
                    cariHareket.ACIKLAMA = txt_BelgeNo + " belge numaralı ve " + txt_CekNo.Text + " çek numaralı müşteri çeki";
                    cariHareket.CARIID = CariID;
                    cariHareket.EVRAKID = yeniCek.CEKID;
                    cariHareket.EVRAKTURU = "Müşteri Çeki";
                    cariHareket.TARIH = DateTime.Now;
                    cariHareket.TIP = "MÇ";
                    cariHareket.SAVEDATE = DateTime.Now;
                    cariHareket.SAVEUSER = frm_Anasayfa.userID;
                    db.TBL_CARIHAREKETLERI.InsertOnSubmit(cariHareket);
                    db.SubmitChanges();
                    Fonksiyonlar.Mesajlar.MesajGoster("Kaydetme işlemi başarılı.");
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
                Fonksiyonlar.TBL_CEKLER yeniCek = db.TBL_CEKLER.First(t => t.CEKID == CekID);
                yeniCek.ACIKLAMA = txt_Aciklama.Text;
                if (txt_CekTuru.SelectedIndex == 0) yeniCek.ACKODU = "A";
                if (txt_CekTuru.SelectedIndex == 1) yeniCek.ACKODU = "C";
                yeniCek.ALINANCARIID = CariID;
                yeniCek.BANKA = txt_Banka.Text;
                yeniCek.BELGENO = txt_BelgeNo.Text;
                yeniCek.CEKNO = txt_CekNo.Text;
                yeniCek.DURUM = "Portföy";
                yeniCek.HESAPNO = txt_HesapNo.Text;
                yeniCek.SUBE = txt_Sube.Text;
                yeniCek.TAHSIL = "Hayır";
                yeniCek.VADETARIHI = DateTime.Parse(txt_VadeTarihi.Text);
                yeniCek.TUTAR = decimal.Parse(txt_Tutar.Text);
                yeniCek.TIP = "Müşteri Çeki";
                yeniCek.ASILBORCLU = txt_AsilBorclu.Text;
                yeniCek.EDITDATE = DateTime.Now;
                yeniCek.EDITUSER = frm_Anasayfa.userID;

                if (Fonksiyonlar.Mesajlar.OnayMesaj() == DialogResult.Yes)
                {
                    db.SubmitChanges();

                    Fonksiyonlar.TBL_CARIHAREKETLERI cariHareket = db.TBL_CARIHAREKETLERI.First(t => t.EVRAKID == CekID && t.EVRAKTURU == "Müşteri Çeki" && t.TIP == "MÇ");
                    cariHareket.ACIKLAMA = txt_BelgeNo + " belge numaralı ve " + txt_CekNo.Text + " çek numaralı müşteri çeki";
                    cariHareket.CARIID = CariID;
                    cariHareket.EVRAKID = yeniCek.CEKID;
                    cariHareket.EVRAKTURU = "Müşteri Çeki";
                    cariHareket.TARIH = DateTime.Now;
                    cariHareket.TIP = "MÇ";
                    cariHareket.EDITDATE = DateTime.Now;
                    cariHareket.EDITUSER = frm_Anasayfa.userID;
                    db.SubmitChanges();
                    Fonksiyonlar.Mesajlar.MesajGoster("Güncelleme işlemi başarılı.");
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
                    db.TBL_CEKLER.DeleteOnSubmit(db.TBL_CEKLER.First(t => t.CEKID == CekID));
                    db.TBL_CARIHAREKETLERI.DeleteOnSubmit(db.TBL_CARIHAREKETLERI.First(t => t.EVRAKID == CekID && t.EVRAKTURU == "Müşteri Çek"));
                    db.SubmitChanges();
                    Fonksiyonlar.Mesajlar.MesajGoster("Silme işlemi başarılı");
                    Temizle();
                }

            }
            catch (Exception err)
            {
                Fonksiyonlar.Mesajlar.HataMesaj(err);
            }
        }

        public void Ac(int ID)
        {
            try
            {
                CekID = ID;
                Fonksiyonlar.TBL_CEKLER cek = db.TBL_CEKLER.First(t => t.CEKID == CekID);
                txt_Aciklama.Text = cek.ACIKLAMA;
                if (cek.ACKODU == "A") txt_CekTuru.SelectedIndex = 0;
                if (cek.ACKODU == "C") txt_CekTuru.SelectedIndex = 1;
                txt_AsilBorclu.Text = cek.ASILBORCLU;
                txt_Banka.Text = cek.BANKA;
                txt_BelgeNo.Text = cek.BELGENO;
                txt_CekNo.Text = cek.CEKNO;
                txt_HesapNo.Text = cek.HESAPNO;
                txt_Sube.Text = cek.SUBE;
                txt_Tutar.Text = cek.TUTAR.Value.ToString();
                txt_VadeTarihi.Text = cek.VADETARIHI.Value.ToShortDateString();
                CariAc(cek.ALINANCARIID.Value);
            }
            catch (Exception err)
            {
                Fonksiyonlar.Mesajlar.HataMesaj(err);
                Temizle();
            }
        }

        void CariAc(int ID)
        {
            try
            {
                CariID = ID;
                Fonksiyonlar.TBL_CARILER cari = db.TBL_CARILER.First(t => t.CARIID == CariID);
                txt_CariAdi.Text = cari.CARIADI;
                txt_CariAdi.Text = cari.CARIKODU;
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
                if (control is DevExpress.XtraEditors.TextEdit || control is DevExpress.XtraEditors.MemoEdit || control is DevExpress.XtraEditors.ButtonEdit)
                    control.Text = "";
            }

            txt_CekTuru.SelectedIndex = 0;
            txt_VadeTarihi.Text = DateTime.Now.ToShortDateString();
            CariID = -1;
            CekID = -1;
            frm_Anasayfa.AktarilanID = -1;
            btn_Guncelle.Enabled = false;
            btn_Sil.Enabled = false;
        }
    }
}
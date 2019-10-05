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
    public partial class frm_KullaniciCek : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.StokDatabaseDataContext db = new Fonksiyonlar.StokDatabaseDataContext();
        Fonksiyonlar.FormYonetici formRouter = new Fonksiyonlar.FormYonetici();

        int CekID = -1;
        int BankaID = -1;

        public frm_KullaniciCek()
        {
            InitializeComponent();
        }

        private void KullaniciCek_Load(object sender, EventArgs e)
        {
            txt_VadeTarihi.Text = DateTime.Now.ToShortDateString();
        }
        private void Txt_BankaSubesi_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }
        private void Txt_HesapNo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            formRouter.BankaListesiAc(true);
            BankaID = frm_Anasayfa.AktarilanID;
            if (BankaID > -1)
            {
                BankaAc(BankaID);
                frm_Anasayfa.AktarilanID = -1;
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
                Fonksiyonlar.TBL_CEKLER cek = new Fonksiyonlar.TBL_CEKLER();
                cek.ACIKLAMA = txt_Aciklama.Text;
                cek.ACKODU = "A";
                cek.BANKA = txt_Banka.Text;
                cek.BELGENO = txt_BelgeNo.Text;
                cek.CEKNO = txt_CekNo.Text;
                cek.DURUM = "Portföy";
                cek.HESAPNO = txt_HesapNo.Text;
                cek.SUBE = txt_Sube.Text;
                cek.TAHSIL = "Hayır";
                cek.TARIH = DateTime.Now;
                cek.TIP = "Kullanıcı Çeki";
                cek.TUTAR = decimal.Parse(txt_Tutar.Text);
                cek.VADETARIHI = DateTime.Parse(txt_VadeTarihi.Text);
                cek.SAVEDATE = DateTime.Now;
                cek.SAVEUSER = frm_Anasayfa.userID;

                if (Fonksiyonlar.Mesajlar.OnayMesaj() == DialogResult.Yes)
                {
                    db.TBL_CEKLER.InsertOnSubmit(cek);
                    db.SubmitChanges();

                    Fonksiyonlar.TBL_BANKAHAREKETLERI bankaHareket = new Fonksiyonlar.TBL_BANKAHAREKETLERI();
                    bankaHareket.ACIKLAMA = txt_CekNo.Text + " nolu ve " + txt_VadeTarihi.Text + " vadeli kullanıcı çeki.";
                    bankaHareket.BANKAID = BankaID;
                    bankaHareket.BELGENO = txt_BelgeNo.Text;
                    bankaHareket.EVRAKID = cek.CEKID;
                    bankaHareket.EVRAKTURU = "Kullanıcı Çeki";
                    bankaHareket.GCKODU = "C";
                    bankaHareket.TARIH = DateTime.Now;
                    bankaHareket.TUTAR = 0;
                    bankaHareket.SAVEDATE = DateTime.Now;
                    bankaHareket.SAVEUSER = frm_Anasayfa.userID;

                    db.TBL_BANKAHAREKETLERI.InsertOnSubmit(bankaHareket);
                    db.SubmitChanges();

                    Fonksiyonlar.Mesajlar.MesajGoster("Kayıt işlemi başarılı.");
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
                Fonksiyonlar.TBL_CEKLER cek = db.TBL_CEKLER.First(t => t.CEKID == CekID);
                cek.ACIKLAMA = txt_Aciklama.Text;
                cek.ACKODU = "A";
                cek.BANKA = txt_Banka.Text;
                cek.BELGENO = txt_BelgeNo.Text;
                cek.CEKNO = txt_CekNo.Text;
                cek.DURUM = "Portföy";
                cek.HESAPNO = txt_HesapNo.Text;
                cek.SUBE = txt_Sube.Text;
                cek.TAHSIL = "Hayır";
                cek.TARIH = DateTime.Now;
                cek.TIP = "Kullanıcı Çeki";
                cek.TUTAR = decimal.Parse(txt_Tutar.Text);
                cek.VADETARIHI = DateTime.Parse(txt_VadeTarihi.Text);
                cek.EDITDATE = DateTime.Now;
                cek.EDITUSER = frm_Anasayfa.userID;

                if (Fonksiyonlar.Mesajlar.OnayMesaj() == DialogResult.Yes)
                {
                    db.SubmitChanges();

                    Fonksiyonlar.TBL_BANKAHAREKETLERI bankaHareket = db.TBL_BANKAHAREKETLERI.First(t => t.EVRAKID == CekID && t.EVRAKTURU == "Kullanıcı Çeki");
                    bankaHareket.ACIKLAMA = txt_CekNo.Text + " nolu ve " + txt_VadeTarihi.Text + " vadeli kullanıcı çeki.";
                    bankaHareket.BANKAID = BankaID;
                    bankaHareket.BELGENO = txt_BelgeNo.Text;
                    bankaHareket.EVRAKID = cek.CEKID;
                    bankaHareket.EVRAKTURU = "Kullanıcı Çeki";
                    bankaHareket.GCKODU = "C";
                    bankaHareket.TARIH = DateTime.Now;
                    bankaHareket.TUTAR = 0;
                    bankaHareket.EDITDATE = DateTime.Now;
                    bankaHareket.EDITUSER = frm_Anasayfa.userID;

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
                    db.TBL_BANKAHAREKETLERI.DeleteOnSubmit(db.TBL_BANKAHAREKETLERI.First(t => t.EVRAKID == CekID && t.EVRAKTURU == "Kullanıcı Çeki"));
                    db.TBL_CEKLER.DeleteOnSubmit(db.TBL_CEKLER.First(t => t.CEKID == CekID));
                    db.SubmitChanges();
                    Fonksiyonlar.Mesajlar.MesajGoster("Silme işlemi başarılı.");
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
                BankaAc(db.TBL_BANKALAR.First(t => t.BANKAADI == cek.BANKA && t.HESAPNO == cek.HESAPNO).BANKAID);
                txt_Aciklama.Text = cek.ACIKLAMA;
                txt_BelgeNo.Text = cek.BELGENO;
                txt_CekNo.Text = cek.CEKNO;
                txt_Tutar.Text = cek.TUTAR.Value.ToString();
                txt_VadeTarihi.Text = cek.VADETARIHI.Value.ToShortDateString();
                btn_Guncelle.Enabled = true;
                btn_Sil.Enabled = true;
            }
            catch (Exception err)
            {
                Fonksiyonlar.Mesajlar.HataMesaj(err);
                Temizle();
            }
        }

        void BankaAc(int ID)
        {
            try
            {
                BankaID = ID;
                Fonksiyonlar.TBL_BANKALAR banka = db.TBL_BANKALAR.First(t => t.BANKAID == BankaID);
                txt_Banka.Text = banka.BANKAADI;
                txt_HesapNo.Text = banka.HESAPNO;
                txt_Sube.Text = banka.SUBE;
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
            txt_VadeTarihi.Text = DateTime.Now.ToShortDateString();
            CekID = -1;
            BankaID = -1;
            btn_Guncelle.Enabled = false;
            btn_Sil.Enabled = false;
            frm_Anasayfa.AktarilanID = -1;
        }

        
    }
}
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
    public partial class frm_CariyeCekCikisi : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.StokDatabaseDataContext db = new Fonksiyonlar.StokDatabaseDataContext();
        Fonksiyonlar.FormYonetici formRouter = new Fonksiyonlar.FormYonetici();
        int CariID = -1;
        int CekID = -1;
        public frm_CariyeCekCikisi()
        {
            InitializeComponent();
        }

        private void Frm_CariyeCekCikisi_Load(object sender, EventArgs e)
        {
            txt_Tarih.Text = DateTime.Now.ToShortDateString();
            txt_VadeTarihi.Text = DateTime.Now.ToShortDateString();
        }

        private void Txt_BelgeNo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

        private void Txt_CariKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            formRouter.CariListesiAc(true);
            int id = frm_Anasayfa.AktarilanID;
            if (id > -1)
                CariAc(id);
            frm_Anasayfa.AktarilanID = -1;
        }

        private void Txt_CekNo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            formRouter.CariListesiAc(true);
            CekID = frm_Anasayfa.AktarilanID;
            if (CekID > -1)
                Ac(CekID);
            frm_Anasayfa.AktarilanID = -1;
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
                Fonksiyonlar.TBL_CEKLER cek = db.TBL_CEKLER.First(t => t.CEKID == CekID);
                cek.VERILENCARIID = CariID;
                cek.VERILENCARITARIHI = DateTime.Parse(txt_Tarih.Text);
                cek.VERILENCARIBELGENO = txt_BelgeNo.Text;
                cek.DURUM = "Caride";
                cek.EDITDATE = DateTime.Now;
                cek.EDITUSER = frm_Anasayfa.userID;
                if (Fonksiyonlar.Mesajlar.OnayMesaj() == DialogResult.Yes)
                {
                    db.SubmitChanges();
                    Fonksiyonlar.TBL_CARIHAREKETLERI cariHareket = new Fonksiyonlar.TBL_CARIHAREKETLERI();
                    cariHareket.ACIKLAMA = txt_CekNo.Text + " çek numaralı ve " + txt_BelgeNo.Text + " belge numaralı çek.";
                    cariHareket.BORC = decimal.Parse(txt_Tutar.Text);
                    cariHareket.CARIID = CariID;
                    cariHareket.EVRAKID = CekID;
                    cariHareket.EVRAKTURU = "Cariye Çek";
                    cariHareket.TARIH = DateTime.Now;
                    cariHareket.TIP = "Çek İşlemi";
                    cariHareket.SAVEDATE = DateTime.Now;
                    cariHareket.SAVEUSER = frm_Anasayfa.userID;
                    db.TBL_CARIHAREKETLERI.InsertOnSubmit(cariHareket);
                    db.SubmitChanges();
                    Fonksiyonlar.Mesajlar.MesajGoster("Kaydetme işlemi başarılı");
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
                cek.VERILENCARIID = CariID;
                cek.VERILENCARITARIHI = DateTime.Parse(txt_Tarih.Text);
                cek.VERILENCARIBELGENO = txt_BelgeNo.Text;
                cek.DURUM = "Caride";
                cek.EDITDATE = DateTime.Now;
                cek.EDITUSER = frm_Anasayfa.userID;
                if (Fonksiyonlar.Mesajlar.OnayMesaj() == DialogResult.Yes)
                {
                    db.SubmitChanges();
                    Fonksiyonlar.TBL_CARIHAREKETLERI cariHareket = db.TBL_CARIHAREKETLERI.First(t => t.EVRAKTURU == "Cariye çek" && t.EVRAKID == CekID);
                    cariHareket.ACIKLAMA = txt_CekNo.Text + " çek numaralı ve " + txt_BelgeNo.Text + " belge numaralı çek.";
                    cariHareket.BORC = decimal.Parse(txt_Tutar.Text);
                    cariHareket.CARIID = CariID;
                    cariHareket.EVRAKID = CekID;
                    cariHareket.EVRAKTURU = "Cariye Çek";
                    cariHareket.TARIH = DateTime.Now;
                    cariHareket.TIP = "Çek İşlemi";
                    cariHareket.EDITDATE = DateTime.Now;
                    cariHareket.EDITUSER = frm_Anasayfa.userID;
                    db.SubmitChanges();
                    Fonksiyonlar.Mesajlar.MesajGoster("Guncelleme işlemi başarılı");
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
                    db.TBL_CARIHAREKETLERI.DeleteOnSubmit(db.TBL_CARIHAREKETLERI.First(t => t.EVRAKTURU == "Cariye çek" && t.EVRAKID == CekID));
                    Fonksiyonlar.TBL_CEKLER cek = db.TBL_CEKLER.First(t => t.CEKID == CekID);
                    cek.VERILENCARIBELGENO = "";
                    cek.VERILENCARIID = -1;
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
                CekAc(CekID);
            }
            catch (Exception err)
            {
                Fonksiyonlar.Mesajlar.HataMesaj(err);
                Temizle();
            }
        }
        void CekAc(int ID)
        {
            try
            {
                CekID = ID;
                Fonksiyonlar.TBL_CEKLER cek = db.TBL_CEKLER.First(t => t.CEKID == CekID);
                txt_Banka.Text = cek.BANKA;
                txt_CekNo.Text = cek.CEKNO;
                txt_Sube.Text = cek.SUBE;
                txt_VadeTarihi.Text = cek.VADETARIHI.Value.ToShortDateString();
                txt_Tutar.Text = cek.TUTAR.Value.ToString();

                if (cek.VERILENCARIID.Value > -1 && cek.VERILENCARIID != null)
                {
                    CariAc(cek.VERILENCARIID.Value);
                    txt_BelgeNo.Text = cek.VERILENCARIBELGENO;
                    txt_Tarih.Text = cek.VERILENCARITARIHI.Value.ToShortDateString();
                } 

                btn_Guncelle.Enabled = true;
                btn_Sil.Enabled = true;
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
                Fonksiyonlar.TBL_CARILER cari = db.TBL_CARILER.First(t => t.CARIID == CariID);
                txt_CariKodu.Text = cari.CARIKODU;
                txt_CariAdi.Text = cari.CARIADI;
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
                if (control is DevExpress.XtraEditors.TextEdit || control is DevExpress.XtraEditors.ButtonEdit)
                    control.Text = "";
            }

            txt_VadeTarihi.Text = DateTime.Now.ToShortDateString();
            txt_Tarih.Text = DateTime.Now.ToShortDateString();
            CariID = -1;
            CekID = -1;
            frm_Anasayfa.AktarilanID = -1;
            btn_Guncelle.Enabled = false;
            btn_Sil.Enabled = false;
        }
    }
}
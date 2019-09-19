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
    public partial class frm_KasaDevirIslem : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.StokDatabaseDataContext db = new Fonksiyonlar.StokDatabaseDataContext();
        public bool secim = false;
        int KasaID = -1;
        int islemID = -1;

        public frm_KasaDevirIslem()
        {
            InitializeComponent();
        }

        private void Frm_KasaDevirIslem_Load(object sender, EventArgs e)
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

        private void Btn_Kaydet_Click(object sender, EventArgs e)
        {
            if (txt_BelgeNo.Text != "" && txt_KasaKodu.Text != "" && txt_KasaAdi.Text != "")
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
                Fonksiyonlar.TBL_KASAHAREKETLERI yeniHareket = new Fonksiyonlar.TBL_KASAHAREKETLERI();
                yeniHareket.BELGENO = txt_BelgeNo.Text;
                yeniHareket.KASAID = KasaID;
                yeniHareket.EVRAKTURU = "Kasa Devir Kartı";
                if (rb_Giris.Checked) yeniHareket.GCKODU = "G";
                else yeniHareket.GCKODU = "C";
                yeniHareket.ACIKLAMA = txt_Aciklama.Text;
                yeniHareket.TARIH = DateTime.Parse(txt_Tarih.Text);
                yeniHareket.TUTAR = decimal.Parse(txt_Tutar.Text);
                yeniHareket.SAVEDATE = DateTime.Now;
                yeniHareket.SAVEUSER = frm_Anasayfa.userID;

                if (Fonksiyonlar.Mesajlar.OnayMesaj() == DialogResult.Yes)
                {
                    db.TBL_KASAHAREKETLERI.InsertOnSubmit(yeniHareket);
                    db.SubmitChanges();
                    Fonksiyonlar.Mesajlar.MesajGoster("Kayıt işlemi başarılı");
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
                Fonksiyonlar.TBL_KASAHAREKETLERI secilenHareket = db.TBL_KASAHAREKETLERI.First(t => t.ID == islemID);
                secilenHareket.BELGENO = txt_BelgeNo.Text;
                secilenHareket.KASAID = KasaID;
                secilenHareket.EVRAKTURU = "Kasa Devir Kartı";
                if (rb_Giris.Checked) secilenHareket.GCKODU = "G";
                else secilenHareket.GCKODU = "C";
                secilenHareket.ACIKLAMA = txt_Aciklama.Text;
                secilenHareket.TARIH = DateTime.Parse(txt_Tarih.Text);
                secilenHareket.TUTAR = decimal.Parse(txt_Tutar.Text);
                secilenHareket.EDITDATE = DateTime.Now;
                secilenHareket.EDITUSER = frm_Anasayfa.userID;

                if (Fonksiyonlar.Mesajlar.OnayMesaj() == DialogResult.Yes)
                {
                    db.SubmitChanges();
                    Fonksiyonlar.Mesajlar.MesajGoster("Güncelleme işlemi başarılı");
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
                Fonksiyonlar.TBL_KASAHAREKETLERI secilenHareket = db.TBL_KASAHAREKETLERI.First(t => t.ID == islemID);

                if (Fonksiyonlar.Mesajlar.OnayMesaj() == DialogResult.Yes)
                {
                    db.TBL_KASAHAREKETLERI.DeleteOnSubmit(secilenHareket);
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

        void KasaAc(int ID)
        {
            KasaID = ID;
            txt_KasaKodu.Text = db.TBL_KASALAR.First(t => t.KASAID == KasaID).KASAKODU.ToString();
            txt_KasaAdi.Text = db.TBL_KASALAR.First(t => t.KASAID == KasaID).KASAADI.ToString();
        }

        public void Ac(int ID)
        {
            try
            {
                
                islemID = ID;
                Fonksiyonlar.TBL_KASAHAREKETLERI hareket = db.TBL_KASAHAREKETLERI.First(t => t.ID == islemID);
                txt_Aciklama.Text = hareket.ACIKLAMA;
                txt_BelgeNo.Text = hareket.BELGENO;
                KasaAc(hareket.KASAID.Value);
                txt_Tarih.Text = hareket.TARIH.Value.ToShortDateString();
                txt_Tutar.Text = hareket.TUTAR.ToString();
                if (hareket.GCKODU.ToString() == "G") rb_Giris.Checked = true;
                else if (hareket.GCKODU.ToString() == "C") rb_Cikis.Checked = true;
                btn_Guncelle.Enabled = true;
                btn_Sil.Enabled = true;
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
                if (control is DevExpress.XtraEditors.TextEdit || control is DevExpress.XtraEditors.MemoEdit)
                    control.Text = "";
            }

            txt_Tarih.Text = DateTime.Now.ToShortDateString();
            btn_Guncelle.Enabled = false;
            btn_Sil.Enabled = false;
            KasaID = -1;
            frm_Anasayfa.AktarilanID = -1;
        }
    }
}
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

namespace Otomasyon.BankaModul
{
    public partial class frm_ParaTransferi : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.StokDatabaseDataContext db = new Fonksiyonlar.StokDatabaseDataContext();
        Fonksiyonlar.FormYonetici formRouter = new Fonksiyonlar.FormYonetici();

        int CariID = -1;
        int BankaID = -1;
        int IslemID = -1;
        public frm_ParaTransferi()
        {
            InitializeComponent();
        }

        private void Frm_ParaTransferi_Load(object sender, EventArgs e)
        {
            txt_Tarih.Text = DateTime.Now.ToShortDateString();
        }
        private void Txt_TransferTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txt_TransferTuru.SelectedIndex == 0)
            {
                radioButton1.Text = "Gelen Havale";
                radioButton2.Text = "Giden Havale";
            }
            else if (txt_TransferTuru.SelectedIndex == 1)
            {
                radioButton1.Text = "Gelen EFT";
                radioButton2.Text = "Giden EFT";
            }
        }

        private void Txt_HesapAdi_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            formRouter.BankaListesiAc(true);
            BankaID = frm_Anasayfa.AktarilanID;
            if (BankaID > -1)
                BankaAc(BankaID);
        }

        private void Txt_CariKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            formRouter.CariListesiAc(true);
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
                Fonksiyonlar.TBL_BANKAHAREKETLERI yeniHareket = new Fonksiyonlar.TBL_BANKAHAREKETLERI();
                yeniHareket.ACIKLAMA = txt_Aciklama.Text;
                yeniHareket.BANKAID = BankaID;
                yeniHareket.CARIID = CariID;
                yeniHareket.BELGENO = txt_BelgeNo.Text;
                yeniHareket.EVRAKTURU = txt_TransferTuru.SelectedItem.ToString();
                if (radioButton1.Checked) yeniHareket.GCKODU = "G";
                if (radioButton2.Checked) yeniHareket.GCKODU = "C";
                yeniHareket.TARIH = DateTime.Parse(txt_Tarih.Text);
                yeniHareket.TUTAR = decimal.Parse(txt_Tutar.Text);
                yeniHareket.SAVEDATE = DateTime.Now;
                yeniHareket.SAVEUSER = frm_Anasayfa.userID;
                if (Fonksiyonlar.Mesajlar.OnayMesaj() == DialogResult.Yes)
                {
                    db.TBL_BANKAHAREKETLERI.InsertOnSubmit(yeniHareket);
                    db.SubmitChanges();

                    Fonksiyonlar.TBL_CARIHAREKETLERI cariHareket = new Fonksiyonlar.TBL_CARIHAREKETLERI();
                    cariHareket.ACIKLAMA = txt_Aciklama.Text;
                    if (radioButton1.Checked) cariHareket.ALACAK = decimal.Parse(txt_Tutar.Text);
                    if (radioButton2.Checked) cariHareket.BORC = decimal.Parse(txt_Tutar.Text);
                    cariHareket.CARIID = CariID;
                    cariHareket.EVRAKID = yeniHareket.ID;
                    cariHareket.EVRAKTURU = txt_TransferTuru.SelectedItem.ToString();
                    cariHareket.TARIH = DateTime.Parse(txt_Tarih.Text);
                    if (txt_TransferTuru.SelectedIndex == 0) cariHareket.TIP = "BH";
                    if (txt_TransferTuru.SelectedIndex == 1) cariHareket.TIP = "EFT";
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
                Fonksiyonlar.TBL_BANKAHAREKETLERI yeniHareket = db.TBL_BANKAHAREKETLERI.First(t => t.ID == IslemID);
                yeniHareket.ACIKLAMA = txt_Aciklama.Text;
                yeniHareket.BANKAID = BankaID;
                yeniHareket.CARIID = CariID;
                yeniHareket.BELGENO = txt_BelgeNo.Text;
                yeniHareket.EVRAKTURU = txt_TransferTuru.SelectedItem.ToString();
                if (radioButton1.Checked) yeniHareket.GCKODU = "G";
                if (radioButton2.Checked) yeniHareket.GCKODU = "C";
                yeniHareket.TARIH = DateTime.Parse(txt_Tarih.Text);
                yeniHareket.TUTAR = decimal.Parse(txt_Tutar.Text);
                yeniHareket.EDITDATE = DateTime.Now;
                yeniHareket.EDITUSER = frm_Anasayfa.userID;
                if (Fonksiyonlar.Mesajlar.OnayMesaj() == DialogResult.Yes)
                {
                    db.SubmitChanges();

                    Fonksiyonlar.TBL_CARIHAREKETLERI cariHareket = db.TBL_CARIHAREKETLERI.First(t => t.EVRAKTURU == txt_TransferTuru.SelectedItem.ToString() && t.EVRAKID == IslemID); ;
                    cariHareket.ACIKLAMA = txt_Aciklama.Text;
                    if (radioButton1.Checked) cariHareket.ALACAK = decimal.Parse(txt_Tutar.Text);
                    if (radioButton2.Checked) cariHareket.BORC = decimal.Parse(txt_Tutar.Text);
                    cariHareket.CARIID = CariID;
                    cariHareket.EVRAKID = yeniHareket.ID;
                    cariHareket.EVRAKTURU = txt_TransferTuru.SelectedItem.ToString();
                    cariHareket.TARIH = DateTime.Parse(txt_Tarih.Text);
                    if (txt_TransferTuru.SelectedIndex == 0) cariHareket.TIP = "BH";
                    if (txt_TransferTuru.SelectedIndex == 1) cariHareket.TIP = "EFT";
                    cariHareket.EDITDATE = DateTime.Now;
                    cariHareket.EDITUSER = frm_Anasayfa.userID;
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
                if (Fonksiyonlar.Mesajlar.OnayMesaj() == DialogResult.Yes)
                {
                    db.TBL_CARIHAREKETLERI.DeleteOnSubmit(db.TBL_CARIHAREKETLERI.First(t => t.EVRAKTURU == txt_TransferTuru.SelectedItem.ToString() && t.EVRAKID == IslemID));
                    db.SubmitChanges();
                    db.TBL_BANKAHAREKETLERI.DeleteOnSubmit(db.TBL_BANKAHAREKETLERI.First(t => t.ID == IslemID));
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
        void BankaAc(int ID)
        {
            try
            {
                BankaID = ID;
                txt_HesapAdi.Text = db.TBL_BANKALAR.First(t => t.BANKAID == BankaID).HESAPADI;
                txt_HesapNo.Text = db.TBL_BANKALAR.First(t => t.BANKAID == BankaID).HESAPNO;
                btn_Guncelle.Enabled = true;
                btn_Sil.Enabled = true;
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
                IslemID = ID;
                Fonksiyonlar.TBL_BANKAHAREKETLERI banka = db.TBL_BANKAHAREKETLERI.First(t => t.ID == IslemID);
                BankaAc(banka.BANKAID.Value);
                CariAc(banka.CARIID.Value);
                txt_Aciklama.Text = banka.ACIKLAMA;
                txt_BelgeNo.Text = banka.BELGENO;
                txt_Tarih.Text = banka.TARIH.Value.ToShortDateString();
                txt_TransferTuru.Text = banka.EVRAKTURU;
                txt_Tutar.Text = banka.TUTAR.ToString();
                if (banka.GCKODU == "G") radioButton1.Checked = true;
                if (banka.GCKODU == "C") radioButton2.Checked = true;

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
                txt_CariAdi.Text = db.TBL_CARILER.First(t => t.CARIID == CariID).CARIADI;
                txt_CariKodu.Text = db.TBL_CARILER.First(t => t.CARIID == CariID).CARIKODU;
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
            txt_TransferTuru.SelectedIndex = 0;
            radioButton1.Checked = true;
            frm_Anasayfa.AktarilanID = -1;
            BankaID = -1;
            CariID = -1;
            IslemID = -1;
            btn_Guncelle.Enabled = false;
            btn_Sil.Enabled = false;
        }

        
    }
}
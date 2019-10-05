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
    public partial class frm_BankayaCekCikisi : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.StokDatabaseDataContext db = new Fonksiyonlar.StokDatabaseDataContext();
        Fonksiyonlar.FormYonetici formRouter = new Fonksiyonlar.FormYonetici();
        Fonksiyonlar.TBL_CEKLER cek;

        int CekID = -1;
        int BankaID = -1;

        public frm_BankayaCekCikisi()
        {
            InitializeComponent();
        }

        private void Frm_BankayaCekCikisi_Load(object sender, EventArgs e)
        {
            txt_VadeTarihi.Text = DateTime.Now.ToShortDateString();
            txt_Tarih.Text = DateTime.Now.ToShortDateString();
        }

        private void Txt_BelgeNo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

        private void Txt_HesapNo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            formRouter.BankaListesiAc(true);
            BankaID = frm_Anasayfa.AktarilanID;
            if (BankaID > -1)
                BankaAc(BankaID);
            frm_Anasayfa.AktarilanID = -1;
        }

        private void Txt_CekNo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            formRouter.CekListesiAc(true);
            CekID = frm_Anasayfa.AktarilanID;
            if (CekID > -1)
                CekAc(CekID);
            frm_Anasayfa.AktarilanID = -1;
        }

        private void Txt_Banka_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

        private void Btn_Kaydet_Click(object sender, EventArgs e)
        {
            Kaydet();
        }

        private void Btn_Guncelle_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Sil_Click(object sender, EventArgs e)
        {

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
                yeniHareket.ACIKLAMA = txt_BelgeNo.Text + " belge numaralı ve " + txt_CekNo.Text + " numaralı çekin bankaya çıkışı";
                yeniHareket.BANKAID = BankaID;
                yeniHareket.BELGENO = txt_BelgeNo.Text;
                yeniHareket.EVRAKID = CekID;
                yeniHareket.EVRAKTURU = "Bankaya çek";
                yeniHareket.GCKODU = "G";
                yeniHareket.SAVEDATE = DateTime.Now;
                yeniHareket.SAVEUSER = frm_Anasayfa.userID;
                yeniHareket.TARIH = DateTime.Parse(txt_Tarih.Text);
                yeniHareket.TUTAR = decimal.Parse(txt_Tutar.Text);

                if (Fonksiyonlar.Mesajlar.OnayMesaj() == DialogResult.Yes)
                {
                    db.TBL_BANKAHAREKETLERI.InsertOnSubmit(yeniHareket);
                    db.SubmitChanges();
                    Fonksiyonlar.Mesajlar.MesajGoster("Kaydetme işlemi başarılı.");
                    cek.VERILENBANKABELGENO = txt_BelgeNo.Text;
                    cek.VERILENBANKATARIHI = DateTime.Parse(txt_Tarih.Text);
                    cek.VERILENBANKAID = BankaID;
                    cek.DURUM = "Bankada";
                    db.SubmitChanges();
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
                Fonksiyonlar.TBL_BANKALAR banka = db.TBL_BANKALAR.First(t => t.BANKAID == BankaID);
                txt_HesapNo.Text = banka.HESAPNO;
                txt_BankaAdi.Text = banka.HESAPADI;
            }
            catch (Exception err)
            {
                Fonksiyonlar.Mesajlar.HataMesaj(err);
            }
        }
        void CekAc(int ID)
        {
            try
            {
                CekID = ID;
                cek = db.TBL_CEKLER.First(t => t.CEKID == CekID);
                txt_Banka.Text = cek.BANKA;
                txt_CekNo.Text = cek.CEKNO;
                txt_Sube.Text = cek.SUBE;
                txt_VadeTarihi.Text = cek.VADETARIHI.Value.ToShortDateString();
                txt_Tutar.Text = cek.TUTAR.Value.ToString();
                
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
            BankaID = -1;
            CekID = -1;
            cek = null;
            frm_Anasayfa.AktarilanID = -1;
            btn_Guncelle.Enabled = false;
            btn_Sil.Enabled = false;
        }
    }
}
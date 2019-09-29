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
    public partial class frm_BankaIslem : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.StokDatabaseDataContext db = new Fonksiyonlar.StokDatabaseDataContext();
        Fonksiyonlar.FormYonetici formRouter = new Fonksiyonlar.FormYonetici();

        int BankaID = -1;
        int IslemID = -1;

        public frm_BankaIslem()
        {
            InitializeComponent();
        }

        private void Txt_HesapAdi_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            formRouter.BankaListesiAc(true);
            BankaID = frm_Anasayfa.AktarilanID;
            if(BankaID > -1)
                BankaAc(BankaID);
        }

        private void Frm_BankaIslem_Load(object sender, EventArgs e)
        {
            txt_Tarih.Text = DateTime.Now.ToShortDateString();
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
                yeniHareket.BELGENO = txt_BelgeNo.Text;
                yeniHareket.EVRAKTURU = "Banka İşlem";
                yeniHareket.TUTAR = decimal.Parse(txt_Tutar.Text);
                if (radioButton1.Checked) yeniHareket.GCKODU = "G";
                else if (radioButton2.Checked) yeniHareket.GCKODU = "C";
                yeniHareket.TARIH = DateTime.Parse(txt_Tarih.Text);
                yeniHareket.SAVEDATE = DateTime.Now;
                yeniHareket.SAVEUSER = frm_Anasayfa.userID;

                if (Fonksiyonlar.Mesajlar.OnayMesaj() == DialogResult.Yes)
                {
                    db.TBL_BANKAHAREKETLERI.InsertOnSubmit(yeniHareket);
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
                Fonksiyonlar.TBL_BANKAHAREKETLERI secilenHareket = db.TBL_BANKAHAREKETLERI.First(t => t.ID == IslemID);
                secilenHareket.ACIKLAMA = txt_Aciklama.Text;
                secilenHareket.BANKAID = BankaID;
                secilenHareket.BELGENO = txt_BelgeNo.Text;
                secilenHareket.EVRAKTURU = "Banka İşlem";
                secilenHareket.TUTAR = decimal.Parse(txt_Tutar.Text);
                if (radioButton1.Checked) secilenHareket.GCKODU = "G";
                else if (radioButton2.Checked) secilenHareket.GCKODU = "C";
                secilenHareket.TARIH = DateTime.Parse(txt_Tarih.Text);
                secilenHareket.EDITDATE = DateTime.Now;
                secilenHareket.EDITUSER = frm_Anasayfa.userID;

                if (Fonksiyonlar.Mesajlar.OnayMesaj() == DialogResult.Yes)
                {
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
                db.TBL_BANKAHAREKETLERI.DeleteOnSubmit(db.TBL_BANKAHAREKETLERI.First(t => t.ID == IslemID));
                if (Fonksiyonlar.Mesajlar.OnayMesaj() == DialogResult)
                {
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
                IslemID = ID;
                Fonksiyonlar.TBL_BANKAHAREKETLERI secilenHareket = db.TBL_BANKAHAREKETLERI.First(t => t.ID == IslemID);
                BankaAc(secilenHareket.BANKAID.Value);
                txt_Aciklama.Text = secilenHareket.ACIKLAMA;
                txt_BelgeNo.Text = secilenHareket.BELGENO;
                txt_Tarih.Text = secilenHareket.TARIH.Value.ToShortDateString();
                txt_Tutar.Text = secilenHareket.TUTAR.ToString();
                if (secilenHareket.GCKODU == "G") radioButton1.Checked = true;
                else if (secilenHareket.GCKODU == "C") radioButton2.Checked = true;
                
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

            frm_Anasayfa.AktarilanID = -1;
            txt_Tarih.Text = DateTime.Now.ToShortTimeString();
            radioButton1.Checked = true;
            btn_Guncelle.Enabled = false;
            btn_Sil.Enabled = false;
        }
    }
}
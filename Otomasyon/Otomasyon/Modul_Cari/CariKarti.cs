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

namespace Otomasyon.CariModul
{
    public partial class frm_CariKarti : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.StokDatabaseDataContext db = new Fonksiyonlar.StokDatabaseDataContext();
        int CariID = -1;
        int CariGrupID = -1;
        public frm_CariKarti()
        {
            InitializeComponent();
        }

        private void Frm_CariKarti_Load(object sender, EventArgs e)
        {
            txt_CariKodu.Text = CariKodNumarasi();
        }

        private void Txt_CariKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            Fonksiyonlar.FormYonetici.CariListesiAc(true);
            CariID = frm_Anasayfa.AktarilanID;

            if (CariID > -1)
                CariAc(CariID);
            
        }

        private void Txt_CariGrupKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            Fonksiyonlar.FormYonetici.CariGrupListesiAc(true);
            CariGrupID = frm_Anasayfa.AktarilanID;

            if(CariGrupID > -1)
                CariGrupAc(CariGrupID);
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

        string CariKodNumarasi()
        {
            try
            {
                int Numara = int.Parse((from t in db.TBL_CARILER
                                        orderby t.CARIID descending
                                        select t).First().CARIKODU)+1;
                string num = Numara.ToString().PadLeft(7, '0');
                return num;

            }
            catch (Exception)
            {
                return "0000001";
            }
            
        }

        void Kaydet()
        {
            try
            {
                Fonksiyonlar.TBL_CARILER yeniCari = new Fonksiyonlar.TBL_CARILER();
                yeniCari.CARIKODU = txt_CariKodu.Text;
                yeniCari.CARIADI = txt_CariAdi.Text;
                yeniCari.VERGINO = txt_VergiNo.Text;
                yeniCari.VERGIDAIRESI = txt_VergiDairesi.Text;
                yeniCari.CARIGRUPID = CariGrupID;
                yeniCari.ULKE = txt_Ulke.Text;
                yeniCari.SEHIR = txt_Sehir.Text;
                yeniCari.ILCE = txt_Ilce.Text;
                yeniCari.ADRES = txt_Adres.Text;
                yeniCari.TELEFON1 = txt_Telefon1.Text;
                yeniCari.TELEFON2 = txt_Telefon2.Text;
                yeniCari.WEBADRES = txt_WebAdres.Text;
                yeniCari.MAILADRES = txt_MailAdres.Text;
                yeniCari.YETKILI = txt_Yetkili.Text;
                yeniCari.YETKILIMAIL = txt_YetkiliMail.Text;
                yeniCari.FAX1 = txt_Fax1.Text;
                yeniCari.FAX2 = txt_Fax2.Text;
                yeniCari.CARISAVEDATE = DateTime.Now;
                yeniCari.CARISAVEUSER = frm_Anasayfa.userID;

                if (Fonksiyonlar.Mesajlar.OnayMesaj() == DialogResult.Yes)
                {
                    db.TBL_CARILER.InsertOnSubmit(yeniCari);
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
                Fonksiyonlar.TBL_CARILER secilenCari = db.TBL_CARILER.First(t => t.CARIID == CariID);
                secilenCari.CARIKODU = txt_CariKodu.Text;
                secilenCari.CARIADI = txt_CariAdi.Text;
                secilenCari.VERGINO = txt_VergiNo.Text;
                secilenCari.VERGIDAIRESI = txt_VergiDairesi.Text;
                secilenCari.CARIGRUPID = CariGrupID;
                secilenCari.ULKE = txt_Ulke.Text;
                secilenCari.SEHIR = txt_Sehir.Text;
                secilenCari.ILCE = txt_Ilce.Text;
                secilenCari.ADRES = txt_Adres.Text;
                secilenCari.TELEFON1 = txt_Telefon1.Text;
                secilenCari.TELEFON2 = txt_Telefon2.Text;
                secilenCari.WEBADRES = txt_WebAdres.Text;
                secilenCari.MAILADRES = txt_MailAdres.Text;
                secilenCari.YETKILI = txt_Yetkili.Text;
                secilenCari.YETKILIMAIL = txt_YetkiliMail.Text;
                secilenCari.FAX1 = txt_Fax1.Text;
                secilenCari.FAX2 = txt_Fax2.Text;
                secilenCari.CARIEDITDATE = DateTime.Now;
                secilenCari.CARIEDITUSER = frm_Anasayfa.userID;

                if (Fonksiyonlar.Mesajlar.OnayMesaj() == DialogResult.Yes)
                {
                    db.SubmitChanges();
                    Fonksiyonlar.Mesajlar.MesajGoster("Güncelleme işlemi başaarılı.");
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
                Fonksiyonlar.TBL_CARILER secilenCari = db.TBL_CARILER.First(t => t.CARIID == CariID);
                if (Fonksiyonlar.Mesajlar.OnayMesaj() == DialogResult.Yes)
                {
                    db.TBL_CARILER.DeleteOnSubmit(secilenCari);
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

        void CariAc(int cariId)
        {
            try
            {
                Fonksiyonlar.TBL_CARILER secilenCari = db.TBL_CARILER.First(t => t.CARIID == cariId);
                txt_CariKodu.Text = secilenCari.CARIKODU.ToString();
                btn_Guncelle.Enabled = true;
                btn_Sil.Enabled = true;
                txt_CariAdi.Text = secilenCari.CARIADI.ToString();
                txt_VergiNo.Text = secilenCari.VERGINO.ToString();
                txt_VergiDairesi.Text = secilenCari.VERGIDAIRESI.ToString();
                CariGrupAc(secilenCari.CARIGRUPID.Value);
                txt_Ulke.Text = secilenCari.ULKE.ToString();
                txt_Sehir.Text = secilenCari.SEHIR.ToString();
                txt_Ilce.Text = secilenCari.ILCE.ToString();
                txt_Adres.Text = secilenCari.ADRES.ToString();
                txt_Telefon1.Text = secilenCari.TELEFON1.ToString();
                txt_Telefon2.Text = secilenCari.TELEFON2.ToString();
                txt_WebAdres.Text = secilenCari.WEBADRES.ToString();
                txt_MailAdres.Text = secilenCari.MAILADRES.ToString();
                txt_Yetkili.Text = secilenCari.YETKILI.ToString();
                txt_YetkiliMail.Text = secilenCari.YETKILIMAIL.ToString();
                txt_Fax1.Text = secilenCari.FAX1.ToString();
                txt_Fax2.Text = secilenCari.FAX2.ToString();
            }
            catch (Exception err)
            {
                Fonksiyonlar.Mesajlar.HataMesaj(err);
            }
            
        }

        void CariGrupAc(int cariGrupId)
        {
            try
            {
                Fonksiyonlar.TBL_CARIGRUPLAR secilenGrup = db.TBL_CARIGRUPLAR.First(t => t.CARIGRUPID == cariGrupId);
                txt_CariGrupKodu.Text = secilenGrup.CARIGRUPKODU.ToString();
                txt_CariGrupAdi.Text = secilenGrup.CARIGRUPADI.ToString();
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

            foreach (Control control in groupControl3.Controls)
            {
                if (control is DevExpress.XtraEditors.TextEdit || control is DevExpress.XtraEditors.ButtonEdit || control is DevExpress.XtraEditors.MemoEdit)
                    control.Text = "";
            }

            txt_CariKodu.Text = CariKodNumarasi();
            frm_Anasayfa.AktarilanID = -1;
            btn_Guncelle.Enabled = false;
            btn_Sil.Enabled = false;
            CariGrupID = -1;
            CariID = -1;
        }
        
    }
}
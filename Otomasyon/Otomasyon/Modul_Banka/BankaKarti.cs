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
    public partial class frm_BankaKarti : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.StokDatabaseDataContext db = new Fonksiyonlar.StokDatabaseDataContext();
        Fonksiyonlar.FormYonetici formRouter = new Fonksiyonlar.FormYonetici();
        int secimID = -1;


        public frm_BankaKarti()
        {
            InitializeComponent();
        }

        private void Txt_BankaAdi_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            formRouter.BankaListesiAc(true);
            secimID = frm_Anasayfa.AktarilanID;

            if (secimID > -1)
                Ac();
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
                Fonksiyonlar.TBL_BANKALAR yeniBanka = new Fonksiyonlar.TBL_BANKALAR();
                yeniBanka.ADRES = txt_Adres.Text;
                yeniBanka.BANKAADI = txt_BankaAdi.Text;
                yeniBanka.HESAPADI = txt_HesapAdi.Text;
                yeniBanka.HESAPNO = txt_HesapNo.Text;
                yeniBanka.IBAN = txt_IBAN.Text;
                yeniBanka.SUBE = txt_BankaSubesi.Text;
                yeniBanka.TEL = txt_SubeTelefon.Text;
                yeniBanka.TEMSILCI = txt_Temsilci.Text;
                yeniBanka.TEMSILCIMAIL = txt_TemsilciMail.Text;
                yeniBanka.SAVEDATE = DateTime.Now;
                yeniBanka.SAVEUSER = frm_Anasayfa.userID;

                if (Fonksiyonlar.Mesajlar.OnayMesaj() == DialogResult.Yes)
                {
                    db.TBL_BANKALAR.InsertOnSubmit(yeniBanka);
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
                Fonksiyonlar.TBL_BANKALAR secilenBanka = db.TBL_BANKALAR.First(t => t.BANKAID == secimID);
                secilenBanka.ADRES = txt_Adres.Text;
                secilenBanka.BANKAADI = txt_BankaAdi.Text;
                secilenBanka.HESAPADI = txt_HesapAdi.Text;
                secilenBanka.HESAPNO = txt_HesapNo.Text;
                secilenBanka.IBAN = txt_IBAN.Text;
                secilenBanka.SUBE = txt_BankaSubesi.Text;
                secilenBanka.TEL = txt_SubeTelefon.Text;
                secilenBanka.TEMSILCI = txt_Temsilci.Text;
                secilenBanka.TEMSILCIMAIL = txt_TemsilciMail.Text;
                secilenBanka.EDITDATE = DateTime.Now;
                secilenBanka.EDITUSER = frm_Anasayfa.userID;

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
                if (Fonksiyonlar.Mesajlar.OnayMesaj() == DialogResult.Yes)
                {
                    db.TBL_BANKALAR.DeleteOnSubmit(db.TBL_BANKALAR.First(t => t.BANKAID == secimID));
                    db.SubmitChanges();
                    Temizle();
                }
            }
            catch (Exception err)
            {
                Fonksiyonlar.Mesajlar.HataMesaj(err);
            }
        }

        void Ac()
        {
            try
            {
                Fonksiyonlar.TBL_BANKALAR secilenBanka = db.TBL_BANKALAR.First(t => t.BANKAID == secimID);
                txt_BankaAdi.Text = secilenBanka.BANKAADI;
                txt_BankaSubesi.Text = secilenBanka.SUBE;
                txt_Adres.Text = secilenBanka.ADRES;
                txt_HesapAdi.Text = secilenBanka.HESAPADI;
                txt_HesapNo.Text = secilenBanka.HESAPNO;
                txt_IBAN.Text = secilenBanka.IBAN;
                txt_SubeTelefon.Text = secilenBanka.TEL;
                txt_Temsilci.Text = secilenBanka.TEMSILCI;
                txt_TemsilciMail.Text = secilenBanka.TEMSILCIMAIL;
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
                if (control is DevExpress.XtraEditors.TextEdit || control is DevExpress.XtraEditors.MemoEdit)
                    control.Text = "";
            }
            frm_Anasayfa.AktarilanID = -1;
            btn_Guncelle.Enabled = false;
            btn_Sil.Enabled = false;
        }


    }
}
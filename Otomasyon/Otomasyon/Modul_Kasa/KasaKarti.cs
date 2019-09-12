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
    public partial class frm_KasaKarti : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.StokDatabaseDataContext db = new Fonksiyonlar.StokDatabaseDataContext();
        int KasaID = -1;
        public frm_KasaKarti()
        {
            InitializeComponent();
        }

        private void Frm_KasaKarti_Load(object sender, EventArgs e)
        {
            txt_KasaKodu.Text = KasaKodNumarasi();
        }

        string KasaKodNumarasi()
        {
            try
            {
                int num = int.Parse((from t in db.TBL_KASALAR
                                     orderby t.KASAID descending
                                     select t).First().KASAKODU) + 1;
                string numara = num.ToString().PadLeft(7, '0');
                return numara;
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
                Fonksiyonlar.TBL_KASALAR yeniKasa = new Fonksiyonlar.TBL_KASALAR();
                yeniKasa.KASAKODU = txt_KasaKodu.Text;
                yeniKasa.KASAADI = txt_KasaAdi.Text;
                yeniKasa.ACIKLAMA = txt_Aciklama.Text;
                yeniKasa.SAVEDATE = DateTime.Now;
                yeniKasa.SAVEUSER = frm_Anasayfa.userID;

                if (Fonksiyonlar.Mesajlar.OnayMesaj() == DialogResult.Yes)
                {
                    db.TBL_KASALAR.InsertOnSubmit(yeniKasa);
                    db.SubmitChanges();
                    Fonksiyonlar.Mesajlar.MesajGoster("Kaydetme İşlemi Başarılı");
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
                Fonksiyonlar.TBL_KASALAR secilenKasa = db.TBL_KASALAR.First(t => t.KASAID == KasaID);
                secilenKasa.KASAKODU = txt_KasaKodu.Text;
                secilenKasa.KASAADI = txt_KasaAdi.Text;
                secilenKasa.ACIKLAMA = txt_Aciklama.Text;
                secilenKasa.EDITDATE = DateTime.Now;
                secilenKasa.EDITUSER = frm_Anasayfa.userID;

                if (Fonksiyonlar.Mesajlar.OnayMesaj() == DialogResult.Yes)
                {
                    db.SubmitChanges();
                    Fonksiyonlar.Mesajlar.MesajGoster("Guncelleme İşlemi Başarılı");
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
                Fonksiyonlar.TBL_KASALAR secilenKasa = db.TBL_KASALAR.First(t => t.KASAID == KasaID);

                if (Fonksiyonlar.Mesajlar.OnayMesaj() == DialogResult.Yes)
                {
                    db.TBL_KASALAR.DeleteOnSubmit(secilenKasa);
                    db.SubmitChanges();
                    Fonksiyonlar.Mesajlar.MesajGoster("Silme İşlemi Başarılı");
                    Temizle();
                }
            }
            catch (Exception err)
            {
                Fonksiyonlar.Mesajlar.HataMesaj(err);
            }
        }

        void KasaAc()
        {
            try
            {
                Fonksiyonlar.FormYonetici.KasaListesiAc(true);
                KasaID = frm_Anasayfa.AktarilanID;
                Fonksiyonlar.TBL_KASALAR kasa = db.TBL_KASALAR.First(t => t.KASAID == KasaID);
                txt_KasaKodu.Text = kasa.KASAKODU.ToString();
                txt_KasaAdi.Text = kasa.KASAADI.ToString();
                txt_Aciklama.Text = kasa.ACIKLAMA.ToString();
            }
            catch (Exception err)
            {
                Fonksiyonlar.Mesajlar.HataMesaj(err);
                Temizle();
            }
            
        }
        void Temizle()
        {
            foreach (Control control in groupControl1.Controls)
            {
                if (control is DevExpress.XtraEditors.TextEdit || control is DevExpress.XtraEditors.ButtonEdit ||control is DevExpress.XtraEditors.MemoEdit)
                    control.Text = "";
            }
            txt_KasaKodu.Text = KasaKodNumarasi();

            btn_Guncelle.Enabled = false;
            btn_Sil.Enabled = false;
            KasaID = -1;
            frm_Anasayfa.AktarilanID = -1;
        }

        private void Txt_KasaKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            KasaAc();
            if(KasaID > -1)
            {
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
    }
}
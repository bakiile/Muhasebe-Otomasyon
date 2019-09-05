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
using System.IO;

namespace Otomasyon.StokModul
{
    public partial class frm_StokKarti : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.StokDatabaseDataContext db = new Fonksiyonlar.StokDatabaseDataContext();
        OpenFileDialog Dosya = new OpenFileDialog();
        bool guncelleme = false;
        bool resimSecildimi = false;
        int StokID = -1;
        int GrupID = -1;
        public frm_StokKarti()
        {
            InitializeComponent();
        }

        private void Frm_StokKarti_Load(object sender, EventArgs e)
        {
            txt_StokKodu.Text = StokKodNumarasi();
        }

        private void Txt_StokKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            Temizle();
            Fonksiyonlar.FormYonetici.StokListesiAc(true);
            StokID = frm_Anasayfa.AktarilanID;

            if(StokID > -1)
                StokGetir(frm_Anasayfa.AktarilanID);


        }

        private void Btn_ResimSec_Click(object sender, EventArgs e)
        {
            ResimSec();
        }

        private void Txt_GrupKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            Fonksiyonlar.FormYonetici.StokGrupListesiAc(true);
            GrupID = frm_Anasayfa.AktarilanID;

            if (GrupID > -1)
                GrupGetir(GrupID);
        }
        string StokKodNumarasi()
        {
            try
            {
                int KodNum = int.Parse((from t in db.TBL_STOKLAR
                                        orderby t.STOKID descending
                                        select t).First().STOKKODU) + 1;
                string Numara = KodNum.ToString().PadLeft(7, '0');
                return Numara;
            }
            catch (Exception err)
            {
                Fonksiyonlar.Mesajlar.HataMesaj(err);
                return "0000001";
            }
            
        }

        void StokGetir(int StokID)
        {
            try
            {
                Fonksiyonlar.TBL_STOKLAR secilenStok = (from t in db.TBL_STOKLAR where t.STOKID == StokID select t).First();
                txt_StokAdi.Text = secilenStok.STOKADI.ToString();
                txt_StokKodu.Text = secilenStok.STOKKODU.ToString();
                txt_StokBarkod.Text = secilenStok.STOKBARKOD.ToString();
                GrupGetir(Convert.ToInt32(secilenStok.STOKGRUPID));
                txt_AlisFiyat.Text = secilenStok.STOKALISFIYAT.ToString();
                txt_SatisFiyat.Text = secilenStok.STOKSATISFIYAT.ToString();
                txt_KDV.Text = secilenStok.STOKKDV.ToString();
                txt_Birim.Text = secilenStok.STOKBIRIM.ToString();
                if(secilenStok.STOKRESIM != null)   pb_Resim.Image = ResimGetirme(secilenStok.STOKRESIM.ToArray());

                GrupID = Convert.ToInt32(secilenStok.STOKGRUPID);

                guncelleme = true;
                btn_Guncelle.Enabled = true;
                btn_Sil.Enabled = true;
            }
            catch (Exception err)
            {
                Fonksiyonlar.Mesajlar.HataMesaj(err);
                
            }
        }

        void Kaydet()
        {
            try
            {
                Fonksiyonlar.TBL_STOKLAR yeniStok = new Fonksiyonlar.TBL_STOKLAR();
                yeniStok.STOKADI = txt_StokAdi.Text;
                yeniStok.STOKKODU = txt_StokKodu.Text;
                yeniStok.STOKBARKOD = txt_StokBarkod.Text;
                if(resimSecildimi)  yeniStok.STOKRESIM = new System.Data.Linq.Binary(ResimYukleme(pb_Resim.Image));
                yeniStok.STOKGRUPID = GrupID;
                yeniStok.STOKALISFIYAT = decimal.Parse(txt_AlisFiyat.Text);
                yeniStok.STOKSATISFIYAT = decimal.Parse(txt_SatisFiyat.Text);
                yeniStok.STOKKDV = decimal.Parse(txt_KDV.Text);
                yeniStok.STOKBIRIM = txt_Birim.Text;
                yeniStok.STOKSAVEDATE = DateTime.Now;
                yeniStok.STOKSAVEUSER = frm_Anasayfa.userID;

                if(Fonksiyonlar.Mesajlar.OnayMesaj() == DialogResult.Yes)
                {
                    db.TBL_STOKLAR.InsertOnSubmit(yeniStok);
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
                Fonksiyonlar.TBL_STOKLAR secilenStok = db.TBL_STOKLAR.First(t => t.STOKID == StokID);
                secilenStok.STOKADI = txt_StokAdi.Text;
                secilenStok.STOKKODU = txt_StokKodu.Text;
                secilenStok.STOKBARKOD = txt_StokBarkod.Text;
                if (resimSecildimi) secilenStok.STOKRESIM = new System.Data.Linq.Binary(ResimYukleme(pb_Resim.Image));
                secilenStok.STOKGRUPID = GrupID;
                secilenStok.STOKALISFIYAT = decimal.Parse(txt_AlisFiyat.Text);
                secilenStok.STOKSATISFIYAT = decimal.Parse(txt_SatisFiyat.Text);
                secilenStok.STOKKDV = decimal.Parse(txt_KDV.Text);
                secilenStok.STOKBIRIM = txt_Birim.Text;
                secilenStok.STOKSAVEDATE = DateTime.Now;
                secilenStok.STOKSAVEUSER = frm_Anasayfa.userID;

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
                Fonksiyonlar.TBL_STOKLAR secilenStok = db.TBL_STOKLAR.First(t => t.STOKID == StokID);
                db.TBL_STOKLAR.DeleteOnSubmit(secilenStok);

                if (Fonksiyonlar.Mesajlar.OnayMesaj() == DialogResult.Yes)
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

        void Temizle()
        {
            txt_StokKodu.Text = "";
            txt_StokAdi.Text = "";
            txt_StokBarkod.Text = "";
            txt_GrupKodu.Text = "";
            txt_GrupAdi.Text = "";
            txt_AlisFiyat.Text = "";
            txt_SatisFiyat.Text = "";
            txt_KDV.Text = "";
            txt_Birim.SelectedIndex = 0;
            pb_Resim.Image = null;

            guncelleme = false;
            frm_Anasayfa.AktarilanID = -1;
            btn_Guncelle.Enabled = false;
            btn_Sil.Enabled = false;
            resimSecildimi = false;
        }

        byte[] ResimYukleme(System.Drawing.Image Resim)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                Resim.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }

        void ResimSec()
        {
            Dosya.Filter = "JPG|*.jpg;*.jpeg|PNG|*.png";
            if (Dosya.ShowDialog() == DialogResult.OK)
            {
                pb_Resim.ImageLocation = Dosya.FileName;
                resimSecildimi = true;
            }
        }

        Image ResimGetirme(byte[] ResimArray)
        {
            using (MemoryStream ms = new MemoryStream(ResimArray))
            {
                Image resim = Image.FromStream(ms);
                return resim;
            }
        }

        

        void GrupGetir(int grupID)
        {
            Fonksiyonlar.TBL_GRUPLAR secilenGrup = db.TBL_GRUPLAR.First(t => t.GRUPID == grupID);
            txt_GrupAdi.Text = secilenGrup.GRUPADI.ToString();
            txt_GrupKodu.Text = secilenGrup.GRUPKODU.ToString();
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
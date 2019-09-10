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
    public partial class frm_CariGruplari : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.StokDatabaseDataContext db = new Fonksiyonlar.StokDatabaseDataContext();
        public bool secim = false;
        bool guncelleme = false;
        int secilenID = -1;
        public frm_CariGruplari()
        {
            InitializeComponent();
        }

        private void Frm_CariGruplari_Load(object sender, EventArgs e)
        {
            grupListele();
        }
        private void Btn_Ara_Click(object sender, EventArgs e)
        {
            Ara();
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


        private void GridControl1_DoubleClick(object sender, EventArgs e)
        {
            if (secim == false)
            {
                Sec();
                guncelleme = true;
            }
            else
            {
                secilenID = Convert.ToInt16(gridView1.GetFocusedRowCellValue("CARIGRUPID"));
                frm_Anasayfa.AktarilanID = secilenID;
                this.Close();
            }
        }

        void Kaydet()
        {
            try
            {
                Fonksiyonlar.TBL_CARIGRUPLAR yeniGrup = new Fonksiyonlar.TBL_CARIGRUPLAR();
                yeniGrup.CARIGRUPKODU = txt_GrupKodu.Text;
                yeniGrup.CARIGRUPADI = txt_GrupAdi.Text;
                yeniGrup.CARIGRUPSAVEDATE = DateTime.Now;
                yeniGrup.CARIGRUPSAVEUSER = frm_Anasayfa.userID;

                //Uyarı Mesajı onaylanırsa veritabanına kayıt işlemi gerçekleşecektir.
                if (Fonksiyonlar.Mesajlar.OnayMesaj() == DialogResult.Yes)
                {
                    db.TBL_CARIGRUPLAR.InsertOnSubmit(yeniGrup);
                    db.SubmitChanges();
                    Fonksiyonlar.Mesajlar.MesajGoster("Kayıt Başarılı!");
                }
            }
            catch (Exception err)
            {
                Fonksiyonlar.Mesajlar.HataMesaj(err);
            }

            grupListele();
            Temizle();
        }

        void Guncelle()
        {
            try
            {
                Fonksiyonlar.TBL_CARIGRUPLAR secilenGrup = db.TBL_CARIGRUPLAR.First(t => t.CARIGRUPID == secilenID);
                secilenGrup.CARIGRUPADI = txt_GrupAdi.Text;
                secilenGrup.CARIGRUPKODU = txt_GrupKodu.Text;
                secilenGrup.CARIGRUPEDITDATE = DateTime.Now;
                secilenGrup.CARIGRUPEDITUSER = frm_Anasayfa.userID;

                if (Fonksiyonlar.Mesajlar.OnayMesaj() == DialogResult.Yes)
                {
                    db.SubmitChanges();
                    Fonksiyonlar.Mesajlar.MesajGoster("Güncelleme işlemi başarılı.");
                }


            }
            catch (Exception err)
            {
                Fonksiyonlar.Mesajlar.HataMesaj(err);
            }

            grupListele();
            Temizle();
        }

        void Sil()
        {
            try
            {
                if (guncelleme == true)
                {
                    Fonksiyonlar.TBL_CARIGRUPLAR secilenGrup = db.TBL_CARIGRUPLAR.First(t => t.CARIGRUPID == secilenID);
                    db.TBL_CARIGRUPLAR.DeleteOnSubmit(secilenGrup);

                    if (Fonksiyonlar.Mesajlar.OnayMesaj() == DialogResult.Yes)
                    {
                        db.SubmitChanges();
                        Fonksiyonlar.Mesajlar.MesajGoster("Silme işlemi başarılı.");
                    }
                }
            }
            catch (Exception err)
            {
                Fonksiyonlar.Mesajlar.HataMesaj(err);
            }

            grupListele();
            Temizle();
        }

        void Ara()
        {
            var sonuc = from t in db.TBL_CARIGRUPLAR
                        where t.CARIGRUPADI.Contains(txt_GrupAdi.Text) && t.CARIGRUPKODU.Contains(txt_GrupKodu.Text)
                        select t;
            gridControl1.DataSource = sonuc;
        }

        void Sec()
        {
            secilenID = Convert.ToInt16(gridView1.GetFocusedRowCellValue("CARIGRUPID"));
            string grupAdi = gridView1.GetFocusedRowCellValue("CARIGRUPADI").ToString();
            string grupKodu = gridView1.GetFocusedRowCellValue("CARIGRUPKODU").ToString();
            txt_GrupAdi.Text = grupAdi;
            txt_GrupKodu.Text = grupKodu;
            btn_Guncelle.Enabled = true;
            btn_Sil.Enabled = true;
        }

        void Temizle()
        {
            txt_GrupAdi.Text = "";
            txt_GrupKodu.Text = "";
            guncelleme = false;
            secilenID = -1;
            btn_Guncelle.Enabled = false;
            btn_Sil.Enabled = false;
        }

        void grupListele()
        {
            var liste = from t in db.TBL_CARIGRUPLAR select t;
            gridControl1.DataSource = liste;
        }

        
    }
}
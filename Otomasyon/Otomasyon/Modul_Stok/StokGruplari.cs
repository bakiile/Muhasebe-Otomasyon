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

namespace Otomasyon.StokModul
{
    public partial class frm_StokGruplari : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.StokDatabaseDataContext db = new Fonksiyonlar.StokDatabaseDataContext();
        public bool secim = false;
        bool guncelleme = false;
        int secilenID = -1;
        public frm_StokGruplari()
        {
            InitializeComponent();
        }
        private void Frm_StokGruplari_Load(object sender, EventArgs e)
        {
            grupListele();
        }

        private void Btn_Cikis_Click(object sender, EventArgs e)
        {
            this.Close();
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

        void Kaydet()
        {
            try
            {
                Fonksiyonlar.TBL_GRUPLAR yeniGrup = new Fonksiyonlar.TBL_GRUPLAR();
                yeniGrup.GRUPKODU = txt_GrupKodu.Text;
                yeniGrup.GRUPADI = txt_GrupAdi.Text;
                yeniGrup.GRUPSAVEDATE = DateTime.Now;
                yeniGrup.GRUPSAVEUSER = frm_Anasayfa.userID;

                //Uyarı Mesajı onaylanırsa veritabanına kayıt işlemi gerçekleşecektir.
                if (Fonksiyonlar.Mesajlar.OnayMesaj() == DialogResult.Yes)
                {
                    db.TBL_GRUPLAR.InsertOnSubmit(yeniGrup);
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
                Fonksiyonlar.TBL_GRUPLAR secilenGrup = db.TBL_GRUPLAR.First(t => t.GRUPID == secilenID);
                secilenGrup.GRUPADI = txt_GrupAdi.Text;
                secilenGrup.GRUPKODU = txt_GrupKodu.Text;
                secilenGrup.GRUPEDITDATE = DateTime.Now;
                secilenGrup.GRUPEDITUSER = frm_Anasayfa.userID;

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
                    Fonksiyonlar.TBL_GRUPLAR secilenGrup = db.TBL_GRUPLAR.First(t => t.GRUPID == secilenID);
                    db.TBL_GRUPLAR.DeleteOnSubmit(secilenGrup);

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

        private void Btn_Ara_Click(object sender, EventArgs e)
        {
            Ara();
        }
        private void GridControl1_DoubleClick(object sender, EventArgs e)
        {
            if(secim == false)
            {
                Sec();
                guncelleme = true;
            }
            else
            {
                secilenID = Convert.ToInt16(gridView1.GetFocusedRowCellValue("GRUPID"));
                frm_Anasayfa.AktarilanID = secilenID;
                this.Close();
            }
        }

        void grupListele()
        {
            var liste = from t in db.TBL_GRUPLAR select t;
            gridControl1.DataSource = liste;
        }

        void Ara()
        {
            var sonuc = from t in db.TBL_GRUPLAR
                        where t.GRUPADI.Contains(txt_GrupAdi.Text) && t.GRUPKODU.Contains(txt_GrupKodu.Text)
                        select t;
            gridControl1.DataSource = sonuc;
        }

        void Sec()
        {
            secilenID = Convert.ToInt16(gridView1.GetFocusedRowCellValue("GRUPID"));
            string grupAdi = gridView1.GetFocusedRowCellValue("GRUPADI").ToString();
            string grupKodu = gridView1.GetFocusedRowCellValue("GRUPKODU").ToString();
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

       
    }
}
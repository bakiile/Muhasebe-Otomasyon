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

        private void Btn_Sil_Click(object sender, EventArgs e)
        {

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
                if (Fonksiyonlar.Mesajlar.Kaydedilsinmi() == DialogResult.Yes)
                {
                    db.TBL_GRUPLAR.InsertOnSubmit(yeniGrup);
                    db.SubmitChanges();
                    Fonksiyonlar.Mesajlar.MesajGoster("Kayıt Başarılı!");
                    Temizle();
                    grupListele();
                }
            }
            catch (Exception err)
            {
                Fonksiyonlar.Mesajlar.HataMesaj(err);
            }
            

        }

        void Guncelle()
        {

        }

        void Sil()
        {

        }

        private void Btn_Ara_Click(object sender, EventArgs e)
        {
            Ara();
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

        void Temizle()
        {
            txt_GrupAdi.Text = "";
            txt_GrupKodu.Text = "";
        }

       
    }
}
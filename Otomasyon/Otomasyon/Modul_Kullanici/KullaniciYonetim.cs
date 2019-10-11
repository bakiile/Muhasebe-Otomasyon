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

namespace Otomasyon.Modul_Kullanici
{
    public partial class frm_KullaniciYonetim : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.StokDatabaseDataContext db = new Fonksiyonlar.StokDatabaseDataContext();
        Fonksiyonlar.FormYonetici formRouter = new Fonksiyonlar.FormYonetici();
        int secimID = -1;
        public frm_KullaniciYonetim()
        {
            InitializeComponent();
            this.Shown += Frm_KullaniciYonetim_Shown;
        }
        void Listele()
        {
            var liste = from t in db.TBL_KULLANICILAR
                        select t;
            gridControl1.DataSource = liste;
        }
        private void Frm_KullaniciYonetim_Shown(object sender, EventArgs e)
        {
            Listele();
        }

        private void Btn_Kaydet_Click(object sender, EventArgs e)
        {
            formRouter.KullaniciPaneliAc(false,secimID);
            Listele();
        }

        private void Btn_Guncelle_Click(object sender, EventArgs e)
        {
            formRouter.KullaniciPaneliAc(true, secimID);
            Listele();
        }

        private void Btn_Sil_Click(object sender, EventArgs e)
        {
            try
            {
                if (Fonksiyonlar.Mesajlar.OnayMesaj() == DialogResult.Yes)
                {
                    db.TBL_KULLANICILAR.DeleteOnSubmit(db.TBL_KULLANICILAR.First(t => t.ID == secimID));
                    db.SubmitChanges();
                }

            }
            catch (Exception err)
            {
                Fonksiyonlar.Mesajlar.HataMesaj(err);
            }
        }

        private void GridView1_Click(object sender, EventArgs e)
        {
            secimID = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
        }
    }
}
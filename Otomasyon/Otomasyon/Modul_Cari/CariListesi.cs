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
    public partial class frm_CariListesi : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.StokDatabaseDataContext db = new Fonksiyonlar.StokDatabaseDataContext();
        public bool secim = false;
        int cariID = -1;
        public frm_CariListesi()
        {
            InitializeComponent();
        }

        private void CariListesi_Load(object sender, EventArgs e)
        {
            CariListele();
        }

        private void Btn_Ara_Click(object sender, EventArgs e)
        {
            Ara();
        }

        private void GridView1_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            if (secim == false)
            {
                Fonksiyonlar.TBL_CARILER secilenCari = db.TBL_CARILER.First(t => t.CARIID == cariID);
                txt_CariKodu.Text = secilenCari.CARIKODU.ToString();
                txt_CariAdi.Text = secilenCari.CARIADI.ToString();
                txt_VergiNo.Text = secilenCari.VERGINO.ToString();
            }
            else
            {
                frm_Anasayfa.AktarilanID = cariID;
                this.Close();
            }
        }

        void CariListele()
        {
            var liste = from t in db.TBL_CARILER
                        select t;
            gridControl1.DataSource = liste;
        }

        void Ara()
        {
            var liste = from t in db.TBL_CARILER
                        where t.CARIKODU.Contains(txt_CariKodu.Text) && t.CARIADI.Contains(txt_CariAdi.Text) && t.VERGINO.Contains(txt_VergiNo.Text)
                        select t;
            gridControl1.DataSource = liste;
        }

        void Sec()
        {
            cariID = int.Parse(gridView1.GetFocusedRowCellValue("CARIID").ToString());
            
        }
    }
}
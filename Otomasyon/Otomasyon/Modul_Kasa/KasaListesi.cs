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
    public partial class frm_KasaListesi : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.StokDatabaseDataContext db = new Fonksiyonlar.StokDatabaseDataContext();
        public bool Secim = false;
        public frm_KasaListesi()
        {
            InitializeComponent();
        }

        private void Frm_KasaListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Btn_Ara_Click(object sender, EventArgs e)
        {
            Ara();
        }
        void Listele()
        {
            var liste = from t in db.VW_KASALISTESI
                        select t;
            gridControl1.DataSource = liste;
        }

        void Ara()
        {
            var liste = from t in db.TBL_KASALAR
                        where t.KASAKODU.Contains(txt_KasaKodu.Text) && t.KASAADI.Contains(txt_KasaAdi.Text)
                        select t;
            gridControl1.DataSource = liste;
        }

        private void GridView1_DoubleClick(object sender, EventArgs e)
        {
            Sec();
        }

        void Sec()
        {
            int secilenID = Convert.ToInt32(gridView1.GetFocusedRowCellValue("KASAID"));
            if (Secim == false)
            {
                Fonksiyonlar.TBL_KASALAR secilenKasa = db.TBL_KASALAR.First(t => t.KASAID == secilenID);
                txt_KasaKodu.Text = secilenKasa.KASAKODU.ToString();
                txt_KasaAdi.Text = secilenKasa.KASAADI.ToString();
            }
            else
            {
                frm_Anasayfa.AktarilanID = secilenID;
                this.Close();
            }
        }
    }
}
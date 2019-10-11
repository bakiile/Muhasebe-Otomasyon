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

namespace Otomasyon.Modul_Fatura
{
    public partial class frm_FaturaListesi : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.StokDatabaseDataContext db = new Fonksiyonlar.StokDatabaseDataContext();
        Fonksiyonlar.FormYonetici formRouter = new Fonksiyonlar.FormYonetici();
        bool Secim = false;
        public frm_FaturaListesi(bool secim)
        {
            InitializeComponent();
            Secim = secim;
        }
        
        void Listele()
        {
            var liste = from t in db.TBL_FATURALAR
                        where t.FATURATURU.Contains(txt_FaturaTuru.Text) && t.FATURANO.Contains(txt_FaturaNo.Text)
                        select t;
            gridControl1.DataSource = liste;
        }

        private void Frm_FaturaListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Txt_FaturaTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            Listele();
        }

        private void Btn_Ara_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void GridView1_DoubleClick(object sender, EventArgs e)
        {
            int ID = int.Parse(gridView1.GetFocusedRowCellValue("FATURAID").ToString());
            if (ID > -1)
            {
                formRouter.SatisFaturasiAc(true, ID, false);
            }
        }

        private void Cms_Yenile_Click(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
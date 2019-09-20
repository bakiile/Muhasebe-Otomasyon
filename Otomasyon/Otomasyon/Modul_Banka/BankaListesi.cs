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
    public partial class frm_BankaListesi : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.StokDatabaseDataContext db = new Fonksiyonlar.StokDatabaseDataContext();
        public bool secim = false;
        int secimID = -1;

        public frm_BankaListesi()
        {
            InitializeComponent();
        }

        private void Btn_Ara_Click(object sender, EventArgs e)
        {

        }

        void Listele()
        {
            var liste = from t in db.TBL_BANKALAR
                        select t;
            gridControl1.DataSource = liste;
        }

        private void Frm_BankaListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void GridView1_DoubleClick(object sender, EventArgs e)
        {
            if (secim)
            {
                Sec();
                this.Close();
            }
        }

        void Sec()
        {
            try
            {
                secimID = Convert.ToInt32(gridView1.GetFocusedRowCellValue("BANKAID"));
                frm_Anasayfa.AktarilanID = secimID;
            }
            catch (Exception err)
            {
                Fonksiyonlar.Mesajlar.HataMesaj(err);
            }
        }
    }
}
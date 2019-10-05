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

namespace Otomasyon.Modul_Cek
{
    public partial class frm_CekListesi : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.StokDatabaseDataContext db = new Fonksiyonlar.StokDatabaseDataContext();
        public bool secim = false;
        public frm_CekListesi()
        {
            InitializeComponent();
        }

        private void CekListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }

        void Listele()
        {
            var liste = from t in db.TBL_CEKLER
                        select t;
            gridControl1.DataSource = liste;
        }

        void Ara()
        {
            var liste = from t in db.TBL_CEKLER
                        where t.CEKNO.Contains(txt_CekNo.Text) && t.TIP.Contains(txt_CekTuru.SelectedItem.ToString()) && t.BANKA.Contains(txt_Banka.Text)
                        select t;
            gridControl1.DataSource = liste;
        }
        private void Btn_Ara_Click(object sender, EventArgs e)
        {
            Ara();
        }

        private void GridView1_DoubleClick(object sender, EventArgs e)
        {
            if (secim)
                Sec();
        }
        
        void Sec()
        {
            try
            {
                int secilenID = int.Parse(gridView1.GetFocusedRowCellValue("CEKID").ToString());
                if(secilenID > -1)
                    frm_Anasayfa.AktarilanID = secilenID;
                this.Close();
            }
            catch (Exception err)
            {
                Fonksiyonlar.Mesajlar.HataMesaj(err);
            }
        }
    }
}
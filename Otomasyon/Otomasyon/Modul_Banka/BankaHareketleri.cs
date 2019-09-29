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

namespace Otomasyon.Modul_Banka
{
    public partial class frm_BankaHareketleri : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.StokDatabaseDataContext db = new Fonksiyonlar.StokDatabaseDataContext();
        Fonksiyonlar.FormYonetici formRouter = new Fonksiyonlar.FormYonetici();

        int IslemID = -1;
        int BankaID = -1;
        string evrakTuru;
        public frm_BankaHareketleri()
        {
            InitializeComponent();
        }

        void Listele()
        {
            var liste = from t in db.VW_BANKAHAREKETLERI
                        where t.BANKAID == BankaID
                        select t;
            gridControl1.DataSource = liste;
        }

        public void BankaAc(int ID)
        {
            try
            {
                BankaID = ID;
                Fonksiyonlar.VW_BANKALISTESI banka = db.VW_BANKALISTESI.First(t => t.BANKAID == BankaID);
                txt_HesapAdi.Text = banka.HESAPADI;
                txt_HesapNo.Text = banka.HESAPNO;
                txt_Giris.Text = banka.GIRIS.Value.ToString();
                txt_Cikis.Text = banka.CIKIS.Value.ToString();
                txt_Bakiye.Text = banka.BAKIYE.Value.ToString();
                Listele();
            }
            catch (Exception err)
            {
                Fonksiyonlar.Mesajlar.HataMesaj(err);
            }
        }

        private void Txt_HesapAdi_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            formRouter.BankaListesiAc(true);
            int id = frm_Anasayfa.AktarilanID;
            if (id > -1)
                BankaAc(id);

            frm_Anasayfa.AktarilanID = -1;
        }

        void Sec()
        {
            try
            {
                IslemID = int.Parse(gridView1.GetFocusedRowCellValue(ID).ToString());
                evrakTuru = gridView1.GetFocusedRowCellValue("EVRAKTURU").ToString();
            }
            catch (Exception)
            {
                IslemID = -1;
                evrakTuru = "";
            }
        }
        private void ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            Sec();
            if (IslemID > -1)
            {
                if (evrakTuru == "Banka İşlem")
                {
                    menu_BankaIslemDuzenle.Enabled = true;
                    menu_ParaTransferDuzenle.Enabled = false;
                }
                else if (evrakTuru == "Banka EFT" || evrakTuru == "Banka Havale")
                {
                    menu_BankaIslemDuzenle.Enabled = false;
                    menu_ParaTransferDuzenle.Enabled = true;
                }
            }
            
        }

        private void Menu_BankaIslemDuzenle_Click(object sender, EventArgs e)
        {
            formRouter.BankaIslemAc(true, IslemID);
            Listele();
        }

        private void Menu_ParaTransferDuzenle_Click(object sender, EventArgs e)
        {
            formRouter.BankaParaTransferAc(true, IslemID);
            Listele();
        }
    }
}
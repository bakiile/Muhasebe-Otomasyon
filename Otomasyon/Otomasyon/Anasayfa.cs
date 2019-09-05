using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Otomasyon
{
    public partial class frm_Anasayfa : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public static int userID = -1;
        public static int AktarilanID = -1;
        bool secim = false;
        public frm_Anasayfa()
        {
            InitializeComponent();
        }

        private void Btn_StokListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Fonksiyonlar.FormYonetici.StokListesiAc(secim);
        }

        private void Btn_StokGruplari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Fonksiyonlar.FormYonetici.StokGrupListesiAc(secim);
        }

        private void Btn_StokKarti_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Fonksiyonlar.FormYonetici.StokKartiAc();
        }

        private void Btn_CariGruplari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Fonksiyonlar.FormYonetici.CariGrupListesiAc(secim);
        }
    }
}

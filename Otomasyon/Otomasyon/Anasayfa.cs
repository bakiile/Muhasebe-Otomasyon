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
        Fonksiyonlar.FormYonetici formRouter = new Fonksiyonlar.FormYonetici();
        public static int userID = -1;
        public static int AktarilanID = -1;
        bool secim = false;
        public frm_Anasayfa()
        {
            InitializeComponent();
        }

        private void Btn_StokListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formRouter.StokListesiAc(secim);
        }

        private void Btn_StokGruplari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formRouter.StokGrupListesiAc(secim);
        }

        private void Btn_StokKarti_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formRouter.StokKartiAc();
        }

        private void Btn_CariGruplari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formRouter.CariGrupListesiAc(secim);
        }

        private void Btn_CariKarti_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formRouter.CariKartiAc();
        }

        private void Btn_CariListele_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formRouter.CariListesiAc(secim);
        }

        private void Btn_BankaKarti_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formRouter.BankaKartiAc();
        }

        private void Btn_BankaListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formRouter.BankaListesiAc(secim);
        }

        private void Btn_KasaListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formRouter.KasaListesiAc(secim);
        }

        private void Btn_KasaKarti_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formRouter.KasaKartiAc();
        }

        private void Btn_KasaDevir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formRouter.KasaDevirIslemAc(secim, -1);
        }

        private void Btn_KasaTahsilat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formRouter.KasaTahsilatOdemeAc(secim, -1);
        }

        private void Btn_KasaHareket_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formRouter.KasaHareketleriAc(secim);
        }

        
    }
}

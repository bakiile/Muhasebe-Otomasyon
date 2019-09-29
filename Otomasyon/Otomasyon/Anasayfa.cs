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

        #region Stok Butonlari

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

        private void NavBtn_StokKarti_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            formRouter.StokKartiAc();
        }

        private void NavBtn_StokListesi_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            formRouter.StokListesiAc(secim);
        }

        private void NavBtn_StokGruplari_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            formRouter.StokGrupListesiAc(secim);
        }

        private void NavBtn_StokHareketleri_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

        }

        #endregion

        #region Cari Butonlari
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

        private void NavBtn_CariKarti_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            formRouter.CariKartiAc();
        }

        private void NavBtn_CariGruplari_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            formRouter.CariGrupListesiAc(secim);
        }

        private void NavBtn_CariListesi_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            formRouter.CariListesiAc(secim);
        }

        private void NavBtn_CariHareketleri_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
        }
        #endregion

        #region Banka Butonlari
        private void Btn_BankaKarti_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formRouter.BankaKartiAc();
        }

        private void Btn_BankaListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formRouter.BankaListesiAc(secim);
        }

        private void Btn_BankaIslemi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formRouter.BankaIslemAc(secim, -1);
        }

        private void Btn_ParaTransferi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formRouter.BankaParaTransferAc(secim, -1);
        }

        private void Btn_BankaHareketleri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formRouter.BankaHareketleriAc(secim, -1);
        }

        private void NavBtn_BankaKarti_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            formRouter.BankaKartiAc();
        }

        private void NavBtn_ParaTransferi_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            formRouter.BankaParaTransferAc(secim, -1);
        }

        private void NavBtn_BankaListesi_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            formRouter.BankaListesiAc(secim);
        }

        private void NavBtn_BankaIslemi_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            formRouter.BankaIslemAc(secim, -1);
        }

        private void NavBtn_BankaHareketleri_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            formRouter.BankaHareketleriAc(secim, -1);
        }

        #endregion

        #region Kasa Butonlari
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
        private void NavBtn_KasaKarti_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            formRouter.KasaKartiAc();
        }

        private void NavBtn_KasaListesi_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            formRouter.KasaListesiAc(secim);
        }

        private void NavBtn_KasaDevirIslem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            formRouter.KasaDevirIslemAc(secim, -1);
        }

        private void NavBtn_KasaTahsilatOdeme_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            formRouter.KasaTahsilatOdemeAc(secim, -1);
        }

        private void NavBtn_KasaHareketleri_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            formRouter.KasaHareketleriAc(secim);
        }

        #endregion

    }
}

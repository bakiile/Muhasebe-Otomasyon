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

        private void Btn_CariKarti_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Fonksiyonlar.FormYonetici.CariKartiAc();
        }

        private void Btn_CariListele_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Fonksiyonlar.FormYonetici.CariListesiAc(secim);
        }

        private void Btn_BankaKarti_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Fonksiyonlar.FormYonetici.BankaKartiAc();
        }

        private void Btn_KasaListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Fonksiyonlar.FormYonetici.KasaListesiAc(secim);
        }

        private void Btn_KasaKarti_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Fonksiyonlar.FormYonetici.KasaKartiAc();
        }

        private void Btn_KasaDevir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Fonksiyonlar.FormYonetici.KasaDevirIslemAc();
        }

        private void Btn_KasaTahsilat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Fonksiyonlar.FormYonetici.KasaTahsilatOdemeAc();
        }
    }
}

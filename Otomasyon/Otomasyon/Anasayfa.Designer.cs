namespace Otomasyon
{
    partial class frm_Anasayfa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btn_StokKarti = new DevExpress.XtraBars.BarButtonItem();
            this.btn_StokGruplari = new DevExpress.XtraBars.BarButtonItem();
            this.btn_StokListesi = new DevExpress.XtraBars.BarButtonItem();
            this.btn_StokHareketleri = new DevExpress.XtraBars.BarButtonItem();
            this.btn_CariKarti = new DevExpress.XtraBars.BarButtonItem();
            this.btn_CariGruplari = new DevExpress.XtraBars.BarButtonItem();
            this.btn_CariListele = new DevExpress.XtraBars.BarButtonItem();
            this.btn_CariHareketleri = new DevExpress.XtraBars.BarButtonItem();
            this.btn_BankaKarti = new DevExpress.XtraBars.BarButtonItem();
            this.btn_BankaListesi = new DevExpress.XtraBars.BarButtonItem();
            this.btn_ParaTransferi = new DevExpress.XtraBars.BarButtonItem();
            this.btn_BankaIslemi = new DevExpress.XtraBars.BarButtonItem();
            this.btn_BankaHareketleri = new DevExpress.XtraBars.BarButtonItem();
            this.btn_KasaKarti = new DevExpress.XtraBars.BarButtonItem();
            this.btn_KasaListesi = new DevExpress.XtraBars.BarButtonItem();
            this.btn_KasaDevir = new DevExpress.XtraBars.BarButtonItem();
            this.btn_KasaTahsilat = new DevExpress.XtraBars.BarButtonItem();
            this.btn_SatisFaturasi = new DevExpress.XtraBars.BarButtonItem();
            this.btn_SatisIadeFaturasi = new DevExpress.XtraBars.BarButtonItem();
            this.btn_AlisFaturasi = new DevExpress.XtraBars.BarButtonItem();
            this.btn_AlisIadeFaturasi = new DevExpress.XtraBars.BarButtonItem();
            this.btn_SatisIrsaliye = new DevExpress.XtraBars.BarButtonItem();
            this.btn_AlisIrsaliyesi = new DevExpress.XtraBars.BarButtonItem();
            this.tab_Stok = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.tab_Cari = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btn_Fatura = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.BackColor = System.Drawing.Color.Aqua;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btn_StokKarti,
            this.btn_StokGruplari,
            this.btn_StokListesi,
            this.btn_StokHareketleri,
            this.btn_CariKarti,
            this.btn_CariGruplari,
            this.btn_CariListele,
            this.btn_CariHareketleri,
            this.btn_BankaKarti,
            this.btn_BankaListesi,
            this.btn_ParaTransferi,
            this.btn_BankaIslemi,
            this.btn_BankaHareketleri,
            this.btn_KasaKarti,
            this.btn_KasaListesi,
            this.btn_KasaDevir,
            this.btn_KasaTahsilat,
            this.btn_SatisFaturasi,
            this.btn_SatisIadeFaturasi,
            this.btn_AlisFaturasi,
            this.btn_AlisIadeFaturasi,
            this.btn_SatisIrsaliye,
            this.btn_AlisIrsaliyesi});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 24;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.tab_Stok,
            this.tab_Cari,
            this.ribbonPage1,
            this.ribbonPage2,
            this.btn_Fatura});
            this.ribbonControl1.Size = new System.Drawing.Size(758, 162);
            // 
            // btn_StokKarti
            // 
            this.btn_StokKarti.Caption = "Stok Açılış Kartı";
            this.btn_StokKarti.Id = 1;
            this.btn_StokKarti.ImageOptions.LargeImage = global::Otomasyon.Properties.Resources.Stok_Kartı32x32;
            this.btn_StokKarti.Name = "btn_StokKarti";
            this.btn_StokKarti.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Btn_StokKarti_ItemClick);
            // 
            // btn_StokGruplari
            // 
            this.btn_StokGruplari.Caption = "Stok Grupları";
            this.btn_StokGruplari.Id = 2;
            this.btn_StokGruplari.ImageOptions.LargeImage = global::Otomasyon.Properties.Resources.Stok_Grup32x32;
            this.btn_StokGruplari.Name = "btn_StokGruplari";
            this.btn_StokGruplari.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Btn_StokGruplari_ItemClick);
            // 
            // btn_StokListesi
            // 
            this.btn_StokListesi.Caption = "Stok Listesi";
            this.btn_StokListesi.Id = 3;
            this.btn_StokListesi.ImageOptions.LargeImage = global::Otomasyon.Properties.Resources.Stok_Liste32x32;
            this.btn_StokListesi.Name = "btn_StokListesi";
            this.btn_StokListesi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Btn_StokListesi_ItemClick);
            // 
            // btn_StokHareketleri
            // 
            this.btn_StokHareketleri.Caption = "Stok Hareketleri";
            this.btn_StokHareketleri.Id = 4;
            this.btn_StokHareketleri.ImageOptions.LargeImage = global::Otomasyon.Properties.Resources.Stok_Hareket32x32;
            this.btn_StokHareketleri.Name = "btn_StokHareketleri";
            // 
            // btn_CariKarti
            // 
            this.btn_CariKarti.Caption = "Cari Açılış Kartı";
            this.btn_CariKarti.Id = 5;
            this.btn_CariKarti.ImageOptions.LargeImage = global::Otomasyon.Properties.Resources.Cari_Kart32x32;
            this.btn_CariKarti.Name = "btn_CariKarti";
            this.btn_CariKarti.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Btn_CariKarti_ItemClick);
            // 
            // btn_CariGruplari
            // 
            this.btn_CariGruplari.Caption = "Cari Grupları";
            this.btn_CariGruplari.Id = 6;
            this.btn_CariGruplari.ImageOptions.LargeImage = global::Otomasyon.Properties.Resources.Cari_Grup32x32;
            this.btn_CariGruplari.Name = "btn_CariGruplari";
            this.btn_CariGruplari.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Btn_CariGruplari_ItemClick);
            // 
            // btn_CariListele
            // 
            this.btn_CariListele.Caption = "Cari Listele";
            this.btn_CariListele.Id = 7;
            this.btn_CariListele.ImageOptions.LargeImage = global::Otomasyon.Properties.Resources.Cari_Liste32x32;
            this.btn_CariListele.Name = "btn_CariListele";
            this.btn_CariListele.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Btn_CariListele_ItemClick);
            // 
            // btn_CariHareketleri
            // 
            this.btn_CariHareketleri.Caption = "Cari Hareketleri";
            this.btn_CariHareketleri.Id = 8;
            this.btn_CariHareketleri.ImageOptions.LargeImage = global::Otomasyon.Properties.Resources.Cari_Hareket32x32;
            this.btn_CariHareketleri.Name = "btn_CariHareketleri";
            // 
            // btn_BankaKarti
            // 
            this.btn_BankaKarti.Caption = "Banka Açılış Kartı";
            this.btn_BankaKarti.Id = 9;
            this.btn_BankaKarti.ImageOptions.LargeImage = global::Otomasyon.Properties.Resources.Banka_Kartı32x32;
            this.btn_BankaKarti.Name = "btn_BankaKarti";
            this.btn_BankaKarti.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Btn_BankaKarti_ItemClick);
            // 
            // btn_BankaListesi
            // 
            this.btn_BankaListesi.Caption = "Banka Listesi";
            this.btn_BankaListesi.Id = 10;
            this.btn_BankaListesi.ImageOptions.LargeImage = global::Otomasyon.Properties.Resources.Banka_Liste32x32;
            this.btn_BankaListesi.Name = "btn_BankaListesi";
            // 
            // btn_ParaTransferi
            // 
            this.btn_ParaTransferi.Caption = "Para Transferi";
            this.btn_ParaTransferi.Id = 11;
            this.btn_ParaTransferi.ImageOptions.LargeImage = global::Otomasyon.Properties.Resources.Banka_Havale32x32;
            this.btn_ParaTransferi.Name = "btn_ParaTransferi";
            // 
            // btn_BankaIslemi
            // 
            this.btn_BankaIslemi.Caption = "Banka İşlemi";
            this.btn_BankaIslemi.Id = 12;
            this.btn_BankaIslemi.ImageOptions.LargeImage = global::Otomasyon.Properties.Resources.Banka_Islem32x32;
            this.btn_BankaIslemi.Name = "btn_BankaIslemi";
            // 
            // btn_BankaHareketleri
            // 
            this.btn_BankaHareketleri.Caption = "Banka Hareketleri";
            this.btn_BankaHareketleri.Id = 13;
            this.btn_BankaHareketleri.ImageOptions.LargeImage = global::Otomasyon.Properties.Resources.Banka_Hareket32x32;
            this.btn_BankaHareketleri.Name = "btn_BankaHareketleri";
            // 
            // btn_KasaKarti
            // 
            this.btn_KasaKarti.Caption = "Kasa Açılış Kartı";
            this.btn_KasaKarti.Id = 14;
            this.btn_KasaKarti.ImageOptions.LargeImage = global::Otomasyon.Properties.Resources.Kasa_Acilis_Karti;
            this.btn_KasaKarti.Name = "btn_KasaKarti";
            this.btn_KasaKarti.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Btn_KasaKarti_ItemClick);
            // 
            // btn_KasaListesi
            // 
            this.btn_KasaListesi.Caption = "Kasa Listesi";
            this.btn_KasaListesi.Id = 15;
            this.btn_KasaListesi.ImageOptions.LargeImage = global::Otomasyon.Properties.Resources.Kasa_Liste32x32;
            this.btn_KasaListesi.Name = "btn_KasaListesi";
            this.btn_KasaListesi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Btn_KasaListesi_ItemClick);
            // 
            // btn_KasaDevir
            // 
            this.btn_KasaDevir.Caption = "Kasa Devir / İşlem Kartı";
            this.btn_KasaDevir.Id = 16;
            this.btn_KasaDevir.ImageOptions.LargeImage = global::Otomasyon.Properties.Resources.Kasa_Devir32x32;
            this.btn_KasaDevir.Name = "btn_KasaDevir";
            // 
            // btn_KasaTahsilat
            // 
            this.btn_KasaTahsilat.Caption = "Kasa Tahsilat / Ödeme";
            this.btn_KasaTahsilat.Id = 17;
            this.btn_KasaTahsilat.ImageOptions.Image = global::Otomasyon.Properties.Resources.Kasa_Tahsilat32x321;
            this.btn_KasaTahsilat.ImageOptions.LargeImage = global::Otomasyon.Properties.Resources.Kasa_Odeme32x32;
            this.btn_KasaTahsilat.Name = "btn_KasaTahsilat";
            // 
            // btn_SatisFaturasi
            // 
            this.btn_SatisFaturasi.Caption = "Satış Faturası";
            this.btn_SatisFaturasi.Id = 18;
            this.btn_SatisFaturasi.ImageOptions.LargeImage = global::Otomasyon.Properties.Resources.Satis_Faturasi;
            this.btn_SatisFaturasi.Name = "btn_SatisFaturasi";
            // 
            // btn_SatisIadeFaturasi
            // 
            this.btn_SatisIadeFaturasi.Caption = "Satış İade Faturası";
            this.btn_SatisIadeFaturasi.Id = 19;
            this.btn_SatisIadeFaturasi.ImageOptions.LargeImage = global::Otomasyon.Properties.Resources.Fatura_SatisIade32x32;
            this.btn_SatisIadeFaturasi.Name = "btn_SatisIadeFaturasi";
            // 
            // btn_AlisFaturasi
            // 
            this.btn_AlisFaturasi.Caption = "Alış Faturası";
            this.btn_AlisFaturasi.Id = 20;
            this.btn_AlisFaturasi.ImageOptions.LargeImage = global::Otomasyon.Properties.Resources.Fatura_Alis32x32;
            this.btn_AlisFaturasi.Name = "btn_AlisFaturasi";
            // 
            // btn_AlisIadeFaturasi
            // 
            this.btn_AlisIadeFaturasi.Caption = "Alış İade Faturası";
            this.btn_AlisIadeFaturasi.Id = 21;
            this.btn_AlisIadeFaturasi.ImageOptions.LargeImage = global::Otomasyon.Properties.Resources.Fatura_AlisIade32x32;
            this.btn_AlisIadeFaturasi.Name = "btn_AlisIadeFaturasi";
            // 
            // btn_SatisIrsaliye
            // 
            this.btn_SatisIrsaliye.Caption = "Satış İrsaliyesi";
            this.btn_SatisIrsaliye.Id = 22;
            this.btn_SatisIrsaliye.ImageOptions.LargeImage = global::Otomasyon.Properties.Resources.Fatura_SatisIade32x32;
            this.btn_SatisIrsaliye.Name = "btn_SatisIrsaliye";
            // 
            // btn_AlisIrsaliyesi
            // 
            this.btn_AlisIrsaliyesi.AllowHtmlText = DevExpress.Utils.DefaultBoolean.False;
            this.btn_AlisIrsaliyesi.Caption = "Alış İrsaliyesi";
            this.btn_AlisIrsaliyesi.Id = 23;
            this.btn_AlisIrsaliyesi.ImageOptions.LargeImage = global::Otomasyon.Properties.Resources.Fatura_AlisIade32x32;
            this.btn_AlisIrsaliyesi.Name = "btn_AlisIrsaliyesi";
            // 
            // tab_Stok
            // 
            this.tab_Stok.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.tab_Stok.ImageOptions.Image = global::Otomasyon.Properties.Resources.Stok32x32;
            this.tab_Stok.Name = "tab_Stok";
            this.tab_Stok.Text = "Stok İşlemleri";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_StokKarti);
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_StokGruplari);
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_StokListesi);
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_StokHareketleri);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Stok İşlem Sayfası";
            // 
            // tab_Cari
            // 
            this.tab_Cari.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.tab_Cari.ImageOptions.Image = global::Otomasyon.Properties.Resources.Cari32x32;
            this.tab_Cari.Name = "tab_Cari";
            this.tab_Cari.Text = "Cari İşlemleri";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_CariKarti);
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_CariGruplari);
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_CariListele);
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_CariHareketleri);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Cari İşlem Sayfası";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.ribbonPage1.ImageOptions.Image = global::Otomasyon.Properties.Resources.Banka32x32;
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Banka İşlemleri";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btn_BankaKarti);
            this.ribbonPageGroup3.ItemLinks.Add(this.btn_BankaListesi);
            this.ribbonPageGroup3.ItemLinks.Add(this.btn_ParaTransferi);
            this.ribbonPageGroup3.ItemLinks.Add(this.btn_BankaIslemi);
            this.ribbonPageGroup3.ItemLinks.Add(this.btn_BankaHareketleri);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Banka İşlem Sayfası";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.ribbonPage2.ImageOptions.Image = global::Otomasyon.Properties.Resources.Kasa32x32;
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Kasa İşlemleri";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btn_KasaKarti);
            this.ribbonPageGroup4.ItemLinks.Add(this.btn_KasaListesi);
            this.ribbonPageGroup4.ItemLinks.Add(this.btn_KasaDevir);
            this.ribbonPageGroup4.ItemLinks.Add(this.btn_KasaTahsilat);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Kasa İşlem Sayfası";
            // 
            // btn_Fatura
            // 
            this.btn_Fatura.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup5,
            this.ribbonPageGroup6});
            this.btn_Fatura.ImageOptions.Image = global::Otomasyon.Properties.Resources.Fatura32x32;
            this.btn_Fatura.Name = "btn_Fatura";
            this.btn_Fatura.Text = "Fatura İşlemleri";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btn_SatisFaturasi);
            this.ribbonPageGroup5.ItemLinks.Add(this.btn_SatisIadeFaturasi);
            this.ribbonPageGroup5.ItemLinks.Add(this.btn_AlisFaturasi, true);
            this.ribbonPageGroup5.ItemLinks.Add(this.btn_AlisIadeFaturasi);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Fatura İşlem Sayfası";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.btn_SatisIrsaliye);
            this.ribbonPageGroup6.ItemLinks.Add(this.btn_AlisIrsaliyesi);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "İrsaliye İşlem Faturası";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // frm_Anasayfa
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 414);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "frm_Anasayfa";
            this.Ribbon = this.ribbonControl1;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anasayfa";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage tab_Stok;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btn_StokKarti;
        private DevExpress.XtraBars.BarButtonItem btn_StokGruplari;
        private DevExpress.XtraBars.BarButtonItem btn_StokListesi;
        private DevExpress.XtraBars.BarButtonItem btn_StokHareketleri;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem btn_CariKarti;
        private DevExpress.XtraBars.BarButtonItem btn_CariGruplari;
        private DevExpress.XtraBars.BarButtonItem btn_CariListele;
        private DevExpress.XtraBars.BarButtonItem btn_CariHareketleri;
        private DevExpress.XtraBars.Ribbon.RibbonPage tab_Cari;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btn_BankaKarti;
        private DevExpress.XtraBars.BarButtonItem btn_BankaListesi;
        private DevExpress.XtraBars.BarButtonItem btn_ParaTransferi;
        private DevExpress.XtraBars.BarButtonItem btn_BankaIslemi;
        private DevExpress.XtraBars.BarButtonItem btn_BankaHareketleri;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem btn_KasaKarti;
        private DevExpress.XtraBars.BarButtonItem btn_KasaListesi;
        private DevExpress.XtraBars.BarButtonItem btn_KasaDevir;
        private DevExpress.XtraBars.BarButtonItem btn_KasaTahsilat;
        private DevExpress.XtraBars.Ribbon.RibbonPage btn_Fatura;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem btn_SatisFaturasi;
        private DevExpress.XtraBars.BarButtonItem btn_SatisIadeFaturasi;
        private DevExpress.XtraBars.BarButtonItem btn_AlisFaturasi;
        private DevExpress.XtraBars.BarButtonItem btn_AlisIadeFaturasi;
        private DevExpress.XtraBars.BarButtonItem btn_SatisIrsaliye;
        private DevExpress.XtraBars.BarButtonItem btn_AlisIrsaliyesi;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
    }
}


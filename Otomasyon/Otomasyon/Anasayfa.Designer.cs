﻿namespace Otomasyon
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
            this.tab_Stok = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
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
            this.btn_StokHareketleri});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 5;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.tab_Stok});
            this.ribbonControl1.Size = new System.Drawing.Size(758, 143);
            // 
            // btn_StokKarti
            // 
            this.btn_StokKarti.Caption = "Stok Kartı";
            this.btn_StokKarti.Id = 1;
            this.btn_StokKarti.ImageOptions.LargeImage = global::Otomasyon.Properties.Resources.Stok_Kartı32x32;
            this.btn_StokKarti.Name = "btn_StokKarti";
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
            // tab_Stok
            // 
            this.tab_Stok.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
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
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
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
    }
}


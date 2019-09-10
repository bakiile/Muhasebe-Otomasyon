namespace Otomasyon.StokModul
{
    partial class frm_StokGruplari
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_StokGruplari));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btn_Ara = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_GrupAdi = new DevExpress.XtraEditors.TextEdit();
            this.txt_GrupKodu = new DevExpress.XtraEditors.TextEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GRUPID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GRUPKODU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GRUPADI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.btn_Cikis = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Sil = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Guncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Kaydet = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_GrupAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_GrupKodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btn_Ara);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txt_GrupAdi);
            this.groupControl1.Controls.Add(this.txt_GrupKodu);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(404, 93);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Grup Bilgileri";
            // 
            // btn_Ara
            // 
            this.btn_Ara.ImageOptions.Image = global::Otomasyon.Properties.Resources.Ara32x32;
            this.btn_Ara.Location = new System.Drawing.Point(317, 33);
            this.btn_Ara.Name = "btn_Ara";
            this.btn_Ara.Size = new System.Drawing.Size(75, 40);
            this.btn_Ara.TabIndex = 2;
            this.btn_Ara.Text = "Ara";
            this.btn_Ara.Click += new System.EventHandler(this.Btn_Ara_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(165, 33);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(45, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Grup Adı:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(14, 33);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(54, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Grup Kodu:";
            // 
            // txt_GrupAdi
            // 
            this.txt_GrupAdi.Location = new System.Drawing.Point(165, 52);
            this.txt_GrupAdi.Name = "txt_GrupAdi";
            this.txt_GrupAdi.Size = new System.Drawing.Size(133, 20);
            this.txt_GrupAdi.TabIndex = 1;
            // 
            // txt_GrupKodu
            // 
            this.txt_GrupKodu.Location = new System.Drawing.Point(14, 52);
            this.txt_GrupKodu.Name = "txt_GrupKodu";
            this.txt_GrupKodu.Size = new System.Drawing.Size(133, 20);
            this.txt_GrupKodu.TabIndex = 0;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridControl1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl2.Location = new System.Drawing.Point(0, 93);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(404, 198);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Grup Listesi";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 20);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(400, 176);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.GridControl1_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GRUPID,
            this.GRUPKODU,
            this.GRUPADI});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // GRUPID
            // 
            this.GRUPID.Caption = "GRUPID";
            this.GRUPID.FieldName = "GRUPID";
            this.GRUPID.Name = "GRUPID";
            // 
            // GRUPKODU
            // 
            this.GRUPKODU.Caption = "GRUPKODU";
            this.GRUPKODU.FieldName = "GRUPKODU";
            this.GRUPKODU.Name = "GRUPKODU";
            this.GRUPKODU.OptionsColumn.AllowEdit = false;
            this.GRUPKODU.Visible = true;
            this.GRUPKODU.VisibleIndex = 0;
            // 
            // GRUPADI
            // 
            this.GRUPADI.Caption = "GRUPADI";
            this.GRUPADI.FieldName = "GRUPADI";
            this.GRUPADI.Name = "GRUPADI";
            this.GRUPADI.OptionsColumn.AllowEdit = false;
            this.GRUPADI.Visible = true;
            this.GRUPADI.VisibleIndex = 1;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.btn_Cikis);
            this.groupControl3.Controls.Add(this.btn_Sil);
            this.groupControl3.Controls.Add(this.btn_Guncelle);
            this.groupControl3.Controls.Add(this.btn_Kaydet);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(0, 291);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(404, 69);
            this.groupControl3.TabIndex = 2;
            this.groupControl3.Text = "İşlemler";
            // 
            // btn_Cikis
            // 
            this.btn_Cikis.ImageOptions.Image = global::Otomasyon.Properties.Resources.Kapat24x24;
            this.btn_Cikis.Location = new System.Drawing.Point(305, 24);
            this.btn_Cikis.Name = "btn_Cikis";
            this.btn_Cikis.Size = new System.Drawing.Size(94, 40);
            this.btn_Cikis.TabIndex = 2;
            this.btn_Cikis.Text = "Çıkış";
            this.btn_Cikis.Click += new System.EventHandler(this.Btn_Cikis_Click);
            // 
            // btn_Sil
            // 
            this.btn_Sil.Enabled = false;
            this.btn_Sil.ImageOptions.Image = global::Otomasyon.Properties.Resources.Sil24x24;
            this.btn_Sil.Location = new System.Drawing.Point(205, 24);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(94, 40);
            this.btn_Sil.TabIndex = 1;
            this.btn_Sil.Text = "Sil";
            this.btn_Sil.Click += new System.EventHandler(this.Btn_Sil_Click);
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.Enabled = false;
            this.btn_Guncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Guncelle.ImageOptions.Image")));
            this.btn_Guncelle.Location = new System.Drawing.Point(105, 24);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(94, 40);
            this.btn_Guncelle.TabIndex = 0;
            this.btn_Guncelle.Text = "Güncelle";
            this.btn_Guncelle.Click += new System.EventHandler(this.Btn_Guncelle_Click);
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.ImageOptions.Image = global::Otomasyon.Properties.Resources.Kaydet24x24;
            this.btn_Kaydet.Location = new System.Drawing.Point(5, 24);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(94, 40);
            this.btn_Kaydet.TabIndex = 0;
            this.btn_Kaydet.Text = "Kaydet";
            this.btn_Kaydet.Click += new System.EventHandler(this.Btn_Kaydet_Click);
            // 
            // frm_StokGruplari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 360);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_StokGruplari";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok Grupları";
            this.Load += new System.EventHandler(this.Frm_StokGruplari_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_GrupAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_GrupKodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txt_GrupKodu;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.SimpleButton btn_Ara;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txt_GrupAdi;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn GRUPID;
        private DevExpress.XtraGrid.Columns.GridColumn GRUPKODU;
        private DevExpress.XtraGrid.Columns.GridColumn GRUPADI;
        private DevExpress.XtraEditors.SimpleButton btn_Cikis;
        private DevExpress.XtraEditors.SimpleButton btn_Sil;
        private DevExpress.XtraEditors.SimpleButton btn_Kaydet;
        private DevExpress.XtraEditors.SimpleButton btn_Guncelle;
    }
}
namespace Otomasyon.Modul_Kullanici
{
    partial class frm_KullaniciYonetim
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Sil = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Guncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Kaydet = new DevExpress.XtraEditors.SimpleButton();
            this.AKTIF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KODU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KULLANICIADI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ISIM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SOYISIM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AKTIFF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KOD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Sil);
            this.panel1.Controls.Add(this.btn_Guncelle);
            this.panel1.Controls.Add(this.btn_Kaydet);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(588, 30);
            this.panel1.TabIndex = 0;
            // 
            // btn_Sil
            // 
            this.btn_Sil.Location = new System.Drawing.Point(397, 4);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(188, 23);
            this.btn_Sil.TabIndex = 0;
            this.btn_Sil.Text = "Seçili Kullanıcıyı Sil";
            this.btn_Sil.Click += new System.EventHandler(this.Btn_Sil_Click);
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.Location = new System.Drawing.Point(200, 4);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(188, 23);
            this.btn_Guncelle.TabIndex = 0;
            this.btn_Guncelle.Text = "Seçili Kullanıcıyı Güncelle";
            this.btn_Guncelle.Click += new System.EventHandler(this.Btn_Guncelle_Click);
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.Location = new System.Drawing.Point(3, 3);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(188, 23);
            this.btn_Kaydet.TabIndex = 0;
            this.btn_Kaydet.Text = "Yeni Kullanıcı Ekle";
            this.btn_Kaydet.Click += new System.EventHandler(this.Btn_Kaydet_Click);
            // 
            // AKTIF
            // 
            this.AKTIF.Caption = "Durum";
            this.AKTIF.FieldName = "AKTIF";
            this.AKTIF.Name = "AKTIF";
            this.AKTIF.OptionsColumn.AllowEdit = false;
            this.AKTIF.OptionsColumn.AllowFocus = false;
            this.AKTIF.OptionsColumn.FixedWidth = true;
            this.AKTIF.OptionsColumn.ReadOnly = true;
            this.AKTIF.Visible = true;
            this.AKTIF.VisibleIndex = 4;
            this.AKTIF.Width = 21;
            // 
            // KODU
            // 
            this.KODU.Caption = "Kullanıcı Kodu";
            this.KODU.FieldName = "KODU";
            this.KODU.Name = "KODU";
            this.KODU.OptionsColumn.AllowEdit = false;
            this.KODU.OptionsColumn.AllowFocus = false;
            this.KODU.OptionsColumn.FixedWidth = true;
            this.KODU.OptionsColumn.ReadOnly = true;
            this.KODU.Visible = true;
            this.KODU.VisibleIndex = 5;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 48);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(588, 222);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.KULLANICIADI,
            this.ISIM,
            this.SOYISIM,
            this.AKTIFF,
            this.KOD});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.Click += new System.EventHandler(this.GridView1_Click);
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            this.ID.OptionsColumn.AllowEdit = false;
            this.ID.OptionsColumn.AllowFocus = false;
            this.ID.OptionsColumn.FixedWidth = true;
            this.ID.OptionsColumn.ReadOnly = true;
            this.ID.Visible = true;
            this.ID.VisibleIndex = 0;
            // 
            // KULLANICIADI
            // 
            this.KULLANICIADI.Caption = "Kullanıcı Adı";
            this.KULLANICIADI.FieldName = "KULLANICIADI";
            this.KULLANICIADI.Name = "KULLANICIADI";
            this.KULLANICIADI.OptionsColumn.AllowEdit = false;
            this.KULLANICIADI.OptionsColumn.AllowFocus = false;
            this.KULLANICIADI.OptionsColumn.FixedWidth = true;
            this.KULLANICIADI.OptionsColumn.ReadOnly = true;
            this.KULLANICIADI.Visible = true;
            this.KULLANICIADI.VisibleIndex = 1;
            // 
            // ISIM
            // 
            this.ISIM.Caption = "İsim";
            this.ISIM.FieldName = "ISIM";
            this.ISIM.Name = "ISIM";
            this.ISIM.OptionsColumn.AllowEdit = false;
            this.ISIM.OptionsColumn.AllowFocus = false;
            this.ISIM.OptionsColumn.FixedWidth = true;
            this.ISIM.OptionsColumn.ReadOnly = true;
            this.ISIM.Visible = true;
            this.ISIM.VisibleIndex = 2;
            // 
            // SOYISIM
            // 
            this.SOYISIM.Caption = "Soyisim";
            this.SOYISIM.FieldName = "SOYISIM";
            this.SOYISIM.Name = "SOYISIM";
            this.SOYISIM.OptionsColumn.AllowEdit = false;
            this.SOYISIM.OptionsColumn.AllowFocus = false;
            this.SOYISIM.OptionsColumn.FixedWidth = true;
            this.SOYISIM.OptionsColumn.ReadOnly = true;
            this.SOYISIM.Visible = true;
            this.SOYISIM.VisibleIndex = 3;
            // 
            // AKTIFF
            // 
            this.AKTIFF.Caption = "Durum";
            this.AKTIFF.FieldName = "AKTIF";
            this.AKTIFF.Name = "AKTIFF";
            this.AKTIFF.OptionsColumn.AllowEdit = false;
            this.AKTIFF.OptionsColumn.AllowFocus = false;
            this.AKTIFF.OptionsColumn.FixedWidth = true;
            this.AKTIFF.OptionsColumn.ReadOnly = true;
            this.AKTIFF.Visible = true;
            this.AKTIFF.VisibleIndex = 4;
            // 
            // KOD
            // 
            this.KOD.Caption = "Kullanıcı Kodu";
            this.KOD.FieldName = "KODU";
            this.KOD.Name = "KOD";
            this.KOD.OptionsColumn.AllowEdit = false;
            this.KOD.OptionsColumn.AllowFocus = false;
            this.KOD.OptionsColumn.FixedWidth = true;
            this.KOD.OptionsColumn.ReadOnly = true;
            this.KOD.Visible = true;
            this.KOD.VisibleIndex = 5;
            // 
            // frm_KullaniciYonetim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 282);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frm_KullaniciYonetim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Yönetim";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btn_Sil;
        private DevExpress.XtraEditors.SimpleButton btn_Guncelle;
        private DevExpress.XtraEditors.SimpleButton btn_Kaydet;
        private DevExpress.XtraGrid.Columns.GridColumn AKTIF;
        private DevExpress.XtraGrid.Columns.GridColumn KODU;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn KULLANICIADI;
        private DevExpress.XtraGrid.Columns.GridColumn ISIM;
        private DevExpress.XtraGrid.Columns.GridColumn SOYISIM;
        private DevExpress.XtraGrid.Columns.GridColumn AKTIFF;
        private DevExpress.XtraGrid.Columns.GridColumn KOD;
    }
}
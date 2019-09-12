namespace Otomasyon.KasaModul
{
    partial class frm_KasaKarti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_KasaKarti));
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btn_Cikis = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Kaydet = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Sil = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Guncelle = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txt_KasaAdi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Aciklama = new DevExpress.XtraEditors.MemoEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txt_KasaKodu = new DevExpress.XtraEditors.ButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_KasaAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Aciklama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_KasaKodu.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btn_Cikis);
            this.groupControl2.Controls.Add(this.btn_Kaydet);
            this.groupControl2.Controls.Add(this.btn_Sil);
            this.groupControl2.Controls.Add(this.btn_Guncelle);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 197);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(432, 68);
            this.groupControl2.TabIndex = 3;
            this.groupControl2.Text = "İşlemler";
            // 
            // btn_Cikis
            // 
            this.btn_Cikis.ImageOptions.Image = global::Otomasyon.Properties.Resources.Kapat24x24;
            this.btn_Cikis.Location = new System.Drawing.Point(329, 23);
            this.btn_Cikis.Name = "btn_Cikis";
            this.btn_Cikis.Size = new System.Drawing.Size(94, 40);
            this.btn_Cikis.TabIndex = 7;
            this.btn_Cikis.Text = "Çıkış";
            this.btn_Cikis.Click += new System.EventHandler(this.Btn_Cikis_Click);
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.ImageOptions.Image = global::Otomasyon.Properties.Resources.Kaydet24x24;
            this.btn_Kaydet.Location = new System.Drawing.Point(29, 23);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(94, 40);
            this.btn_Kaydet.TabIndex = 4;
            this.btn_Kaydet.Text = "Kaydet";
            this.btn_Kaydet.Click += new System.EventHandler(this.Btn_Kaydet_Click);
            // 
            // btn_Sil
            // 
            this.btn_Sil.Enabled = false;
            this.btn_Sil.ImageOptions.Image = global::Otomasyon.Properties.Resources.Sil24x24;
            this.btn_Sil.Location = new System.Drawing.Point(229, 23);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(94, 40);
            this.btn_Sil.TabIndex = 6;
            this.btn_Sil.Text = "Sil";
            this.btn_Sil.Click += new System.EventHandler(this.Btn_Sil_Click);
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.Enabled = false;
            this.btn_Guncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Guncelle.ImageOptions.Image")));
            this.btn_Guncelle.Location = new System.Drawing.Point(129, 23);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(94, 40);
            this.btn_Guncelle.TabIndex = 5;
            this.btn_Guncelle.Text = "Güncelle";
            this.btn_Guncelle.Click += new System.EventHandler(this.Btn_Guncelle_Click);
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(69, 86);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(48, 13);
            this.labelControl7.TabIndex = 0;
            this.labelControl7.Text = "Açıklama :";
            // 
            // txt_KasaAdi
            // 
            this.txt_KasaAdi.Location = new System.Drawing.Point(125, 57);
            this.txt_KasaAdi.Name = "txt_KasaAdi";
            this.txt_KasaAdi.Size = new System.Drawing.Size(198, 20);
            this.txt_KasaAdi.TabIndex = 1;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(69, 60);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(48, 13);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "Kasa Adı :";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(60, 34);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(57, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Kasa Kodu :";
            // 
            // txt_Aciklama
            // 
            this.txt_Aciklama.Location = new System.Drawing.Point(125, 85);
            this.txt_Aciklama.Name = "txt_Aciklama";
            this.txt_Aciklama.Size = new System.Drawing.Size(198, 83);
            this.txt_Aciklama.TabIndex = 1;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.txt_KasaAdi);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txt_Aciklama);
            this.groupControl1.Controls.Add(this.txt_KasaKodu);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(432, 197);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = " Kasa Bilgileri";
            // 
            // txt_KasaKodu
            // 
            this.txt_KasaKodu.Location = new System.Drawing.Point(125, 31);
            this.txt_KasaKodu.Name = "txt_KasaKodu";
            this.txt_KasaKodu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txt_KasaKodu.Size = new System.Drawing.Size(198, 20);
            this.txt_KasaKodu.TabIndex = 1;
            this.txt_KasaKodu.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.Txt_KasaKodu_ButtonClick);
            // 
            // frm_KasaKarti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 265);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_KasaKarti";
            this.Text = "Kasa Açılış Kartı";
            this.Load += new System.EventHandler(this.Frm_KasaKarti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_KasaAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Aciklama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_KasaKodu.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btn_Cikis;
        private DevExpress.XtraEditors.SimpleButton btn_Kaydet;
        private DevExpress.XtraEditors.SimpleButton btn_Sil;
        private DevExpress.XtraEditors.SimpleButton btn_Guncelle;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txt_KasaAdi;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.MemoEdit txt_Aciklama;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.ButtonEdit txt_KasaKodu;
    }
}
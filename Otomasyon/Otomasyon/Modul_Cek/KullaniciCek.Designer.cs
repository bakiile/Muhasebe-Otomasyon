namespace Otomasyon.Modul_Cek
{
    partial class frm_KullaniciCek
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_KullaniciCek));
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btn_Cikis = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Kaydet = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Sil = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Guncelle = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txt_Tutar = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Banka = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txt_CekNo = new DevExpress.XtraEditors.TextEdit();
            this.txt_Sube = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Aciklama = new DevExpress.XtraEditors.MemoEdit();
            this.txt_VadeTarihi = new DevExpress.XtraEditors.DateEdit();
            this.txt_BelgeNo = new DevExpress.XtraEditors.ButtonEdit();
            this.txt_HesapNo = new DevExpress.XtraEditors.ButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Tutar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Banka.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CekNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Sube.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Aciklama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_VadeTarihi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_VadeTarihi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_BelgeNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_HesapNo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btn_Cikis);
            this.groupControl2.Controls.Add(this.btn_Kaydet);
            this.groupControl2.Controls.Add(this.btn_Sil);
            this.groupControl2.Controls.Add(this.btn_Guncelle);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 299);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(415, 73);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "İşlemler";
            // 
            // btn_Cikis
            // 
            this.btn_Cikis.ImageOptions.Image = global::Otomasyon.Properties.Resources.Kapat24x24;
            this.btn_Cikis.Location = new System.Drawing.Point(309, 23);
            this.btn_Cikis.Name = "btn_Cikis";
            this.btn_Cikis.Size = new System.Drawing.Size(94, 40);
            this.btn_Cikis.TabIndex = 3;
            this.btn_Cikis.Text = "Çıkış";
            this.btn_Cikis.Click += new System.EventHandler(this.Btn_Cikis_Click);
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.ImageOptions.Image = global::Otomasyon.Properties.Resources.Kaydet24x24;
            this.btn_Kaydet.Location = new System.Drawing.Point(9, 23);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(94, 40);
            this.btn_Kaydet.TabIndex = 0;
            this.btn_Kaydet.Text = "Kaydet";
            this.btn_Kaydet.Click += new System.EventHandler(this.Btn_Kaydet_Click);
            // 
            // btn_Sil
            // 
            this.btn_Sil.Enabled = false;
            this.btn_Sil.ImageOptions.Image = global::Otomasyon.Properties.Resources.Sil24x24;
            this.btn_Sil.Location = new System.Drawing.Point(209, 23);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(94, 40);
            this.btn_Sil.TabIndex = 2;
            this.btn_Sil.Text = "Sil";
            this.btn_Sil.Click += new System.EventHandler(this.Btn_Sil_Click);
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.Enabled = false;
            this.btn_Guncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Guncelle.ImageOptions.Image")));
            this.btn_Guncelle.Location = new System.Drawing.Point(109, 23);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(94, 40);
            this.btn_Guncelle.TabIndex = 1;
            this.btn_Guncelle.Text = "Güncelle";
            this.btn_Guncelle.Click += new System.EventHandler(this.Btn_Guncelle_Click);
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(34, 35);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(80, 13);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "Belge Numarası :";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txt_Tutar);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.txt_Banka);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txt_CekNo);
            this.groupControl1.Controls.Add(this.txt_Sube);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.txt_Aciklama);
            this.groupControl1.Controls.Add(this.txt_VadeTarihi);
            this.groupControl1.Controls.Add(this.txt_BelgeNo);
            this.groupControl1.Controls.Add(this.txt_HesapNo);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(415, 299);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Çek Bilgileri";
            // 
            // txt_Tutar
            // 
            this.txt_Tutar.Location = new System.Drawing.Point(120, 188);
            this.txt_Tutar.Name = "txt_Tutar";
            this.txt_Tutar.Properties.Mask.EditMask = "c";
            this.txt_Tutar.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txt_Tutar.Size = new System.Drawing.Size(223, 20);
            this.txt_Tutar.TabIndex = 1;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(65, 217);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(48, 13);
            this.labelControl8.TabIndex = 0;
            this.labelControl8.Text = "Açıklama :";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(80, 191);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(33, 13);
            this.labelControl7.TabIndex = 0;
            this.labelControl7.Text = "Tutar :";
            // 
            // txt_Banka
            // 
            this.txt_Banka.Location = new System.Drawing.Point(120, 136);
            this.txt_Banka.Name = "txt_Banka";
            this.txt_Banka.Size = new System.Drawing.Size(223, 20);
            this.txt_Banka.TabIndex = 1;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(30, 113);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(84, 13);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "Hesap Numarası :";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(77, 139);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(36, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Banka :";
            // 
            // txt_CekNo
            // 
            this.txt_CekNo.Location = new System.Drawing.Point(120, 58);
            this.txt_CekNo.Name = "txt_CekNo";
            this.txt_CekNo.Size = new System.Drawing.Size(223, 20);
            this.txt_CekNo.TabIndex = 1;
            // 
            // txt_Sube
            // 
            this.txt_Sube.Location = new System.Drawing.Point(120, 162);
            this.txt_Sube.Name = "txt_Sube";
            this.txt_Sube.Size = new System.Drawing.Size(223, 20);
            this.txt_Sube.TabIndex = 1;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(83, 165);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(31, 13);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Şube :";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(41, 61);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(72, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Çek Numarası :";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(53, 87);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Vade Tarihi :";
            // 
            // txt_Aciklama
            // 
            this.txt_Aciklama.Location = new System.Drawing.Point(120, 214);
            this.txt_Aciklama.Name = "txt_Aciklama";
            this.txt_Aciklama.Size = new System.Drawing.Size(223, 76);
            this.txt_Aciklama.TabIndex = 1;
            // 
            // txt_VadeTarihi
            // 
            this.txt_VadeTarihi.EditValue = null;
            this.txt_VadeTarihi.Location = new System.Drawing.Point(120, 84);
            this.txt_VadeTarihi.Name = "txt_VadeTarihi";
            this.txt_VadeTarihi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_VadeTarihi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_VadeTarihi.Properties.DisplayFormat.FormatString = "";
            this.txt_VadeTarihi.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txt_VadeTarihi.Properties.EditFormat.FormatString = "";
            this.txt_VadeTarihi.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txt_VadeTarihi.Properties.Mask.EditMask = "";
            this.txt_VadeTarihi.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txt_VadeTarihi.Size = new System.Drawing.Size(223, 20);
            this.txt_VadeTarihi.TabIndex = 1;
            // 
            // txt_BelgeNo
            // 
            this.txt_BelgeNo.Location = new System.Drawing.Point(120, 32);
            this.txt_BelgeNo.Name = "txt_BelgeNo";
            this.txt_BelgeNo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txt_BelgeNo.Size = new System.Drawing.Size(223, 20);
            this.txt_BelgeNo.TabIndex = 1;
            this.txt_BelgeNo.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.Txt_BankaSubesi_ButtonClick);
            // 
            // txt_HesapNo
            // 
            this.txt_HesapNo.Location = new System.Drawing.Point(120, 110);
            this.txt_HesapNo.Name = "txt_HesapNo";
            this.txt_HesapNo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txt_HesapNo.Size = new System.Drawing.Size(223, 20);
            this.txt_HesapNo.TabIndex = 1;
            this.txt_HesapNo.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.Txt_HesapNo_ButtonClick);
            // 
            // frm_KullaniciCek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 372);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_KullaniciCek";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Çek";
            this.Load += new System.EventHandler(this.KullaniciCek_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Tutar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Banka.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CekNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Sube.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Aciklama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_VadeTarihi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_VadeTarihi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_BelgeNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_HesapNo.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btn_Cikis;
        private DevExpress.XtraEditors.SimpleButton btn_Kaydet;
        private DevExpress.XtraEditors.SimpleButton btn_Sil;
        private DevExpress.XtraEditors.SimpleButton btn_Guncelle;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txt_Tutar;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txt_Banka;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txt_CekNo;
        private DevExpress.XtraEditors.TextEdit txt_Sube;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.MemoEdit txt_Aciklama;
        private DevExpress.XtraEditors.DateEdit txt_VadeTarihi;
        private DevExpress.XtraEditors.ButtonEdit txt_BelgeNo;
        private DevExpress.XtraEditors.ButtonEdit txt_HesapNo;
    }
}
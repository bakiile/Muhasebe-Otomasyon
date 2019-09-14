namespace Otomasyon.KasaModul
{
    partial class frm_KasaDevirIslem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_KasaDevirIslem));
            this.btn_Cikis = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Sil = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Kaydet = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.btn_Guncelle = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Tutar = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Tarih = new DevExpress.XtraEditors.DateEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.rb_Cikis = new System.Windows.Forms.RadioButton();
            this.rb_Giris = new System.Windows.Forms.RadioButton();
            this.txt_Aciklama = new DevExpress.XtraEditors.MemoEdit();
            this.txt_KasaAdi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_BelgeNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_KasaKodu = new DevExpress.XtraEditors.ButtonEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Tutar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Tarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Tarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Aciklama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_KasaAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_BelgeNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_KasaKodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Cikis
            // 
            this.btn_Cikis.ImageOptions.Image = global::Otomasyon.Properties.Resources.Kapat24x24;
            this.btn_Cikis.Location = new System.Drawing.Point(358, 25);
            this.btn_Cikis.Name = "btn_Cikis";
            this.btn_Cikis.Size = new System.Drawing.Size(94, 40);
            this.btn_Cikis.TabIndex = 7;
            this.btn_Cikis.Text = "Çıkış";
            this.btn_Cikis.Click += new System.EventHandler(this.Btn_Cikis_Click);
            // 
            // btn_Sil
            // 
            this.btn_Sil.Enabled = false;
            this.btn_Sil.ImageOptions.Image = global::Otomasyon.Properties.Resources.Sil24x24;
            this.btn_Sil.Location = new System.Drawing.Point(258, 25);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(94, 40);
            this.btn_Sil.TabIndex = 6;
            this.btn_Sil.Text = "Sil";
            this.btn_Sil.Click += new System.EventHandler(this.Btn_Sil_Click);
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.ImageOptions.Image = global::Otomasyon.Properties.Resources.Kaydet24x24;
            this.btn_Kaydet.Location = new System.Drawing.Point(58, 25);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(94, 40);
            this.btn_Kaydet.TabIndex = 4;
            this.btn_Kaydet.Text = "Kaydet";
            this.btn_Kaydet.Click += new System.EventHandler(this.Btn_Kaydet_Click);
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.btn_Cikis);
            this.groupControl3.Controls.Add(this.btn_Sil);
            this.groupControl3.Controls.Add(this.btn_Guncelle);
            this.groupControl3.Controls.Add(this.btn_Kaydet);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(0, 245);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(463, 73);
            this.groupControl3.TabIndex = 5;
            this.groupControl3.Text = "İşlemler";
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.Enabled = false;
            this.btn_Guncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Guncelle.ImageOptions.Image")));
            this.btn_Guncelle.Location = new System.Drawing.Point(158, 25);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(94, 40);
            this.btn_Guncelle.TabIndex = 5;
            this.btn_Guncelle.Text = "Güncelle";
            this.btn_Guncelle.Click += new System.EventHandler(this.Btn_Guncelle_Click);
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(20, 82);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(48, 13);
            this.labelControl9.TabIndex = 0;
            this.labelControl9.Text = "Açıklama :";
            // 
            // txt_Tutar
            // 
            this.txt_Tutar.Location = new System.Drawing.Point(300, 27);
            this.txt_Tutar.Name = "txt_Tutar";
            this.txt_Tutar.Properties.Mask.EditMask = "c";
            this.txt_Tutar.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txt_Tutar.Size = new System.Drawing.Size(145, 20);
            this.txt_Tutar.TabIndex = 1;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(261, 30);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(33, 13);
            this.labelControl8.TabIndex = 0;
            this.labelControl8.Text = "Tutar :";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(37, 30);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(31, 13);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "Tarih :";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(11, 56);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(57, 13);
            this.labelControl7.TabIndex = 0;
            this.labelControl7.Text = "İşlem Türü :";
            // 
            // txt_Tarih
            // 
            this.txt_Tarih.EditValue = null;
            this.txt_Tarih.Location = new System.Drawing.Point(74, 27);
            this.txt_Tarih.Name = "txt_Tarih";
            this.txt_Tarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_Tarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_Tarih.Properties.DisplayFormat.FormatString = "";
            this.txt_Tarih.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txt_Tarih.Properties.EditFormat.FormatString = "";
            this.txt_Tarih.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txt_Tarih.Properties.Mask.EditMask = "";
            this.txt_Tarih.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txt_Tarih.Size = new System.Drawing.Size(157, 20);
            this.txt_Tarih.TabIndex = 1;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.rb_Cikis);
            this.groupControl2.Controls.Add(this.rb_Giris);
            this.groupControl2.Controls.Add(this.labelControl9);
            this.groupControl2.Controls.Add(this.txt_Tutar);
            this.groupControl2.Controls.Add(this.labelControl8);
            this.groupControl2.Controls.Add(this.labelControl6);
            this.groupControl2.Controls.Add(this.labelControl7);
            this.groupControl2.Controls.Add(this.txt_Tarih);
            this.groupControl2.Controls.Add(this.txt_Aciklama);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl2.Location = new System.Drawing.Point(0, 81);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(463, 164);
            this.groupControl2.TabIndex = 4;
            this.groupControl2.Text = "İşlem Bilgileri";
            // 
            // rb_Cikis
            // 
            this.rb_Cikis.AutoSize = true;
            this.rb_Cikis.Location = new System.Drawing.Point(155, 56);
            this.rb_Cikis.Name = "rb_Cikis";
            this.rb_Cikis.Size = new System.Drawing.Size(76, 17);
            this.rb_Cikis.TabIndex = 2;
            this.rb_Cikis.Text = "Çıkış İşlemi";
            this.rb_Cikis.UseVisualStyleBackColor = true;
            // 
            // rb_Giris
            // 
            this.rb_Giris.AutoSize = true;
            this.rb_Giris.Checked = true;
            this.rb_Giris.Location = new System.Drawing.Point(74, 56);
            this.rb_Giris.Name = "rb_Giris";
            this.rb_Giris.Size = new System.Drawing.Size(75, 17);
            this.rb_Giris.TabIndex = 2;
            this.rb_Giris.TabStop = true;
            this.rb_Giris.Text = "Giriş İşlemi";
            this.rb_Giris.UseVisualStyleBackColor = true;
            // 
            // txt_Aciklama
            // 
            this.txt_Aciklama.Location = new System.Drawing.Point(74, 79);
            this.txt_Aciklama.Name = "txt_Aciklama";
            this.txt_Aciklama.Size = new System.Drawing.Size(371, 69);
            this.txt_Aciklama.TabIndex = 1;
            // 
            // txt_KasaAdi
            // 
            this.txt_KasaAdi.Location = new System.Drawing.Point(300, 49);
            this.txt_KasaAdi.Name = "txt_KasaAdi";
            this.txt_KasaAdi.Size = new System.Drawing.Size(145, 20);
            this.txt_KasaAdi.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(246, 52);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Kasa Adı :";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(11, 52);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(57, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Kasa Kodu :";
            // 
            // txt_BelgeNo
            // 
            this.txt_BelgeNo.Location = new System.Drawing.Point(144, 23);
            this.txt_BelgeNo.Name = "txt_BelgeNo";
            this.txt_BelgeNo.Size = new System.Drawing.Size(301, 20);
            this.txt_BelgeNo.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 26);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(126, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Belge / Makbuz Numarası :";
            // 
            // txt_KasaKodu
            // 
            this.txt_KasaKodu.Location = new System.Drawing.Point(74, 49);
            this.txt_KasaKodu.Name = "txt_KasaKodu";
            this.txt_KasaKodu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txt_KasaKodu.Size = new System.Drawing.Size(157, 20);
            this.txt_KasaKodu.TabIndex = 1;
            this.txt_KasaKodu.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.Txt_KasaKodu_ButtonClick);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txt_KasaAdi);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txt_BelgeNo);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txt_KasaKodu);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(463, 81);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Kasa Bilgileri";
            // 
            // frm_KasaDevirIslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 318);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_KasaDevirIslem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kasa Devir İşlem";
            this.Load += new System.EventHandler(this.Frm_KasaDevirIslem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_Tutar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Tarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Tarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Aciklama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_KasaAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_BelgeNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_KasaKodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_Cikis;
        private DevExpress.XtraEditors.SimpleButton btn_Sil;
        private DevExpress.XtraEditors.SimpleButton btn_Kaydet;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.SimpleButton btn_Guncelle;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit txt_Tutar;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.DateEdit txt_Tarih;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.RadioButton rb_Cikis;
        private System.Windows.Forms.RadioButton rb_Giris;
        private DevExpress.XtraEditors.MemoEdit txt_Aciklama;
        private DevExpress.XtraEditors.TextEdit txt_KasaAdi;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txt_BelgeNo;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ButtonEdit txt_KasaKodu;
        private DevExpress.XtraEditors.GroupControl groupControl1;
    }
}
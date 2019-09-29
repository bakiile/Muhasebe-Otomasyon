namespace Otomasyon.BankaModul
{
    partial class frm_BankaIslem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_BankaIslem));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.txt_Tutar = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Aciklama = new DevExpress.XtraEditors.MemoEdit();
            this.txt_Tarih = new DevExpress.XtraEditors.DateEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txt_HesapNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txt_BelgeNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txt_HesapAdi = new DevExpress.XtraEditors.ButtonEdit();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.btn_Cikis = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Kaydet = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Sil = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Guncelle = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Tutar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Aciklama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Tarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Tarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_HesapNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_BelgeNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_HesapAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.groupControl2);
            this.panelControl1.Controls.Add(this.groupControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(446, 239);
            this.panelControl1.TabIndex = 0;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.groupControl4);
            this.groupControl2.Controls.Add(this.txt_Tutar);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Controls.Add(this.txt_Aciklama);
            this.groupControl2.Controls.Add(this.txt_Tarih);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(192, 2);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(252, 235);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "İşlem Bilgileri";
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.radioButton2);
            this.groupControl4.Controls.Add(this.radioButton1);
            this.groupControl4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl4.Location = new System.Drawing.Point(2, 20);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(248, 52);
            this.groupControl4.TabIndex = 14;
            this.groupControl4.Text = "İşlem Türü";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(132, 26);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(76, 17);
            this.radioButton2.TabIndex = 0;
            this.radioButton2.Text = "Çıkış İşlemi";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(51, 26);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(75, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Giriş İşlemi";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // txt_Tutar
            // 
            this.txt_Tutar.Location = new System.Drawing.Point(59, 111);
            this.txt_Tutar.Name = "txt_Tutar";
            this.txt_Tutar.Properties.Mask.EditMask = "c";
            this.txt_Tutar.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txt_Tutar.Size = new System.Drawing.Size(179, 20);
            this.txt_Tutar.TabIndex = 11;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(5, 140);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 13);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "Açıklama :";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(19, 88);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(31, 13);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "Tarih :";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(17, 114);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(33, 13);
            this.labelControl3.TabIndex = 10;
            this.labelControl3.Text = "Tutar :";
            // 
            // txt_Aciklama
            // 
            this.txt_Aciklama.Location = new System.Drawing.Point(59, 137);
            this.txt_Aciklama.Name = "txt_Aciklama";
            this.txt_Aciklama.Size = new System.Drawing.Size(179, 85);
            this.txt_Aciklama.TabIndex = 13;
            // 
            // txt_Tarih
            // 
            this.txt_Tarih.EditValue = null;
            this.txt_Tarih.Location = new System.Drawing.Point(59, 85);
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
            this.txt_Tarih.Size = new System.Drawing.Size(179, 20);
            this.txt_Tarih.TabIndex = 12;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txt_HesapNo);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.txt_BelgeNo);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.txt_HesapAdi);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Location = new System.Drawing.Point(2, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(190, 235);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Hesap Bilgileri";
            // 
            // txt_HesapNo
            // 
            this.txt_HesapNo.Location = new System.Drawing.Point(10, 167);
            this.txt_HesapNo.Name = "txt_HesapNo";
            this.txt_HesapNo.Properties.ReadOnly = true;
            this.txt_HesapNo.Size = new System.Drawing.Size(161, 20);
            this.txt_HesapNo.TabIndex = 5;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(10, 37);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(80, 13);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Belge Numarası :";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(13, 148);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(84, 13);
            this.labelControl6.TabIndex = 4;
            this.labelControl6.Text = "Hesap Numarası :";
            // 
            // txt_BelgeNo
            // 
            this.txt_BelgeNo.Location = new System.Drawing.Point(10, 56);
            this.txt_BelgeNo.Name = "txt_BelgeNo";
            this.txt_BelgeNo.Size = new System.Drawing.Size(161, 20);
            this.txt_BelgeNo.TabIndex = 6;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(10, 92);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(87, 13);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "Hesap Adı / Türü :";
            // 
            // txt_HesapAdi
            // 
            this.txt_HesapAdi.Location = new System.Drawing.Point(10, 111);
            this.txt_HesapAdi.Name = "txt_HesapAdi";
            this.txt_HesapAdi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txt_HesapAdi.Properties.ReadOnly = true;
            this.txt_HesapAdi.Size = new System.Drawing.Size(161, 20);
            this.txt_HesapAdi.TabIndex = 5;
            this.txt_HesapAdi.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.Txt_HesapAdi_ButtonClick);
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.btn_Cikis);
            this.groupControl3.Controls.Add(this.btn_Kaydet);
            this.groupControl3.Controls.Add(this.btn_Sil);
            this.groupControl3.Controls.Add(this.btn_Guncelle);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(0, 239);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(446, 67);
            this.groupControl3.TabIndex = 1;
            this.groupControl3.Text = "İşlemler";
            // 
            // btn_Cikis
            // 
            this.btn_Cikis.ImageOptions.Image = global::Otomasyon.Properties.Resources.Kapat24x24;
            this.btn_Cikis.Location = new System.Drawing.Point(336, 23);
            this.btn_Cikis.Name = "btn_Cikis";
            this.btn_Cikis.Size = new System.Drawing.Size(94, 40);
            this.btn_Cikis.TabIndex = 11;
            this.btn_Cikis.Text = "Çıkış";
            this.btn_Cikis.Click += new System.EventHandler(this.Btn_Cikis_Click);
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.ImageOptions.Image = global::Otomasyon.Properties.Resources.Kaydet24x24;
            this.btn_Kaydet.Location = new System.Drawing.Point(36, 23);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(94, 40);
            this.btn_Kaydet.TabIndex = 8;
            this.btn_Kaydet.Text = "Kaydet";
            this.btn_Kaydet.Click += new System.EventHandler(this.Btn_Kaydet_Click);
            // 
            // btn_Sil
            // 
            this.btn_Sil.Enabled = false;
            this.btn_Sil.ImageOptions.Image = global::Otomasyon.Properties.Resources.Sil24x24;
            this.btn_Sil.Location = new System.Drawing.Point(236, 23);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(94, 40);
            this.btn_Sil.TabIndex = 10;
            this.btn_Sil.Text = "Sil";
            this.btn_Sil.Click += new System.EventHandler(this.Btn_Sil_Click);
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.Enabled = false;
            this.btn_Guncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Guncelle.ImageOptions.Image")));
            this.btn_Guncelle.Location = new System.Drawing.Point(136, 23);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(94, 40);
            this.btn_Guncelle.TabIndex = 9;
            this.btn_Guncelle.Text = "Güncelle";
            this.btn_Guncelle.Click += new System.EventHandler(this.Btn_Guncelle_Click);
            // 
            // frm_BankaIslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 306);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.panelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_BankaIslem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banka İşlem";
            this.Load += new System.EventHandler(this.Frm_BankaIslem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            this.groupControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Tutar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Aciklama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Tarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Tarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_HesapNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_BelgeNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_HesapAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txt_BelgeNo;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.TextEdit txt_Tutar;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.MemoEdit txt_Aciklama;
        private DevExpress.XtraEditors.TextEdit txt_HesapNo;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private DevExpress.XtraEditors.SimpleButton btn_Cikis;
        private DevExpress.XtraEditors.SimpleButton btn_Kaydet;
        private DevExpress.XtraEditors.SimpleButton btn_Sil;
        private DevExpress.XtraEditors.SimpleButton btn_Guncelle;
        private DevExpress.XtraEditors.DateEdit txt_Tarih;
        private DevExpress.XtraEditors.ButtonEdit txt_HesapAdi;
    }
}
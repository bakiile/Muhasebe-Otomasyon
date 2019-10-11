namespace Otomasyon.Modul_Kullanici
{
    partial class frm_KullaniciPaneli
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_KullaniciAdi = new DevExpress.XtraEditors.TextEdit();
            this.btn_Kaydet = new DevExpress.XtraEditors.SimpleButton();
            this.rBtn_Aktif = new System.Windows.Forms.RadioButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Sifre = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txt_SifreTekrar = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Isim = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Soyisim = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txt_KullaniciTuru = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btn_Temizle = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Kapat = new DevExpress.XtraEditors.SimpleButton();
            this.rBtn_Pasif = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.txt_KullaniciAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Sifre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SifreTekrar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Isim.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Soyisim.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_KullaniciTuru.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(26, 21);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(59, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Kullanıcı Adı:";
            // 
            // txt_KullaniciAdi
            // 
            this.txt_KullaniciAdi.Location = new System.Drawing.Point(91, 18);
            this.txt_KullaniciAdi.Name = "txt_KullaniciAdi";
            this.txt_KullaniciAdi.Size = new System.Drawing.Size(156, 20);
            this.txt_KullaniciAdi.TabIndex = 1;
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.Location = new System.Drawing.Point(10, 198);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(75, 36);
            this.btn_Kaydet.TabIndex = 2;
            this.btn_Kaydet.Text = "Kaydet";
            this.btn_Kaydet.Click += new System.EventHandler(this.Btn_Kaydet_Click);
            // 
            // rBtn_Aktif
            // 
            this.rBtn_Aktif.AutoSize = true;
            this.rBtn_Aktif.Location = new System.Drawing.Point(91, 174);
            this.rBtn_Aktif.Name = "rBtn_Aktif";
            this.rBtn_Aktif.Size = new System.Drawing.Size(47, 17);
            this.rBtn_Aktif.TabIndex = 3;
            this.rBtn_Aktif.TabStop = true;
            this.rBtn_Aktif.Text = "Aktif";
            this.rBtn_Aktif.UseVisualStyleBackColor = true;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(59, 47);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(26, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Şifre:";
            // 
            // txt_Sifre
            // 
            this.txt_Sifre.Location = new System.Drawing.Point(91, 44);
            this.txt_Sifre.Name = "txt_Sifre";
            this.txt_Sifre.Size = new System.Drawing.Size(156, 20);
            this.txt_Sifre.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(17, 73);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(68, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Şifre (Tekrar):";
            // 
            // txt_SifreTekrar
            // 
            this.txt_SifreTekrar.Location = new System.Drawing.Point(91, 70);
            this.txt_SifreTekrar.Name = "txt_SifreTekrar";
            this.txt_SifreTekrar.Size = new System.Drawing.Size(156, 20);
            this.txt_SifreTekrar.TabIndex = 1;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(62, 99);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(23, 13);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "İsim:";
            // 
            // txt_Isim
            // 
            this.txt_Isim.Location = new System.Drawing.Point(91, 96);
            this.txt_Isim.Name = "txt_Isim";
            this.txt_Isim.Size = new System.Drawing.Size(156, 20);
            this.txt_Isim.TabIndex = 1;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(46, 125);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(39, 13);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "Soyisim:";
            // 
            // txt_Soyisim
            // 
            this.txt_Soyisim.Location = new System.Drawing.Point(91, 122);
            this.txt_Soyisim.Name = "txt_Soyisim";
            this.txt_Soyisim.Size = new System.Drawing.Size(156, 20);
            this.txt_Soyisim.TabIndex = 1;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(19, 151);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(66, 13);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "Kullanıcı Türü:";
            // 
            // txt_KullaniciTuru
            // 
            this.txt_KullaniciTuru.EditValue = "Normal";
            this.txt_KullaniciTuru.Location = new System.Drawing.Point(91, 148);
            this.txt_KullaniciTuru.Name = "txt_KullaniciTuru";
            this.txt_KullaniciTuru.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_KullaniciTuru.Properties.Items.AddRange(new object[] {
            "Yönetici",
            "Normal"});
            this.txt_KullaniciTuru.Size = new System.Drawing.Size(156, 20);
            this.txt_KullaniciTuru.TabIndex = 1;
            // 
            // btn_Temizle
            // 
            this.btn_Temizle.Location = new System.Drawing.Point(91, 198);
            this.btn_Temizle.Name = "btn_Temizle";
            this.btn_Temizle.Size = new System.Drawing.Size(75, 36);
            this.btn_Temizle.TabIndex = 2;
            this.btn_Temizle.Text = "Temizle";
            this.btn_Temizle.Click += new System.EventHandler(this.Btn_Temizle_Click);
            // 
            // btn_Kapat
            // 
            this.btn_Kapat.Location = new System.Drawing.Point(172, 198);
            this.btn_Kapat.Name = "btn_Kapat";
            this.btn_Kapat.Size = new System.Drawing.Size(75, 36);
            this.btn_Kapat.TabIndex = 2;
            this.btn_Kapat.Text = "Kapat";
            this.btn_Kapat.Click += new System.EventHandler(this.Btn_Kapat_Click);
            // 
            // rBtn_Pasif
            // 
            this.rBtn_Pasif.AutoSize = true;
            this.rBtn_Pasif.Location = new System.Drawing.Point(144, 174);
            this.rBtn_Pasif.Name = "rBtn_Pasif";
            this.rBtn_Pasif.Size = new System.Drawing.Size(48, 17);
            this.rBtn_Pasif.TabIndex = 3;
            this.rBtn_Pasif.TabStop = true;
            this.rBtn_Pasif.Text = "Pasif";
            this.rBtn_Pasif.UseVisualStyleBackColor = true;
            // 
            // frm_KullaniciPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 245);
            this.Controls.Add(this.rBtn_Pasif);
            this.Controls.Add(this.rBtn_Aktif);
            this.Controls.Add(this.btn_Kapat);
            this.Controls.Add(this.btn_Temizle);
            this.Controls.Add(this.btn_Kaydet);
            this.Controls.Add(this.txt_Soyisim);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.txt_SifreTekrar);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txt_Isim);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txt_Sifre);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txt_KullaniciAdi);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txt_KullaniciTuru);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_KullaniciPaneli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Paneli";
            ((System.ComponentModel.ISupportInitialize)(this.txt_KullaniciAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Sifre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SifreTekrar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Isim.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Soyisim.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_KullaniciTuru.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txt_KullaniciAdi;
        private DevExpress.XtraEditors.SimpleButton btn_Kaydet;
        private System.Windows.Forms.RadioButton rBtn_Aktif;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txt_Sifre;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txt_SifreTekrar;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txt_Isim;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txt_Soyisim;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.ComboBoxEdit txt_KullaniciTuru;
        private DevExpress.XtraEditors.SimpleButton btn_Temizle;
        private DevExpress.XtraEditors.SimpleButton btn_Kapat;
        private System.Windows.Forms.RadioButton rBtn_Pasif;
    }
}
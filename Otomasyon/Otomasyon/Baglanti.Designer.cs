namespace Otomasyon
{
    partial class frm_BaglantiAyar
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btn_YeniAyar = new DevExpress.XtraEditors.SimpleButton();
            this.chk_YeniGiris = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Sifre = new DevExpress.XtraEditors.TextEdit();
            this.txt_VeriTabani = new DevExpress.XtraEditors.TextEdit();
            this.txt_KullaniciID = new DevExpress.XtraEditors.TextEdit();
            this.txt_Sunucu = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chk_YeniGiris.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Sifre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_VeriTabani.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_KullaniciID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Sunucu.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(492, 58);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Mevcut Bağlantı Bilgileri";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(45, 30);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(63, 13);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "labelControl5";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(14, 28);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(25, 16);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "CS :";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btn_YeniAyar);
            this.groupControl2.Controls.Add(this.chk_YeniGiris);
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Controls.Add(this.txt_Sifre);
            this.groupControl2.Controls.Add(this.txt_VeriTabani);
            this.groupControl2.Controls.Add(this.txt_KullaniciID);
            this.groupControl2.Controls.Add(this.txt_Sunucu);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 58);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(492, 119);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "Yeni Bağlantı Bilgileri";
            // 
            // btn_YeniAyar
            // 
            this.btn_YeniAyar.Enabled = false;
            this.btn_YeniAyar.Location = new System.Drawing.Point(315, 77);
            this.btn_YeniAyar.Name = "btn_YeniAyar";
            this.btn_YeniAyar.Size = new System.Drawing.Size(165, 23);
            this.btn_YeniAyar.TabIndex = 4;
            this.btn_YeniAyar.Text = "Yeni Ayar Kaydet";
            this.btn_YeniAyar.Click += new System.EventHandler(this.Btn_YeniAyar_Click);
            // 
            // chk_YeniGiris
            // 
            this.chk_YeniGiris.Location = new System.Drawing.Point(165, 79);
            this.chk_YeniGiris.Name = "chk_YeniGiris";
            this.chk_YeniGiris.Properties.Caption = "Yeni Giriş";
            this.chk_YeniGiris.Size = new System.Drawing.Size(75, 19);
            this.chk_YeniGiris.TabIndex = 3;
            this.chk_YeniGiris.CheckedChanged += new System.EventHandler(this.Chk_YeniGiris_CheckedChanged);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(280, 52);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(29, 13);
            this.labelControl4.TabIndex = 1;
            this.labelControl4.Text = "Şifre :";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(11, 52);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(58, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Veri tabanı :";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(251, 26);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(58, 13);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Kullanıcı ID :";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(27, 26);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(42, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Sunucu :";
            // 
            // txt_Sifre
            // 
            this.txt_Sifre.Enabled = false;
            this.txt_Sifre.Location = new System.Drawing.Point(315, 49);
            this.txt_Sifre.Name = "txt_Sifre";
            this.txt_Sifre.Size = new System.Drawing.Size(165, 20);
            this.txt_Sifre.TabIndex = 0;
            // 
            // txt_VeriTabani
            // 
            this.txt_VeriTabani.Enabled = false;
            this.txt_VeriTabani.Location = new System.Drawing.Point(75, 49);
            this.txt_VeriTabani.Name = "txt_VeriTabani";
            this.txt_VeriTabani.Size = new System.Drawing.Size(165, 20);
            this.txt_VeriTabani.TabIndex = 0;
            // 
            // txt_KullaniciID
            // 
            this.txt_KullaniciID.Enabled = false;
            this.txt_KullaniciID.Location = new System.Drawing.Point(315, 23);
            this.txt_KullaniciID.Name = "txt_KullaniciID";
            this.txt_KullaniciID.Size = new System.Drawing.Size(165, 20);
            this.txt_KullaniciID.TabIndex = 0;
            // 
            // txt_Sunucu
            // 
            this.txt_Sunucu.Enabled = false;
            this.txt_Sunucu.Location = new System.Drawing.Point(75, 23);
            this.txt_Sunucu.Name = "txt_Sunucu";
            this.txt_Sunucu.Size = new System.Drawing.Size(165, 20);
            this.txt_Sunucu.TabIndex = 0;
            // 
            // frm_BaglantiAyar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 177);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frm_BaglantiAyar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bağlantı Ayarları";
            this.Load += new System.EventHandler(this.Frm_BaglantiAyar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chk_YeniGiris.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Sifre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_VeriTabani.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_KullaniciID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Sunucu.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btn_YeniAyar;
        private DevExpress.XtraEditors.CheckEdit chk_YeniGiris;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txt_Sifre;
        private DevExpress.XtraEditors.TextEdit txt_VeriTabani;
        private DevExpress.XtraEditors.TextEdit txt_KullaniciID;
        private DevExpress.XtraEditors.TextEdit txt_Sunucu;
    }
}
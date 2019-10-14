namespace Otomasyon
{
    partial class frm_Login
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
            this.txt_KullaniciAdi = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Sifre = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Giris = new DevExpress.XtraEditors.SimpleButton();
            this.btn_BaglantiAyar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txt_KullaniciAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Sifre.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_KullaniciAdi
            // 
            this.txt_KullaniciAdi.Location = new System.Drawing.Point(148, 12);
            this.txt_KullaniciAdi.Name = "txt_KullaniciAdi";
            this.txt_KullaniciAdi.Size = new System.Drawing.Size(166, 20);
            this.txt_KullaniciAdi.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // txt_Sifre
            // 
            this.txt_Sifre.Location = new System.Drawing.Point(148, 38);
            this.txt_Sifre.Name = "txt_Sifre";
            this.txt_Sifre.Properties.PasswordChar = '*';
            this.txt_Sifre.Size = new System.Drawing.Size(166, 20);
            this.txt_Sifre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre :";
            // 
            // btn_Giris
            // 
            this.btn_Giris.Location = new System.Drawing.Point(109, 69);
            this.btn_Giris.Name = "btn_Giris";
            this.btn_Giris.Size = new System.Drawing.Size(110, 34);
            this.btn_Giris.TabIndex = 2;
            this.btn_Giris.Text = "Giriş";
            this.btn_Giris.Click += new System.EventHandler(this.Btn_Giris_Click);
            // 
            // btn_BaglantiAyar
            // 
            this.btn_BaglantiAyar.Location = new System.Drawing.Point(225, 69);
            this.btn_BaglantiAyar.Name = "btn_BaglantiAyar";
            this.btn_BaglantiAyar.Size = new System.Drawing.Size(110, 34);
            this.btn_BaglantiAyar.TabIndex = 3;
            this.btn_BaglantiAyar.Text = "Bağlantı Ayarları";
            this.btn_BaglantiAyar.Click += new System.EventHandler(this.Btn_BaglantiAyar_Click);
            // 
            // frm_Login
            // 
            this.AcceptButton = this.btn_Giris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 119);
            this.Controls.Add(this.btn_BaglantiAyar);
            this.Controls.Add(this.btn_Giris);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Sifre);
            this.Controls.Add(this.txt_KullaniciAdi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.txt_KullaniciAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Sifre.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txt_KullaniciAdi;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txt_Sifre;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton btn_Giris;
        private DevExpress.XtraEditors.SimpleButton btn_BaglantiAyar;
    }
}
namespace Otomasyon.BankaModul
{
    partial class frm_BankaListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_BankaListesi));
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btn_Ara = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_BarkodNumarasi = new DevExpress.XtraEditors.TextEdit();
            this.txt_StokKodu = new DevExpress.XtraEditors.TextEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txt_StokAdi = new DevExpress.XtraEditors.TextEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_BarkodNumarasi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_StokKodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_StokAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl2
            // 
            this.panelControl2.Appearance.BorderColor = System.Drawing.Color.Black;
            this.panelControl2.Appearance.Options.UseBorderColor = true;
            this.panelControl2.Controls.Add(this.gridControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 71);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(636, 271);
            this.panelControl2.TabIndex = 3;
            // 
            // btn_Ara
            // 
            this.btn_Ara.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btn_Ara.Appearance.Options.UseFont = true;
            this.btn_Ara.ImageOptions.Image = global::Otomasyon.Properties.Resources.Ara32x32;
            this.btn_Ara.Location = new System.Drawing.Point(526, 12);
            this.btn_Ara.Name = "btn_Ara";
            this.btn_Ara.Size = new System.Drawing.Size(98, 44);
            this.btn_Ara.TabIndex = 3;
            this.btn_Ara.Text = "Ara";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(354, 12);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(36, 16);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "IBAN:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(183, 12);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(108, 16);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Hesap Numarası:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(115, 16);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Hesap Adı / Türü:";
            // 
            // txt_BarkodNumarasi
            // 
            this.txt_BarkodNumarasi.Location = new System.Drawing.Point(354, 34);
            this.txt_BarkodNumarasi.Name = "txt_BarkodNumarasi";
            this.txt_BarkodNumarasi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txt_BarkodNumarasi.Properties.Appearance.Options.UseFont = true;
            this.txt_BarkodNumarasi.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txt_BarkodNumarasi.Size = new System.Drawing.Size(165, 22);
            this.txt_BarkodNumarasi.TabIndex = 2;
            // 
            // txt_StokKodu
            // 
            this.txt_StokKodu.Location = new System.Drawing.Point(183, 34);
            this.txt_StokKodu.Name = "txt_StokKodu";
            this.txt_StokKodu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txt_StokKodu.Properties.Appearance.Options.UseFont = true;
            this.txt_StokKodu.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txt_StokKodu.Size = new System.Drawing.Size(165, 22);
            this.txt_StokKodu.TabIndex = 1;
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panelControl1.Appearance.BackColor2 = System.Drawing.Color.LightGray;
            this.panelControl1.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Appearance.Options.UseBorderColor = true;
            this.panelControl1.Controls.Add(this.btn_Ara);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.txt_BarkodNumarasi);
            this.panelControl1.Controls.Add(this.txt_StokKodu);
            this.panelControl1.Controls.Add(this.txt_StokAdi);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(636, 71);
            this.panelControl1.TabIndex = 2;
            // 
            // txt_StokAdi
            // 
            this.txt_StokAdi.Location = new System.Drawing.Point(12, 34);
            this.txt_StokAdi.Name = "txt_StokAdi";
            this.txt_StokAdi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txt_StokAdi.Properties.Appearance.Options.UseFont = true;
            this.txt_StokAdi.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txt_StokAdi.Size = new System.Drawing.Size(165, 22);
            this.txt_StokAdi.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(632, 267);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // frm_BankaListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 342);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_BankaListesi";
            this.Text = "Banka Listesi";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_BarkodNumarasi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_StokKodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_StokAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btn_Ara;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txt_BarkodNumarasi;
        private DevExpress.XtraEditors.TextEdit txt_StokKodu;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit txt_StokAdi;
    }
}
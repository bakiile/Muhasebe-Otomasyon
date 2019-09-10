namespace Otomasyon.KasaModul
{
    partial class frm_KasaListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_KasaListesi));
            this.txt_CariKodu = new DevExpress.XtraEditors.TextEdit();
            this.txt_CariAdi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btn_Ara = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CariKodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CariAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_CariKodu
            // 
            this.txt_CariKodu.Location = new System.Drawing.Point(18, 32);
            this.txt_CariKodu.Name = "txt_CariKodu";
            this.txt_CariKodu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txt_CariKodu.Properties.Appearance.Options.UseFont = true;
            this.txt_CariKodu.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txt_CariKodu.Size = new System.Drawing.Size(165, 22);
            this.txt_CariKodu.TabIndex = 0;
            // 
            // txt_CariAdi
            // 
            this.txt_CariAdi.Location = new System.Drawing.Point(189, 32);
            this.txt_CariAdi.Name = "txt_CariAdi";
            this.txt_CariAdi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txt_CariAdi.Properties.Appearance.Options.UseFont = true;
            this.txt_CariAdi.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txt_CariAdi.Size = new System.Drawing.Size(165, 22);
            this.txt_CariAdi.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(18, 10);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(76, 16);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "Kasa Kodu :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(189, 10);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(65, 16);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "Kasa Adı :";
            // 
            // btn_Ara
            // 
            this.btn_Ara.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btn_Ara.Appearance.Options.UseFont = true;
            this.btn_Ara.ImageOptions.Image = global::Otomasyon.Properties.Resources.Ara32x32;
            this.btn_Ara.Location = new System.Drawing.Point(360, 10);
            this.btn_Ara.Name = "btn_Ara";
            this.btn_Ara.Size = new System.Drawing.Size(98, 44);
            this.btn_Ara.TabIndex = 3;
            this.btn_Ara.Text = "Ara";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btn_Ara);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.txt_CariAdi);
            this.panelControl1.Controls.Add(this.txt_CariKodu);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(465, 64);
            this.panelControl1.TabIndex = 2;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 64);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(465, 219);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // frm_KasaListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 283);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_KasaListesi";
            this.Text = "KasaListesi";
            ((System.ComponentModel.ISupportInitialize)(this.txt_CariKodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CariAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txt_CariKodu;
        private DevExpress.XtraEditors.TextEdit txt_CariAdi;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btn_Ara;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}
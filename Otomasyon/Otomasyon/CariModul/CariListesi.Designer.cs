namespace Otomasyon.CariModul
{
    partial class frm_CariListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_CariListesi));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btn_Ara = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_VergiNo = new DevExpress.XtraEditors.TextEdit();
            this.txt_CariAdi = new DevExpress.XtraEditors.TextEdit();
            this.txt_CariKodu = new DevExpress.XtraEditors.TextEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.CARIID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CARIKODU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CARIADI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VERGINO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VERGIDAIRESI = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_VergiNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CariAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CariKodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btn_Ara);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.txt_VergiNo);
            this.panelControl1.Controls.Add(this.txt_CariAdi);
            this.panelControl1.Controls.Add(this.txt_CariKodu);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(650, 64);
            this.panelControl1.TabIndex = 0;
            // 
            // btn_Ara
            // 
            this.btn_Ara.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btn_Ara.Appearance.Options.UseFont = true;
            this.btn_Ara.ImageOptions.Image = global::Otomasyon.Properties.Resources.Ara32x32;
            this.btn_Ara.Location = new System.Drawing.Point(546, 10);
            this.btn_Ara.Name = "btn_Ara";
            this.btn_Ara.Size = new System.Drawing.Size(98, 44);
            this.btn_Ara.TabIndex = 3;
            this.btn_Ara.Text = "Ara";
            this.btn_Ara.Click += new System.EventHandler(this.Btn_Ara_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(360, 10);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(106, 16);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Vergi Numarası :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(189, 10);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(59, 16);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "Cari Adı :";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(18, 10);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(70, 16);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "Cari Kodu :";
            // 
            // txt_VergiNo
            // 
            this.txt_VergiNo.Location = new System.Drawing.Point(360, 32);
            this.txt_VergiNo.Name = "txt_VergiNo";
            this.txt_VergiNo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txt_VergiNo.Properties.Appearance.Options.UseFont = true;
            this.txt_VergiNo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txt_VergiNo.Size = new System.Drawing.Size(165, 22);
            this.txt_VergiNo.TabIndex = 2;
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
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 64);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(650, 197);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.CARIID,
            this.CARIKODU,
            this.CARIADI,
            this.VERGINO,
            this.VERGIDAIRESI});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.DoubleClick += new System.EventHandler(this.GridView1_DoubleClick);
            // 
            // CARIID
            // 
            this.CARIID.Caption = "CARIID";
            this.CARIID.FieldName = "CARIID";
            this.CARIID.Name = "CARIID";
            // 
            // CARIKODU
            // 
            this.CARIKODU.Caption = "CARIKODU";
            this.CARIKODU.FieldName = "CARIKODU";
            this.CARIKODU.Name = "CARIKODU";
            this.CARIKODU.OptionsColumn.AllowEdit = false;
            this.CARIKODU.Visible = true;
            this.CARIKODU.VisibleIndex = 0;
            // 
            // CARIADI
            // 
            this.CARIADI.Caption = "CARIADI";
            this.CARIADI.FieldName = "CARIADI";
            this.CARIADI.Name = "CARIADI";
            this.CARIADI.OptionsColumn.AllowEdit = false;
            this.CARIADI.Visible = true;
            this.CARIADI.VisibleIndex = 1;
            // 
            // VERGINO
            // 
            this.VERGINO.Caption = "VERGINO";
            this.VERGINO.FieldName = "VERGINO";
            this.VERGINO.Name = "VERGINO";
            this.VERGINO.OptionsColumn.AllowEdit = false;
            this.VERGINO.Visible = true;
            this.VERGINO.VisibleIndex = 2;
            // 
            // VERGIDAIRESI
            // 
            this.VERGIDAIRESI.Caption = "VERGIDAIRESI";
            this.VERGIDAIRESI.FieldName = "VERGIDAIRESI";
            this.VERGIDAIRESI.Name = "VERGIDAIRESI";
            this.VERGIDAIRESI.OptionsColumn.AllowEdit = false;
            this.VERGIDAIRESI.Visible = true;
            this.VERGIDAIRESI.VisibleIndex = 3;
            // 
            // frm_CariListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 261);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_CariListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cari Listesi";
            this.Load += new System.EventHandler(this.CariListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_VergiNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CariAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CariKodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btn_Ara;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txt_VergiNo;
        private DevExpress.XtraEditors.TextEdit txt_CariAdi;
        private DevExpress.XtraEditors.TextEdit txt_CariKodu;
        private DevExpress.XtraGrid.Columns.GridColumn CARIID;
        private DevExpress.XtraGrid.Columns.GridColumn CARIKODU;
        private DevExpress.XtraGrid.Columns.GridColumn CARIADI;
        private DevExpress.XtraGrid.Columns.GridColumn VERGINO;
        private DevExpress.XtraGrid.Columns.GridColumn VERGIDAIRESI;
    }
}
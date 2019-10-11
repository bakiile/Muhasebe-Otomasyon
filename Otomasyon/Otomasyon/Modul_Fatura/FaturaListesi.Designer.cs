namespace Otomasyon.Modul_Fatura
{
    partial class frm_FaturaListesi
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_FaturaListesi));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btn_Ara = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_FaturaNo = new DevExpress.XtraEditors.TextEdit();
            this.txt_FaturaTuru = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txt_Tarih = new DevExpress.XtraEditors.DateEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.FATURANO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FATURATURU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CARIKODU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FATURAID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cms_Yenile = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_FaturaNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_FaturaTuru.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Tarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Tarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btn_Ara);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.txt_FaturaNo);
            this.panelControl1.Controls.Add(this.txt_FaturaTuru);
            this.panelControl1.Controls.Add(this.txt_Tarih);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(655, 64);
            this.panelControl1.TabIndex = 2;
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
            this.labelControl3.Size = new System.Drawing.Size(41, 16);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Tarih :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(189, 10);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(114, 16);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "Fatura Numarası :";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(18, 10);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(84, 16);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "Fatura Türü :";
            // 
            // txt_FaturaNo
            // 
            this.txt_FaturaNo.Location = new System.Drawing.Point(189, 32);
            this.txt_FaturaNo.Name = "txt_FaturaNo";
            this.txt_FaturaNo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txt_FaturaNo.Properties.Appearance.Options.UseFont = true;
            this.txt_FaturaNo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txt_FaturaNo.Size = new System.Drawing.Size(165, 22);
            this.txt_FaturaNo.TabIndex = 1;
            // 
            // txt_FaturaTuru
            // 
            this.txt_FaturaTuru.EditValue = "Satış Faturası";
            this.txt_FaturaTuru.Location = new System.Drawing.Point(18, 32);
            this.txt_FaturaTuru.Name = "txt_FaturaTuru";
            this.txt_FaturaTuru.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txt_FaturaTuru.Properties.Appearance.Options.UseFont = true;
            this.txt_FaturaTuru.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txt_FaturaTuru.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_FaturaTuru.Properties.Items.AddRange(new object[] {
            "Satış Faturası",
            "Satış İade Faturası",
            "Alış Faturası",
            "Alış İade Faturası"});
            this.txt_FaturaTuru.Properties.ReadOnly = true;
            this.txt_FaturaTuru.Size = new System.Drawing.Size(165, 22);
            this.txt_FaturaTuru.TabIndex = 0;
            this.txt_FaturaTuru.SelectedIndexChanged += new System.EventHandler(this.Txt_FaturaTuru_SelectedIndexChanged);
            // 
            // txt_Tarih
            // 
            this.txt_Tarih.EditValue = null;
            this.txt_Tarih.Location = new System.Drawing.Point(360, 32);
            this.txt_Tarih.Name = "txt_Tarih";
            this.txt_Tarih.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txt_Tarih.Properties.Appearance.Options.UseFont = true;
            this.txt_Tarih.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
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
            this.txt_Tarih.Size = new System.Drawing.Size(165, 22);
            this.txt_Tarih.TabIndex = 2;
            // 
            // gridControl1
            // 
            this.gridControl1.ContextMenuStrip = this.contextMenuStrip1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 64);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(655, 241);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.FATURANO,
            this.FATURATURU,
            this.CARIKODU,
            this.FATURAID});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.DoubleClick += new System.EventHandler(this.GridView1_DoubleClick);
            // 
            // FATURANO
            // 
            this.FATURANO.Caption = "Fatura Numarası";
            this.FATURANO.FieldName = "FATURANO";
            this.FATURANO.Name = "FATURANO";
            this.FATURANO.OptionsColumn.AllowEdit = false;
            this.FATURANO.Visible = true;
            this.FATURANO.VisibleIndex = 0;
            // 
            // FATURATURU
            // 
            this.FATURATURU.Caption = "Fatura Türü";
            this.FATURATURU.FieldName = "FATURATURU";
            this.FATURATURU.Name = "FATURATURU";
            this.FATURATURU.OptionsColumn.AllowEdit = false;
            this.FATURATURU.Visible = true;
            this.FATURATURU.VisibleIndex = 1;
            // 
            // CARIKODU
            // 
            this.CARIKODU.Caption = "Cari Kodu";
            this.CARIKODU.FieldName = "CARIKODU";
            this.CARIKODU.Name = "CARIKODU";
            this.CARIKODU.Visible = true;
            this.CARIKODU.VisibleIndex = 2;
            // 
            // FATURAID
            // 
            this.FATURAID.Caption = "FATURAID";
            this.FATURAID.FieldName = "FATURAID";
            this.FATURAID.Name = "FATURAID";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cms_Yenile});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(106, 26);
            // 
            // cms_Yenile
            // 
            this.cms_Yenile.Name = "cms_Yenile";
            this.cms_Yenile.Size = new System.Drawing.Size(180, 22);
            this.cms_Yenile.Text = "Yenile";
            this.cms_Yenile.Click += new System.EventHandler(this.Cms_Yenile_Click);
            // 
            // frm_FaturaListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 305);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_FaturaListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fatura Listesi";
            this.Load += new System.EventHandler(this.Frm_FaturaListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_FaturaNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_FaturaTuru.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Tarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Tarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_Ara;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txt_FaturaNo;
        private DevExpress.XtraEditors.ComboBoxEdit txt_FaturaTuru;
        private DevExpress.XtraEditors.DateEdit txt_Tarih;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn FATURANO;
        private DevExpress.XtraGrid.Columns.GridColumn FATURATURU;
        private DevExpress.XtraGrid.Columns.GridColumn CARIKODU;
        private DevExpress.XtraGrid.Columns.GridColumn FATURAID;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cms_Yenile;
    }
}
namespace Otomasyon.Modul_Kasa
{
    partial class frm_KasaHareketleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_KasaHareketleri));
            this.EVRAKTUR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txt_Bakiye = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Cikis = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Giris = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txt_KasaAdi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_KasaKodu = new DevExpress.XtraEditors.ButtonEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxDevirKarti = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxTahsilat = new System.Windows.Forms.ToolStripMenuItem();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BELGENO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GIRIS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CIKIS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ACIKLAMA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TARIH = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Bakiye.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Cikis.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Giris.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_KasaAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_KasaKodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // EVRAKTUR
            // 
            this.EVRAKTUR.Caption = "EVRAK TÜRÜ";
            this.EVRAKTUR.FieldName = "EVRAKTURU";
            this.EVRAKTUR.Name = "EVRAKTUR";
            this.EVRAKTUR.Visible = true;
            this.EVRAKTUR.VisibleIndex = 1;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txt_Bakiye);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.txt_Cikis);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txt_Giris);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txt_KasaAdi);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txt_KasaKodu);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(655, 86);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Kasa Bilgileri";
            // 
            // txt_Bakiye
            // 
            this.txt_Bakiye.Location = new System.Drawing.Point(354, 49);
            this.txt_Bakiye.Name = "txt_Bakiye";
            this.txt_Bakiye.Properties.ReadOnly = true;
            this.txt_Bakiye.Size = new System.Drawing.Size(92, 20);
            this.txt_Bakiye.TabIndex = 1;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(313, 52);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(35, 13);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "Bakiye:";
            // 
            // txt_Cikis
            // 
            this.txt_Cikis.Location = new System.Drawing.Point(206, 49);
            this.txt_Cikis.Name = "txt_Cikis";
            this.txt_Cikis.Properties.ReadOnly = true;
            this.txt_Cikis.Size = new System.Drawing.Size(92, 20);
            this.txt_Cikis.TabIndex = 1;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(176, 52);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(25, 13);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Çıkış:";
            // 
            // txt_Giris
            // 
            this.txt_Giris.Location = new System.Drawing.Point(73, 49);
            this.txt_Giris.Name = "txt_Giris";
            this.txt_Giris.Properties.ReadOnly = true;
            this.txt_Giris.Size = new System.Drawing.Size(92, 20);
            this.txt_Giris.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(43, 52);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(24, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Giriş:";
            // 
            // txt_KasaAdi
            // 
            this.txt_KasaAdi.Location = new System.Drawing.Point(288, 23);
            this.txt_KasaAdi.Name = "txt_KasaAdi";
            this.txt_KasaAdi.Properties.ReadOnly = true;
            this.txt_KasaAdi.Size = new System.Drawing.Size(158, 20);
            this.txt_KasaAdi.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(237, 26);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(45, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Kasa Adı:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 26);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(54, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Kasa Kodu:";
            // 
            // txt_KasaKodu
            // 
            this.txt_KasaKodu.Location = new System.Drawing.Point(73, 23);
            this.txt_KasaKodu.Name = "txt_KasaKodu";
            this.txt_KasaKodu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txt_KasaKodu.Properties.ReadOnly = true;
            this.txt_KasaKodu.Size = new System.Drawing.Size(158, 20);
            this.txt_KasaKodu.TabIndex = 1;
            this.txt_KasaKodu.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.TextEdit1_ButtonClick);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridControl1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 86);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(655, 207);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Kasa Hareket Listesi";
            // 
            // gridControl1
            // 
            this.gridControl1.ContextMenuStrip = this.contextMenuStrip1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 20);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(651, 185);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxDevirKarti,
            this.ctxTahsilat});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(204, 48);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.ContextMenuStrip1_Opening);
            // 
            // ctxDevirKarti
            // 
            this.ctxDevirKarti.Enabled = false;
            this.ctxDevirKarti.Name = "ctxDevirKarti";
            this.ctxDevirKarti.Size = new System.Drawing.Size(203, 22);
            this.ctxDevirKarti.Text = "Devir Kartını Düzenle";
            this.ctxDevirKarti.Click += new System.EventHandler(this.CtxDevirKarti_Click);
            // 
            // ctxTahsilat
            // 
            this.ctxTahsilat.Enabled = false;
            this.ctxTahsilat.Name = "ctxTahsilat";
            this.ctxTahsilat.Size = new System.Drawing.Size(203, 22);
            this.ctxTahsilat.Text = "Tahsilat/Ödeme Düzenle";
            this.ctxTahsilat.Click += new System.EventHandler(this.CtxTahsilat_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.BELGENO,
            this.EVRAKTUR,
            this.GIRIS,
            this.CIKIS,
            this.ACIKLAMA,
            this.TARIH});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            // 
            // BELGENO
            // 
            this.BELGENO.Caption = "BELGE NO";
            this.BELGENO.FieldName = "BELGENO";
            this.BELGENO.Name = "BELGENO";
            this.BELGENO.Visible = true;
            this.BELGENO.VisibleIndex = 0;
            // 
            // GIRIS
            // 
            this.GIRIS.Caption = "GİRİŞ";
            this.GIRIS.FieldName = "GIRIS";
            this.GIRIS.Name = "GIRIS";
            this.GIRIS.Visible = true;
            this.GIRIS.VisibleIndex = 3;
            // 
            // CIKIS
            // 
            this.CIKIS.Caption = "ÇIKIŞ";
            this.CIKIS.FieldName = "CIKIS";
            this.CIKIS.Name = "CIKIS";
            this.CIKIS.Visible = true;
            this.CIKIS.VisibleIndex = 4;
            // 
            // ACIKLAMA
            // 
            this.ACIKLAMA.Caption = "AÇIKLAMA";
            this.ACIKLAMA.FieldName = "ACIKLAMA";
            this.ACIKLAMA.Name = "ACIKLAMA";
            this.ACIKLAMA.Visible = true;
            this.ACIKLAMA.VisibleIndex = 5;
            // 
            // TARIH
            // 
            this.TARIH.Caption = "TARİH";
            this.TARIH.FieldName = "TARIH";
            this.TARIH.Name = "TARIH";
            this.TARIH.Visible = true;
            this.TARIH.VisibleIndex = 2;
            // 
            // frm_KasaHareketleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 293);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_KasaHareketleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KasaHareketleri";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Bakiye.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Cikis.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Giris.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_KasaAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_KasaKodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txt_Bakiye;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txt_Cikis;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txt_Giris;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txt_KasaAdi;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ButtonEdit txt_KasaKodu;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ctxDevirKarti;
        private System.Windows.Forms.ToolStripMenuItem ctxTahsilat;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn BELGENO;
        private DevExpress.XtraGrid.Columns.GridColumn EVRAKTUR;
        private DevExpress.XtraGrid.Columns.GridColumn GIRIS;
        private DevExpress.XtraGrid.Columns.GridColumn CIKIS;
        private DevExpress.XtraGrid.Columns.GridColumn ACIKLAMA;
        private DevExpress.XtraGrid.Columns.GridColumn TARIH;
    }
}
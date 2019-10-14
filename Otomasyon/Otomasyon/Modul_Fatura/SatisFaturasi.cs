using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Reflection;
using DevExpress.XtraReports.UI;

namespace Otomasyon.Modul_Fatura
{
    public partial class frm_SatisFaturasi : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.StokDatabaseDataContext db = new Fonksiyonlar.StokDatabaseDataContext();
        Fonksiyonlar.FormYonetici formRouter = new Fonksiyonlar.FormYonetici();

        int CariID = -1;
        int OdemeID = -1;
        int FaturaID = -1;
        int IrsaliyeID = -1;
        string OdemeYeri = "";
        bool IrsaliyeAc = false;
        bool Edit = false;
        public frm_SatisFaturasi(bool ac, int ID, bool Irsaliye)
        {
            InitializeComponent();
            Edit = ac;
            if (Irsaliye) IrsaliyeID = ID;
            else FaturaID = ID;
            IrsaliyeAc = Irsaliye;
            this.Shown += Frm_SatisFaturasi_Shown;
        }

        private void Frm_SatisFaturasi_Shown(object sender, EventArgs e)
        {
            if (Edit) FaturaAc();
        }

        private void Btn_Guncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void Btn_Kaydet_Click(object sender, EventArgs e)
        {
            Kaydet();
        }

        

        private void Btn_Cikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Sil_Click(object sender, EventArgs e)
        {
        }

        private void Frm_SatisFaturasi_Load(object sender, EventArgs e)
        {
            txt_FaturaTarihi.Text = DateTime.Now.ToShortDateString();
            txt_IrsaliyeTarihi.Text = DateTime.Now.ToShortDateString();
        }

        
        void FaturaAc()
        {
            try
            {
                Fonksiyonlar.TBL_FATURALAR fatura = db.TBL_FATURALAR.First(t => t.FATURAID == FaturaID);
                IrsaliyeID = fatura.IRSALIYEID.Value;
                txt_Aciklama.Text = fatura.ACIKLAMA;
                txt_FaturaNo.Text = fatura.FATURANO;
                if (fatura.ODEMEYERIID > 0)
                {
                    txt_FaturaTuru.SelectedIndex = 1;
                    if (fatura.ODEMEYERI == "Kasa")
                    {
                        txt_OdemeYeri.SelectedIndex = 0;
                        Fonksiyonlar.TBL_KASALAR kasa = db.TBL_KASALAR.First(t => t.KASAID == fatura.ODEMEYERIID.Value);
                        txt_KasaAdi.Text = kasa.KASAADI;
                        txt_KasaKodu.Text = kasa.KASAKODU;
                    }
                    else if (fatura.ODEMEYERI == "Banka")
                    {
                        txt_OdemeYeri.SelectedIndex = 1;
                        Fonksiyonlar.TBL_BANKALAR banka = db.TBL_BANKALAR.First(t => t.BANKAID == fatura.ODEMEYERIID.Value);
                        txt_HesapAdi.Text = banka.HESAPADI;
                        txt_HesapNo.Text = banka.HESAPNO;
                    }
                    OdemeYeri = fatura.ODEMEYERI;
                    OdemeID = fatura.ODEMEYERIID.Value;

                }
                else if (fatura.ODEMEYERIID < 1) txt_FaturaTuru.SelectedIndex = 0;
                txt_IrsaliyeNo.Text = db.TBL_IRSALIYELER.First(t => t.IRSALIYEID == fatura.IRSALIYEID).IRSALIYENO;
                txt_IrsaliyeTarihi.EditValue = db.TBL_IRSALIYELER.First(t => t.IRSALIYEID == fatura.IRSALIYEID).TARIHI.Value.ToShortDateString();
                Fonksiyonlar.TBL_CARILER cari = db.TBL_CARILER.First(t => t.CARIKODU == fatura.CARIKODU);
                txt_CariAdi.Text = cari.CARIADI;
                txt_CariKodu.Text = cari.CARIKODU;
                txt_FaturaTarihi.EditValue = fatura.TARIHI.Value.ToShortDateString();

                var sorgu = from t in db.VW_KALEMLER
                            where t.FATURAID == FaturaID
                            select t;

                foreach (Fonksiyonlar.VW_KALEMLER kalem in sorgu)
                {
                    gridView1.AddNewRow();
                    gridView1.SetFocusedRowCellValue("MIKTAR", kalem.MIKTAR);
                    gridView1.SetFocusedRowCellValue("BIRIMFIYAT", kalem.BIRIMFIYAT);
                    gridView1.SetFocusedRowCellValue("KDV", kalem.KDV);
                    gridView1.SetFocusedRowCellValue("BARKOD",kalem.STOKBARKOD);
                    gridView1.SetFocusedRowCellValue("STOKKODU",kalem.STOKKODU);
                    gridView1.SetFocusedRowCellValue("STOKADI",kalem.STOKADI);
                    gridView1.SetFocusedRowCellValue("BIRIM",kalem.STOKBIRIM);
                    gridView1.UpdateCurrentRow();
                }

                btn_Guncelle.Enabled = true;
                btn_Sil.Enabled = true;
            }
            catch (Exception err)
            {
                Fonksiyonlar.Mesajlar.HataMesaj(err);
            }
        }
        void Hesapla()
        {
            try
            {
                decimal BirimFiyat = 0, Miktar = 0, GenelToplam = 0, AraToplam = 0, KDV = 0;
                for (int i = 0; i < gridView1.RowCount; i++)
                {
                    BirimFiyat = decimal.Parse(gridView1.GetRowCellValue(i, "BIRIMFIYAT").ToString());
                    Miktar = decimal.Parse(gridView1.GetRowCellValue(i, "MIKTAR").ToString());
                    KDV = decimal.Parse(gridView1.GetRowCellValue(i, "KDV").ToString()) / 100 + 1;
                    AraToplam += Miktar * BirimFiyat;
                    GenelToplam += decimal.Parse(gridView1.GetRowCellValue(i, "TOPLAM").ToString()) * KDV;
                }

                txt_AraToplam.Text = AraToplam.ToString("0.00");
                txt_KDV.Text = (GenelToplam - AraToplam).ToString("0.00");
                txt_GenelToplam.Text = GenelToplam.ToString("0.00");
            }
            catch (Exception err)
            {
                Fonksiyonlar.Mesajlar.HataMesaj(err);
            }
        }


        private void Txt_CariKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int id;
            formRouter.CariListesiAc(true);
            id = frm_Anasayfa.AktarilanID;
            if (id > -1)
                CariAc(id);
            frm_Anasayfa.AktarilanID = -1;

        }

        void CariAc(int ID)
        {
            try
            {
                CariID = ID;
                Fonksiyonlar.TBL_CARILER cari = db.TBL_CARILER.First(t => t.CARIID == CariID);
                txt_CariKodu.Text = cari.CARIKODU;
                txt_CariAdi.Text = cari.CARIADI;
            }
            catch (Exception err)
            {
                Fonksiyonlar.Mesajlar.HataMesaj(err);
            }
        }

        private void Txt_FaturaTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txt_FaturaTuru.SelectedIndex == 0)
            {
                pnl_HesapYeri.Enabled = false;
                txt_OdemeYeri.Enabled = false;
            }
            if (txt_FaturaTuru.SelectedIndex == 1)
            {
                pnl_HesapYeri.Enabled = true;
                txt_OdemeYeri.Enabled = true;
            }
        }

        private void Txt_OdemeYeri_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txt_OdemeYeri.SelectedIndex == 0)
            {
                txt_HesapAdi.Enabled = false;
                txt_HesapNo.Enabled = false;
                txt_KasaAdi.Enabled = true;
                txt_KasaKodu.Enabled = true;
            }
            if (txt_OdemeYeri.SelectedIndex == 1)
            {
                txt_HesapAdi.Enabled = true;
                txt_HesapNo.Enabled = true;
                txt_KasaKodu.Enabled = false;
                txt_KasaAdi.Enabled = false;
            }
            OdemeYeri = txt_OdemeYeri.Text;

        }

        void Kaydet()
        {
            try
            {
                Fonksiyonlar.TBL_FATURALAR fatura = new Fonksiyonlar.TBL_FATURALAR();
                fatura.ACIKLAMA = txt_Aciklama.Text;
                fatura.CARIKODU = txt_CariKodu.Text;
                fatura.FATURANO = txt_FaturaNo.Text;
                fatura.FATURATURU = "Satış Faturası";
                fatura.GENELTOPLAM = decimal.Parse(txt_GenelToplam.Text);
                fatura.IRSALIYEID = IrsaliyeID;
                fatura.ODEMEYERI = OdemeYeri;
                fatura.ODEMEYERIID = OdemeID;
                fatura.TARIHI = DateTime.Parse(txt_FaturaTarihi.Text);
                fatura.SAVEDATE = DateTime.Now;
                fatura.SAVEUSER = frm_Anasayfa.userID;

                if (Fonksiyonlar.Mesajlar.OnayMesaj() == DialogResult.Yes)
                {
                    db.TBL_FATURALAR.InsertOnSubmit(fatura);
                    db.SubmitChanges();
                    FaturaID = fatura.FATURAID;

                    if(IrsaliyeID < 0)
                    {
                        Fonksiyonlar.TBL_IRSALIYELER irsaliye = new Fonksiyonlar.TBL_IRSALIYELER();
                        irsaliye.ACIKLAMA = txt_Aciklama.Text;
                        irsaliye.CARIKODU = txt_CariKodu.Text;
                        irsaliye.FATURAID = fatura.FATURAID;
                        irsaliye.IRSALIYENO = txt_IrsaliyeNo.Text;
                        irsaliye.TARIHI = DateTime.Parse(txt_IrsaliyeTarihi.Text);
                        irsaliye.SAVEDATE = DateTime.Now;
                        irsaliye.SAVEUSER = frm_Anasayfa.userID;
                        db.TBL_IRSALIYELER.InsertOnSubmit(irsaliye);
                        db.SubmitChanges();
                        IrsaliyeID = irsaliye.IRSALIYEID;
                    }

                    Fonksiyonlar.TBL_STOKHAREKETLERI[] stokHareketi = new Fonksiyonlar.TBL_STOKHAREKETLERI[gridView1.RowCount];
                    for (int i = 0; i < gridView1.RowCount; i++)
                    {
                        stokHareketi[i] = new Fonksiyonlar.TBL_STOKHAREKETLERI();
                        stokHareketi[i].BIRIMFIYAT = decimal.Parse(gridView1.GetRowCellValue(i, "BIRIMFIYAT").ToString());
                        stokHareketi[i].FATURAID = fatura.FATURAID;
                        stokHareketi[i].GCKODU = "C";
                        stokHareketi[i].IRSALIYEID = IrsaliyeID;
                        stokHareketi[i].KDV = decimal.Parse(gridView1.GetRowCellValue(i, "KDV").ToString());
                        stokHareketi[i].MIKTAR = int.Parse(gridView1.GetRowCellValue(i, "MIKTAR").ToString());
                        stokHareketi[i].STOKKODU = gridView1.GetRowCellValue(i, "STOKKODU").ToString();
                        stokHareketi[i].TIPI = "Satış Faturası";
                        stokHareketi[i].SAVEDATE = DateTime.Now;
                        stokHareketi[i].SAVEUSER = frm_Anasayfa.userID;
                        db.TBL_STOKHAREKETLERI.InsertOnSubmit(stokHareketi[i]);

                    }
                    db.SubmitChanges();

                    Fonksiyonlar.TBL_CARIHAREKETLERI cariHareket = new Fonksiyonlar.TBL_CARIHAREKETLERI();
                    cariHareket.ACIKLAMA = txt_FaturaNo.Text + " no'lu satış faturası tutarı";
                    if (txt_FaturaTuru.SelectedIndex == 0)
                    {
                        cariHareket.ALACAK = 0;
                        cariHareket.BORC = decimal.Parse(txt_GenelToplam.Text);
                    }
                    else if (txt_FaturaTuru.SelectedIndex == 1)
                    {
                        cariHareket.ALACAK = decimal.Parse(txt_GenelToplam.Text);
                        cariHareket.BORC = 0;
                    }
                    cariHareket.CARIID = CariID;
                    cariHareket.TARIH = DateTime.Now;
                    cariHareket.TIP = "SF";
                    cariHareket.EVRAKTURU = "Satış Faturası";
                    cariHareket.EVRAKID = fatura.FATURAID;
                    cariHareket.SAVEDATE = DateTime.Now;
                    cariHareket.SAVEUSER = frm_Anasayfa.userID;
                    db.TBL_CARIHAREKETLERI.InsertOnSubmit(cariHareket);
                    db.SubmitChanges();
                    Fonksiyonlar.Mesajlar.MesajGoster("Kaydetme işlemi başarılı.");
                    Temizle();
                }
            }
            catch (Exception err)
            {
                Fonksiyonlar.Mesajlar.HataMesaj(err);
            }
        }

        void Guncelle()
        {
            try
            {
                Fonksiyonlar.TBL_FATURALAR fatura = db.TBL_FATURALAR.First(t => t.FATURAID == FaturaID);
                fatura.FATURANO = txt_FaturaNo.Text;
                fatura.ACIKLAMA = txt_Aciklama.Text;
                fatura.CARIKODU = txt_CariKodu.Text;
                fatura.GENELTOPLAM = decimal.Parse(txt_GenelToplam.Text);
                fatura.ODEMEYERI = OdemeYeri;
                fatura.ODEMEYERIID = OdemeID;
                fatura.EDITDATE = DateTime.Now;
                fatura.EDITUSER = frm_Anasayfa.userID;

                if (Fonksiyonlar.Mesajlar.OnayMesaj() == DialogResult.Yes)
                {
                    db.SubmitChanges();
                    Fonksiyonlar.TBL_IRSALIYELER irsaliye = db.TBL_IRSALIYELER.First(t => t.IRSALIYEID == IrsaliyeID);
                    irsaliye.IRSALIYENO = txt_IrsaliyeNo.Text;
                    irsaliye.TARIHI = DateTime.Parse(txt_IrsaliyeTarihi.SelectedText);
                    irsaliye.EDITDATE = DateTime.Now;
                    irsaliye.EDITUSER = frm_Anasayfa.userID;
                    db.TBL_STOKHAREKETLERI.DeleteAllOnSubmit(db.TBL_STOKHAREKETLERI.Where(t => t.FATURAID == FaturaID));
                    db.SubmitChanges();
                    Fonksiyonlar.TBL_STOKHAREKETLERI[] stokHareketleri = new Fonksiyonlar.TBL_STOKHAREKETLERI[gridView1.RowCount];
                    for (int i = 0; i < gridView1.RowCount; i++)
                    {
                        stokHareketleri[i] = new Fonksiyonlar.TBL_STOKHAREKETLERI();
                        stokHareketleri[i].FATURAID = FaturaID;
                        stokHareketleri[i].BIRIMFIYAT = decimal.Parse(gridView1.GetRowCellValue(i, "BIRIMFIYAT").ToString());
                        stokHareketleri[i].GCKODU = "C";
                        stokHareketleri[i].IRSALIYEID = IrsaliyeID;
                        stokHareketleri[i].KDV = decimal.Parse(gridView1.GetRowCellValue(i, "KDV").ToString());
                        stokHareketleri[i].MIKTAR = int.Parse(gridView1.GetRowCellValue(i, "MIKTAR").ToString());
                        stokHareketleri[i].STOKKODU = gridView1.GetRowCellValue(i, "STOKKODU").ToString();
                        stokHareketleri[i].TIPI = "Satış Faturası";
                        stokHareketleri[i].SAVEDATE = DateTime.Now;
                        stokHareketleri[i].SAVEUSER = frm_Anasayfa.userID;
                        db.TBL_STOKHAREKETLERI.InsertOnSubmit(stokHareketleri[i]);
                    }
                    db.SubmitChanges();
                    Fonksiyonlar.TBL_CARIHAREKETLERI cariHareket = db.TBL_CARIHAREKETLERI.First(t => t.EVRAKTURU == "Satış Faturası" && t.EVRAKID == FaturaID);
                    if (txt_FaturaTuru.SelectedIndex == 0)
                    {
                        cariHareket.ALACAK = 0;
                        cariHareket.BORC = decimal.Parse(txt_GenelToplam.Text);
                    }
                    else if (txt_FaturaTuru.SelectedIndex == 1)
                    {
                        cariHareket.BORC = decimal.Parse(txt_GenelToplam.Text);
                        cariHareket.ALACAK = decimal.Parse(txt_GenelToplam.Text);
                    }
                    cariHareket.EDITDATE = DateTime.Now;
                    cariHareket.EDITUSER = frm_Anasayfa.userID;
                    db.SubmitChanges();
                    Temizle();
                }
            }
            catch (Exception err)
            {
                Fonksiyonlar.Mesajlar.HataMesaj(err);
            }
        }
        void Temizle()
        {
            txt_CariKodu.Text = "";
            txt_CariAdi.Text = "";
            txt_FaturaNo.Text = "";
            txt_IrsaliyeNo.Text = "";
            txt_HesapNo.Text = "";
            txt_HesapAdi.Text = "";
            txt_KasaKodu.Text = "";
            txt_KasaAdi.Text = "";
            txt_FaturaTarihi.Text = DateTime.Now.ToShortDateString();
            txt_IrsaliyeTarihi.Text = DateTime.Now.ToShortDateString();
            txt_FaturaTuru.SelectedIndex = 0;
            txt_OdemeYeri.SelectedIndex = 0;
            txt_KDV.Text = "0";
            txt_GenelToplam.Text = "0";
            txt_AraToplam.Text = "0";
            txt_Aciklama.Text = "";
            CariID = -1;
            OdemeID = -1;
            FaturaID = -1;
            IrsaliyeID = -1;
            frm_Anasayfa.AktarilanID = -1;
            OdemeYeri = "";
            btn_Guncelle.Enabled = false;
            btn_Sil.Enabled = false;
            for (int i = gridView1.RowCount; i > -1 ; i--)
            {
                gridView1.DeleteRow(i);
            }
        }



        private void Btn_StokAc_ButtonClick_1(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            StokAc();
        }

        void StokAc()
        {
            try
            {
                int StokID;
                formRouter.StokListesiAc(true);
                StokID = frm_Anasayfa.AktarilanID;

                if (StokID > -1)
                {
                    Fonksiyonlar.TBL_STOKLAR stok = db.TBL_STOKLAR.First(t => t.STOKID == StokID);
                    gridView1.AddNewRow();
                    gridView1.SetFocusedRowCellValue("BARKOD", stok.STOKBARKOD);
                    gridView1.SetFocusedRowCellValue("STOKKODU", stok.STOKKODU);
                    gridView1.SetFocusedRowCellValue("STOKADI", stok.STOKADI);
                    gridView1.SetFocusedRowCellValue("BIRIM", stok.STOKBIRIM);
                    gridView1.SetFocusedRowCellValue("FIYAT", stok.STOKSATISFIYAT);
                    gridView1.SetFocusedRowCellValue("KDV", stok.STOKKDV);
                    gridView1.SetFocusedRowCellValue("MIKTAR", 0);
                    gridView1.SetFocusedRowCellValue("BIRIMFIYAT", 0);
                }
                frm_Anasayfa.AktarilanID = -1;
            }
            catch (Exception err)
            {
                Fonksiyonlar.Mesajlar.HataMesaj(err);
            }
        }

        private void GridView1_RowCountChanged(object sender, EventArgs e)
        {
            Hesapla();
        }

        private void GridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                decimal Miktar = 0, BirimFiyat = 0, Toplam = 0;

                if (e.Column.Name != "colTOPLAM")
                {
                    if (gridView1.GetFocusedRowCellValue("MIKTAR").ToString() != "") Miktar = decimal.Parse(gridView1.GetFocusedRowCellValue("MIKTAR").ToString());
                    if (gridView1.GetFocusedRowCellValue("BIRIMFIYAT").ToString() != "")
                    {
                        BirimFiyat = decimal.Parse(gridView1.GetFocusedRowCellValue("BIRIMFIYAT").ToString());
                        Toplam = Miktar * BirimFiyat;
                        gridView1.SetFocusedRowCellValue("TOPLAM", Toplam.ToString());
                    }
                    Hesapla();
                }
            }
            catch (Exception err)
            {
                Fonksiyonlar.Mesajlar.HataMesaj(err);
            }
        }

        private void Txt_OdemeYeri_EnabledChanged(object sender, EventArgs e)
        {
            if (txt_OdemeYeri.Enabled)
                OdemeYeri = txt_OdemeYeri.Text;
            else if (!txt_OdemeYeri.Enabled)
                OdemeYeri = "";
        }

        private void Btn_FaturaYazdir_Click(object sender, EventArgs e)
        {
            var sorgu = db.VW_FATURALAR.Where(t => t.FATURANO == txt_FaturaNo.Text);
            DataSet ds = new DataSet();
            ds.Tables.Add(LINQToDataTable(sorgu));

            rprSatisFaturasi rpr = new rprSatisFaturasi();
            rpr.DataSource = ds;
            rpr.ShowPreview();
        }

        public DataTable LINQToDataTable<T>(IEnumerable<T> Lnqlst)
        {
            DataTable dt = new DataTable();


            PropertyInfo[] columns = null;

            if (Lnqlst == null) return dt;

            foreach (T Record in Lnqlst)
            {

                if (columns == null)
                {
                    columns = ((Type)Record.GetType()).GetProperties();
                    foreach (PropertyInfo GetProperty in columns)
                    {
                        Type colType = GetProperty.PropertyType;

                        if ((colType.IsGenericType) && (colType.GetGenericTypeDefinition()
                        == typeof(Nullable<>)))
                        {
                            colType = colType.GetGenericArguments()[0];
                        }

                        dt.Columns.Add(new DataColumn(GetProperty.Name, colType));
                    }
                }

                DataRow dr = dt.NewRow();

                foreach (PropertyInfo pinfo in columns)
                {
                    dr[pinfo.Name] = pinfo.GetValue(Record, null) == null ? DBNull.Value : pinfo.GetValue
                    (Record, null);
                }

                dt.Rows.Add(dr);
            }
            return dt;
        }
    }
}
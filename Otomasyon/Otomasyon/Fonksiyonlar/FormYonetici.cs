using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Otomasyon.Fonksiyonlar
{
    class FormYonetici
    {
        public void StokListesiAc(bool secim)
        {
            StokModul.frm_StokListesi form = new StokModul.frm_StokListesi();
            form.secim = secim;
            if (secim == false)
            {
                form.MdiParent = frm_Anasayfa.ActiveForm;
                form.Show();
            }
            else
            {
                form.ShowDialog();
            }
        }

        public void StokGrupListesiAc(bool secim)
        {
            StokModul.frm_StokGruplari form = new StokModul.frm_StokGruplari();
            form.secim = secim;
            form.ShowDialog();
        }

        public void StokKartiAc()
        {
            StokModul.frm_StokKarti form = new StokModul.frm_StokKarti();
            form.ShowDialog();
        }

        public void CariGrupListesiAc(bool secim)
        {
            CariModul.frm_CariGruplari form = new CariModul.frm_CariGruplari();
            form.secim = secim;
            form.ShowDialog();
        }

        public void CariKartiAc()
        {
            CariModul.frm_CariKarti form = new CariModul.frm_CariKarti();
            form.ShowDialog();
        }

        public void CariListesiAc(bool secim)
        {
            CariModul.frm_CariListesi form = new CariModul.frm_CariListesi();
            form.secim = secim;
            if (secim == false)
            {
                form.MdiParent = frm_Anasayfa.ActiveForm;
                form.Show();
            }
            else
            {
                form.ShowDialog();
            }
        }

        public void BankaKartiAc()
        {
            BankaModul.frm_BankaKarti form = new BankaModul.frm_BankaKarti();
            form.ShowDialog();
        }

        public void BankaListesiAc(bool secim)
        {
            BankaModul.frm_BankaListesi form = new BankaModul.frm_BankaListesi();
            form.secim = secim;
            if (secim == false)
            {
                form.MdiParent = frm_Anasayfa.ActiveForm;
                form.Show();
            }
            else
            {
                form.secim = secim;
                form.ShowDialog();
            }
        }
        
        public void BankaIslemAc(bool ac, int ID)
        {
            BankaModul.frm_BankaIslem form = new BankaModul.frm_BankaIslem();
            if (ac) form.Ac(ID);
            form.ShowDialog();
        }

        public void BankaParaTransferAc(bool ac, int ID)
        {
            BankaModul.frm_ParaTransferi form = new BankaModul.frm_ParaTransferi();
            if (ac) form.Ac(ID);
            form.ShowDialog();
        }

        public void BankaHareketleriAc(bool ac, int ID)
        {
            Modul_Banka.frm_BankaHareketleri form = new Modul_Banka.frm_BankaHareketleri();
            form.MdiParent = frm_Anasayfa.ActiveForm;
            if (ac) form.BankaAc(ID);
            form.Show();
        }

        public void KasaKartiAc()
        {
            KasaModul.frm_KasaKarti form = new KasaModul.frm_KasaKarti();
            form.ShowDialog();
        }

        public void KasaListesiAc(bool secim)
        {
            KasaModul.frm_KasaListesi form = new KasaModul.frm_KasaListesi();
            form.Secim = secim;
            if (secim == false)
            {
                form.MdiParent = frm_Anasayfa.ActiveForm;
                form.Show();
            }
            else
            {
                form.ShowDialog();
            }
        }

        public void KasaDevirIslemAc(bool secim, int hareketID)
        {
            KasaModul.frm_KasaDevirIslem form = new KasaModul.frm_KasaDevirIslem();
            form.secim = secim;
            if (secim)
                form.Ac(hareketID);
            form.ShowDialog();
        }

        public void KasaTahsilatOdemeAc(bool secim, int kasaHareketID)
        {
            KasaModul.frm_KasaTahsilatOdeme form = new KasaModul.frm_KasaTahsilatOdeme();
            form.secim = secim;
            if (secim)
                form.Ac(kasaHareketID);
            form.ShowDialog();
        }

        public void KasaHareketleriAc(bool secim)
        {
            Modul_Kasa.frm_KasaHareketleri form = new Modul_Kasa.frm_KasaHareketleri();
            form.secim = secim;
            if (secim == false)
            {
                form.MdiParent = frm_Anasayfa.ActiveForm;
                form.Show();
            }
            else
            {
                form.ShowDialog();
            }
        }

        public void KullaniciCekAc(bool ac, int ID)
        {
            Modul_Cek.frm_KullaniciCek form = new Modul_Cek.frm_KullaniciCek();

            if (ac) form.Ac(ID);
            form.ShowDialog();
        }

        public void MusteriCekAc(bool ac, int ID)
        {
            Modul_Cek.frm_MusteriCek form = new Modul_Cek.frm_MusteriCek();

            if (ac) form.Ac(ID);
            form.ShowDialog();
        }

        public void CariyeCekCikisiAc()
        {
            Modul_Cek.frm_CariyeCekCikisi form = new Modul_Cek.frm_CariyeCekCikisi();
            form.ShowDialog();
        }

        public void BankayaCekCikisiAc()
        {
            Modul_Cek.frm_BankayaCekCikisi form = new Modul_Cek.frm_BankayaCekCikisi();
            form.ShowDialog();
        }

        public void CekListesiAc(bool secim)
        {
            Modul_Cek.frm_CekListesi form = new Modul_Cek.frm_CekListesi();
            form.secim = secim;
            if (secim)
            {
                form.ShowDialog();
            }
            else
            {
                form.MdiParent = frm_Anasayfa.ActiveForm;
                form.Show();
            }
        }

        public void SatisFaturasiAc(bool secim, int ID, bool Irsaliye)
        {
            Modul_Fatura.frm_SatisFaturasi form = new Modul_Fatura.frm_SatisFaturasi(secim,ID,Irsaliye);
            if (secim)
            {
                form.ShowDialog();
            }
            else
            {
                form.MdiParent = frm_Anasayfa.ActiveForm;
                form.Show();
            }
        }

        public void FaturaListesiAc(bool secim)
        {
            Modul_Fatura.frm_FaturaListesi form = new Modul_Fatura.frm_FaturaListesi(secim);
            if (secim)
                form.ShowDialog();
            else
            {
                form.MdiParent = frm_Anasayfa.ActiveForm;
                form.Show();
            }

        }

        public void KullaniciYonetimAc()
        {
            Modul_Kullanici.frm_KullaniciYonetim form = new Modul_Kullanici.frm_KullaniciYonetim();
            form.ShowDialog();
        }

        public void KullaniciPaneliAc(bool ac, int ID)
        {
            Modul_Kullanici.frm_KullaniciPaneli form = new Modul_Kullanici.frm_KullaniciPaneli(ID, ac);
            form.ShowDialog();
        }
    }
}

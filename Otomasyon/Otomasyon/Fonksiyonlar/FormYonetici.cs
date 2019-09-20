using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}

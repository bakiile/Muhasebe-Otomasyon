using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otomasyon.Fonksiyonlar
{
    class FormYonetici
    {
        public static void StokListesiAc(bool secim)
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

        public static void StokGrupListesiAc(bool secim)
        {
            StokModul.frm_StokGruplari form = new StokModul.frm_StokGruplari();
            form.secim = secim;
            form.ShowDialog();
        }

        public static void StokKartiAc()
        {
            StokModul.frm_StokKarti form = new StokModul.frm_StokKarti();
            form.ShowDialog();
        }

        public static void CariGrupListesiAc(bool secim)
        {
            CariModul.frm_CariGruplari form = new CariModul.frm_CariGruplari();
            form.secim = secim;
            form.ShowDialog();
        }

        public static void CariKartiAc()
        {
            CariModul.frm_CariKarti form = new CariModul.frm_CariKarti();
            form.ShowDialog();
        }

        public static void CariListesiAc(bool secim)
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

        public static void BankaKartiAc()
        {
            BankaModul.frm_BankaKarti form = new BankaModul.frm_BankaKarti();
            form.ShowDialog();
        }

        public static void KasaKartiAc()
        {
            KasaModul.frm_KasaKarti form = new KasaModul.frm_KasaKarti();
            form.ShowDialog();
        }

        public static void KasaListesiAc(bool secim)
        {
            KasaModul.frm_KasaListesi form = new KasaModul.frm_KasaListesi();
            form.Secim = secim;
            form.ShowDialog();
        }
    }
}

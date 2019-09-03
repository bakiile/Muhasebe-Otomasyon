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

        public static void GrupListesiAc(bool secim)
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
    }
}

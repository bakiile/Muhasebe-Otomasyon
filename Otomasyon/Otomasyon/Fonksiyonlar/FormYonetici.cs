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
            StokModul.frm_StokListesi frm = new StokModul.frm_StokListesi();
            if (secim == false)
            {
                frm.MdiParent = frm_Anasayfa.ActiveForm;
                frm.Show();
            }
            else
            {
                frm.ShowDialog();
            }
        }

        public void GrupListesiAc(bool secim)
        {
            StokModul.frm_StokGruplari form = new StokModul.frm_StokGruplari();
            form.secim = secim;
            form.ShowDialog();
        }
    }
}

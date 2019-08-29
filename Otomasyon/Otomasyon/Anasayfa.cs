using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Otomasyon
{
    public partial class frm_Anasayfa : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frm_Anasayfa()
        {
            InitializeComponent();
        }

        private void Btn_StokListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool secim = false;

            StokModul.frm_StokListesi frm = new StokModul.frm_StokListesi();
            if (secim)
            {
                frm.MdiParent = frm_Anasayfa.ActiveForm;
                frm.Show();
            }
            else
            {
                frm.ShowDialog();
            }
            
        }
    }
}

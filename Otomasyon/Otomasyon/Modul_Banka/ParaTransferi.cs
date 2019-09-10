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

namespace Otomasyon.BankaModul
{
    public partial class frm_ParaTransferi : DevExpress.XtraEditors.XtraForm
    {
        string islemTuru = "Banka Havale";
        public frm_ParaTransferi()
        {
            InitializeComponent();
        }

        private void Txt_TransferTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txt_TransferTuru.SelectedIndex == 0)
            {
                radioButton1.Text = "Gelen Havale";
                radioButton2.Text = "Giden Havale";
                islemTuru = "Banka Havale";
            }
            else if (txt_TransferTuru.SelectedIndex == 1)
            {
                radioButton1.Text = "Gelen EFT";
                radioButton2.Text = "Giden EFT";
                islemTuru = "Banka EFT";
            }
        }

    
    }
}
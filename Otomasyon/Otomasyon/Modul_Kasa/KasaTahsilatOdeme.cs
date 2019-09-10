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

namespace Otomasyon.KasaModul
{
    public partial class frm_KasaTahsilatOdeme : DevExpress.XtraEditors.XtraForm
    {
        string islemTuru = "Kasa Tahsilat";
        public frm_KasaTahsilatOdeme()
        {
            InitializeComponent();
        }

        private void Txt_IslemTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            islemTuru = txt_IslemTuru.SelectedItem.ToString();
        }
    }
}
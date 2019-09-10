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
    public partial class frm_KasaDevirIslem : DevExpress.XtraEditors.XtraForm
    {
        public frm_KasaDevirIslem()
        {
            InitializeComponent();
        }

        private void Frm_KasaDevirIslem_Load(object sender, EventArgs e)
        {
            txt_Tarih.Text = DateTime.Now.ToShortDateString();
        }
    }
}
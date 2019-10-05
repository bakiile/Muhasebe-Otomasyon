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

namespace Otomasyon
{
    public partial class frm_Login : DevExpress.XtraEditors.XtraForm
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void Btn_Giris_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Anasayfa form = new frm_Anasayfa();
            form.Show();
        }

        private void Btn_BaglantiAyar_Click(object sender, EventArgs e)
        {
            frm_BaglantiAyar form = new frm_BaglantiAyar();
            form.Show();
        }
    }
}
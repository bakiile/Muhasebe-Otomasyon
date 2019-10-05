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
    public partial class frm_BaglantiAyar : DevExpress.XtraEditors.XtraForm
    {
        public frm_BaglantiAyar()
        {
            InitializeComponent();
        }

        private void Chk_YeniGiris_CheckedChanged(object sender, EventArgs e)
        {
            txt_VeriTabani.Enabled = !txt_VeriTabani.Enabled;
            txt_Sifre.Enabled = !txt_Sifre.Enabled;
            txt_Sunucu.Enabled = !txt_Sunucu.Enabled;
            txt_KullaniciID.Enabled = !txt_KullaniciID.Enabled;
            btn_YeniAyar.Enabled = !btn_YeniAyar.Enabled;
        }

        private void Btn_YeniAyar_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.cs_Server = txt_Sunucu.Text.Trim() + ";";
            Properties.Settings.Default.cs_Database = txt_VeriTabani.Text.Trim() + ";";
            Properties.Settings.Default.cs_UserID = txt_KullaniciID.Text.Trim() + ";";
            Properties.Settings.Default.cs_Password = txt_Sifre.Text.Trim() + ";";
            Properties.Settings.Default.Database = txt_VeriTabani.Text.Trim();
            Properties.Settings.Default.Save();
            //Application.Restart();
            this.Close();
        }

        private void Frm_BaglantiAyar_Load(object sender, EventArgs e)
        {
            labelControl6.Text = Properties.Settings.Default.cs1 + Properties.Settings.Default.cs_Server + Properties.Settings.Default.cs2 +
                Properties.Settings.Default.cs_Database + Properties.Settings.Default.cs3 + Properties.Settings.Default.cs_UserID + Properties.Settings.Default.cs4 +
                Properties.Settings.Default.cs_Password;
        }
    }
}
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
        Fonksiyonlar.StokDatabaseDataContext db = new Fonksiyonlar.StokDatabaseDataContext();
        public frm_Login()
        {
            InitializeComponent();
            txt_KullaniciAdi.Focus();
        }

        private void Btn_Giris_Click(object sender, EventArgs e)
        {
            try
            {
                Fonksiyonlar.TBL_KULLANICILAR girisKullanici = db.TBL_KULLANICILAR.First(t => t.KULLANICIADI == txt_KullaniciAdi.Text.Trim() && t.SIFRE == txt_Sifre.Text.Trim());
                girisKullanici.LASTLOGIN = DateTime.Now;
                db.SubmitChanges();
                this.Hide();
                frm_Anasayfa form = new frm_Anasayfa(girisKullanici);
                form.Show();

            }
            catch (Exception err)
            {
                Fonksiyonlar.Mesajlar.MesajGoster("Kullanıcı adı ya da şifre geçersiz.");
            }
        }

        private void Btn_BaglantiAyar_Click(object sender, EventArgs e)
        {
            frm_BaglantiAyar form = new frm_BaglantiAyar();
            form.Show();
        }
    }
}
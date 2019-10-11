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

namespace Otomasyon.Modul_Kullanici
{
    public partial class frm_KullaniciPaneli : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.StokDatabaseDataContext db = new Fonksiyonlar.StokDatabaseDataContext();
        bool ac = false;
        int KullaniciID = -1;
        public frm_KullaniciPaneli(int ID, bool AC)
        {
            InitializeComponent();
            ac = AC;
            KullaniciID = ID;
            if (ac)
            {
                KullaniciAc(ID);
                txt_KullaniciAdi.Enabled = false;
            }
        }

        private void Btn_Kaydet_Click(object sender, EventArgs e)
        {
            Kaydet();
        }

        private void Btn_Temizle_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Kapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void Kaydet()
        {
            try
            {
                if (txt_Sifre.Text.Trim() == txt_SifreTekrar.Text.Trim())
                {
                    if (txt_Isim.Text == "")
                    {
                        Fonksiyonlar.Mesajlar.MesajGoster("İsim boş bırakılamaz");
                        return;
                    }
                    else if(txt_Soyisim.Text == "")
                    {
                        Fonksiyonlar.Mesajlar.MesajGoster("Soyisim boş bırakılamaz");
                        return;
                    }
                    else if (txt_KullaniciAdi.Text == "")
                    {
                        Fonksiyonlar.Mesajlar.MesajGoster("Kullanıcı adı boş bırakılamaz");
                        return;
                    }
                    else if (txt_Sifre.Text == "")
                    {
                        Fonksiyonlar.Mesajlar.MesajGoster("Şifre boş bırakılamaz");
                        return;
                    }

                    DialogResult dr = MessageBox.Show(txt_KullaniciTuru.Text + " türünde bir kullanıcı oluşturmayı onaylıyor musunuz?", "Kullanıcı Kaydı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == System.Windows.Forms.DialogResult.Yes)
                    {
                        try
                        {
                            if (!ac)
                            {
                                if (db.TBL_KULLANICILAR.Where(t => t.KULLANICIADI == txt_KullaniciAdi.Text).Count() > 0)
                                {
                                    Fonksiyonlar.Mesajlar.MesajGoster("Böyle bir kullanıcı zaten mevcut..");
                                    return;
                                } 
                            }
                            Fonksiyonlar.TBL_KULLANICILAR Kullanici;
                            if (!ac) Kullanici = new Fonksiyonlar.TBL_KULLANICILAR();
                            else Kullanici = db.TBL_KULLANICILAR.First(t => t.ID == KullaniciID);
                            if (rBtn_Aktif.Checked) Kullanici.AKTIF = true;
                            if (rBtn_Pasif.Checked) Kullanici.AKTIF = false;
                            Kullanici.ISIM = txt_Isim.Text;
                            Kullanici.SOYISIM = txt_Soyisim.Text;
                            Kullanici.SIFRE = txt_Sifre.Text;
                            Kullanici.KULLANICIADI = txt_KullaniciAdi.Text;
                            Kullanici.KODU = txt_KullaniciTuru.Text;
                            if (ac) Kullanici.EDITDATE = DateTime.Now;
                            else Kullanici.SAVEDATE = DateTime.Now;
                            if (!ac) db.TBL_KULLANICILAR.InsertOnSubmit(Kullanici);
                            db.SubmitChanges();
                            if (!ac) Fonksiyonlar.Mesajlar.MesajGoster(txt_KullaniciAdi.Text + " kullanıcı başarıyla kaydedilmiştir.");
                            else Fonksiyonlar.Mesajlar.MesajGoster(txt_KullaniciAdi.Text + " kullanıcı başarıyla güncellenmiştir.");
                            this.Close();
                        }
                        catch (Exception err)
                        {
                            Fonksiyonlar.Mesajlar.HataMesaj(err);
                        }
                    }
                    
                }
                else
                {
                    Fonksiyonlar.Mesajlar.MesajGoster("Şifreler aynı değil!");
                }


            }
            catch (Exception err)
            {
                Fonksiyonlar.Mesajlar.HataMesaj(err);
            }
            
        }

        void Temizle()
        {
            txt_Isim.Text = "";
            txt_KullaniciAdi.Text = "";
            txt_KullaniciTuru.SelectedIndex = 1;
            txt_Sifre.Text = "";
            txt_SifreTekrar.Text = "";
            txt_Soyisim.Text = "";
            rBtn_Pasif.Checked = true;
            ac = false;
            KullaniciID = -1;
        }

        void KullaniciAc(int ID)
        {
            KullaniciID = ID;
            try
            {
                Fonksiyonlar.TBL_KULLANICILAR kullanici = db.TBL_KULLANICILAR.First(t => t.ID == KullaniciID);
                txt_Isim.Text = kullanici.ISIM;
                txt_Soyisim.Text = kullanici.SOYISIM;
                txt_KullaniciAdi.Text = kullanici.KULLANICIADI;
                txt_Sifre.Text = kullanici.SIFRE;
                txt_SifreTekrar.Text = kullanici.SIFRE;
                if (kullanici.KODU == "Normal") txt_KullaniciTuru.SelectedIndex = 1;
                if (kullanici.KODU == "Yönetici") txt_KullaniciTuru.SelectedIndex = 0;
                if (kullanici.AKTIF.Value) rBtn_Aktif.Checked = true;
                if (!kullanici.AKTIF.Value) rBtn_Pasif.Checked = true;


            }
            catch (Exception err)
            {
                Fonksiyonlar.Mesajlar.HataMesaj(err);
            }

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otomasyon.Fonksiyonlar
{
    class Mesajlar
    {
        public static DialogResult OnayMesaj()
        {
            return MessageBox.Show("İşlemi Onaylıyor musunuz?","Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
        }

        public static DialogResult MesajGoster(string mesaj)
        {
            return MessageBox.Show(mesaj, "Uygulama Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static DialogResult HataMesaj(Exception err)
        {
            return MessageBox.Show(err.Message, "Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}

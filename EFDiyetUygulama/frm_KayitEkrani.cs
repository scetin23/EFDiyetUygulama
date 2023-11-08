using EF_Diyet_UI.AppDbContex;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace EF_Diyet_UI
{
    public partial class frm_KayitEkrani : Form
    {
        public frm_KayitEkrani()
        {
            InitializeComponent();
        }
        Context contex;
        private void btnKayıtOl_Click(object sender, EventArgs e)
        {
            contex = new Context();
            string Email = txtMail.Text.Trim();
            var user = contex.Kullanicilar.FirstOrDefault(x => x.Mail == Email);
            if (user == null)
            {
                if (txtAd.Text.Trim() != "" && txtSoyad.Text.Trim() != "" && txtBoy.Text.Trim() != "" && txtKilo.Text.Trim() != "" && txtMail.Text.Trim() != "" && txtSifre.Text.Trim() != "" && txtYas.Text.Trim() != "")
                {
                    try
                    {

                        contex = new Context();
                        contex.Kullanicilar.Add(new Kullanici()
                        {
                            KullaniciAdi = txtAd.Text.Trim(),
                            KullaniciSoyadi = txtSoyad.Text.Trim(),
                            KullaniciSifre = txtSifre.Text.Trim(),
                            Mail = txtMail.Text.Trim(),
                            Kilo = Convert.ToDecimal(txtKilo.Text.Trim()),
                            Yas = Convert.ToInt32(txtYas.Text.Trim()),
                            Boy = Convert.ToDecimal(txtBoy.Text.Trim()),
                            Cinsiyet = rdbErkek.Checked ? "Erkek" : "Kadın",

                        });
                        if (sifreBelirle(txtSifre.Text.Trim()) == true && EmailKontrol(txtMail.Text.Trim()) == true)
                        {
                            contex.SaveChanges();
                            MessageBox.Show("Sistemimize başarıyla kayıt yaptınız!!");
                            this.Close();

                        }
                        else
                            MessageBox.Show("Şifre veya Email hatalı");


                    }

                    catch (Exception)
                    {

                        throw new Exception("Kayıt yapılamadı bilgileri kontrol ediniz");
                    }

                }
            }

            else MessageBox.Show("Bu kullanıcı zaten var.");

        }
        public bool sifreBelirle(string sifre)
        {

            if (sifre.Length < 8) { return false; }
            // En az bir büyük harf (uppercase), bir küçük harf (lowercase), bir rakam (digit) ve bir özel karakter (special character) içermeli
            string pattern = @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*\W).*$";
            return Regex.IsMatch(sifre, pattern);

        }
        private bool EmailKontrol(string email)
        {// E-posta adresi için geçerli bir düzenli ifade kullanın
            string pattern = @"^(?!\.)[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, pattern);
        }

    }

}

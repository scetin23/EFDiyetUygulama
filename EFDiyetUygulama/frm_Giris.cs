using EF_Diyet_UI.AppDbContex;
using Entities.Concrete;
using System;

namespace EF_Diyet_UI
{
    public partial class frm_Giris : Form
    {
        public frm_Giris()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtSifre.PasswordChar = '*';

        }
        Context context = new Context();
        private void btnGiris_Click(object sender, EventArgs e)
        {

            string Email = txtMail.Text.Trim();
            string Sifre = txtSifre.Text.Trim();
            var user = context.Kullanicilar.FirstOrDefault(x => x.Mail == Email && x.KullaniciSifre == Sifre);

            if (user is not null)
            {
                MessageBox.Show("Saðlýklý Yaþama Hoþgeldin!!");
                frm_AnaMenu makaleler = new frm_AnaMenu(user);
                makaleler.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Hatalý giriþ");
                txtMail.Text = txtSifre.Text = "";
            }


        }
        private void btnKaydol_Click(object sender, EventArgs e)
        {
            frm_KayitEkrani kyt = new frm_KayitEkrani();

            kyt.Show();

        }


    }
}


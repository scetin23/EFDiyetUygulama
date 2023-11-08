using EF_Diyet_UI.AppDbContex;
using Entities.Concrete;
using HtmlAgilityPack;
using Microsoft.IdentityModel.Tokens;
using System.Net;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace EF_Diyet_UI
{
    public partial class frm_VucutAnalizi : Form
    {
        private Kullanici _kullanici;
        Context cnt;
        public frm_VucutAnalizi(Kullanici kullanici)
        {
            cnt = new Context();
            InitializeComponent();
            var user = cnt.Kullanicilar.FirstOrDefault(x => x.ID == kullanici.ID);
            _kullanici = user;

        }
        public void ShowVkiGroupBox()
        {

            gbVKI.Visible = true;
            gbVYO.Visible = false;
            gbBMH.Visible = false;
            txtVKIBoy.Text = _kullanici.Boy.ToString();
            txtVKIKilo.Text = _kullanici.Kilo.ToString();



        }
        public void ShowBmhGroupBox()
        {

            gbVKI.Visible = false;
            gbBMH.Visible = true;
            gbVYO.Visible = false;
            txtBMHBoy.Text = _kullanici.Boy.ToString();
            txtBMHKilo.Text = _kullanici.Kilo.ToString();
            txtBMHYas.Text = _kullanici.Yas.ToString();
        }
        public void ShowVYOGroupBox()
        {

            gbVKI.Visible = false;
            gbBMH.Visible = false;
            gbVYO.Visible = true;
            txtVYOBoy.Text = _kullanici.Boy.ToString();
            txtVYOKilo.Text = _kullanici.Kilo.ToString();
            txtVYOYas.Text = _kullanici.Yas.ToString();

        }

        private void hedefToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_AnaMenu frm = new frm_AnaMenu(_kullanici);
            frm.Show();
            this.Close();
        }

        private void btnVKI_Click(object sender, EventArgs e)
        {
            var kontrolKullanici = cnt.VucutAnalizleri.FirstOrDefault(x => x.KullaniciId == _kullanici.ID);
            if (gbVKI.Visible == true)
            {
                cnt = new Context();
                double kilo = Convert.ToDouble(txtVKIKilo.Text);
                double boy = Convert.ToDouble(txtVKIBoy.Text) / 100;
                double vki = kilo / (boy * boy);
                if (vki < 18.5)
                {
                    lblVki.Text = "Zayıfsınız.";
                }
                else if (vki < 24.9)
                {
                    lblVki.Text = "Normal kilodasınız.";
                }
                else if (vki < 29.9)
                {
                    lblVki.Text = "Fazla kilolusunuz.";
                }
                else
                {
                    lblVki.Text = "Obezsiniz.";
                }


                if (kontrolKullanici == null)
                {
                    cnt.VucutAnalizleri.Add(new VucutAnalizi() { KullaniciId = _kullanici.ID, VKI = vki });
                    cnt.SaveChanges();
                }
                else
                {
                    using (cnt = new Context())
                    {
                        VucutAnalizi vucut = (from i in cnt.VucutAnalizleri
                                              where i.KullaniciId == _kullanici.ID
                                              select i).FirstOrDefault<VucutAnalizi>();
                        vucut.VKI = vki;
                        cnt.SaveChanges();

                    }
                }
            }
            else if (gbVYO.Visible == true)
            {
                double kilo = Convert.ToDouble(txtVYOKilo.Text);
                double boy = Convert.ToDouble(txtVYOBoy.Text);
                int yas = Convert.ToInt32(txtVYOYas.Text);
                double belCevresi = Convert.ToDouble(txtBelCevre.Text);
                double vucutYagOrani = HesaplaVucutYagOrani(kilo, boy, yas, belCevresi, _kullanici);
                lblVYO.Text = "Basit Vücut Yağ Oranı (BF%):" + " " + vucutYagOrani;
                if (kontrolKullanici == null)
                {
                    cnt.VucutAnalizleri.Add(new VucutAnalizi() { KullaniciId = _kullanici.ID, VYO = vucutYagOrani });
                    cnt.SaveChanges();
                }
                else
                {
                    using (cnt = new Context())
                    {
                        VucutAnalizi vucut = (from i in cnt.VucutAnalizleri
                                              where i.KullaniciId == _kullanici.ID
                                              select i).FirstOrDefault<VucutAnalizi>();
                        vucut.VYO = vucutYagOrani;
                        cnt.SaveChanges();

                    }
                }

            }
            else if (gbBMH.Visible == true)
            {
                double kilo = Convert.ToDouble(txtBMHKilo.Text);
                double boy = Convert.ToDouble(txtBMHBoy.Text);
                int yas = Convert.ToInt32(txtBMHYas.Text);
                double bmh = HesaplaBMH(kilo, boy, yas, _kullanici);
                lblBMH.Text = "Bazal Metabolizma Hızı (BMR):" + " " + bmh + "kcal/gün";
                if (kontrolKullanici == null)
                {
                    cnt.VucutAnalizleri.Add(new VucutAnalizi() { KullaniciId = _kullanici.ID, BMH = bmh });
                    cnt.SaveChanges();
                }
                else
                {
                    using (cnt = new Context())
                    {
                        VucutAnalizi vucut = (from i in cnt.VucutAnalizleri
                                              where i.KullaniciId == _kullanici.ID
                                              select i).FirstOrDefault<VucutAnalizi>();
                        vucut.BMH = bmh;
                        cnt.SaveChanges();

                    }
                }
            }

        }


        static double HesaplaVucutYagOrani(double kilo, double boy, int yas, double belCevresi, Kullanici kullanici)
        {
            double vucutYagOrani = 0;
            if (kullanici.Cinsiyet.ToLower() == "erkek")
            {
                vucutYagOrani = (1.20 * (kilo / Math.Pow(boy / 100, 3))) + (0.23 * yas) - (10.8 * 1) - 5.4;
            }
            else if (kullanici.Cinsiyet.ToLower() == "kadın")
            {
                vucutYagOrani = (1.20 * (kilo / Math.Pow(boy / 100, 3))) + (0.23 * yas) - (10.8 * 0) - 5.4;
            }
            if (belCevresi > 0)
            {
                vucutYagOrani += (0.4 * belCevresi);
            }
            return vucutYagOrani;
        }

        static double HesaplaBMH(double kilo, double boy, int yas, Kullanici kullanici)
        {
            double bmr = 0;
            if (kullanici.Cinsiyet.ToLower() == "erkek")
            {
                bmr = 88.362 + (13.397 * kilo) + (4.799 * boy) - (5.677 * yas);
            }
            else if (kullanici.Cinsiyet.ToLower() == "kadın")
            {
                bmr = 447.593 + (9.247 * kilo) + (3.098 * boy) - (4.330 * yas);
            }
            return bmr;
        }
    }
}

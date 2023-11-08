using EF_Diyet_UI.AppDbContex;
using EF_Diyet_UI.Concrete;
using Entities.Enums;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Entities.Concrete;
using Entities.Abstract;

namespace EF_Diyet_UI
{

    public partial class frm_DiyetListe : Form
    {
        public Kullanici _kullanici;

        Context context;
        public frm_DiyetListe(Kullanici kullanici)
        {
            context = new Context();
            var user = context.Kullanicilar.FirstOrDefault(x => x.ID == kullanici.ID);
            _kullanici = user;
            InitializeComponent();
        }

        private void frm_DiyetListe_Load(object sender, EventArgs e)
        {
            Ogun[] ogunlerDizisi = (Ogun[])
            Enum.GetValues(typeof(Ogun));
            foreach (Ogun ogun in ogunlerDizisi)
            {
                comboBox1.Items.Add(ogun);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            context = new Context();
            var veriler = context.BesinBilgi.ToList();
            if (comboBox1.SelectedIndex == 0)
            {

                Ogun secilenOgun = (Ogun)comboBox1.SelectedItem;
                gbKahvaltı.Visible = true;
                gbAperatif.Visible = false;
                gbAksam.Visible = false;
                gbOgle.Visible = false;


                foreach (var veri in veriler)
                {
                    lstTumKahvalti.Items.Add(veri.BesinAdi);

                }
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                gbOgle.Visible = true;
                gbKahvaltı.Visible = false;
                gbAperatif.Visible = false;
                gbAksam.Visible = false;
                foreach (var veri in veriler)
                {
                    lstTumOgle.Items.Add(veri.BesinAdi);

                }
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                gbOgle.Visible = false;
                gbKahvaltı.Visible = false;
                gbAperatif.Visible = false;
                gbAksam.Visible = true;
                foreach (var veri in veriler)
                {
                    lstTumAksam.Items.Add(veri.BesinAdi);
                    lstTumAksam.ValueMember = "veri.Kalori";

                }
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                gbOgle.Visible = false;
                gbKahvaltı.Visible = false;
                gbAperatif.Visible = true;
                gbAksam.Visible = false;
                foreach (var veri in veriler)
                {
                    lstTumAperatif.Items.Add(veri.BesinAdi);
                }
            }
        }
        float toplamKahvaltiKalori = 0;
        float toplamOgleKalori = 0;
        float toplamAksamKalori = 0;
        float toplamAperatifKalori = 0;

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            //lstTumKahvalti.Items.Clear();
            //context = new Context();

            //lstTumKahvalti.DataSource = context.BesinBilgi.Where(x => x.BesinAdi.Contains(txtAra.Text)).Select(x => x.BesinAdi).ToList();
            //lstTumAperatif.DataSource = context.BesinBilgi.Where(x => x.BesinAdi.Contains(txtAra.Text)).Select(x => x.BesinAdi).ToList();
            //lstTumAksam.DataSource = context.BesinBilgi.Where(x => x.BesinAdi.Contains(txtAra.Text)).Select(x => x.BesinAdi).ToList();
            //lstTumOgle.DataSource = context.BesinBilgi.Where(x => x.BesinAdi.Contains(txtAra.Text)).Select(x => x.BesinAdi).ToList();

        }
        private void btnAperatif_Click(object sender, EventArgs e)
        {
            context = new Context();
            var kalori = context.BesinBilgi.Where(x => x.BesinAdi == lstTumAperatif.SelectedItem).Select(x => x.Kalori);
            foreach (var item in kalori)
            {
                toplamAperatifKalori += (float)item;
                lblAperatif.Text = toplamAperatifKalori.ToString();
                KaloriEkle((float)item);
            }
            foreach (var item in lstTumAperatif.SelectedItems)
            {
                if (!lstSecilenAperatif.Items.Contains(item))
                {
                    lstSecilenAperatif.Items.Add(item);

                }
            }
        }
        private void btnAksam_Click(object sender, EventArgs e)
        {
            context = new Context();
            var kalori = context.BesinBilgi.Where(x => x.BesinAdi == lstTumAksam.SelectedItem).Select(x => x.Kalori);
            foreach (var item in kalori)
            {
                toplamAksamKalori += (float)item;
                lblAksam.Text = toplamAksamKalori.ToString();
                KaloriEkle((float)item);
            }
            foreach (var item in lstTumAksam.SelectedItems)
            {
                if (!lstSecilenAksam.Items.Contains(item))
                {
                    lstSecilenAksam.Items.Add(item);

                }
            }
        }
        private void btnKahvalti_Click(object sender, EventArgs e)
        {
            context = new Context();
            var kalori = context.BesinBilgi.Where(x => x.BesinAdi == lstTumKahvalti.SelectedItem).Select(x => x.Kalori);

            foreach (var item in kalori)
            {
                toplamKahvaltiKalori += (float)item;
                lblKahvalti.Text = toplamKahvaltiKalori.ToString();
                KaloriEkle((float)item);
            }
            foreach (var item in lstTumKahvalti.SelectedItems)
            {
                if (!lstSecilenKahvaltı.Items.Contains(item))
                    lstSecilenKahvaltı.Items.Add(item);
            }
        }

        private void btnOgle_Click(object sender, EventArgs e)
        {
            context = new Context();
            var kalori2 = context.BesinBilgi.Where(x => x.BesinAdi == lstTumOgle.SelectedItem).Select(x => x.Kalori);
            foreach (var item in kalori2)
            {
                toplamOgleKalori += (float)item;
                lblOgle.Text = toplamOgleKalori.ToString();
                KaloriEkle((float)item);
            }

            foreach (var item in lstTumOgle.SelectedItems)
            {
                if (!lstSecilenOgle.Items.Contains(item))
                    lstSecilenOgle.Items.Add(item);
            }
        }
        double Toplam = 0;
        public double KaloriEkle(double lbl1)
        {

            Toplam += lbl1;
            label2.Text = Toplam.ToString();
            return Convert.ToDouble(label2.Text);
        }
        public double KaloriCikar(double lbl1)
        {

            Toplam -= lbl1;
            label2.Text = Toplam.ToString();
            return Convert.ToDouble(label2.Text);
        }

        private void btnCikarKahvalti_Click(object sender, EventArgs e)
        {

            context = new Context();
            BesinBilgileri kaloriList = context.BesinBilgi.FirstOrDefault(x => x.BesinAdi == lstSecilenKahvaltı.SelectedItem);
            toplamKahvaltiKalori -= (float)kaloriList.Kalori;
            lblKahvalti.Text = toplamKahvaltiKalori.ToString();
            KaloriCikar((float)kaloriList.Kalori);


            lstSecilenKahvaltı.Items.Remove(lstSecilenKahvaltı.SelectedItem);
        }

        private void btnCikarOgle_Click(object sender, EventArgs e)
        {
            context = new Context();
            BesinBilgileri kaloriList = context.BesinBilgi.FirstOrDefault(x => x.BesinAdi == lstSecilenOgle.SelectedItem);
            toplamOgleKalori -= (float)kaloriList.Kalori;
            lblOgle.Text = toplamOgleKalori.ToString();
            KaloriCikar((float)kaloriList.Kalori);


            lstSecilenOgle.Items.Remove(lstSecilenOgle.SelectedItem);

        }

        private void btnCikarAksam_Click(object sender, EventArgs e)
        {
            context = new Context();
            BesinBilgileri kaloriList = context.BesinBilgi.FirstOrDefault(x => x.BesinAdi == lstSecilenAksam.SelectedItem);
            toplamAksamKalori -= (float)kaloriList.Kalori;

            lblAksam.Text = toplamAksamKalori.ToString();
            KaloriCikar((float)kaloriList.Kalori);

            lstSecilenAksam.Items.Remove(lstSecilenAksam.SelectedItem);
        }

        private void btnCikarAperatif_Click(object sender, EventArgs e)
        {
            context = new Context();
            BesinBilgileri kaloriList = context.BesinBilgi.FirstOrDefault(x => x.BesinAdi == lstSecilenAperatif.SelectedItem);
            toplamAperatifKalori -= (float)kaloriList.Kalori;
            lblAperatif.Text = toplamAperatifKalori.ToString();
            KaloriCikar((float)kaloriList.Kalori);
            lstSecilenAperatif.Items.Remove(lstSecilenAperatif.SelectedItem);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_AnaMenu menu = new frm_AnaMenu(_kullanici);
            menu.Show();
            this.Close();
        }



        private void anaMenüToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frm_AnaMenu menu = new frm_AnaMenu(_kullanici);
            menu.Show();
            this.Close();
        }
    }
}

using EF_Diyet_UI.AppDbContex;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF_Diyet_UI
{
    public partial class frm_AnaMenu : Form
    {
        private Kullanici _kullanici;
        public frm_AnaMenu(Kullanici kullanici)
        {
            cnt = new Context();
            InitializeComponent();
            var user = cnt.Kullanicilar.FirstOrDefault(x => x.ID == kullanici.ID);
            _kullanici = user;
            
        }


        Context cnt;
        frm_VucutAnalizi vct;
        private void vKIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vct = new frm_VucutAnalizi(_kullanici);
            vct.Show();
            vct.ShowVkiGroupBox();
            this.Close();
        }

        private void vYOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vct = new frm_VucutAnalizi(_kullanici);
            vct.Show();
            vct.ShowVYOGroupBox();
            this.Close();
        }

        private void bMHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vct = new frm_VucutAnalizi(_kullanici);
            vct.Show();
            vct.ShowBmhGroupBox();
            this.Close();
        }

      

        private void tüketilenBesinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_DiyetListe diet = new frm_DiyetListe(_kullanici);
            diet.Show();
            this.Close();
        }
    }
}

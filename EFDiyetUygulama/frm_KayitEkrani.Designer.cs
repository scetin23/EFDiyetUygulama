namespace EF_Diyet_UI
{
    partial class frm_KayitEkrani
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_KayitEkrani));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            txtMail = new TextBox();
            txtSifre = new TextBox();
            txtKilo = new TextBox();
            txtBoy = new TextBox();
            btnKayıtOl = new Button();
            label7 = new Label();
            rdbKadin = new RadioButton();
            rdbErkek = new RadioButton();
            label8 = new Label();
            txtYas = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 37);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Adınız:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 79);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 0;
            label2.Text = "Soyadınız:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 114);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 0;
            label3.Text = "Mail Adresi:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 153);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 0;
            label4.Text = "Şifre:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(50, 183);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 0;
            label5.Text = "Kilonuz:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(50, 214);
            label6.Name = "label6";
            label6.Size = new Size(56, 15);
            label6.TabIndex = 0;
            label6.Text = "Boyunuz:";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(140, 29);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(100, 23);
            txtAd.TabIndex = 1;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(140, 71);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(100, 23);
            txtSoyad.TabIndex = 2;
            // 
            // txtMail
            // 
            txtMail.Location = new Point(140, 106);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(100, 23);
            txtMail.TabIndex = 3;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(140, 145);
            txtSifre.Name = "txtSifre";
            txtSifre.PasswordChar = '*';
            txtSifre.Size = new Size(100, 23);
            txtSifre.TabIndex = 4;
            // 
            // txtKilo
            // 
            txtKilo.Location = new Point(140, 175);
            txtKilo.Name = "txtKilo";
            txtKilo.Size = new Size(100, 23);
            txtKilo.TabIndex = 5;
            // 
            // txtBoy
            // 
            txtBoy.Location = new Point(140, 211);
            txtBoy.Name = "txtBoy";
            txtBoy.Size = new Size(100, 23);
            txtBoy.TabIndex = 6;
            // 
            // btnKayıtOl
            // 
            btnKayıtOl.Location = new Point(235, 325);
            btnKayıtOl.Name = "btnKayıtOl";
            btnKayıtOl.Size = new Size(85, 41);
            btnKayıtOl.TabIndex = 9;
            btnKayıtOl.Text = "Kayıt Ol";
            btnKayıtOl.UseVisualStyleBackColor = true;
            btnKayıtOl.Click += btnKayıtOl_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(50, 249);
            label7.Name = "label7";
            label7.Size = new Size(52, 15);
            label7.TabIndex = 0;
            label7.Text = "Cinsiyet:";
            // 
            // rdbKadin
            // 
            rdbKadin.AutoSize = true;
            rdbKadin.Location = new Point(140, 243);
            rdbKadin.Name = "rdbKadin";
            rdbKadin.Size = new Size(55, 19);
            rdbKadin.TabIndex = 7;
            rdbKadin.TabStop = true;
            rdbKadin.Text = "Kadın";
            rdbKadin.UseVisualStyleBackColor = true;
            // 
            // rdbErkek
            // 
            rdbErkek.AutoSize = true;
            rdbErkek.Location = new Point(218, 245);
            rdbErkek.Name = "rdbErkek";
            rdbErkek.Size = new Size(53, 19);
            rdbErkek.TabIndex = 7;
            rdbErkek.TabStop = true;
            rdbErkek.Text = "Erkek";
            rdbErkek.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(50, 288);
            label8.Name = "label8";
            label8.Size = new Size(45, 15);
            label8.TabIndex = 0;
            label8.Text = "Yaşınız:";
            // 
            // txtYas
            // 
            txtYas.Location = new Point(140, 280);
            txtYas.Name = "txtYas";
            txtYas.Size = new Size(100, 23);
            txtYas.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(406, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(338, 337);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // frm_KayitEkrani
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(rdbErkek);
            Controls.Add(rdbKadin);
            Controls.Add(btnKayıtOl);
            Controls.Add(txtYas);
            Controls.Add(txtBoy);
            Controls.Add(txtKilo);
            Controls.Add(txtSifre);
            Controls.Add(txtMail);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frm_KayitEkrani";
            Text = "KayitEkrani";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private TextBox txtMail;
        private TextBox txtSifre;
        private TextBox txtKilo;
        private TextBox txtBoy;
        private Button btnKayıtOl;
        private Label label7;
        private RadioButton rdbKadin;
        private RadioButton rdbErkek;
        private Label label8;
        private TextBox txtYas;
        private PictureBox pictureBox1;
    }
}
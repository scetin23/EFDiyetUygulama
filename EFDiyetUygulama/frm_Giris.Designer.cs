namespace EF_Diyet_UI
{
    partial class frm_Giris
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Giris));
            txtMail = new TextBox();
            txtSifre = new TextBox();
            btnGiris = new Button();
            btnKaydol = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // txtMail
            // 
            txtMail.BackColor = Color.WhiteSmoke;
            txtMail.BorderStyle = BorderStyle.None;
            txtMail.Location = new Point(129, 161);
            txtMail.Multiline = true;
            txtMail.Name = "txtMail";
            txtMail.PlaceholderText = "Mail Adresinizi Giriniz....";
            txtMail.Size = new Size(246, 34);
            txtMail.TabIndex = 1;
            // 
            // txtSifre
            // 
            txtSifre.BackColor = Color.WhiteSmoke;
            txtSifre.BorderStyle = BorderStyle.None;
            txtSifre.Location = new Point(129, 215);
            txtSifre.Multiline = true;
            txtSifre.Name = "txtSifre";
            txtSifre.PlaceholderText = "Şifrenizi Giriniz....";
            txtSifre.Size = new Size(246, 34);
            txtSifre.TabIndex = 2;
            // 
            // btnGiris
            // 
            btnGiris.BackColor = Color.WhiteSmoke;
            btnGiris.BackgroundImageLayout = ImageLayout.Stretch;
            btnGiris.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnGiris.Location = new Point(165, 284);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(172, 54);
            btnGiris.TabIndex = 3;
            btnGiris.Text = "Giriş Yap";
            btnGiris.UseVisualStyleBackColor = false;
            btnGiris.Click += btnGiris_Click;
            // 
            // btnKaydol
            // 
            btnKaydol.BackColor = Color.WhiteSmoke;
            btnKaydol.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnKaydol.Location = new Point(129, 442);
            btnKaydol.Name = "btnKaydol";
            btnKaydol.Size = new Size(246, 63);
            btnKaydol.TabIndex = 4;
            btnKaydol.Text = "Kayıt Ol";
            btnKaydol.UseVisualStyleBackColor = false;
            btnKaydol.Click += btnKaydol_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Gray;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(338, 161);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(37, 34);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(338, 215);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(37, 34);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(165, 379);
            label3.Name = "label3";
            label3.Size = new Size(172, 28);
            label3.TabIndex = 7;
            label3.Text = "Üye Değil Misiniz?";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(165, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(189, 130);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // frm_Giris
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(531, 551);
            Controls.Add(pictureBox3);
            Controls.Add(label3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnKaydol);
            Controls.Add(btnGiris);
            Controls.Add(txtSifre);
            Controls.Add(txtMail);
            Name = "frm_Giris";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtMail;
        private TextBox txtSifre;
        private Button btnGiris;
        private Button btnKaydol;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label3;
        private PictureBox pictureBox3;
    }
}
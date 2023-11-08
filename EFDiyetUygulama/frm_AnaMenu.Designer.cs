namespace EF_Diyet_UI
{
    partial class frm_AnaMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_AnaMenu));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            pictureBox3 = new PictureBox();
            menuStrip2 = new MenuStrip();
            hedefKilonuzToolStripMenuItem = new ToolStripMenuItem();
            vucutAnaliziToolStripMenuItem = new ToolStripMenuItem();
            vKIToolStripMenuItem = new ToolStripMenuItem();
            vYOToolStripMenuItem = new ToolStripMenuItem();
            bMHToolStripMenuItem = new ToolStripMenuItem();
            tüketilenBesinToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(611, 772);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 781);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(624, 821);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(pictureBox1);
            flowLayoutPanel1.Controls.Add(pictureBox2);
            flowLayoutPanel1.Controls.Add(pictureBox3);
            flowLayoutPanel1.Location = new Point(12, 67);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(633, 409);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(3, 1608);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(622, 292);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // menuStrip2
            // 
            menuStrip2.Items.AddRange(new ToolStripItem[] { hedefKilonuzToolStripMenuItem, vucutAnaliziToolStripMenuItem, tüketilenBesinToolStripMenuItem });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(650, 24);
            menuStrip2.TabIndex = 3;
            menuStrip2.Text = "menuStrip2";
            // 
            // hedefKilonuzToolStripMenuItem
            // 
            hedefKilonuzToolStripMenuItem.Name = "hedefKilonuzToolStripMenuItem";
            hedefKilonuzToolStripMenuItem.Size = new Size(93, 20);
            hedefKilonuzToolStripMenuItem.Text = "Hedef Kilonuz";
            // 
            // vucutAnaliziToolStripMenuItem
            // 
            vucutAnaliziToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { vKIToolStripMenuItem, vYOToolStripMenuItem, bMHToolStripMenuItem });
            vucutAnaliziToolStripMenuItem.Name = "vucutAnaliziToolStripMenuItem";
            vucutAnaliziToolStripMenuItem.Size = new Size(88, 20);
            vucutAnaliziToolStripMenuItem.Text = "Vucut Analizi";
            // 
            // vKIToolStripMenuItem
            // 
            vKIToolStripMenuItem.Name = "vKIToolStripMenuItem";
            vKIToolStripMenuItem.Size = new Size(258, 22);
            vKIToolStripMenuItem.Tag = "VKI";
            vKIToolStripMenuItem.Text = "Vücut Kitle Indexi Hesaplama";
            vKIToolStripMenuItem.Click += vKIToolStripMenuItem_Click;
            // 
            // vYOToolStripMenuItem
            // 
            vYOToolStripMenuItem.Name = "vYOToolStripMenuItem";
            vYOToolStripMenuItem.Size = new Size(258, 22);
            vYOToolStripMenuItem.Tag = "VYO";
            vYOToolStripMenuItem.Text = "Vücut Yağ Oranı Hesaplama";
            vYOToolStripMenuItem.Click += vYOToolStripMenuItem_Click;
            // 
            // bMHToolStripMenuItem
            // 
            bMHToolStripMenuItem.Name = "bMHToolStripMenuItem";
            bMHToolStripMenuItem.Size = new Size(258, 22);
            bMHToolStripMenuItem.Tag = "BMH";
            bMHToolStripMenuItem.Text = "Bazal Metabolizma Hızı Hesaplama";
            bMHToolStripMenuItem.Click += bMHToolStripMenuItem_Click;
            // 
            // tüketilenBesinToolStripMenuItem
            // 
            tüketilenBesinToolStripMenuItem.Name = "tüketilenBesinToolStripMenuItem";
            tüketilenBesinToolStripMenuItem.Size = new Size(98, 20);
            tüketilenBesinToolStripMenuItem.Text = "Tüketilen Besin";
            tüketilenBesinToolStripMenuItem.Click += tüketilenBesinToolStripMenuItem_Click;
            // 
            // frm_AnaMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(650, 473);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(menuStrip2);
            MainMenuStrip = menuStrip2;
            Name = "frm_AnaMenu";
            Text = "Makale";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox pictureBox3;
        private MenuStrip menuStrip1;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem hedefKilonuzToolStripMenuItem;
        private ToolStripMenuItem vucutAnaliziToolStripMenuItem;
        private ToolStripMenuItem tüketilenBesinToolStripMenuItem;
        //private ToolStripMenuItem besinBilgileriToolStripMenuItem;
        private ToolStripMenuItem vKIToolStripMenuItem;
        private ToolStripMenuItem vYOToolStripMenuItem;
        private ToolStripMenuItem bMHToolStripMenuItem;
    }
}
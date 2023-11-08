namespace EF_Diyet_UI
{
    partial class frm_VucutAnalizi

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_VucutAnalizi));
            menuStrip1 = new MenuStrip();
            hedefToolStripMenuItem = new ToolStripMenuItem();
            vScrollBar1 = new VScrollBar();
            gbVKI = new GroupBox();
            lblVki = new Label();
            lblSonuc = new Label();
            txtVKIKilo = new TextBox();
            txtVKIBoy = new TextBox();
            label2 = new Label();
            label1 = new Label();
            gbVYO = new GroupBox();
            lblVYO = new Label();
            txtBelCevre = new TextBox();
            txtVYOYas = new TextBox();
            txtVYOKilo = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtVYOBoy = new TextBox();
            gbBMH = new GroupBox();
            lblBMH = new Label();
            txtBMHYas = new TextBox();
            txtBMHKilo = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            txtBMHBoy = new TextBox();
            btnVKI = new Button();
            menuStrip1.SuspendLayout();
            gbVKI.SuspendLayout();
            gbVYO.SuspendLayout();
            gbBMH.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { hedefToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(567, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // hedefToolStripMenuItem
            // 
            hedefToolStripMenuItem.Name = "hedefToolStripMenuItem";
            hedefToolStripMenuItem.Size = new Size(90, 24);
            hedefToolStripMenuItem.Text = "Ana Menü";
            hedefToolStripMenuItem.Click += hedefToolStripMenuItem_Click;
            // 
            // vScrollBar1
            // 
            vScrollBar1.Location = new Point(902, 32);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(17, 716);
            vScrollBar1.TabIndex = 4;
            // 
            // gbVKI
            // 
            gbVKI.BackColor = Color.Transparent;
            gbVKI.Controls.Add(lblVki);
            gbVKI.Controls.Add(lblSonuc);
            gbVKI.Controls.Add(txtVKIKilo);
            gbVKI.Controls.Add(txtVKIBoy);
            gbVKI.Controls.Add(label2);
            gbVKI.Controls.Add(label1);
            gbVKI.Location = new Point(50, 55);
            gbVKI.Margin = new Padding(3, 4, 3, 4);
            gbVKI.Name = "gbVKI";
            gbVKI.Padding = new Padding(3, 4, 3, 4);
            gbVKI.Size = new Size(422, 421);
            gbVKI.TabIndex = 5;
            gbVKI.TabStop = false;
            gbVKI.Text = "Vücut Kitle Indexi";
            gbVKI.Visible = false;
            // 
            // lblVki
            // 
            lblVki.Location = new Point(14, 263);
            lblVki.Name = "lblVki";
            lblVki.Size = new Size(318, 53);
            lblVki.TabIndex = 4;
            // 
            // lblSonuc
            // 
            lblSonuc.Location = new Point(7, 263);
            lblSonuc.Name = "lblSonuc";
            lblSonuc.Size = new Size(318, 53);
            lblSonuc.TabIndex = 4;
            // 
            // txtVKIKilo
            // 
            txtVKIKilo.Location = new Point(103, 119);
            txtVKIKilo.Margin = new Padding(3, 4, 3, 4);
            txtVKIKilo.Name = "txtVKIKilo";
            txtVKIKilo.Size = new Size(114, 27);
            txtVKIKilo.TabIndex = 2;
            // 
            // txtVKIBoy
            // 
            txtVKIBoy.Location = new Point(103, 49);
            txtVKIBoy.Margin = new Padding(3, 4, 3, 4);
            txtVKIBoy.Name = "txtVKIBoy";
            txtVKIBoy.Size = new Size(114, 27);
            txtVKIBoy.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 60);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 0;
            label2.Text = "Boyunuz:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 129);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 0;
            label1.Text = "Kilonuz:";
            // 
            // gbVYO
            // 
            gbVYO.BackColor = Color.Transparent;
            gbVYO.Controls.Add(lblVYO);
            gbVYO.Controls.Add(txtBelCevre);
            gbVYO.Controls.Add(txtVYOYas);
            gbVYO.Controls.Add(txtVYOKilo);
            gbVYO.Controls.Add(label6);
            gbVYO.Controls.Add(label5);
            gbVYO.Controls.Add(label3);
            gbVYO.Controls.Add(label4);
            gbVYO.Controls.Add(txtVYOBoy);
            gbVYO.Location = new Point(50, 55);
            gbVYO.Margin = new Padding(3, 4, 3, 4);
            gbVYO.Name = "gbVYO";
            gbVYO.Padding = new Padding(3, 4, 3, 4);
            gbVYO.Size = new Size(422, 421);
            gbVYO.TabIndex = 6;
            gbVYO.TabStop = false;
            gbVYO.Text = "Vücut Yağ Oranı";
            gbVYO.Visible = false;
            // 
            // lblVYO
            // 
            lblVYO.Location = new Point(26, 328);
            lblVYO.Name = "lblVYO";
            lblVYO.Size = new Size(389, 63);
            lblVYO.TabIndex = 3;
            // 
            // txtBelCevre
            // 
            txtBelCevre.Location = new Point(115, 233);
            txtBelCevre.Margin = new Padding(3, 4, 3, 4);
            txtBelCevre.Name = "txtBelCevre";
            txtBelCevre.Size = new Size(114, 27);
            txtBelCevre.TabIndex = 2;
            // 
            // txtVYOYas
            // 
            txtVYOYas.Location = new Point(115, 173);
            txtVYOYas.Margin = new Padding(3, 4, 3, 4);
            txtVYOYas.Name = "txtVYOYas";
            txtVYOYas.Size = new Size(114, 27);
            txtVYOYas.TabIndex = 2;
            // 
            // txtVYOKilo
            // 
            txtVYOKilo.Location = new Point(115, 112);
            txtVYOKilo.Margin = new Padding(3, 4, 3, 4);
            txtVYOKilo.Name = "txtVYOKilo";
            txtVYOKilo.Size = new Size(114, 27);
            txtVYOKilo.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 244);
            label6.Name = "label6";
            label6.Size = new Size(84, 20);
            label6.TabIndex = 0;
            label6.Text = "Bel Çevresi:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 184);
            label5.Name = "label5";
            label5.Size = new Size(56, 20);
            label5.TabIndex = 0;
            label5.Text = "Yaşınız:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 123);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 0;
            label3.Text = "Kilonuz:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 60);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 0;
            label4.Text = "Boyunuz:";
            // 
            // txtVYOBoy
            // 
            txtVYOBoy.Location = new Point(115, 49);
            txtVYOBoy.Margin = new Padding(3, 4, 3, 4);
            txtVYOBoy.Name = "txtVYOBoy";
            txtVYOBoy.Size = new Size(114, 27);
            txtVYOBoy.TabIndex = 1;
            // 
            // gbBMH
            // 
            gbBMH.BackColor = Color.Transparent;
            gbBMH.Controls.Add(lblBMH);
            gbBMH.Controls.Add(txtBMHYas);
            gbBMH.Controls.Add(txtBMHKilo);
            gbBMH.Controls.Add(label8);
            gbBMH.Controls.Add(label9);
            gbBMH.Controls.Add(label10);
            gbBMH.Controls.Add(txtBMHBoy);
            gbBMH.Location = new Point(57, 47);
            gbBMH.Margin = new Padding(3, 4, 3, 4);
            gbBMH.Name = "gbBMH";
            gbBMH.Padding = new Padding(3, 4, 3, 4);
            gbBMH.Size = new Size(422, 421);
            gbBMH.TabIndex = 7;
            gbBMH.TabStop = false;
            gbBMH.Text = "Bazal Metabolizma Hızı ";
            gbBMH.Visible = false;
            // 
            // lblBMH
            // 
            lblBMH.Location = new Point(0, 236);
            lblBMH.Name = "lblBMH";
            lblBMH.Size = new Size(318, 53);
            lblBMH.TabIndex = 9;
            // 
            // txtBMHYas
            // 
            txtBMHYas.Location = new Point(103, 168);
            txtBMHYas.Margin = new Padding(3, 4, 3, 4);
            txtBMHYas.Name = "txtBMHYas";
            txtBMHYas.Size = new Size(114, 27);
            txtBMHYas.TabIndex = 7;
            // 
            // txtBMHKilo
            // 
            txtBMHKilo.Location = new Point(103, 107);
            txtBMHKilo.Margin = new Padding(3, 4, 3, 4);
            txtBMHKilo.Name = "txtBMHKilo";
            txtBMHKilo.Size = new Size(114, 27);
            txtBMHKilo.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(14, 179);
            label8.Name = "label8";
            label8.Size = new Size(56, 20);
            label8.TabIndex = 3;
            label8.Text = "Yaşınız:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(14, 117);
            label9.Name = "label9";
            label9.Size = new Size(61, 20);
            label9.TabIndex = 4;
            label9.Text = "Kilonuz:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(14, 55);
            label10.Name = "label10";
            label10.Size = new Size(68, 20);
            label10.TabIndex = 5;
            label10.Text = "Boyunuz:";
            // 
            // txtBMHBoy
            // 
            txtBMHBoy.Location = new Point(103, 44);
            txtBMHBoy.Margin = new Padding(3, 4, 3, 4);
            txtBMHBoy.Name = "txtBMHBoy";
            txtBMHBoy.Size = new Size(114, 27);
            txtBMHBoy.TabIndex = 6;
            // 
            // btnVKI
            // 
            btnVKI.Location = new Point(433, 507);
            btnVKI.Margin = new Padding(3, 4, 3, 4);
            btnVKI.Name = "btnVKI";
            btnVKI.Size = new Size(106, 52);
            btnVKI.TabIndex = 3;
            btnVKI.Text = "Hesapla";
            btnVKI.UseVisualStyleBackColor = true;
            btnVKI.Click += btnVKI_Click;
            // 
            // frm_VucutAnalizi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(567, 600);
            Controls.Add(gbBMH);
            Controls.Add(btnVKI);
            Controls.Add(gbVYO);
            Controls.Add(gbVKI);
            Controls.Add(vScrollBar1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frm_VucutAnalizi";
            Text = "Vücut Analizi";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            gbVKI.ResumeLayout(false);
            gbVKI.PerformLayout();
            gbVYO.ResumeLayout(false);
            gbVYO.PerformLayout();
            gbBMH.ResumeLayout(false);
            gbBMH.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem hedefToolStripMenuItem;
        private ToolStripMenuItem vücutAnalizinizToolStripMenuItem;
        private ToolStripMenuItem besinBilgileriToolStripMenuItem;
        private ToolStripMenuItem günlükTüketimToolStripMenuItem;
        private VScrollBar vScrollBar1;
        private GroupBox gbVKI;
        private GroupBox gbVYO;
        private GroupBox gbBMH;
        private Label lblSonuc;
        private Button btnVKI;
        private TextBox txtVKIKilo;
        private TextBox txtVKIBoy;
        private Label label2;
        private Label label1;
        private TextBox txtVYOYas;
        private TextBox txtVYOKilo;
        private Label label5;
        private Label label3;
        private Label label4;
        private TextBox txtVYOBoy;
        private Label lblVki;
        private Label lblVYO;
        private TextBox txtBelCevre;
        private Label label6;
        private Label lblBMH;
        private TextBox txtBMHYas;
        private TextBox txtBMHKilo;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox txtBMHBoy;
    }
}
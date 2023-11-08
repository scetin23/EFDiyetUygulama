namespace EF_Diyet_UI
{
    partial class frm_DiyetListe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_DiyetListe));
            comboBox1 = new ComboBox();
            gbKahvaltı = new GroupBox();
            btnCikarKahvalti = new Button();
            lstSecilenKahvaltı = new ListBox();
            btnKahvalti = new Button();
            btnDetayKahvalti = new Button();
            lstTumKahvalti = new ListBox();
            gbOgle = new GroupBox();
            btnCikarOgle = new Button();
            btnOgle = new Button();
            btnDetayOgle = new Button();
            lstSecilenOgle = new ListBox();
            lstTumOgle = new ListBox();
            gbAksam = new GroupBox();
            btnCikarAksam = new Button();
            btnAksam = new Button();
            btnDetayAksam = new Button();
            lstSecilenAksam = new ListBox();
            lstTumAksam = new ListBox();
            gbAperatif = new GroupBox();
            btnCikarAperatif = new Button();
            btnAperatif = new Button();
            btnDetayAperatif = new Button();
            lstSecilenAperatif = new ListBox();
            lstTumAperatif = new ListBox();
            label1 = new Label();
            label2 = new Label();
            txtAra = new TextBox();
            label3 = new Label();
            lblKahvalti = new Label();
            label5 = new Label();
            lblOgle = new Label();
            label7 = new Label();
            lblAksam = new Label();
            label9 = new Label();
            lblAperatif = new Label();
            label11 = new Label();
            menuStrip1 = new MenuStrip();
            anaMenüToolStripMenuItem = new ToolStripMenuItem();
            gbKahvaltı.SuspendLayout();
            gbOgle.SuspendLayout();
            gbAksam.SuspendLayout();
            gbAperatif.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(38, 40);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(138, 28);
            comboBox1.TabIndex = 4;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // gbKahvaltı
            // 
            gbKahvaltı.BackColor = Color.Transparent;
            gbKahvaltı.Controls.Add(btnCikarKahvalti);
            gbKahvaltı.Controls.Add(lstSecilenKahvaltı);
            gbKahvaltı.Controls.Add(btnKahvalti);
            gbKahvaltı.Controls.Add(btnDetayKahvalti);
            gbKahvaltı.Controls.Add(lstTumKahvalti);
            gbKahvaltı.Location = new Point(39, 87);
            gbKahvaltı.Margin = new Padding(3, 4, 3, 4);
            gbKahvaltı.Name = "gbKahvaltı";
            gbKahvaltı.Padding = new Padding(3, 4, 3, 4);
            gbKahvaltı.Size = new Size(423, 352);
            gbKahvaltı.TabIndex = 5;
            gbKahvaltı.TabStop = false;
            gbKahvaltı.Text = "Kahvalti";
            gbKahvaltı.Visible = false;
            // 
            // btnCikarKahvalti
            // 
            btnCikarKahvalti.Location = new Point(152, 187);
            btnCikarKahvalti.Margin = new Padding(3, 4, 3, 4);
            btnCikarKahvalti.Name = "btnCikarKahvalti";
            btnCikarKahvalti.Size = new Size(63, 31);
            btnCikarKahvalti.TabIndex = 4;
            btnCikarKahvalti.Text = "<---";
            btnCikarKahvalti.UseVisualStyleBackColor = true;
            btnCikarKahvalti.Click += btnCikarKahvalti_Click;
            // 
            // lstSecilenKahvaltı
            // 
            lstSecilenKahvaltı.FormattingEnabled = true;
            lstSecilenKahvaltı.ItemHeight = 20;
            lstSecilenKahvaltı.Location = new Point(246, 29);
            lstSecilenKahvaltı.Margin = new Padding(3, 4, 3, 4);
            lstSecilenKahvaltı.Name = "lstSecilenKahvaltı";
            lstSecilenKahvaltı.Size = new Size(170, 264);
            lstSecilenKahvaltı.TabIndex = 3;
            // 
            // btnKahvalti
            // 
            btnKahvalti.Location = new Point(152, 115);
            btnKahvalti.Margin = new Padding(3, 4, 3, 4);
            btnKahvalti.Name = "btnKahvalti";
            btnKahvalti.Size = new Size(75, 31);
            btnKahvalti.TabIndex = 2;
            btnKahvalti.Text = "--->";
            btnKahvalti.UseVisualStyleBackColor = true;
            btnKahvalti.Click += btnKahvalti_Click;
            // 
            // btnDetayKahvalti
            // 
            btnDetayKahvalti.Location = new Point(7, 309);
            btnDetayKahvalti.Margin = new Padding(3, 4, 3, 4);
            btnDetayKahvalti.Name = "btnDetayKahvalti";
            btnDetayKahvalti.Size = new Size(86, 31);
            btnDetayKahvalti.TabIndex = 1;
            btnDetayKahvalti.Text = "Detaylandır";
            btnDetayKahvalti.UseVisualStyleBackColor = true;
            // 
            // lstTumKahvalti
            // 
            lstTumKahvalti.FormattingEnabled = true;
            lstTumKahvalti.ItemHeight = 20;
            lstTumKahvalti.Location = new Point(7, 29);
            lstTumKahvalti.Margin = new Padding(3, 4, 3, 4);
            lstTumKahvalti.Name = "lstTumKahvalti";
            lstTumKahvalti.Size = new Size(138, 264);
            lstTumKahvalti.TabIndex = 0;
            // 
            // gbOgle
            // 
            gbOgle.BackColor = Color.Transparent;
            gbOgle.Controls.Add(btnCikarOgle);
            gbOgle.Controls.Add(btnOgle);
            gbOgle.Controls.Add(btnDetayOgle);
            gbOgle.Controls.Add(lstSecilenOgle);
            gbOgle.Controls.Add(lstTumOgle);
            gbOgle.Location = new Point(31, 75);
            gbOgle.Margin = new Padding(3, 4, 3, 4);
            gbOgle.Name = "gbOgle";
            gbOgle.Padding = new Padding(3, 4, 3, 4);
            gbOgle.Size = new Size(423, 352);
            gbOgle.TabIndex = 6;
            gbOgle.TabStop = false;
            gbOgle.Text = "Ogle";
            gbOgle.Visible = false;
            // 
            // btnCikarOgle
            // 
            btnCikarOgle.Location = new Point(165, 187);
            btnCikarOgle.Margin = new Padding(3, 4, 3, 4);
            btnCikarOgle.Name = "btnCikarOgle";
            btnCikarOgle.Size = new Size(63, 31);
            btnCikarOgle.TabIndex = 3;
            btnCikarOgle.Text = "<---";
            btnCikarOgle.UseVisualStyleBackColor = true;
            btnCikarOgle.Click += btnCikarOgle_Click;
            // 
            // btnOgle
            // 
            btnOgle.Location = new Point(165, 101);
            btnOgle.Margin = new Padding(3, 4, 3, 4);
            btnOgle.Name = "btnOgle";
            btnOgle.Size = new Size(63, 31);
            btnOgle.TabIndex = 2;
            btnOgle.Text = "--->";
            btnOgle.UseVisualStyleBackColor = true;
            btnOgle.Click += btnOgle_Click;
            // 
            // btnDetayOgle
            // 
            btnDetayOgle.Location = new Point(7, 296);
            btnDetayOgle.Margin = new Padding(3, 4, 3, 4);
            btnDetayOgle.Name = "btnDetayOgle";
            btnDetayOgle.Size = new Size(86, 31);
            btnDetayOgle.TabIndex = 1;
            btnDetayOgle.Text = "Detaylandır";
            btnDetayOgle.UseVisualStyleBackColor = true;
            // 
            // lstSecilenOgle
            // 
            lstSecilenOgle.FormattingEnabled = true;
            lstSecilenOgle.ItemHeight = 20;
            lstSecilenOgle.Location = new Point(246, 29);
            lstSecilenOgle.Margin = new Padding(3, 4, 3, 4);
            lstSecilenOgle.Name = "lstSecilenOgle";
            lstSecilenOgle.Size = new Size(170, 264);
            lstSecilenOgle.TabIndex = 0;
            // 
            // lstTumOgle
            // 
            lstTumOgle.FormattingEnabled = true;
            lstTumOgle.ItemHeight = 20;
            lstTumOgle.Location = new Point(7, 29);
            lstTumOgle.Margin = new Padding(3, 4, 3, 4);
            lstTumOgle.Name = "lstTumOgle";
            lstTumOgle.Size = new Size(138, 264);
            lstTumOgle.TabIndex = 0;
            // 
            // gbAksam
            // 
            gbAksam.BackColor = Color.Transparent;
            gbAksam.Controls.Add(btnCikarAksam);
            gbAksam.Controls.Add(btnAksam);
            gbAksam.Controls.Add(btnDetayAksam);
            gbAksam.Controls.Add(lstSecilenAksam);
            gbAksam.Controls.Add(lstTumAksam);
            gbAksam.Location = new Point(32, 79);
            gbAksam.Margin = new Padding(3, 4, 3, 4);
            gbAksam.Name = "gbAksam";
            gbAksam.Padding = new Padding(3, 4, 3, 4);
            gbAksam.Size = new Size(423, 352);
            gbAksam.TabIndex = 7;
            gbAksam.TabStop = false;
            gbAksam.Text = "Aksam";
            gbAksam.Visible = false;
            // 
            // btnCikarAksam
            // 
            btnCikarAksam.Location = new Point(152, 165);
            btnCikarAksam.Margin = new Padding(3, 4, 3, 4);
            btnCikarAksam.Name = "btnCikarAksam";
            btnCikarAksam.Size = new Size(63, 31);
            btnCikarAksam.TabIndex = 3;
            btnCikarAksam.Text = "<---";
            btnCikarAksam.UseVisualStyleBackColor = true;
            btnCikarAksam.Click += btnCikarAksam_Click;
            // 
            // btnAksam
            // 
            btnAksam.Location = new Point(152, 64);
            btnAksam.Margin = new Padding(3, 4, 3, 4);
            btnAksam.Name = "btnAksam";
            btnAksam.Size = new Size(63, 31);
            btnAksam.TabIndex = 2;
            btnAksam.Text = "--->";
            btnAksam.UseVisualStyleBackColor = true;
            btnAksam.Click += btnAksam_Click;
            // 
            // btnDetayAksam
            // 
            btnDetayAksam.Location = new Point(7, 303);
            btnDetayAksam.Margin = new Padding(3, 4, 3, 4);
            btnDetayAksam.Name = "btnDetayAksam";
            btnDetayAksam.Size = new Size(86, 31);
            btnDetayAksam.TabIndex = 1;
            btnDetayAksam.Text = "Detaylandır";
            btnDetayAksam.UseVisualStyleBackColor = true;
            // 
            // lstSecilenAksam
            // 
            lstSecilenAksam.FormattingEnabled = true;
            lstSecilenAksam.ItemHeight = 20;
            lstSecilenAksam.Location = new Point(224, 29);
            lstSecilenAksam.Margin = new Padding(3, 4, 3, 4);
            lstSecilenAksam.Name = "lstSecilenAksam";
            lstSecilenAksam.Size = new Size(170, 264);
            lstSecilenAksam.TabIndex = 0;
            // 
            // lstTumAksam
            // 
            lstTumAksam.FormattingEnabled = true;
            lstTumAksam.ItemHeight = 20;
            lstTumAksam.Location = new Point(7, 29);
            lstTumAksam.Margin = new Padding(3, 4, 3, 4);
            lstTumAksam.Name = "lstTumAksam";
            lstTumAksam.Size = new Size(138, 264);
            lstTumAksam.TabIndex = 0;
            // 
            // gbAperatif
            // 
            gbAperatif.BackColor = Color.Transparent;
            gbAperatif.Controls.Add(btnCikarAperatif);
            gbAperatif.Controls.Add(btnAperatif);
            gbAperatif.Controls.Add(btnDetayAperatif);
            gbAperatif.Controls.Add(lstSecilenAperatif);
            gbAperatif.Controls.Add(lstTumAperatif);
            gbAperatif.Location = new Point(24, 93);
            gbAperatif.Margin = new Padding(3, 4, 3, 4);
            gbAperatif.Name = "gbAperatif";
            gbAperatif.Padding = new Padding(3, 4, 3, 4);
            gbAperatif.Size = new Size(423, 352);
            gbAperatif.TabIndex = 8;
            gbAperatif.TabStop = false;
            gbAperatif.Text = "Aperatif";
            gbAperatif.Visible = false;
            // 
            // btnCikarAperatif
            // 
            btnCikarAperatif.Location = new Point(165, 152);
            btnCikarAperatif.Margin = new Padding(3, 4, 3, 4);
            btnCikarAperatif.Name = "btnCikarAperatif";
            btnCikarAperatif.Size = new Size(63, 31);
            btnCikarAperatif.TabIndex = 2;
            btnCikarAperatif.Text = "<---";
            btnCikarAperatif.UseVisualStyleBackColor = true;
            btnCikarAperatif.Click += btnCikarAperatif_Click;
            // 
            // btnAperatif
            // 
            btnAperatif.Location = new Point(165, 75);
            btnAperatif.Margin = new Padding(3, 4, 3, 4);
            btnAperatif.Name = "btnAperatif";
            btnAperatif.Size = new Size(63, 31);
            btnAperatif.TabIndex = 2;
            btnAperatif.Text = "--->";
            btnAperatif.UseVisualStyleBackColor = true;
            btnAperatif.Click += btnAperatif_Click;
            // 
            // btnDetayAperatif
            // 
            btnDetayAperatif.Location = new Point(7, 303);
            btnDetayAperatif.Margin = new Padding(3, 4, 3, 4);
            btnDetayAperatif.Name = "btnDetayAperatif";
            btnDetayAperatif.Size = new Size(86, 31);
            btnDetayAperatif.TabIndex = 1;
            btnDetayAperatif.Text = "Detaylandır";
            btnDetayAperatif.UseVisualStyleBackColor = true;
            // 
            // lstSecilenAperatif
            // 
            lstSecilenAperatif.FormattingEnabled = true;
            lstSecilenAperatif.ItemHeight = 20;
            lstSecilenAperatif.Location = new Point(246, 35);
            lstSecilenAperatif.Margin = new Padding(3, 4, 3, 4);
            lstSecilenAperatif.Name = "lstSecilenAperatif";
            lstSecilenAperatif.Size = new Size(170, 264);
            lstSecilenAperatif.TabIndex = 0;
            // 
            // lstTumAperatif
            // 
            lstTumAperatif.FormattingEnabled = true;
            lstTumAperatif.ItemHeight = 20;
            lstTumAperatif.Location = new Point(7, 29);
            lstTumAperatif.Margin = new Padding(3, 4, 3, 4);
            lstTumAperatif.Name = "lstTumAperatif";
            lstTumAperatif.Size = new Size(138, 264);
            lstTumAperatif.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(558, 464);
            label1.Name = "label1";
            label1.Size = new Size(141, 20);
            label1.TabIndex = 9;
            label1.Text = "Toplam Kalori(kcal):";
            // 
            // label2
            // 
            label2.Location = new Point(718, 453);
            label2.Name = "label2";
            label2.Size = new Size(153, 31);
            label2.TabIndex = 10;
            label2.Text = "0";
            // 
            // txtAra
            // 
            txtAra.Location = new Point(112, 453);
            txtAra.Margin = new Padding(3, 4, 3, 4);
            txtAra.Name = "txtAra";
            txtAra.Size = new Size(349, 27);
            txtAra.TabIndex = 11;
            txtAra.TextChanged += txtAra_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 453);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 12;
            label3.Text = "Besin Ara:";
            // 
            // lblKahvalti
            // 
            lblKahvalti.Location = new Point(718, 87);
            lblKahvalti.Name = "lblKahvalti";
            lblKahvalti.Size = new Size(153, 31);
            lblKahvalti.TabIndex = 14;
            lblKahvalti.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(558, 87);
            label5.Name = "label5";
            label5.Size = new Size(108, 20);
            label5.TabIndex = 13;
            label5.Text = "Kahvaltı Kalori:";
            // 
            // lblOgle
            // 
            lblOgle.Location = new Point(718, 165);
            lblOgle.Name = "lblOgle";
            lblOgle.Size = new Size(153, 31);
            lblOgle.TabIndex = 16;
            lblOgle.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(558, 176);
            label7.Name = "label7";
            label7.Size = new Size(144, 20);
            label7.TabIndex = 15;
            label7.Text = "Öğle Yemeği  Kalori:";
            // 
            // lblAksam
            // 
            lblAksam.Location = new Point(718, 251);
            lblAksam.Name = "lblAksam";
            lblAksam.Size = new Size(153, 31);
            lblAksam.TabIndex = 18;
            lblAksam.Text = "0";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(558, 261);
            label9.Name = "label9";
            label9.Size = new Size(99, 20);
            label9.TabIndex = 17;
            label9.Text = "Akşam Kalori:";
            // 
            // lblAperatif
            // 
            lblAperatif.Location = new Point(718, 339);
            lblAperatif.Name = "lblAperatif";
            lblAperatif.Size = new Size(153, 31);
            lblAperatif.TabIndex = 20;
            lblAperatif.Text = "0";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(558, 349);
            label11.Name = "label11";
            label11.Size = new Size(109, 20);
            label11.TabIndex = 19;
            label11.Text = "Aperatif Kalori:";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { anaMenüToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(914, 30);
            menuStrip1.TabIndex = 22;
            menuStrip1.Text = "menuStrip1";
            // 
            // anaMenüToolStripMenuItem
            // 
            anaMenüToolStripMenuItem.Name = "anaMenüToolStripMenuItem";
            anaMenüToolStripMenuItem.Size = new Size(90, 24);
            anaMenüToolStripMenuItem.Text = "Ana Menü";
            anaMenüToolStripMenuItem.Click += anaMenüToolStripMenuItem_Click_1;
            // 
            // frm_DiyetListe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(914, 715);
            Controls.Add(lblAperatif);
            Controls.Add(label11);
            Controls.Add(lblAksam);
            Controls.Add(label9);
            Controls.Add(gbOgle);
            Controls.Add(lblOgle);
            Controls.Add(label7);
            Controls.Add(lblKahvalti);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(txtAra);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(gbAperatif);
            Controls.Add(gbAksam);
            Controls.Add(gbKahvaltı);
            Controls.Add(comboBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frm_DiyetListe";
            Text = "frm_DiyetListe";
            Load += frm_DiyetListe_Load;
            gbKahvaltı.ResumeLayout(false);
            gbOgle.ResumeLayout(false);
            gbAksam.ResumeLayout(false);
            gbAperatif.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox comboBox1;
        private GroupBox gbKahvaltı;
        private ListBox lstTumKahvalti;
        private Button btnKahvalti;
        private Button btnDetayKahvalti;
        private GroupBox gbOgle;
        private Button btnOgle;
        private Button btnDetayOgle;
        private ListBox lstSecilenOgle;
        private ListBox lstTumOgle;
        private GroupBox gbAksam;
        private Button btnAksam;
        private Button btnDetayAksam;
        private ListBox lstSecilenAksam;
        private ListBox lstTumAksam;
        private GroupBox gbAperatif;
        private Button btnAperatif;
        private Button btnDetayAperatif;
        private ListBox lstSecilenAperatif;
        private ListBox lstTumAperatif;
        private ListBox lstSecilenKahvaltı;
        private Label label1;
        private Label label2;
        private TextBox txtAra;
        private Label label3;
        private Button btnCikarAperatif;
        private Button btnCikarKahvalti;
        private Button btnCikarOgle;
        private Button btnCikarAksam;
        private Label lblKahvalti;
        private Label label5;
        private Label lblOgle;
        private Label label7;
        private Label lblAksam;
        private Label label9;
        private Label lblAperatif;
        private Label label11;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem anaMenüToolStripMenuItem;
    }
}
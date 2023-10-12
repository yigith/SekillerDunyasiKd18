namespace SekillerDunyasiKd18
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lstSekiller = new ListBox();
            nudX = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            nudY = new NumericUpDown();
            label3 = new Label();
            nudGenislik = new NumericUpDown();
            label4 = new Label();
            nudYukseklik = new NumericUpDown();
            label5 = new Label();
            cboTur = new ComboBox();
            label6 = new Label();
            pboRenk = new PictureBox();
            btnRastgeleEkle = new Button();
            btnEkle = new Button();
            btnYukari = new Button();
            btnSil = new Button();
            btnAsagi = new Button();
            pnlCizim = new Panel();
            btnTemizle = new Button();
            btnKaydet = new Button();
            colorDialog1 = new ColorDialog();
            ((System.ComponentModel.ISupportInitialize)nudX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudGenislik).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudYukseklik).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboRenk).BeginInit();
            SuspendLayout();
            // 
            // lstSekiller
            // 
            lstSekiller.FormattingEnabled = true;
            lstSekiller.ItemHeight = 15;
            lstSekiller.Location = new Point(22, 66);
            lstSekiller.Name = "lstSekiller";
            lstSekiller.Size = new Size(477, 109);
            lstSekiller.TabIndex = 0;
            // 
            // nudX
            // 
            nudX.Location = new Point(23, 36);
            nudX.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudX.Name = "nudX";
            nudX.Size = new Size(57, 23);
            nudX.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 18);
            label1.Name = "label1";
            label1.Size = new Size(14, 15);
            label1.TabIndex = 2;
            label1.Text = "X";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(86, 18);
            label2.Name = "label2";
            label2.Size = new Size(14, 15);
            label2.TabIndex = 4;
            label2.Text = "Y";
            // 
            // nudY
            // 
            nudY.Location = new Point(86, 36);
            nudY.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudY.Name = "nudY";
            nudY.Size = new Size(57, 23);
            nudY.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(149, 18);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 6;
            label3.Text = "Genişlik";
            // 
            // nudGenislik
            // 
            nudGenislik.Location = new Point(149, 36);
            nudGenislik.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudGenislik.Name = "nudGenislik";
            nudGenislik.Size = new Size(57, 23);
            nudGenislik.TabIndex = 5;
            nudGenislik.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(212, 18);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 8;
            label4.Text = "Yükseklik";
            // 
            // nudYukseklik
            // 
            nudYukseklik.Location = new Point(212, 36);
            nudYukseklik.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudYukseklik.Name = "nudYukseklik";
            nudYukseklik.Size = new Size(57, 23);
            nudYukseklik.TabIndex = 7;
            nudYukseklik.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(274, 17);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 9;
            label5.Text = "Şekil Türü";
            // 
            // cboTur
            // 
            cboTur.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTur.FormattingEnabled = true;
            cboTur.Items.AddRange(new object[] { "Dikdörtgen", "Elips" });
            cboTur.Location = new Point(275, 35);
            cboTur.Name = "cboTur";
            cboTur.Size = new Size(87, 23);
            cboTur.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(366, 17);
            label6.Name = "label6";
            label6.Size = new Size(33, 15);
            label6.TabIndex = 11;
            label6.Text = "Renk";
            // 
            // pboRenk
            // 
            pboRenk.BackColor = Color.Black;
            pboRenk.BorderStyle = BorderStyle.FixedSingle;
            pboRenk.Location = new Point(368, 35);
            pboRenk.Name = "pboRenk";
            pboRenk.Size = new Size(23, 23);
            pboRenk.TabIndex = 12;
            pboRenk.TabStop = false;
            pboRenk.Click += pboRenk_Click;
            // 
            // btnRastgeleEkle
            // 
            btnRastgeleEkle.Location = new Point(451, 35);
            btnRastgeleEkle.Name = "btnRastgeleEkle";
            btnRastgeleEkle.Size = new Size(23, 23);
            btnRastgeleEkle.TabIndex = 13;
            btnRastgeleEkle.Text = "?";
            btnRastgeleEkle.UseVisualStyleBackColor = true;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(480, 34);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(57, 23);
            btnEkle.TabIndex = 14;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnYukari
            // 
            btnYukari.BackgroundImage = (Image)resources.GetObject("btnYukari.BackgroundImage");
            btnYukari.BackgroundImageLayout = ImageLayout.Zoom;
            btnYukari.Location = new Point(505, 66);
            btnYukari.Name = "btnYukari";
            btnYukari.Size = new Size(32, 32);
            btnYukari.TabIndex = 15;
            btnYukari.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            btnSil.BackgroundImage = (Image)resources.GetObject("btnSil.BackgroundImage");
            btnSil.BackgroundImageLayout = ImageLayout.Zoom;
            btnSil.Location = new Point(505, 105);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(32, 32);
            btnSil.TabIndex = 16;
            btnSil.UseVisualStyleBackColor = true;
            // 
            // btnAsagi
            // 
            btnAsagi.BackgroundImage = (Image)resources.GetObject("btnAsagi.BackgroundImage");
            btnAsagi.BackgroundImageLayout = ImageLayout.Zoom;
            btnAsagi.Location = new Point(505, 144);
            btnAsagi.Name = "btnAsagi";
            btnAsagi.Size = new Size(32, 32);
            btnAsagi.TabIndex = 17;
            btnAsagi.UseVisualStyleBackColor = true;
            // 
            // pnlCizim
            // 
            pnlCizim.BackColor = Color.White;
            pnlCizim.Location = new Point(23, 181);
            pnlCizim.Name = "pnlCizim";
            pnlCizim.Size = new Size(514, 347);
            pnlCizim.TabIndex = 18;
            pnlCizim.Paint += pnlCizim_Paint;
            // 
            // btnTemizle
            // 
            btnTemizle.Location = new Point(23, 534);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(77, 23);
            btnTemizle.TabIndex = 19;
            btnTemizle.Text = "TEMİZLE";
            btnTemizle.UseVisualStyleBackColor = true;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(106, 534);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(77, 23);
            btnKaydet.TabIndex = 20;
            btnKaydet.Text = "KAYDET";
            btnKaydet.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(558, 570);
            Controls.Add(btnKaydet);
            Controls.Add(btnTemizle);
            Controls.Add(pnlCizim);
            Controls.Add(btnAsagi);
            Controls.Add(btnSil);
            Controls.Add(btnYukari);
            Controls.Add(btnEkle);
            Controls.Add(btnRastgeleEkle);
            Controls.Add(pboRenk);
            Controls.Add(label6);
            Controls.Add(cboTur);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(nudYukseklik);
            Controls.Add(label3);
            Controls.Add(nudGenislik);
            Controls.Add(label2);
            Controls.Add(nudY);
            Controls.Add(label1);
            Controls.Add(nudX);
            Controls.Add(lstSekiller);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Şekiller Dünyası";
            ((System.ComponentModel.ISupportInitialize)nudX).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudY).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudGenislik).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudYukseklik).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboRenk).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstSekiller;
        private NumericUpDown nudX;
        private Label label1;
        private Label label2;
        private NumericUpDown nudY;
        private Label label3;
        private NumericUpDown nudGenislik;
        private Label label4;
        private NumericUpDown nudYukseklik;
        private Label label5;
        private ComboBox cboTur;
        private Label label6;
        private PictureBox pboRenk;
        private Button btnRastgeleEkle;
        private Button btnEkle;
        private Button btnYukari;
        private Button btnSil;
        private Button btnAsagi;
        private Panel pnlCizim;
        private Button btnTemizle;
        private Button btnKaydet;
        private ColorDialog colorDialog1;
    }
}
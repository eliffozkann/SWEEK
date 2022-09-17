
namespace SWEEK
{
    partial class Form2
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
            this.lblMerhaba1 = new System.Windows.Forms.Label();
            this.lblHikayeAdi = new System.Windows.Forms.Label();
            this.lblHikayeDili = new System.Windows.Forms.Label();
            this.lblHikayeninOzeti = new System.Windows.Forms.Label();
            this.grp2 = new System.Windows.Forms.GroupBox();
            this.btnRenk = new System.Windows.Forms.Button();
            this.rtxtbHikayeYaz = new System.Windows.Forms.RichTextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnFont = new System.Windows.Forms.Button();
            this.fontD1 = new System.Windows.Forms.FontDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.grp3 = new System.Windows.Forms.GroupBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.lblSil = new System.Windows.Forms.Label();
            this.lblGuncelle = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lblYazarAdSoyad = new System.Windows.Forms.Label();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.grp2.SuspendLayout();
            this.grp3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMerhaba1
            // 
            this.lblMerhaba1.AutoSize = true;
            this.lblMerhaba1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMerhaba1.Location = new System.Drawing.Point(38, 21);
            this.lblMerhaba1.Name = "lblMerhaba1";
            this.lblMerhaba1.Size = new System.Drawing.Size(119, 18);
            this.lblMerhaba1.TabIndex = 0;
            this.lblMerhaba1.Text = "HOŞGELDİNİZ";
            // 
            // lblHikayeAdi
            // 
            this.lblHikayeAdi.AutoSize = true;
            this.lblHikayeAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHikayeAdi.Location = new System.Drawing.Point(38, 121);
            this.lblHikayeAdi.Name = "lblHikayeAdi";
            this.lblHikayeAdi.Size = new System.Drawing.Size(136, 20);
            this.lblHikayeAdi.TabIndex = 1;
            this.lblHikayeAdi.Text = "Hikayenin Adı :";
            // 
            // lblHikayeDili
            // 
            this.lblHikayeDili.AutoSize = true;
            this.lblHikayeDili.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHikayeDili.Location = new System.Drawing.Point(38, 156);
            this.lblHikayeDili.Name = "lblHikayeDili";
            this.lblHikayeDili.Size = new System.Drawing.Size(138, 20);
            this.lblHikayeDili.TabIndex = 1;
            this.lblHikayeDili.Text = "Hikayenin Dili :";
            // 
            // lblHikayeninOzeti
            // 
            this.lblHikayeninOzeti.AutoSize = true;
            this.lblHikayeninOzeti.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHikayeninOzeti.Location = new System.Drawing.Point(38, 228);
            this.lblHikayeninOzeti.Name = "lblHikayeninOzeti";
            this.lblHikayeninOzeti.Size = new System.Drawing.Size(176, 20);
            this.lblHikayeninOzeti.TabIndex = 1;
            this.lblHikayeninOzeti.Text = "Hikayenin Tanıtımı :";
            // 
            // grp2
            // 
            this.grp2.Controls.Add(this.btnRenk);
            this.grp2.Controls.Add(this.rtxtbHikayeYaz);
            this.grp2.Controls.Add(this.btnKaydet);
            this.grp2.Controls.Add(this.btnFont);
            this.grp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grp2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.grp2.Location = new System.Drawing.Point(43, 291);
            this.grp2.Name = "grp2";
            this.grp2.Size = new System.Drawing.Size(1192, 341);
            this.grp2.TabIndex = 2;
            this.grp2.TabStop = false;
            this.grp2.Text = "Hikayenizi Yazmaya Başlayabilirsiniz";
            this.grp2.Enter += new System.EventHandler(this.grp2_Enter);
            // 
            // btnRenk
            // 
            this.btnRenk.BackColor = System.Drawing.Color.LightBlue;
            this.btnRenk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRenk.Location = new System.Drawing.Point(585, 14);
            this.btnRenk.Name = "btnRenk";
            this.btnRenk.Size = new System.Drawing.Size(179, 40);
            this.btnRenk.TabIndex = 4;
            this.btnRenk.Text = "Renk Ayarları";
            this.btnRenk.UseVisualStyleBackColor = false;
            this.btnRenk.Click += new System.EventHandler(this.btnRenk_Click);
            // 
            // rtxtbHikayeYaz
            // 
            this.rtxtbHikayeYaz.Location = new System.Drawing.Point(6, 60);
            this.rtxtbHikayeYaz.Name = "rtxtbHikayeYaz";
            this.rtxtbHikayeYaz.Size = new System.Drawing.Size(1180, 273);
            this.rtxtbHikayeYaz.TabIndex = 3;
            this.rtxtbHikayeYaz.TabStop = false;
            this.rtxtbHikayeYaz.Text = "";
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.LightBlue;
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(968, 14);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(218, 40);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "HİKAYEYİ KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnFont
            // 
            this.btnFont.BackColor = System.Drawing.Color.LightBlue;
            this.btnFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFont.Location = new System.Drawing.Point(770, 14);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(192, 40);
            this.btnFont.TabIndex = 0;
            this.btnFont.Text = "Font Ayarları";
            this.btnFont.UseVisualStyleBackColor = false;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(237, 119);
            this.textBox1.MaxLength = 80;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(995, 27);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "0/80";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.Location = new System.Drawing.Point(237, 153);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(995, 27);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox3.Location = new System.Drawing.Point(237, 224);
            this.textBox3.MaxLength = 2000;
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox3.Size = new System.Drawing.Size(995, 51);
            this.textBox3.TabIndex = 5;
            this.textBox3.TabStop = false;
            this.textBox3.Text = "0/2000";
            // 
            // grp3
            // 
            this.grp3.Controls.Add(this.btnSil);
            this.grp3.Controls.Add(this.btnGuncelle);
            this.grp3.Controls.Add(this.lblSil);
            this.grp3.Controls.Add(this.lblGuncelle);
            this.grp3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grp3.Location = new System.Drawing.Point(626, 21);
            this.grp3.Name = "grp3";
            this.grp3.Size = new System.Drawing.Size(607, 92);
            this.grp3.TabIndex = 7;
            this.grp3.TabStop = false;
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.LightBlue;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(383, 43);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(218, 43);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.LightBlue;
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(45, 43);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(252, 43);
            this.btnGuncelle.TabIndex = 1;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // lblSil
            // 
            this.lblSil.AutoSize = true;
            this.lblSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSil.Location = new System.Drawing.Point(380, 14);
            this.lblSil.Name = "lblSil";
            this.lblSil.Size = new System.Drawing.Size(186, 18);
            this.lblSil.TabIndex = 0;
            this.lblSil.Text = "Oluşturulan Hikayeyi Sil";
            // 
            // lblGuncelle
            // 
            this.lblGuncelle.AutoSize = true;
            this.lblGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGuncelle.Location = new System.Drawing.Point(42, 14);
            this.lblGuncelle.Name = "lblGuncelle";
            this.lblGuncelle.Size = new System.Drawing.Size(232, 18);
            this.lblGuncelle.TabIndex = 0;
            this.lblGuncelle.Text = "Hikayeler Tablosunu Güncelle";
            this.lblGuncelle.Click += new System.EventHandler(this.lblGuncelle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(38, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bölüm Sayısı :";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericUpDown1.Location = new System.Drawing.Point(237, 189);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(82, 27);
            this.numericUpDown1.TabIndex = 8;
            // 
            // lblYazarAdSoyad
            // 
            this.lblYazarAdSoyad.AutoSize = true;
            this.lblYazarAdSoyad.Location = new System.Drawing.Point(234, 74);
            this.lblYazarAdSoyad.Name = "lblYazarAdSoyad";
            this.lblYazarAdSoyad.Size = new System.Drawing.Size(102, 17);
            this.lblYazarAdSoyad.TabIndex = 9;
            this.lblYazarAdSoyad.Text = "YazarAdSoyad";
            this.lblYazarAdSoyad.Visible = false;
            // 
            // dgv1
            // 
            this.dgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv1.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(41, 638);
            this.dgv1.Name = "dgv1";
            this.dgv1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgv1.RowHeadersWidth = 51;
            this.dgv1.RowTemplate.Height = 24;
            this.dgv1.Size = new System.Drawing.Size(1192, 181);
            this.dgv1.TabIndex = 10;
            this.dgv1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv1_CellMouseClick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1267, 824);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.lblYazarAdSoyad);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.grp3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.grp2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHikayeninOzeti);
            this.Controls.Add(this.lblHikayeDili);
            this.Controls.Add(this.lblHikayeAdi);
            this.Controls.Add(this.lblMerhaba1);
            this.Name = "Form2";
            this.Text = "HİKAYE YAZ";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.grp2.ResumeLayout(false);
            this.grp3.ResumeLayout(false);
            this.grp3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblMerhaba1;
        private System.Windows.Forms.FontDialog fontD1;
        public System.Windows.Forms.Label lblHikayeAdi;
        public System.Windows.Forms.Label lblHikayeDili;
        public System.Windows.Forms.Label lblHikayeninOzeti;
        public System.Windows.Forms.GroupBox grp2;
        public System.Windows.Forms.Button btnFont;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.TextBox textBox3;
        public System.Windows.Forms.GroupBox grp3;
        public System.Windows.Forms.Label lblSil;
        public System.Windows.Forms.Label lblGuncelle;
        public System.Windows.Forms.Button btnSil;
        public System.Windows.Forms.Button btnGuncelle;
        public System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.RichTextBox rtxtbHikayeYaz;
        private System.Windows.Forms.ColorDialog colorDialog1;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnRenk;
        public System.Windows.Forms.Label lblYazarAdSoyad;
        public System.Windows.Forms.DataGridView dgv1;
    }
}
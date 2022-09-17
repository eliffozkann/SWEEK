
namespace SWEEK
{
    partial class Form3
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
            this.dgv2 = new System.Windows.Forms.DataGridView();
            this.lblMerhaba2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.lblYazan = new System.Windows.Forms.Label();
            this.txtKisa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rtbOkuma = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv2
            // 
            this.dgv2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv2.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2.Location = new System.Drawing.Point(31, 45);
            this.dgv2.Name = "dgv2";
            this.dgv2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgv2.RowHeadersWidth = 51;
            this.dgv2.RowTemplate.Height = 24;
            this.dgv2.Size = new System.Drawing.Size(1881, 172);
            this.dgv2.TabIndex = 1;
            this.dgv2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv2_CellContentClick);
            this.dgv2.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv2_CellMouseClick);
            // 
            // lblMerhaba2
            // 
            this.lblMerhaba2.AutoSize = true;
            this.lblMerhaba2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMerhaba2.Location = new System.Drawing.Point(1630, 9);
            this.lblMerhaba2.Name = "lblMerhaba2";
            this.lblMerhaba2.Size = new System.Drawing.Size(93, 18);
            this.lblMerhaba2.TabIndex = 4;
            this.lblMerhaba2.Text = "hoşgeldiniz";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(28, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Lütfen okumak istediğiniz hikayeyi seçiniz :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.Location = new System.Drawing.Point(949, 250);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(0, 25);
            this.lblBaslik.TabIndex = 6;
            this.lblBaslik.Click += new System.EventHandler(this.lblBaslik_Click);
            // 
            // lblYazan
            // 
            this.lblYazan.AutoSize = true;
            this.lblYazan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYazan.Location = new System.Drawing.Point(1740, 267);
            this.lblYazan.Name = "lblYazan";
            this.lblYazan.Size = new System.Drawing.Size(0, 20);
            this.lblYazan.TabIndex = 7;
            this.lblYazan.Click += new System.EventHandler(this.lblYazan_Click);
            // 
            // txtKisa
            // 
            this.txtKisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKisa.Location = new System.Drawing.Point(31, 291);
            this.txtKisa.MaxLength = 2000;
            this.txtKisa.Multiline = true;
            this.txtKisa.Name = "txtKisa";
            this.txtKisa.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtKisa.Size = new System.Drawing.Size(1885, 69);
            this.txtKisa.TabIndex = 8;
            this.txtKisa.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(35, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Hikayenin Tanıtımı : ";
            // 
            // rtbOkuma
            // 
            this.rtbOkuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rtbOkuma.Location = new System.Drawing.Point(31, 401);
            this.rtbOkuma.Name = "rtbOkuma";
            this.rtbOkuma.Size = new System.Drawing.Size(1881, 591);
            this.rtbOkuma.TabIndex = 10;
            this.rtbOkuma.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(35, 378);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(353, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Seçtiğiniz hikayeyi okumaya başlayabilirsiniz. ";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1924, 1019);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rtbOkuma);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKisa);
            this.Controls.Add(this.lblYazan);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMerhaba2);
            this.Controls.Add(this.dgv2);
            this.Name = "Form3";
            this.Text = "HİKAYE OKU";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lblMerhaba2;
        public System.Windows.Forms.DataGridView dgv2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Label lblYazan;
        private System.Windows.Forms.TextBox txtKisa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtbOkuma;
        private System.Windows.Forms.Label label3;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWEEK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            int sonuc = DatabaseLayer.GirisYap(txtKullaniciAdi.Text.Trim(), txtSifre.Text.Trim(), txtAd.Text.Trim(), txtSoyad.Text.Trim());
            if (sonuc == 1)
            {
                grp1.Visible = true;
            }
            else
            {
                MessageBox.Show("Yanlış kullanıcı adı veya şifre girdiniz.\nİsim ve Soyisminizi tekrardan kontrol ediniz.\nLütfen tekrar deneyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnYaz_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.lblMerhaba1.Text = "Hoşgeldiniz "+ txtAd.Text + " " + txtSoyad.Text;
            f.lblYazarAdSoyad.Text = txtAd.Text + " " + txtSoyad.Text;
            f.Show();
        }

        private void btnOku_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.lblMerhaba2.Text = "Hoşgeldiniz " + txtAd.Text + " " + txtSoyad.Text;
            f.Show();
        }

        private void lblSweek_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtAd_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSoyad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

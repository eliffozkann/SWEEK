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
   
    public partial class Form2 : Form
    {
        Color color = Color.White;
        int hikayeId = -1;
        public Form2()
        {
            InitializeComponent();
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            DialogResult fontResult = fontD1.ShowDialog();
            if (fontResult == DialogResult.OK)
            {
                rtxtbHikayeYaz.Font = fontD1.Font;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dgv1.DataSource = DatabaseLayer.GetirHikayeler();
        }

        private void lblGuncelle_Click(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            int sonuc = -1;
            string name = textBox1.Text.Trim();
            string bolum_sayisi = numericUpDown1.Value.ToString();
            string dil = textBox2.Text.Trim();
            string ozet = textBox3.Text.Trim();
            string writer_name = lblYazarAdSoyad.Text.Trim();
            string icerik = rtxtbHikayeYaz.Text.Trim();
            if (hikayeId>-1)
            {
               sonuc =  DatabaseLayer.GuncelleHikaye(textBox1.Text.Trim(), numericUpDown1.Value.ToString(), textBox2.Text.Trim(), textBox3.Text.Trim(), rtxtbHikayeYaz.Text.Trim(), lblYazarAdSoyad.Text.Trim());
            }
            else
            {
                sonuc = DatabaseLayer.EkleYeniHikaye(name, bolum_sayisi, dil, ozet, writer_name, icerik);
            }
            //int sonuc = DatabaseLayer.EkleYeniHikaye(name, bolum_sayisi, dil, ozet, writer_name, icerik);
            if (sonuc == 1)
            {
                dgv1.DataSource = DatabaseLayer.GetirHikayeler();
                MessageBox.Show("Kayıt başarılı bir şekilde gerçekleşmiştir.", "Tebrikler", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Hikayeniz kayıt edilirken hatalar oluştu.\nLütfen tekrar deneyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void grp2_Enter(object sender, EventArgs e)
        {

        }

        private void btnRenk_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            rtxtbHikayeYaz.SelectionColor = colorDialog1.Color;
            color = colorDialog1.Color;
        }

        private void dgv1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                textBox1.Text = dgv1.Rows[e.RowIndex].Cells[0].Value.ToString();
                hikayeId = (int)dgv1.Rows[e.RowIndex].Cells[0].Value;
                numericUpDown1.Value = decimal.Parse(dgv1.Rows[e.RowIndex].Cells[1].Value.ToString());
                textBox2.Text = dgv1.Rows[e.RowIndex].Cells[2].Value.ToString();
                textBox3.Text = dgv1.Rows[e.RowIndex].Cells[3].Value.ToString();
                lblYazarAdSoyad.Text = dgv1.Rows[e.RowIndex].Cells[4].Value.ToString();
                rtxtbHikayeYaz.Text = dgv1.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.ToString());
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int sonuc = DatabaseLayer.GuncelleHikaye(textBox1.Text.Trim(), numericUpDown1.Value.ToString(), textBox2.Text.Trim(), textBox3.Text.Trim(), rtxtbHikayeYaz.Text.Trim(), lblYazarAdSoyad.Text.Trim());
            if (sonuc == 1)
            {
                dgv1.DataSource = DatabaseLayer.GetirHikayeler();
                MessageBox.Show("Hikaye güncelleme işlemi başarıyla gerçekleşti.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Hikaye güncelleme işlemi gerçekleştirilemedi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int sonuc = DatabaseLayer.SilHikaye(textBox1.Text.Trim());
            if (sonuc == 1)
            {
                dgv1.DataSource = DatabaseLayer.GetirHikayeler();
                lblYazarAdSoyad.Text = "";
                textBox1.Text = "";
                numericUpDown1.Value = 0;
                textBox2.Text = "";
                textBox3.Text = "";
                rtxtbHikayeYaz.Text = "";
                MessageBox.Show("Silme işlemi başarıyla gerçekleşmiştir.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Silme işlemi gerçekleşemedi", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

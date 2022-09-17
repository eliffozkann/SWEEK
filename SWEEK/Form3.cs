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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            dgv2.DataSource = DatabaseLayer.GetirHikayeler();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void dgv2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblBaslik_Click(object sender, EventArgs e)
        {

        }

        private void lblYazan_Click(object sender, EventArgs e)
        {

        }

        private void dgv2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                lblBaslik.Text = dgv2.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtKisa.Text = dgv2.Rows[e.RowIndex].Cells[3].Value.ToString();
                lblYazan.Text = dgv2.Rows[e.RowIndex].Cells[4].Value.ToString();
                rtbOkuma.Text = dgv2.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.ToString());
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

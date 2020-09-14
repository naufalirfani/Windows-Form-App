using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TA_PBO
{
    public partial class ucBalok : UserControl
    {
        public ucBalok()
        {
            InitializeComponent();
        }

        private void btnBalok_Click(object sender, EventArgs e)
        {
            if (tbPanjang.Text == string.Empty | tbLebar.Text == string.Empty | tbTinggi.Text == string.Empty)
            {
                MessageBox.Show("Length, Width, or Height is empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    double p = Convert.ToDouble(tbPanjang.Text);
                    double l = Convert.ToDouble(tbLebar.Text);
                    double t = Convert.ToDouble(tbTinggi.Text);

                    double lPermukaan = 2 * (p * l) + 2 * (p * t) + 2 * (l * t);
                    tbLPBalok.Text = Convert.ToString(lPermukaan);

                    double volume = p * l * t;
                    tbVBalok.Text = Convert.ToString(volume);

                    double pRusuk = 4 * (p + l + t);
                    tbPRBalok.Text = Convert.ToString(pRusuk);


                }
                catch
                {
                    MessageBox.Show("Please enter a number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnKubus_Click(object sender, EventArgs e)
        {
            if (tbSisi.Text == string.Empty)
            {
                MessageBox.Show("Side length is empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    double s = Convert.ToDouble(tbSisi.Text);

                    double luasPermukaan = 6 * (s * s);
                    tbLPKubus.Text = Convert.ToString(luasPermukaan);

                    double volumeKubus = s * s * s;
                    tbVKubus.Text = Convert.ToString(volumeKubus);

                    double panjangRusuk = 12 * s;
                    tbPRKubus.Text = Convert.ToString(panjangRusuk);
                }
                catch
                {
                    MessageBox.Show("Please enter a number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        private void ucBalok_Load(object sender, EventArgs e)
        {
           
        }
    }
}

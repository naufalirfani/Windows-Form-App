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
    public partial class ucPrism : UserControl
    {
        double a, b, c;
        public ucPrism()
        {
            InitializeComponent();
        }

        private void btnTabung_Click(object sender, EventArgs e)
        {
            if (tbRadius.Text == string.Empty)
            {
                MessageBox.Show("Radius is empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    double r = Convert.ToDouble(tbRadius.Text);
                    double t = Convert.ToDouble(tbHeightT.Text);
                    double phi = 3.14;
                    double volume = phi * Math.Pow(r, 2) * t;
                    volume = Math.Round(volume, 2);
                    tbVTabung.Text = Convert.ToString(volume);

                    double luasPermukaan = (2.00000 * phi * Math.Pow(r, 2)) + (2.00000 * phi * r * t);
                    luasPermukaan = Math.Round(luasPermukaan, 2);
                    tbSTabung.Text = Convert.ToString(luasPermukaan);


                }
                catch
                {
                    MessageBox.Show("Please enter a number!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        public void urutkanAngka(double A, double B, double C)
        {
            double temp = 0;
            if (A < B)
            {
                temp = A;
                A = B;
                B = temp;
            }
            if (A < C)
            {
                temp = A;
                A = C;
                C = temp;
            }
            if (B < A)
            {
                temp = B;
                B = A;
                A = temp;
            }
            if (B < C)
            {
                temp = B;
                B = C;
                C = temp;
            }
            if (C < A)
            {
                temp = C;
                C = A;
                A = temp;
            }
            if (C < B)
            {
                temp = C;
                C = B;
                B = temp;
            }

            this.a = A;
            this.b = B;
            this.c = C;
        }
        private void btnSegitiga_Click(object sender, EventArgs e)
        {
            if (tbS1.Text == string.Empty & tbS2.Text == string.Empty & tbS3.Text == string.Empty & tbTinggi.Text == string.Empty)
            {
                MessageBox.Show("Length of the base side and Height is empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tbTinggi.Text == string.Empty)
            {
                MessageBox.Show("Height is empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tbS1.Text == string.Empty && tbS2.Text != string.Empty && tbS3.Text != string.Empty)
            {
                MessageBox.Show("Length of the base side isn't complete", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tbS1.Text != string.Empty && tbS2.Text == string.Empty && tbS3.Text != string.Empty)
            {
                MessageBox.Show("Length of the base side isn't complete", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tbS1.Text != string.Empty && tbS2.Text != string.Empty && tbS3.Text == string.Empty)
            {
                MessageBox.Show("Length of the base side isn't complete", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tbS1.Text != string.Empty && tbS2.Text == string.Empty && tbS3.Text == string.Empty)
            {
                MessageBox.Show("Length of the base side isn't complete", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tbS1.Text == string.Empty && tbS2.Text == string.Empty && tbS3.Text != string.Empty)
            {
                MessageBox.Show("Length of the base side isn't complete", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tbS1.Text == string.Empty && tbS2.Text != string.Empty && tbS3.Text == string.Empty)
            {
                MessageBox.Show("Length of the base side isn't complete", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tbS1.Text == string.Empty & tbS2.Text == string.Empty & tbS3.Text == string.Empty)
            {
                MessageBox.Show("Length of the base side is empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    double s1 = Convert.ToDouble(tbS1.Text);
                    double s2 = Convert.ToDouble(tbS2.Text);
                    double s3 = Convert.ToDouble(tbS3.Text);
                    double t = Convert.ToDouble(tbTinggi.Text);

                    urutkanAngka(s1, s2, s3);

                    if (a + b > c)
                    {
                        double setengah = 0.50000;
                        double s = setengah * (a + b + c);
                        double volume = (Math.Sqrt(s * (s - a) * (s - b) * (s - c))) * t;
                        volume = Math.Round(volume, 2);
                        tbVSegitiga.Text = Convert.ToString(volume);

                        double luasPermukaan = 2.00000 * s + (t*(a + b + c));
                        luasPermukaan = Math.Round(luasPermukaan, 2);
                        tbSSegitiga.Text = Convert.ToString(luasPermukaan);

                    }
                    else
                    {
                        MessageBox.Show("Base side isn't a triangle, please re-enter the length of base side!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch
                {
                    MessageBox.Show("Please enter a number!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}

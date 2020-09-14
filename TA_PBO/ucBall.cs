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
    public partial class ucBall : UserControl
    {
        public ucBall()
        {
            InitializeComponent();
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            if(tbRadius.Text == string.Empty)
            {
                MessageBox.Show("Radius is empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    double phi = 3.14000000000;
                    double radius = Convert.ToDouble(tbRadius.Text);
                    double volumeBall = 4.000000000000 / 3.000000000000 * phi * (Math.Pow(radius, 3));
                    volumeBall = Math.Round(volumeBall, 1);
                    tbVolume.Text = Convert.ToString(volumeBall);
                    
                    double luasPermukaan = 4.0000000000000 * phi * (Math.Pow(radius, 2));
                    luasPermukaan = Math.Round(luasPermukaan, 1);
                    tbSurface.Text = Convert.ToString(luasPermukaan);
                }
                catch
                {
                    MessageBox.Show("Please enter a number!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TA_PBO
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            pnlPenanda.Hide();
            pnlPenanda.Height = btnBola.Height;
            pnlPenanda.Top = btnBola.Top;
        }

        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            pictureBox1.Hide();
            ucBalok1.Hide();
            ucBall1.Hide();
            ucPrism1.Hide();
            pnlPenanda.Show();
            pnlPenanda.Height = btnCalculator.Height;
            pnlPenanda.Top = btnCalculator.Top;
            calculator1.Show();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {
            calculator1.SendToBack();
            ucBalok1.SendToBack();
            ucBall1.SendToBack();
            ucPrism1.SendToBack();
        }

        private void btnBalok_Click(object sender, EventArgs e)
        {
            pictureBox1.Hide();
            calculator1.Hide();
            ucBall1.Hide();
            ucPrism1.Hide();
            pnlPenanda.Show();
            pnlPenanda.Height = btnBalok.Height;
            pnlPenanda.Top = btnBalok.Top;
            ucBalok1.Show();
        }

        private void btnBola_Click(object sender, EventArgs e)
        {
            pictureBox1.Hide();
            ucBalok1.Hide();
            calculator1.Hide();
            ucPrism1.Hide();
            pnlPenanda.Show();
            pnlPenanda.Height = btnBola.Height;
            pnlPenanda.Top = btnBola.Top;
            ucBall1.Show();
        }

        private void btnPrisma_Click(object sender, EventArgs e)
        {
            pictureBox1.Hide();
            calculator1.Hide();
            ucBall1.Hide();
            ucBalok1.Hide();
            pnlPenanda.Show();
            pnlPenanda.Height = btnPrisma.Height;
            pnlPenanda.Top = btnPrisma.Top;
            ucPrism1.Show();
        }
    }
}

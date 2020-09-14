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
    public partial class FormMateri : Form
    {
        public FormMateri()
        {
            InitializeComponent();
            pnlPenanda.Hide();
            pnlPenanda.Height = btnBola.Height;
            pnlPenanda.Top = btnBola.Top;
        }

        private void btnBola_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(192, 192, 255);
            lblTitle.ForeColor = Color.Navy;
            lblKet.ForeColor = Color.Navy;
            splitter1.BackColor = Color.Blue;
            pictureBox1.BackColor = Color.Blue;
            btnBalok.BackColor = Color.Blue;
            btnPrisma.BackColor = Color.Blue;
            btnBola.BackColor = Color.Blue;
            btnBack.BackColor = Color.Blue;
            pnlPenanda.BackColor = Color.Red;
            pictureBox2.Hide();
            pnlPenanda.Show();
            pnlPenanda.Height = btnBola.Height;
            pnlPenanda.Top = btnBola.Top;
            lblKet.Show();
            lblKet.Text = "Surface Area of a Sphere " +
                System.Environment.NewLine +
                "     To find the surface area of a sphere we use" +
                System.Environment.NewLine +
                "a special formula.The answer to this formula " +
                System.Environment.NewLine +
                "will be in square units." +
                System.Environment.NewLine +
                System.Environment.NewLine +
                "                       Surface Area = 4πr ^ 2" +
                System.Environment.NewLine +
                System.Environment.NewLine +
                "Volume of a Sphere" +
                System.Environment.NewLine +
                "     There is another special formula for finding " +
                System.Environment.NewLine +
                "the volume of a sphere.The volume is how much " +
                System.Environment.NewLine +
                "space takes up the inside of a sphere.The answer " +
                System.Environment.NewLine +
                "to a volume question is always in cubic units." +
                System.Environment.NewLine +
                System.Environment.NewLine +
                "                       Volume = 4/3(πr ^ 3)";
            lblKet.Location = new Point(155, 70);
            lblTitle.Show();
            lblTitle.Text = "Sphere";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnBalok_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 192, 192);
            lblKet.ForeColor = Color.Maroon;
            lblTitle.ForeColor = Color.Maroon;
            splitter1.BackColor = Color.Red;
            pictureBox1.BackColor = Color.Red;
            btnBola.BackColor = Color.Red;
            btnBalok.BackColor = Color.Red;
            btnPrisma.BackColor = Color.Red;
            pnlPenanda.BackColor = Color.FromArgb(0, 192, 192);
            btnBack.BackColor = Color.Red;
            pictureBox2.Hide();
            pnlPenanda.Show();
            pnlPenanda.Height = btnBalok.Height;
            pnlPenanda.Top = btnBalok.Top;
            lblTitle.Show();
            lblKet.Show();
            lblTitle.Text = "Beam and Cube";
            lblKet.Text =
                "Beam"+
                System.Environment.NewLine +
                "V = l * w * h                                       l = Length"+
                System.Environment.NewLine +
                "                                                          w = Width"+
                System.Environment.NewLine +
                "S = 2(l*w + l*h + w*h)                     h = Height"+
                System.Environment.NewLine +
                System.Environment.NewLine +
                "Cube" +
                System.Environment.NewLine +
                "     Compute the volume of a cube. Because all" +
                System.Environment.NewLine +
                "sides of a cube are equal, the volume formula is " +
                System.Environment.NewLine +
                "V = s ^ 3, where \"s\" is the length of one side." +
                System.Environment.NewLine +
                System.Environment.NewLine +
                "     Find the surface area of a cube.Because each " +
                System.Environment.NewLine +
                "face has a surface area of s ^ 2 and every cube " +
                System.Environment.NewLine +
                "has six faces, the formula is as follows: " +
                System.Environment.NewLine +
                "Surface area = 6s ^ 2.";

        }

        private void btnPrisma_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(192, 255, 255);
            lblTitle.ForeColor = Color.FromArgb(0, 64, 64);
            lblKet.ForeColor = Color.FromArgb(0, 64, 64);
            splitter1.BackColor = Color.FromArgb(0, 192, 192);
            btnBack.BackColor = Color.FromArgb(0, 192, 192);
            btnBalok.BackColor = Color.FromArgb(0, 192, 192);
            btnBola.BackColor = Color.FromArgb(0, 192, 192);
            btnPrisma.BackColor = Color.FromArgb(0, 192, 192);
            pictureBox1.BackColor = Color.FromArgb(0, 192, 192);
            pnlPenanda.BackColor = Color.Blue;
            pictureBox2.Hide();
            pnlPenanda.Show();
            pnlPenanda.Height = btnPrisma.Height;
            pnlPenanda.Top = btnPrisma.Top;
            lblTitle.Show();
            lblTitle.Text = "Prism";
            lblKet.Show();
            lblKet.Text =
                "Triangular Prism" +
                System.Environment.NewLine +
                "                         V = (Base area) * h" +
                System.Environment.NewLine +
                "                      S = Sum of all side are" +
                System.Environment.NewLine +
                System.Environment.NewLine +
                "Cylinder (tube)" +
                System.Environment.NewLine +
                "Surface Area of a Cylinder" +
                System.Environment.NewLine +
                System.Environment.NewLine +
                "                  Surface area = (2πr ^ 2) + 2πrh" +
                System.Environment.NewLine + System.Environment.NewLine +
                "Volume of a Cylinder" +
                System.Environment.NewLine +
                System.Environment.NewLine +
                "                            Volume = (πr ^ 2)h" +
                System.Environment.NewLine +
                "  r = radius" +
                System.Environment.NewLine +
                "  h = height" +
                System.Environment.NewLine +
                "  π = 3.14";

        }

        private void FormMateri_Load(object sender, EventArgs e)
        {
            lblKet.Hide();
            lblTitle.Hide();
        }
    }
}

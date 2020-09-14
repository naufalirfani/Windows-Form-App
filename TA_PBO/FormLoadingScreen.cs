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
    public partial class FormLoadingScreen : Form
    {
        public FormLoadingScreen()
        {
            InitializeComponent();
        }

        Timer timer;
        private void FormLoadingScreen_Load(object sender, EventArgs e)
        {
            timer = new Timer();
            timer.Interval = 3000;
            timer.Start();
            timer.Tick += timer1_Tick;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }
}

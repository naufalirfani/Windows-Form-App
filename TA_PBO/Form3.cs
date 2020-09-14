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
    public partial class Form3 : Form
    {
        Form4 form4 = new Form4();
        FormTranslate formTranslate = new FormTranslate();
        FormMateri formMateri = new FormMateri();
        public Form3()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            form4.Show();
        }

        private void btnExit3_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
            this.Close();
        }

        private void btnTranslate_Click(object sender, EventArgs e)
        {
            formTranslate.Show();

        }

        private void btnMateri_Click(object sender, EventArgs e)
        {
            formMateri.ShowDialog();
        }
    }
}

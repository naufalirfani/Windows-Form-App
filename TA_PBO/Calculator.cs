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
    public partial class Calculator : UserControl
    {
        double FirstNumber = 0;
        string Operation;
        double SecondNumber;
        public Calculator()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            tbHasil.Text = tbHasil.Text + "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (tbHasil.Text == "0" && tbHasil.Text != null)
            {
                tbHasil.Text = "1";
            }
            else if (tbHasil.Text == string.Empty)
            {
                tbHasil.Text = "1";
            }
            else
            {
                tbHasil.Text = tbHasil.Text + "1";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (tbHasil.Text == "0" && tbHasil.Text != null)
            {
                tbHasil.Text = "2";
            }
            else if(tbHasil.Text == string.Empty)
            {
                tbHasil.Text = "2";
            }
            else
            {
                tbHasil.Text = tbHasil.Text + "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (tbHasil.Text == "0" && tbHasil.Text != null)
            {
                tbHasil.Text = "3";
            }
            else if (tbHasil.Text == string.Empty)
            {
                tbHasil.Text = "3";
            }
            else
            {
                tbHasil.Text = tbHasil.Text + "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (tbHasil.Text == "0" && tbHasil.Text != null)
            {
                tbHasil.Text = "4";
            }
            else if (tbHasil.Text == string.Empty)
            {
                tbHasil.Text = "4";
            }
            else
            {
                tbHasil.Text = tbHasil.Text + "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (tbHasil.Text == "0" && tbHasil.Text != null)
            {
                tbHasil.Text = "5";
            }
            else if (tbHasil.Text == string.Empty)
            {
                tbHasil.Text = "5";
            }
            else
            {
                tbHasil.Text = tbHasil.Text + "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (tbHasil.Text == "0" && tbHasil.Text != null)
            {
                tbHasil.Text = "6";
            }
            else if (tbHasil.Text == string.Empty)
            {
                tbHasil.Text = "6";
            }
            else
            {
                tbHasil.Text = tbHasil.Text + "6";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (tbHasil.Text == "0" && tbHasil.Text != null)
            {
                tbHasil.Text = "7";
            }
            else if (tbHasil.Text == string.Empty)
            {
                tbHasil.Text = "7";
            }
            else
            {
                tbHasil.Text = tbHasil.Text + "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (tbHasil.Text == "0" && tbHasil.Text != null)
            {
                tbHasil.Text = "8";
            }
            else if (tbHasil.Text == string.Empty)
            {
                tbHasil.Text = "8";
            }
            else
            {
                tbHasil.Text = tbHasil.Text + "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (tbHasil.Text == "0" && tbHasil.Text != null)
            {
                tbHasil.Text = "9";
            }
            else if (tbHasil.Text == string.Empty)
            {
                tbHasil.Text = "9";
            }
            else
            {
                tbHasil.Text = tbHasil.Text + "9";
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(tbHasil.Text);
            tbHasil.Text = string.Empty;
            Operation = "+";
        }

        private void btnKursng_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(tbHasil.Text);
            tbHasil.Text = string.Empty;
            Operation = "-";
        }

        private void btnKali_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(tbHasil.Text);
            tbHasil.Text = string.Empty;
            Operation = "*";
        }

        private void btnBagi_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(tbHasil.Text);
            tbHasil.Text = string.Empty;
            Operation = "/";
        }

        private void btnHasil_Click(object sender, EventArgs e)
        {
            
            double Result;

            SecondNumber = Convert.ToDouble(tbHasil.Text);

            if (Operation == "+")
            {
                Result = (FirstNumber + SecondNumber);
                tbHasil.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "-")
            {
                Result = (FirstNumber - SecondNumber);
                tbHasil.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "*")
            {
                Result = (FirstNumber * SecondNumber);
                tbHasil.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "/")
            {
                if (SecondNumber == 0)
                {
                    tbHasil.Text = "Cannot divide by zero";

                }
                else
                {
                    Result = (FirstNumber / SecondNumber);
                    tbHasil.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            tbHasil.Text = "0";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbHasil.Text = string.Empty;
        }

        private void btnKoma_Click(object sender, EventArgs e)
        {
            tbHasil.Text = tbHasil.Text + ".";
        }

        private void btnKuadrat_Click(object sender, EventArgs e)
        {
            if (FirstNumber == 0)
            {
                FirstNumber = Convert.ToDouble(tbHasil.Text);
                tbHasil.Text = Convert.ToString(FirstNumber * FirstNumber);
            }
            else
            {
                SecondNumber = Convert.ToDouble(tbHasil.Text);
                tbHasil.Text = Convert.ToString(SecondNumber * SecondNumber);
            }

            
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TA_PBO
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text == string.Empty && tbPassword.Text == string.Empty)
            {
                MessageBox.Show("Please enter the username and password", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (tbUsername.Text == string.Empty)
            {
                MessageBox.Show("Please enter the username", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (tbPassword.Text == string.Empty)
            {
                MessageBox.Show("Please enter the password", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Naufal\PBO\TA_PBO\TA_PBO\login.mdf;Integrated Security=True;Connect Timeout=30");
                string query = "Select * from [Login] where username = '" + tbUsername.Text + "'and password = '" + tbPassword.Text + "'";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                if (dataTable.Rows.Count == 1)
                {
                    Form3 form3 = new Form3();
                    form3.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Incorrect username or password","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text == string.Empty && tbPassword.Text == string.Empty)
            {
                MessageBox.Show("Please enter the username and password", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (tbUsername.Text == string.Empty)
            {
                MessageBox.Show("Please enter the username", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (tbPassword.Text == string.Empty)
            {
                MessageBox.Show("Please enter the password", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MySQL mySQL = new MySQL();
                mySQL.ReadDataId();
                int maxId = mySQL.max2 + 1;
                mySQL.InsertData(tbUsername.Text, tbPassword.Text, maxId);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            MySQL mySQL = new MySQL();
            mySQL.ReadData();
            tbUsername.Text = mySQL.Username;
            tbPassword.Text = mySQL.Password;
            
        }

        private void tbPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                e.Handled = true;
                btnLogin.PerformClick();
            }
        }

        private void tbUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                btnLogin.PerformClick();
            }
        }
    }
}

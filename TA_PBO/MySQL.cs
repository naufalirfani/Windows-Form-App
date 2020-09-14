using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TA_PBO
{
    public class MySQL : IAkun
    {
        public string username1, password1;

        public int max = 0, max2 = 0;

        public string Username
        {
            get
            {
                return username1;
            }
        }
        public string Password
        {
            get
            {
                return password1;
            }
        }

        public void InsertData(string username, string password, int id)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Naufal\PBO\TA_PBO\TA_PBO\login.mdf;Integrated Security=True;Connect Timeout=30");
            string query = "Select * from [Login] where username = '" + username + "'";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                MessageBox.Show("Username is already use!");
            }
            else
            {
                try
                {
                    string commString = "INSERT INTO [Login](username, password, Id) VALUES (@val1, @val2, @val3)";
                    string conString = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Naufal\PBO\TA_PBO\TA_PBO\login.mdf;Integrated Security=True;Connect Timeout=30";

                    using (SqlConnection conn = new SqlConnection(conString))
                    {
                        using (SqlCommand comm = new SqlCommand())
                        {
                            comm.Connection = conn;
                            comm.CommandText = commString;
                            comm.Parameters.AddWithValue("@val1", username);
                            comm.Parameters.AddWithValue("@val2", password);
                            comm.Parameters.AddWithValue("@val3", id);
                            conn.Open();
                            comm.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Sucessfully create an account!","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Can't create an account, please contact our developer","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }

        public void ReadData()
        {
            // declare the SqlDataReader, which is used in
            // both the try block and the finally block
            SqlDataReader sqlDataReader = null;

            // create a connection object
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Naufal\PBO\TA_PBO\TA_PBO\login.mdf;Integrated Security=True;Connect Timeout=30");

            // create a command object
            SqlCommand sqlCommand = new SqlCommand("select * from [Login] ", sqlConnection);

            try
            {
                // open the connection
                sqlConnection.Open();

                // 1. get an instance of the SqlDataReader
                sqlDataReader = sqlCommand.ExecuteReader();

                do
                {

                    while (sqlDataReader.Read())
                    {
                        // get the results of each column
                        int sesudah = (int)sqlDataReader["Id"];
                        if (sesudah >= this.max)
                        {
                            this.username1 = (string)sqlDataReader["username"];
                            this.password1 = (string)sqlDataReader["password"];
                            this.max = sesudah;
                        }
                    }
                }
                while (sqlDataReader.NextResult());
            }
            finally
            {
                // 3. close the reader
                if (sqlDataReader != null)
                {
                    sqlDataReader.Close();
                }

                // close the connection
                if (sqlConnection != null)
                {
                    sqlConnection.Close();
                }
            }
        }

        public void ReadDataId()
        {
            SqlDataReader sqlDataReader = null;
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Naufal\PBO\TA_PBO\TA_PBO\login.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand sqlCommand = new SqlCommand("select * from [Login] ", sqlConnection);

            try
            {
                sqlConnection.Open();
                sqlDataReader = sqlCommand.ExecuteReader();

                do
                {

                    while (sqlDataReader.Read())
                    {
                        int sesudah2 = (int)sqlDataReader["Id"];
                        if (sesudah2 >= this.max2)
                        {
                            this.max2 = sesudah2;
                        }
                    }
                }
                while (sqlDataReader.NextResult());
            }
            finally
            {
                if (sqlDataReader != null)
                {
                    sqlDataReader.Close();
                }

                if (sqlConnection != null)
                {
                    sqlConnection.Close();
                }
            }
        }


    }
}

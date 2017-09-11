using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryOfMakers
{
    public partial class LoginUser : Form
    {
        SqlConnection Konek = new SqlConnection("Data Source=.;Initial Catalog=MakersDB;Integrated Security=True");

        public LoginUser()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT Count(*) FROM username Where username = '" + UsernameText.Text + "' AND password = '" + PasswordText.Text + "'", Konek);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                Form1 FM = new Form1();
                FM.Show();
            }
            else
            {
                MessageBox.Show("Please check your username or password.");
            }

            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Konek.Open();
            SqlCommand CMD = Konek.CreateCommand();
            CMD.CommandType = CommandType.Text;
            CMD.CommandText = "INSERT INTO USERNAME VALUES ('" + UsernameText.Text + "','" + PasswordText.Text + "');";
            CMD.ExecuteNonQuery();
            Konek.Close();
            MessageBox.Show("REGISTERED!!! Please Login . . .");
        }

        private void GuestLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            GUESS log = new GUESS();
            log.Show();
        }
    }
}

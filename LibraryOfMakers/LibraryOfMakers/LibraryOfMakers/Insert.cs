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

namespace LibraryOfMakers
{
    public partial class Insert : Form
    {
        SqlConnection Konek = new SqlConnection("Data Source=.;Initial Catalog=MakersDB;Integrated Security=True");
        public Insert()
        {
            InitializeComponent();
            dis_data();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            Konek.Open();
            SqlCommand CMD = Konek.CreateCommand();
            CMD.CommandType = CommandType.Text;
            CMD.CommandText = "INSERT INTO Books VALUES ('"+textBoxISBN.Text+"','"+textBoxTitle.Text+"','"+textBoxYear.Text+"','"+textBoxPage.Text+"')";
            CMD.ExecuteNonQuery();
            Konek.Close();
            dis_data();
            MessageBox.Show("Insert Succes");
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            Konek.Open();
            SqlCommand CMD = Konek.CreateCommand();
            CMD.CommandType = CommandType.Text;
            CMD.CommandText = ("DELETE FROM BOOKS WHERE ISBN='"+textBoxISBN.Text+"'");
            CMD.ExecuteNonQuery();
            Konek.Close();
            dis_data();
            MessageBox.Show("Delete Succes");
        }

        private void dis_data()
        {
            Konek.Open();
            SqlCommand CMD = Konek.CreateCommand();
            CMD.CommandType = CommandType.Text;
            CMD.CommandText = "SELECT*FROM Books";
            CMD.ExecuteNonQuery();
            DataTable DataTab = new DataTable();
            SqlDataAdapter DataAdap = new SqlDataAdapter(CMD);
            DataAdap.Fill(DataTab);
            dataGridView1.DataSource = DataTab;
            Konek.Close();
        }

        private void Insert_Load(object sender, EventArgs e)
        {
            dis_data();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            Konek.Open();
            SqlCommand CMD = Konek.CreateCommand();
            CMD.CommandType = CommandType.Text;
            CMD.CommandText = ("UPDATE Books SET ISBN='" + textBoxISBN.Text + "' WHERE ISBN='"+textBoxTitle.Text+"' " );
            CMD.ExecuteNonQuery();
            Konek.Close();
            dis_data();
            MessageBox.Show("Delete Succes");
        }
    }
}

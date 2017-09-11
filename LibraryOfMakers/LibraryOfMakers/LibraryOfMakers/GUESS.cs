﻿using System;
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
    public partial class GUESS : Form
    {
        SqlConnection Konek = new SqlConnection("Data Source=.;Initial Catalog=MakersDB;Integrated Security=True");

        public GUESS()
        {
            InitializeComponent();

            TextValue.Tag = "Insert your value here . . .";
            TextValue.Text = (string)TextValue.Tag;
        }

        private void SHOWALL_Click(object sender, EventArgs e)
        {
            Konek.Open();
            SqlCommand CMD = Konek.CreateCommand();
            CMD.CommandType = CommandType.Text;
            CMD.CommandText = "  SELECT DISTINCT B.ISBN, B.Title, A.AuthorName, P.PublisherName,L.Language,  B.Year, C.CategoryName, B.Page, K.NamaKota FROM Books B LEFT OUTER JOIN BookAuthor BA ON B.ISBN = BA.ISBN LEFT OUTER JOIN AUTHOR A ON BA.AuthorID = A.AuthorID LEFT OUTER JOIN BookCategory BC ON B.ISBN = BC.ISBN LEFT OUTER JOIN Category C ON BC.CategoryID = C.CategoryID LEFT OUTER JOIN BookPublisher BP ON BP.ISBN = B.ISBN LEFT OUTER JOIN Publisher P ON BP.PublisherID = P.PublisherID LEFT OUTER JOIN BookLanguage BL ON B.ISBN = BL.ISBN LEFT OUTER JOIN Language L ON BL.LanguagID = L.LanguageID LEFT OUTER JOIN Kota K ON	P.KotaID = K.KotaID;";
            CMD.ExecuteNonQuery();
            DataTable DataTab = new DataTable();
            SqlDataAdapter DataAdap = new SqlDataAdapter(CMD);
            DataAdap.Fill(DataTab);
            GuestGrid.DataSource = DataTab;
            Konek.Close();
        }

        private void GuestISBN_Click(object sender, EventArgs e)
        {
            Konek.Open();
            SqlCommand CMD = Konek.CreateCommand();
            CMD.CommandType = CommandType.Text;
            CMD.CommandText = "SELECT DISTINCT B.ISBN,  B.Title, A.AuthorName, P.PublisherName,L.Language,  B.Year, B.Page, K.NamaKota FROM Books B JOIN BookAuthor BA ON B.ISBN = BA.ISBN JOIN AUTHOR A ON BA.AuthorID = A.AuthorID JOIN BookCategory BC ON B.ISBN = BC.ISBN JOIN Category C ON BC.CategoryID = C.CategoryID JOIN BookPublisher BP ON BP.ISBN = B.ISBN JOIN Publisher P ON BP.PublisherID = P.PublisherID JOIN BookLanguage BL ON B.ISBN = BL.ISBN JOIN Language L ON BL.LanguagID = L.LanguageID JOIN Kota K ON	P.KotaID = K.KotaID WHERE B.ISBN  LIKE '%" + TextValue.Text + "%';";
            CMD.ExecuteNonQuery();
            DataTable DataTab = new DataTable();
            SqlDataAdapter DataAdap = new SqlDataAdapter(CMD);
            DataAdap.Fill(DataTab);
            GuestGrid.DataSource = DataTab;
            Konek.Close();
        }

        private void GuessTitle_Click(object sender, EventArgs e)
        {
            Konek.Open();
            SqlCommand CMD = Konek.CreateCommand();
            CMD.CommandType = CommandType.Text;
            CMD.CommandText = "SELECT DISTINCT B.ISBN,  B.Title, A.AuthorName, P.PublisherName,L.Language,  B.Year, B.Page, K.NamaKota FROM Books B JOIN BookAuthor BA ON B.ISBN = BA.ISBN JOIN AUTHOR A ON BA.AuthorID = A.AuthorID JOIN BookCategory BC ON B.ISBN = BC.ISBN JOIN Category C ON BC.CategoryID = C.CategoryID JOIN BookPublisher BP ON BP.ISBN = B.ISBN JOIN Publisher P ON BP.PublisherID = P.PublisherID JOIN BookLanguage BL ON B.ISBN = BL.ISBN JOIN Language L ON BL.LanguagID = L.LanguageID JOIN Kota K ON	P.KotaID = K.KotaID WHERE B.TITLE  LIKE '%" + TextValue.Text + "%';";
            CMD.ExecuteNonQuery();
            DataTable DataTab = new DataTable();
            SqlDataAdapter DataAdap = new SqlDataAdapter(CMD);
            DataAdap.Fill(DataTab);
            GuestGrid.DataSource = DataTab;
            Konek.Close();
        }

        private void GuessAuthor_Click(object sender, EventArgs e)
        {
            Konek.Open();
            SqlCommand CMD = Konek.CreateCommand();
            CMD.CommandType = CommandType.Text;
            CMD.CommandText = "SELECT DISTINCT B.ISBN,  B.Title, A.AuthorName, P.PublisherName,L.Language,  B.Year, B.Page, K.NamaKota FROM Books B JOIN BookAuthor BA ON B.ISBN = BA.ISBN JOIN AUTHOR A ON BA.AuthorID = A.AuthorID JOIN BookCategory BC ON B.ISBN = BC.ISBN JOIN Category C ON BC.CategoryID = C.CategoryID JOIN BookPublisher BP ON BP.ISBN = B.ISBN JOIN Publisher P ON BP.PublisherID = P.PublisherID JOIN BookLanguage BL ON B.ISBN = BL.ISBN JOIN Language L ON BL.LanguagID = L.LanguageID JOIN Kota K ON	P.KotaID = K.KotaID WHERE A.Authorname  LIKE '%" + TextValue.Text + "%';";
            CMD.ExecuteNonQuery();
            DataTable DataTab = new DataTable();
            SqlDataAdapter DataAdap = new SqlDataAdapter(CMD);
            DataAdap.Fill(DataTab);
            GuestGrid.DataSource = DataTab;
            Konek.Close();
        }

        private void GuestPublisher_Click(object sender, EventArgs e)
        {
            Konek.Open();
            SqlCommand CMD = Konek.CreateCommand();
            CMD.CommandType = CommandType.Text;
            CMD.CommandText = "SELECT DISTINCT B.ISBN,  B.Title, A.AuthorName, P.PublisherName,L.Language,  B.Year, B.Page, K.NamaKota  FROM Books B  JOIN BookAuthor BA ON B.ISBN = BA.ISBN  JOIN AUTHOR A ON BA.AuthorID = A.AuthorID JOIN BookCategory BC ON B.ISBN = BC.ISBN JOIN Category C ON BC.CategoryID = C.CategoryID JOIN BookPublisher BP ON BP.ISBN = B.ISBN JOIN Publisher P ON BP.PublisherID = P.PublisherID JOIN BookLanguage BL ON B.ISBN = BL.ISBN JOIN Language L ON BL.LanguagID = L.LanguageID JOIN Kota K ON	P.KotaID = K.KotaID WHERE P.PublisherName  LIKE '%" + TextValue.Text + "%';";
            CMD.ExecuteNonQuery();
            DataTable DataTab = new DataTable();
            SqlDataAdapter DataAdap = new SqlDataAdapter(CMD);
            DataAdap.Fill(DataTab);
            GuestGrid.DataSource = DataTab;
            Konek.Close();
        }

        private void GuestLanguage_Click(object sender, EventArgs e)
        {
            Konek.Open();
            SqlCommand CMD = Konek.CreateCommand();
            CMD.CommandType = CommandType.Text;
            CMD.CommandText = "SELECT DISTINCT B.ISBN,  B.Title, A.AuthorName, P.PublisherName,L.Language,  B.Year, B.Page, K.NamaKota FROM Books B JOIN BookAuthor BA ON B.ISBN = BA.ISBN JOIN AUTHOR A ON BA.AuthorID = A.AuthorID JOIN BookCategory BC ON B.ISBN = BC.ISBN JOIN Category C ON BC.CategoryID = C.CategoryID JOIN BookPublisher BP ON BP.ISBN = B.ISBN JOIN Publisher P ON BP.PublisherID = P.PublisherID JOIN BookLanguage BL ON B.ISBN = BL.ISBN JOIN Language L ON BL.LanguagID = L.LanguageID JOIN Kota K ON	P.KotaID = K.KotaID WHERE L.Language  LIKE '%" + TextValue.Text + "%';";
            CMD.ExecuteNonQuery();
            DataTable DataTab = new DataTable();
            SqlDataAdapter DataAdap = new SqlDataAdapter(CMD);
            DataAdap.Fill(DataTab);
            GuestGrid.DataSource = DataTab;
            Konek.Close();
        }

        private void GuestCategory_Click(object sender, EventArgs e)
        {
            Konek.Open();
            SqlCommand CMD = Konek.CreateCommand();
            CMD.CommandType = CommandType.Text;
            CMD.CommandText = "SELECT DISTINCT B.ISBN,  B.Title, A.AuthorName, P.PublisherName,L.Language,  B.Year, B.Page, K.NamaKota FROM Books B JOIN BookAuthor BA ON B.ISBN = BA.ISBN JOIN AUTHOR A ON BA.AuthorID = A.AuthorID JOIN BookCategory BC ON B.ISBN = BC.ISBN JOIN Category C ON BC.CategoryID = C.CategoryID JOIN BookPublisher BP ON BP.ISBN = B.ISBN JOIN Publisher P ON BP.PublisherID = P.PublisherID JOIN BookLanguage BL ON B.ISBN = BL.ISBN JOIN Language L ON BL.LanguagID = L.LanguageID JOIN Kota K ON	P.KotaID = K.KotaID WHERE C.CategoryName  LIKE '%" + TextValue.Text + "%';";
            CMD.ExecuteNonQuery();
            DataTable DataTab = new DataTable();
            SqlDataAdapter DataAdap = new SqlDataAdapter(CMD);
            DataAdap.Fill(DataTab);
            GuestGrid.DataSource = DataTab;
            Konek.Close();
        }

        private void GuestCity_Click(object sender, EventArgs e)
        {
            Konek.Open();
            SqlCommand CMD = Konek.CreateCommand();
            CMD.CommandType = CommandType.Text;
            CMD.CommandText = "SELECT DISTINCT B.ISBN,  B.Title, A.AuthorName, P.PublisherName,L.Language,  B.Year, B.Page, K.NamaKota FROM Books B JOIN BookAuthor BA ON B.ISBN = BA.ISBN JOIN AUTHOR A ON BA.AuthorID = A.AuthorID JOIN BookCategory BC ON B.ISBN = BC.ISBN JOIN Category C ON BC.CategoryID = C.CategoryID JOIN BookPublisher BP ON BP.ISBN = B.ISBN JOIN Publisher P ON BP.PublisherID = P.PublisherID JOIN BookLanguage BL ON B.ISBN = BL.ISBN JOIN Language L ON BL.LanguagID = L.LanguageID JOIN Kota K ON	P.KotaID = K.KotaID WHERE K.NamaKota LIKE '%" + TextValue.Text + "%';";
            CMD.ExecuteNonQuery();
            DataTable DataTab = new DataTable();
            SqlDataAdapter DataAdap = new SqlDataAdapter(CMD);
            DataAdap.Fill(DataTab);
            GuestGrid.DataSource = DataTab;
            Konek.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginUser log = new LoginUser();
            log.Show();
        }
    }
}

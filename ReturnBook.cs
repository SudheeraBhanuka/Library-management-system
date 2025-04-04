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

namespace GUI_CW
{
    public partial class ReturnBook : Form
    {
        public ReturnBook()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int index = Convert.ToInt32(memberIDtxt.Text);
                int bookid = Convert.ToInt32(bookIdtxt.Text);

                SqlConnection con = new DBconnection().connectDB();
                string query = "DELETE FROM issuedBooks WHERE bookID=@bookid AND memberIndex=@index";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@bookid", bookid);
                cmd.Parameters.AddWithValue("@index", index);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                this.Close();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Invalid input");
                memberIDtxt.Clear();
                bookIdtxt.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void memberIDtxt_TextChanged(object sender, EventArgs e)
        {
            int retrieve = Convert.ToInt32(memberIDtxt.Text);

            SqlConnection con = new DBconnection().connectDB();

            string query = "SELECT * FROM members WHERE indexNo=@retrieve";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@retrieve", retrieve);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                nameTxt.Text = rdr.GetString(1);
            }
        }

        private void bookIdtxt_TextChanged(object sender, EventArgs e)
        {
            int retrieve = Convert.ToInt32(bookIdtxt.Text);

            SqlConnection con = new DBconnection().connectDB();

            string query = "SELECT * FROM books WHERE bookID=@retrieve";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@retrieve", retrieve);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                bookNameTxt.Text = rdr.GetString(1);
            }
        }
    }
}

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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI_CW
{
    public partial class IssueBook : Form
    {
        public IssueBook()
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
                string memberName = nameTxt.Text;
                string bookName = bookNameTxt.Text;
                int memberID = Convert.ToInt32(memberIDtxt.Text);
                int bookId = Convert.ToInt32(bookIDtxt.Text);
                string issuedDate = dateIssued.Value.ToShortDateString();

                SqlConnection con = new DBconnection().connectDB();

                string sql = "INSERT INTO issuedBooks(bookID, bookName, memberIndex, memberName, DateAndTime)" +
                    "VALUES(@bookID, @bookName, @memberID, @memberName, @dateAndTime)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@bookID", bookId);
                cmd.Parameters.AddWithValue("@bookName", bookName);
                cmd.Parameters.AddWithValue("@memberID", memberID);
                cmd.Parameters.AddWithValue("@memberName", memberName);
                cmd.Parameters.AddWithValue("@dateAndTime", issuedDate);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                this.Close();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Invalid input");
                nameTxt.Clear();
                bookNameTxt.Clear();
                memberIDtxt.Clear();
                bookIDtxt.Clear();
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

        private void bookIDtxt_TextChanged(object sender, EventArgs e)
        {
            int retrieve = Convert.ToInt32(bookIDtxt.Text);

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

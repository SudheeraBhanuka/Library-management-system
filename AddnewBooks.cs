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
    public partial class AddnewBooks : Form
    {
        public AddnewBooks()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string bookName = bookNameTxt.Text;
                string author = authorNameTxt.Text;
                string isbnNo = isbnTxt.Text;
                string dateofpub = publishedDateTxt.Value.ToShortDateString();
                int noOfCopies = Convert.ToInt32(numOfCopiesTxt.Text);

                SqlConnection con = new DBconnection().connectDB();

                string sql = "INSERT INTO books(bookName, author, isbn, dateofpub, noOfCopies)" +
                    "VALUES(@bookName, @author, @isbn, @dateofpub, @noOfCopies)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@bookname", bookName);
                cmd.Parameters.AddWithValue("@author", author);
                cmd.Parameters.AddWithValue("@isbn", isbnNo);
                cmd.Parameters.AddWithValue("@dateofpub", dateofpub);
                cmd.Parameters.AddWithValue("@noOfCopies", noOfCopies);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                this.Close();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Invalid input");
                bookNameTxt.Clear();
                authorNameTxt.Clear();
                isbnTxt.Clear();
                numOfCopiesTxt.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

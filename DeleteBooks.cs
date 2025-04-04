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
    public partial class DeleteBooks : Form
    {
        public DeleteBooks()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var result = MessageBox.Show("do you want to delete this book? this can't be undone", "Confirm Delete", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    int index = Convert.ToInt32(bookIndexTxt.Text);

                    SqlConnection con = new DBconnection().connectDB();
                    string query = "DELETE FROM books WHERE bookID=@index";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@index", index);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    this.Close();
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Invalid input");
                bookIndexTxt.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bookIndexTxt_TextChanged(object sender, EventArgs e)
        {
            int retrieve = Convert.ToInt32(bookIndexTxt.Text);

            SqlConnection con = new DBconnection().connectDB();

            string query = "SELECT * FROM books WHERE bookID=@retrieve";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@retrieve", retrieve);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                bookNameTxt.Text = rdr.GetString(1);
                textBox1.Text = rdr.GetString(2);
            }
        }
    }
}

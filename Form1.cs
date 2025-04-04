using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI_CW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection con = new DBconnection().connectDB();
            string query = "SELECT * FROM books";
            string qureyformembers = "SELECT * FROM members";
            con.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, con);
            SqlDataAdapter dataAdapter2 = new SqlDataAdapter(qureyformembers, con);

            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            DataTable dataTable2 = new DataTable();
            dataAdapter2.Fill(dataTable2);

            int bookCount = dataTable.Rows.Count;
            noOfBooksTxt.Text = bookCount.ToString();

            int memberCount = dataTable2.Rows.Count;
            noOfMembersTxt.Text = memberCount.ToString();
            
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewAllBooks booksPage = new ViewAllBooks();
            booksPage.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            All_Members membersPage = new All_Members();
            membersPage.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("do you want to exit?", "EXIT", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {


                Application.Exit();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Issued_Books issuedBooks = new Issued_Books();
            issuedBooks.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {

            var result = MessageBox.Show("Are you sure you want to log out?", "Log Out", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                LoginForm loginform = new LoginForm();
                loginform.Show();
                this.Close();
            }

        }
    }
}

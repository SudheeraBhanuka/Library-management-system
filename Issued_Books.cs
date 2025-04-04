using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_CW
{
    public partial class Issued_Books : Form
    {
        public Issued_Books()
        {
            InitializeComponent();
        }

        private void ExitLbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            Form1 dashboard = new Form1();
            dashboard.Show();
            this.Hide();
        }

        private void usersBtn_Click(object sender, EventArgs e)
        {
            All_Members membersPage = new All_Members();
            membersPage.Show();
            this.Hide();
        }

        private void booksViewBtn_Click(object sender, EventArgs e)
        {
            ViewAllBooks viewAllBooks = new ViewAllBooks();
            viewAllBooks.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IssueBook issueBook = new IssueBook();  
            issueBook.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReturnBook returnBook = new ReturnBook();
            returnBook.Show();
        }

        private void Issued_Books_Load(object sender, EventArgs e)
        {
            readData();
            timer3.Start();
        }

        private void readData()
        {
            SqlConnection con = new DBconnection().connectDB();
            string query = "SELECT * FROM issuedBooks";
            con.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, con);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            issuedBooksView.DataSource = dataTable;

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            readData();
            timer3.Start();
        }
    }
}

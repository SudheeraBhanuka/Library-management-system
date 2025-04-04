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
    public partial class ViewAllBooks : Form
    {
        public ViewAllBooks()
        {
            InitializeComponent();
        }

        private void ExitLbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void usersBtn_Click(object sender, EventArgs e)
        {
            All_Members members = new All_Members();
            members.Show();
            this.Hide();
        }

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            Form1 dashboard = new Form1();
            dashboard.Show();
            this.Hide();
        }

        private void issueReturn_Click(object sender, EventArgs e)
        {
            Issued_Books issued_Books = new Issued_Books();
            issued_Books.Show();
            this.Hide();
        }

        private void addbookBtn_Click(object sender, EventArgs e)
        {
            AddnewBooks addBooks = new AddnewBooks();
            addBooks.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DeleteBooks deleteBooks = new DeleteBooks();
            deleteBooks.Show();
        }

        private void ViewAllBooks_Load(object sender, EventArgs e)
        {
            //SqlConnection con = new DBconnection().connectDB();
            //string query = "SELECT * FROM books";
            //con.Open();
            //SqlDataAdapter dataAdapter = new SqlDataAdapter(query, con);
            //DataTable dataTable = new DataTable();
            //dataAdapter.Fill(dataTable);
            //dataGridViewBooks.DataSource = dataTable ;
           // //con.Close();
            readData();
            timer1.Start();
        }

        private void dataGridViewBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void readData()
        {
            SqlConnection con = new DBconnection().connectDB();
            string query = "SELECT * FROM books";
            con.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, con);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridViewBooks.DataSource = dataTable;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            readData();
            timer1.Start();
        }
    }
}

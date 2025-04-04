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
    public partial class All_Members : Form
    {
        public All_Members()
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

        private void booksViewBtn_Click(object sender, EventArgs e)
        {
            ViewAllBooks viewAllBooks = new ViewAllBooks();
            viewAllBooks.Show();
            this.Hide();
        }

        private void issueReturn_Click(object sender, EventArgs e)
        {
            Issued_Books issued_Books = new Issued_Books();
            issued_Books.Show();
            this.Hide();
        }

        private void AddMemberBtn_Click(object sender, EventArgs e)
        {
            AddnewMembers addMember = new AddnewMembers();
            addMember.Show();
        }

        private void removeUserBtn_Click(object sender, EventArgs e)
        {
            DeleteMembers deleteMembers = new DeleteMembers();
            deleteMembers.Show();
        }

        private void All_Members_Load(object sender, EventArgs e)
        {
           // SqlConnection con = new DBconnection().connectDB();
           // string query = "SELECT * FROM members";
           // con.Open();
           // SqlDataAdapter dataAdapter = new SqlDataAdapter(query, con);
           // DataTable dataTable = new DataTable();
           // dataAdapter.Fill(dataTable);
           // dataGridViewUsers.DataSource = dataTable;
           readData();
            timer2.Start();

        }

        private void readData()
        {
            SqlConnection con = new DBconnection().connectDB();
            string query = "SELECT * FROM members";
            con.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, con);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridViewUsers.DataSource = dataTable;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            readData();
            timer2.Start();
        }
    }
}

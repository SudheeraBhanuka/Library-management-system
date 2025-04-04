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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signupBtn_Click(object sender, EventArgs e)
        {
            RegisterForm rForm = new RegisterForm();
            rForm.Show();
            this.Hide();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string username;
                string password;

                //..............................................
                string retrieve = textUsrname.Text;

                SqlConnection con = new DBconnection().connectDB();

                string query = "SELECT * FROM users WHERE username=@retrieve";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@retrieve", retrieve);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    password = rdr.GetString(2);
                }
                else
                {
                    password = ".";
                }
                //................................

                if (password == textPassword.Text)
                {
                    Form1 dashboard = new Form1();
                    dashboard.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid username or password, please try again or register.", "Login Faild", MessageBoxButtons.OK);
                }

            }
            catch (FormatException ex)
            {
                MessageBox.Show("Invlid Input");
                textPassword.Clear();
                textUsrname.Clear();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
                textPassword.Clear();
                textUsrname.Clear();
            }
        }
    }
}

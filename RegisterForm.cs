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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void signin_btn_Click(object sender, EventArgs e)
        {
            LoginForm lForm = new LoginForm();
            lForm.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string username = usernameTxt.Text;
                string password = passwordTxt.Text;
                string email = emailTxt.Text;

                SqlConnection con = new DBconnection().connectDB();

                string sql = "INSERT INTO users(username, passwordTxt,emailAddress)" +
                    "VALUES (@usernameTxt, @passwordTxt, @emailTxt)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@usernameTxt", username);
                cmd.Parameters.AddWithValue("@passwordTxt", password);
                cmd.Parameters.AddWithValue("@emailTxt", email);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                LoginForm lForm = new LoginForm();
                lForm.Show();
                this.Close();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Invalid input");
                usernameTxt.Clear();
                passwordTxt.Clear();
                emailTxt.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

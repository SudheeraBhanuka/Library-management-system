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
    public partial class AddnewMembers : Form
    {
        public AddnewMembers()
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
                //add member to the database table
                string memberName = memberNameTxt.Text;
                string address = addressTxt.Text;
                string contactNo = contactNoTxt.Text;
                string email = emailTxt.Text;

                SqlConnection con = new DBconnection().connectDB();

                string sql = "INSERT INTO members(memberName, email, homrAddress, contactNo)" +
                    "VALUES(@name, @email, @address, @contactNo)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@name", memberName);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@contactNo", contactNo);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                this.Close();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Invalid input");
                memberNameTxt.Clear();
                addressTxt.Clear();
                emailTxt.Clear();
                contactNoTxt.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

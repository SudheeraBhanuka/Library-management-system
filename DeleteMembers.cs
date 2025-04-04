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
    public partial class DeleteMembers : Form
    {
        public DeleteMembers()
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
                var result = MessageBox.Show("do you want to remove this member? this can't be undone", "Confirm Delete", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    int index = Convert.ToInt32(indexTxt.Text);

                    SqlConnection con = new DBconnection().connectDB();
                    string query = "DELETE FROM members WHERE indexNo=@index";
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
                indexTxt.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void indexTxt_TextChanged(object sender, EventArgs e)
        {
            int retrieve = Convert.ToInt32(indexTxt.Text);

            SqlConnection con = new DBconnection().connectDB();

            string query = "SELECT * FROM members WHERE indexNo=@retrieve";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@retrieve", retrieve);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                nameTxt.Text = rdr.GetString(1);
                emailTxt.Text = rdr.GetString(2);
            }
        }
    }
}

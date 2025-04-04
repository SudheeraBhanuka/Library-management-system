using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Net.Configuration;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace GUI_CW
{
    internal class DBconnection
    {
        public SqlConnection connectDB()
        {
            //Change the Connection String ("con_string")
            string con_string = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"TestELibrary.mdf\";Integrated Security=True;Connect Timeout=30";
            SqlConnection con = new SqlConnection(con_string);
            return con;
        }
    }
}

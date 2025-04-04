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
            string con_string = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\94710\\Desktop\\GUI CW\\GUI CW\\bin\\Debug\\TestELibrary.mdf\";Integrated Security=True;Connect Timeout=30";
            SqlConnection con = new SqlConnection(con_string);
            return con;
        }
    }
}

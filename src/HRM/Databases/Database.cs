using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data.OleDb;

namespace HRM.Databases

{
    public class Database
    {
        public static bool IsDatabase;
        public static string PathName { get; set; }
        public static string serverName;
        public static SqlConnection Connect()
        {

            // Change Path Name if u want
            serverName = "dominic";
            PathName = $@"Data Source=3S-IT-SARUFRATU\MSSQLSERVER1;Initial Catalog=HRM;Integrated Security=True";

            try
            {
                IsDatabase = true;
                SqlConnection connection = new SqlConnection(PathName);
                return connection;
            }
            catch (Exception ex)
            {
                IsDatabase = false;
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }


    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DM_app.Modeli
{
        public static class DB
        {
           private static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ZEKO\Documents\BazaPodatakaDeliverMe1.mdf;Integrated Security=True;Connect Timeout=30";

            internal static SqlConnection con = new SqlConnection(connectionString);

            internal static void OpenCon()
            {

                con.Open();
            }

            internal static void CloseCon()
            {
                con.Close();
                
            }
        }
}

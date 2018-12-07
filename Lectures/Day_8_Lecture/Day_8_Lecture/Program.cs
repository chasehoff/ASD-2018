// DEV-231
// Objective: Test your connection from C# on a Windows VMWare instance to MySQL on a Macbook
// This code will connect to MySQL and display the version.
// Be sure both VMWare/Windows and MAMP is running

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace db_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start\n");

            // MySQL Database Connection String
            string cs = @"server=10.63.23.175;userid=dbsAdmin1811;password=password;database=example_1812;port=8889";

            // Declare a MySQL Connection
            MySqlConnection conn = null;

            try
            {
                // Open a connection to MySQL
                conn = new MySqlConnection(cs);
                conn.Open();

                // Form SQL Statement
                string stm = "SELECT VERSION()";

                Console.WriteLine("1\n");

                // Prepare SQL Statement
                MySqlCommand cmd = new MySqlCommand(stm, conn);

                // Execute SQL Statement and Convert Results to a String
                string version = Convert.ToString(cmd.ExecuteScalar());

                Console.WriteLine("2\n"); 

                // Output Results
                Console.WriteLine("MySQL version : {0}", version);

            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            Console.WriteLine("Done");
        }
    }
}

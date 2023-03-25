using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySQL.Data;
using MySql.Data.MySqlClient;


namespace UniMindProject
{
    class theDatabase
    {
        //this is where the code for the database will be held
        public static MySqlConnection GetConnection()
        {
            string connStr = "server=localhost;user=root;database=UniMind;port=3306;password=L3tM31n"; //paramenters will change once deployed on cloud
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL database...");
                conn.Open();
                Console.WriteLine("connection successful");


            }
            catch (Exception)
            {
                Console.WriteLine("theres been an error");
            }
            conn.Close(); // close the connection 
            return conn;
        }
    }



    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySQL.Data;
using MySql.Data.MySqlClient;

namespace UniMindProject
{
    public class SQLDatabase
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
        public static void RegisterStudent()
        {
            //this is for storing the new students information in the database  
        }
        public static void LoginStudent()
        {
            //this is for exsiting students to check the log in details match that in the database
        }

        public static void LoginPageDatabase()
        {
            GetConnection().Open();

            // if button1 clicked:
            RegisterStudent();
            //if button2 clicked:
            LoginStudent();
        }
    }
}
    
       
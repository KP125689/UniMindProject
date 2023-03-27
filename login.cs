using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySQL.Data;
using MySql.Data.MySqlClient;
using System.Security.Cryptography.X509Certificates;
using System.Drawing.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UniMindProject
{
    public partial class login : Form
    {

        public login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            insights testform = new insights();
            testform.Show();
            string username = username_box.Text;
            string password = password_box.Text;

           
            
            void sqlstuff()
            {
                string connectionString = "server=localhost;user=root;database=UniMind;port=3306;password=L3tM31n";
                MySqlConnection connection = new MySqlConnection(connectionString);
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = "SELECT username, password FROM userinfo WHERE username = @username AND password = @password";
                command.Parameters.AddWithValue("@username", username_box.Text);
                command.Parameters.AddWithValue("@password", password_box.Text);

                try
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        MessageBox.Show("Login successful!");
                        homepage homepagedisplay = new homepage();
                        homepagedisplay.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password!");
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }

            }
            sqlstuff();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            register registerform = new register();
            registerform.Show();
            
        }
    }
}

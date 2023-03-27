using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySqlConnector;

namespace UniMindProject
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        private void register_button_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            string rewritePassword = textBox3.Text;
            

            void sqlRegister()
            {
                string connectionString = "server=localhost;user=root;database=UniMind;port=3306;password=L3tM31n";
                MySqlConnection connection = new MySqlConnection(connectionString);
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = "INSERT INTO userinfo (FirstName, LastName, username, password) VALUES ('', '', @username, @password) ";
                command.Parameters.AddWithValue("@username", textBox1.Text);
                command.Parameters.AddWithValue("@password", textBox2.Text);

                try
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();
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

            if (password == rewritePassword)
            {
                sqlRegister();
                MessageBox.Show("Registration successful.");
            }
            else
            {
                MessageBox.Show("the passwords you entered do not match");
                return;
            }

            
        }
    }
    


}

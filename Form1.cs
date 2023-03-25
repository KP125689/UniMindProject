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



namespace UniMindProject
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = username_box.Text; 
            string password = password_box.Text;

         // need to make it read from database !!! and compare values so user can log in!!

            string selectUserName = "SELECT username FROM unimind.userinfo WHERE username = @username";
            string selectPassword = "SELECT password FROM unimind.userinfo WHERE password = @password";
            if (username == selectUserName && password == selectPassword)
            {
                MessageBox.Show("login successful");
            }
            else
            {
                MessageBox.Show("either username or password is incorrect please try again");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            register registerform = new register();
            registerform.Show();
            
        }
    }
}

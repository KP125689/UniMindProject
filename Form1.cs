using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            if (username == "sqlusername" && password == "sqlpassword")
            {
                MessageBox.Show("login sucessful");

            }
            else

            {
                MessageBox.Show("incorrect"); 
            
            }
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            register registerform = new register();
            registerform.Show();
        }
    }
}

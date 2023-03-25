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

            if (string.IsNullOrEmpty(username)) 
            {
                MessageBox.Show("Please enter a username.");
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter a password.");
                return;
            }

            if (string.IsNullOrEmpty(rewritePassword))
            {
                MessageBox.Show("Please rewrite your password.");
                return;
            }

            if (password != rewritePassword)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            // TODO: Save user registration details to a database or file, or perform other registration tasks.

            MessageBox.Show("Registration successful.");
        }
    }
    


}

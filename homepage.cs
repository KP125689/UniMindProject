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
    public partial class homepage : Form
    {
        public homepage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string logmood = richTextBox1.Text;
            //take the string from the textbox and add it into the SQL database into its own field.

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}

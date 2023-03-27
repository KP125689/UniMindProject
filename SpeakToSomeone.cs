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
    public partial class SpeakToSomeone : Form
    {
        public SpeakToSomeone()
        {
            InitializeComponent();
        }

        private void Childline_click(object sender, EventArgs e)
        {

        }

        private void uniWellbeing_click(object sender, EventArgs e)
        {

        }

        private void HSS_click(object sender, EventArgs e)
        {

        }

        private void Samaritans_click(object sender, EventArgs e)
        {
            Samaritan samaritan = new Samaritan();
            samaritan.Show();
        }

        private void backarrow2_click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

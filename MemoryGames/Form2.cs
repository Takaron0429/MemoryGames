using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGames
{
    public partial class Form2 : Form
    {
        int mp = 25;
        public Form2()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            mp--;
            int perc = mp / 60;
            Time.Text = perc.ToString() + ":" + mp % 60;
            if (mp == 0)
            {
                timer1.Stop();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}

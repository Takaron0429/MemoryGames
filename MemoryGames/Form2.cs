using System;
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
    }
}

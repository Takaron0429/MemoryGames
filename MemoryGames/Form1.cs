using System;
using System.Media;
using System.Windows.Forms;

namespace MemoryGames
{
    public partial class Form1 : Form
    {
        SoundPlayer soundplayer = new SoundPlayer(@"../../Resources/Main-Theme.wav");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            soundplayer.PlayLooping();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            soundplayer.Stop();
            this.Hide();
            f2.ShowDialog();
            this.Close();
        }

        private void impressumLabel_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }
    }
}

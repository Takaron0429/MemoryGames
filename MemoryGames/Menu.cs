using System;
using System.Media;
using System.Windows.Forms;

namespace MemoryGames
{
    public partial class Menu : Form
    {
        SoundPlayer soundplayer = new SoundPlayer(@"../../Resources/Main-Theme.wav");

        public Menu()
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
            User f4 = new User();
            soundplayer.Stop();
            this.Hide();
            f4.ShowDialog();
            this.Close();
        }

        private void impressumLabel_Click(object sender, EventArgs e)
        {
            Impressum f3 = new Impressum();
            f3.ShowDialog();
        }
    }
}

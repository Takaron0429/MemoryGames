using System;
using System.Windows.Forms;

namespace MemoryGames
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            Game f2 = new Game();
            this.Hide();
            f2.ShowDialog();
            this.Close();
        }
    }
}

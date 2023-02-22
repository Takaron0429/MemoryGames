using System;
using System.IO;
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
            StreamWriter file = new StreamWriter("../../Resources/username.txt");
            file.WriteLine(userTextBox.Text);
            file.Close();

            Game f2 = new Game();
            this.Hide();
            f2.ShowDialog();
            this.Close();


        }

        private void userTextBox_TextChanged(object sender, EventArgs e)
        {
            if (userTextBox.Text == "")
            {
                playButton.Enabled = false;
            }
            else
            {
                playButton.Enabled = true;
            }
        }
    }
}

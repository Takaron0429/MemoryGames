using System;
using System.IO;
using System.Windows.Forms;

namespace MemoryGames
{
    public partial class User : Form
    {
        StreamWriter file = new StreamWriter("username.txt");
        public User()
        {
            InitializeComponent();
        }
       
        private void playButton_Click(object sender, EventArgs e)
        {
            foreach (var item in userTextBox.Text)
            {
                file.WriteLine(item);
            }

            Game f2 = new Game();
            this.Hide();
            f2.ShowDialog();
            this.Close();


        }
      
        private void userTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}

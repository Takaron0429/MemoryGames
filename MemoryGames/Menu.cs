using System;
using System.Collections.Generic;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace MemoryGames
{
    public partial class Menu : Form
    {
        SoundPlayer soundplayer = new SoundPlayer(@"../../Resources/Main-Theme.wav");
        static List<string> lines = new List<string>();
        static List<string> lines2 = new List<string>();

        public Menu()
        {
            InitializeComponent();
        }
        static void Read()
        {
            StreamReader name = new StreamReader("../../Resources/username.txt");
            StreamReader money = new StreamReader("../../Resources/money.txt");
            while (!name.EndOfStream && !money.EndOfStream)
            {
                try
                {
                    lines.Add(name.ReadLine().ToString());
                    lines2.Add(money.ReadLine().ToString());
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
            money.Close();
            name.Close();
        }
        private void OK()
        {
            try
            {
                for (int i = 0; i < lines.Count; i++)
                {
                    scoreboardListBox.Items.Clear();
                    scoreboardListBox.Items.Add(lines[i].ToString() + "    :   " + lines2[i].ToString());
                }
            }
            catch (Exception)
            {
                scoreboardListBox.Items.Add("A lista üres!");
                throw;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            soundplayer.PlayLooping();
            Read();
            OK();
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
            this.Show();
        }

        private void impressumLabel_Click(object sender, EventArgs e)
        {
            Impressum f3 = new Impressum();
            f3.ShowDialog();
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            Help f5 = new Help();
            f5.ShowDialog();
        }
    }
}

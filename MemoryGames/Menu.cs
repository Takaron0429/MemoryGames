using System;
using System.IO;
using System.Media;
using System.Security.Policy;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
using System.Xml.Linq;
using System.Collections.Generic;

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
            Read();
            OK();
           
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
        }
        private void OK()
        {

            scoreboardListBox.Items.Add("Játékos:" + lines[0].ToString() + "" + lines2[0].ToString());

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

        private void helpButton_Click(object sender, EventArgs e)
        {
            Help f5 = new Help();
            f5.ShowDialog();
        }

        private void scoreboardListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

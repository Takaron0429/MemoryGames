using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace MemoryGames
{
    public partial class End : Form
    {

        SoundPlayer soundplayer = new SoundPlayer();
        static List<string> lines = new List<string>();
        static List<string> lines2 = new List<string>();
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

        public End()
        {
            InitializeComponent();
        }

        private void OK()
        {

            foreach (var str in lines)
            {
                name.Text = str;
                if (name.Text.Length <= 6)
                {
                    name.Location = new Point(240, 21);
                }

            }
            foreach (var str in lines2)
            {
                Money.Text = str;

            }
            if (Money.Text == "Ajándék 1")
            {
                Money.ForeColor = Color.Green;
                Money.Location = new Point(243, 6);
                label1.Text = "Nyertél!";
                label1.ForeColor = Color.Orange;
                label1.Location = new Point(310, 164);

                soundplayer = new SoundPlayer(@"../../Resources/Kvizjatek_Audience-Clapping-Sound-Effect.wav");
                soundplayer.Play();

            }
            else if (Money.Text == "Ajándék 2" || Money.Text == "Ajándék 3" || Money.Text == "Mindent visz!")
            {
                Money.ForeColor = Color.Green;
                label1.Text = "Nyertél";
                label1.ForeColor = Color.Orange;

                label1.Location = new Point(310, 164);

                soundplayer = new SoundPlayer(@"../../Resources/Kvizjatek_Audience-Clapping-Sound-Effect.wav");
                soundplayer.Play();
            }

        }

        private void End_Load(object sender, EventArgs e)
        {
            Read();
            OK();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void name_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}


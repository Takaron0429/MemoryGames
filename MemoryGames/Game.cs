﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace MemoryGames
{
    public partial class Game : Form
    {
        static List<Class> list = new List<Class>();

        Random rnd = new Random();
        End f6 = new End();

        int Round = 0;

        char choice;
        int select = 0;

        SoundPlayer soundplayer = new SoundPlayer();

        static void Read()
        {
            StreamReader sr = new StreamReader("../../Resources/loim.txt");
            while (!sr.EndOfStream)
            {
                try
                {
                    list.Add(new Class(sr.ReadLine()));
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
            sr.Close();
        }

        int mp = 25;

        public Game()
        {
            InitializeComponent();
            Read();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            soundplayer = new SoundPlayer(@"../../Resources/Kvizjatek_legyen_on_is_milliomos_focimdal.wav");

            soundplayer.Play();
        }

        private void button6_Click(object sender, EventArgs e) //START
        {
            soundplayer.Stop();
            Start.Visible = false;
            QuestionBox.Enabled = true;
            tibi.Enabled = true;
            NextQuestion1.Visible = true;
            NextQuestion2.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            mp--;
            int perc = mp / 60;
            Time.Text = perc.ToString() + ":" + mp % 60;
            if (mp < 11)
            {
                Time.ForeColor = Color.Red;
            }
            if (mp == 0)
            {
                timer1.Stop();
            }
            if (mp == 0 && Round < 5)
            {
                StreamWriter file = new StreamWriter("../../Resources/money.txt");
                file.WriteLine("Ajándék 1");
                file.Close();

                this.Hide();
                f6.ShowDialog();
                this.Close();
            }
            else if (mp == 0 && Round > 10)
            {
                StreamWriter file = new StreamWriter("../../Resources/money.txt");
                file.WriteLine("Ajándék 3");
                file.Close();

                this.Hide();
                f6.ShowDialog();
                this.Close();
            }
            else if (mp == 0 && Round > 5)
            {
                StreamWriter file = new StreamWriter("../../Resources/money.txt");
                file.WriteLine("Ajándék 2");
                file.Close();

                this.Hide();
                f6.ShowDialog();
                this.Close();
            }
        }

        private void Rounds()
        {
            if (Round == 1)
            {
                panel1.BackColor = Color.Orange;
                label1.BackColor = Color.Orange;
                label12.BackColor = Color.Orange;
            }
            if (Round == 2)
            {
                panel13.BackColor = Color.Orange;
                label2.BackColor = Color.Orange;
                label15.BackColor = Color.Orange;
            }
            else if (Round == 3)
            {
                panel12.BackColor = Color.Orange;
                label3.BackColor = Color.Orange;
                label16.BackColor = Color.Orange;
            }
            else if (Round == 4)
            {
                panel11.BackColor = Color.Orange;
                label4.BackColor = Color.Orange;
                label17.BackColor = Color.Orange;
            }
            else if (Round == 5)
            {
                panel10.BackColor = Color.Orange;
                label5.BackColor = Color.Orange;
                label18.BackColor = Color.Orange;

                richTextBox1.Visible = true;
                pictureBox8.Visible = true;
                richTextBox1.Text = "Gratulálok! Kilépőponthoz erkeztünk, ha kilépni kivánsz és el vinni az 1. Ajándékot nyomd meg a  a bal alsó sarokban a kilép gombot. Ha viszont folytatni akarod akkor nyomd meg a folytatást!";
                ImOut.Visible = true;
                Cont.Visible = true;
                tibi.Enabled = false;

                QuestionBox.Visible = false;

                Acaption.Visible = false;
                Bcaption.Visible = false;
                Ccaption.Visible = false;
                Dcaption.Visible = false;

                timer1.Stop();

            }
            else if (Round == 6)
            {
                ImOut.Visible = false;
                Cont.Visible = false;

                panel9.BackColor = Color.Orange;
                label6.BackColor = Color.Orange;
                label19.BackColor = Color.Orange;
            }
            else if (Round == 7)
            {
                panel8.BackColor = Color.Orange;
                label14.BackColor = Color.Orange;
                label20.BackColor = Color.Orange;
            }
            else if (Round == 8)
            {
                panel7.BackColor = Color.Orange;
                label7.BackColor = Color.Orange;
                label21.BackColor = Color.Orange;
            }
            else if (Round == 9)
            {
                panel6.BackColor = Color.Orange;
                label8.BackColor = Color.Orange;
                label22.BackColor = Color.Orange;
            }
            else if (Round == 10)
            {
                panel5.BackColor = Color.Orange;
                label9.BackColor = Color.Orange;
                label23.BackColor = Color.Orange;


                richTextBox1.Visible = true;
                pictureBox8.Visible = true;
                richTextBox1.Text = "Gratulálok! Folytatod vagy elviszed a 2. Ajándékot?";
                ImOut.Visible = true;
                Cont.Visible = true;
                tibi.Enabled = false;

                QuestionBox.Visible = false;

                Acaption.Visible = false;
                Bcaption.Visible = false;
                Ccaption.Visible = false;
                Dcaption.Visible = false;

                timer1.Stop();
            }
            else if (Round == 11)
            {
                ImOut.Visible = false;
                Cont.Visible = false;
                panel4.BackColor = Color.Orange;
                label10.BackColor = Color.Orange;
                label24.BackColor = Color.Orange;
            }
            else if (Round == 12)
            {
                panel3.BackColor = Color.Orange;
                label11.BackColor = Color.Orange;
                label25.BackColor = Color.Orange;
            }
            else if (Round == 13)
            {
                panel15.BackColor = Color.Orange;
                label13.BackColor = Color.Orange;
                label26.BackColor = Color.Orange;
            }
            else if (Round == 14)
            {
                label30.BackColor = Color.Orange;
                panel17.BackColor = Color.Orange;
                label29.BackColor = Color.Orange;
            }
            else if (Round == 15)
            {
                panel16.BackColor = Color.Orange;
                label28.BackColor = Color.Orange;
                label27.BackColor = Color.Orange;
                Win.Visible = true;
                Win.Text = "Szép játék volt! Most már te is Milliomos vagy!";

                tibi.Enabled = false;
                timer1.Stop();

                QuestionBox.Visible = false;

                Acaption.Visible = false;
                Bcaption.Visible = false;
                Ccaption.Visible = false;
                Dcaption.Visible = false;
                StreamWriter file = new StreamWriter("../../Resources/money.txt");
                file.WriteLine("Mindent visz!");

                file.Close();


                this.Hide();
                f6.ShowDialog();
                this.Close();
            }
        }

        //Essence
        private void tibi_Click(object sender, EventArgs e)
        {
            soundplayer = new SoundPlayer(@"../../Resources/Kvizjatek_lets-play.wav");

            QuestionBox.Visible = true;

            richTextBox1.Visible = false;

            Acaption.Visible = true; Acaption.BackColor = Color.Black; Acaption.ForeColor = Color.White; Acaption.Enabled = true;
            Bcaption.Visible = true; Bcaption.BackColor = Color.Black; Bcaption.ForeColor = Color.White; Bcaption.Enabled = true;
            Ccaption.Visible = true; Ccaption.BackColor = Color.Black; Ccaption.ForeColor = Color.White; Ccaption.Enabled = true;
            Dcaption.Visible = true; Dcaption.BackColor = Color.Black; Dcaption.ForeColor = Color.White; Dcaption.Enabled = true;
            List<int> Numbers = new List<int>();
            mp = 25;

            Time.ForeColor = Color.Gold;
            timer1.Start();

            NextQuestion1.Visible = false;
            NextQuestion2.Visible = false;

            Round++; //Kör 1-15
            Rounds();
            for (int i = 1; i <= 15; i++)
            {
                do
                {
                    select = rnd.Next(0, list.Count);
                } while (Numbers.Contains(select));

                Numbers.Add(select);

                soundplayer.Play();

                QuestionBox.Text = list[select].Question;
                Acaption.Text = "A:   " + list[select].A;
                Bcaption.Text = "B:   " + list[select].B;
                Ccaption.Text = "C:   " + list[select].C;
                Dcaption.Text = "D:   " + list[select].D;
                developerLabel.Text = list[select].Answer.ToString(); //for testing

                tibi.Enabled = false;
                Halved.Enabled = true;
                Phone.Enabled = true;
                Community.Enabled = true;
            }

        }

        private void Acaption_Click(object sender, EventArgs e)
        {
            choice = 'A';

            for (int i = 0; i <= 15; i++)
            {
                if (choice == list[select].Answer)
                {
                    Acaption.BackColor = Color.LightGreen;
                    Acaption.ForeColor = Color.Black;
                    timer1.Stop();
                    soundplayer = new SoundPlayer(@"../../Resources/Kvizjatek_correct-answer.wav");
                    soundplayer.Play();
                    tibi.Enabled = true;
                    Acaption.Enabled = false;
                    Bcaption.Enabled = false;
                    Ccaption.Enabled = false;
                    Dcaption.Enabled = false;

                    NextQuestion1.Visible = true;
                    NextQuestion2.Visible = true;
                }
                else
                {
                    Acaption.BackColor = Color.Red;
                    timer1.Stop();
                    soundplayer = new SoundPlayer(@"../../Resources/Kvizjatek_wrong-answer.wav");
                    soundplayer.Play();
                    tibi.Enabled = true;
                    Acaption.Enabled = false;
                    Bcaption.Enabled = false;
                    Ccaption.Enabled = false;
                    Dcaption.Enabled = false;

                    if (Round > 10)
                    {
                        StreamWriter file2 = new StreamWriter("../../Resources/money.txt");
                        file2.WriteLine("Ajándék 3");
                        file2.Close();
                    }
                    else if (Round > 5)
                    {
                        StreamWriter file2 = new StreamWriter("../../Resources/money.txt");
                        file2.WriteLine("Ajándék 2");
                        file2.Close();
                    }
                    else
                    {
                        StreamWriter file = new StreamWriter("../../Resources/money.txt");
                        file.WriteLine("Ajándék 1");
                        file.Close();
                    }

                    this.Hide();
                    f6.ShowDialog();
                    this.Close();
                    break;
                }
                if (Community.Visible == false)
                {
                    Community_false();
                }
            }
        }

        private void Bcaption_Click(object sender, EventArgs e)
        {
            choice = 'B';

            for (int i = 0; i <= 15; i++)
            {
                if (choice == list[select].Answer)
                {
                    Bcaption.BackColor = Color.LightGreen;
                    Bcaption.ForeColor = Color.Black;
                    timer1.Stop();
                    soundplayer = new SoundPlayer(@"../../Resources/Kvizjatek_correct-answer.wav");
                    soundplayer.Play();
                    tibi.Enabled = true;
                    Acaption.Enabled = false;
                    Bcaption.Enabled = false;
                    Ccaption.Enabled = false;
                    Dcaption.Enabled = false;
                    NextQuestion1.Visible = true;
                    NextQuestion2.Visible = true;
                }
                else
                {
                    Bcaption.BackColor = Color.Red;
                    timer1.Stop();
                    soundplayer = new SoundPlayer(@"../../Resources/Kvizjatek_wrong-answer.wav");
                    soundplayer.Play();
                    tibi.Enabled = true;
                    Acaption.Enabled = false;
                    Bcaption.Enabled = false;
                    Ccaption.Enabled = false;
                    Dcaption.Enabled = false;

                    if (Round > 10)
                    {
                        StreamWriter file2 = new StreamWriter("../../Resources/money.txt");
                        file2.WriteLine("Ajándék 3");
                        file2.Close();
                    }
                    else if (Round > 5)
                    {
                        StreamWriter file2 = new StreamWriter("../../Resources/money.txt");
                        file2.WriteLine("Ajándék 2");
                        file2.Close();
                    }
                    else
                    {
                        StreamWriter file = new StreamWriter("../../Resources/money.txt");
                        file.WriteLine("Ajándék 1");
                        file.Close();
                    }

                    this.Hide();
                    f6.ShowDialog();
                    this.Close();
                    break;
                }
                if (Community.Visible == false)
                {
                    Community_false();
                }
            }
        }

        private void Ccaption_Click(object sender, EventArgs e)
        {
            choice = 'C';

            for (int i = 0; i <= 15; i++)
            {
                if (choice == list[select].Answer)
                {
                    Ccaption.BackColor = Color.LightGreen;
                    Ccaption.ForeColor = Color.Black;
                    timer1.Stop();
                    soundplayer = new SoundPlayer(@"../../Resources/Kvizjatek_correct-answer.wav");
                    soundplayer.Play();
                    tibi.Enabled = true;
                    Acaption.Enabled = false;
                    Bcaption.Enabled = false;
                    Ccaption.Enabled = false;
                    Dcaption.Enabled = false;
                    NextQuestion1.Visible = true;
                    NextQuestion2.Visible = true;
                }
                else
                {
                    Ccaption.BackColor = Color.Red;
                    timer1.Stop();
                    soundplayer = new SoundPlayer(@"../../Resources/Kvizjatek_wrong-answer.wav");
                    soundplayer.Play();
                    tibi.Enabled = true;
                    Acaption.Enabled = false;
                    Bcaption.Enabled = false;
                    Ccaption.Enabled = false;
                    Dcaption.Enabled = false;

                    if (Round > 10)
                    {
                        StreamWriter file2 = new StreamWriter("../../Resources/money.txt");
                        file2.WriteLine("Ajándék 3");
                        file2.Close();
                    }
                    else if (Round > 5)
                    {
                        StreamWriter file2 = new StreamWriter("../../Resources/money.txt");
                        file2.WriteLine("Ajándék 2");
                        file2.Close();
                    }
                    else
                    {
                        StreamWriter file = new StreamWriter("../../Resources/money.txt");
                        file.WriteLine("Ajándék 1");
                        file.Close();
                    }

                    this.Hide();
                    f6.ShowDialog();
                    this.Close();
                    break;
                }
                if (Community.Visible == false)
                {
                    Community_false();
                }
            }
        }

        private void Dcaption_Click(object sender, EventArgs e)
        {
            choice = 'D';

            for (int i = 0; i <= 15; i++)
            {
                if (choice == list[select].Answer)
                {
                    Dcaption.BackColor = Color.LightGreen;
                    Dcaption.ForeColor = Color.Black;
                    timer1.Stop();
                    soundplayer = new SoundPlayer(@"../../Resources/Kvizjatek_correct-answer.wav");
                    soundplayer.Play();
                    tibi.Enabled = true;
                    Acaption.Enabled = false;
                    Bcaption.Enabled = false;
                    Ccaption.Enabled = false;
                    Dcaption.Enabled = false;
                    NextQuestion1.Visible = true;
                    NextQuestion2.Visible = true;
                }
                else
                {
                    Dcaption.BackColor = Color.Red;
                    timer1.Stop();
                    soundplayer = new SoundPlayer(@"../../Resources/Kvizjatek_wrong-answer.wav");
                    soundplayer.Play();
                    tibi.Enabled = true;
                    Acaption.Enabled = false;
                    Bcaption.Enabled = false;
                    Ccaption.Enabled = false;
                    Dcaption.Enabled = false;

                    if (Round > 10)
                    {
                        StreamWriter file2 = new StreamWriter("../../Resources/money.txt");
                        file2.WriteLine("Ajándék 3");
                        file2.Close();
                    }
                    else if (Round > 5)
                    {
                        StreamWriter file2 = new StreamWriter("../../Resources/money.txt");
                        file2.WriteLine("Ajándék 2");
                        file2.Close();
                    }
                    else
                    {
                        StreamWriter file = new StreamWriter("../../Resources/money.txt");
                        file.WriteLine("Ajándék 1");
                        file.Close();
                    }

                    this.Hide();
                    f6.ShowDialog();
                    this.Close();
                    break;
                }
                if (Community.Visible == false)
                {
                    Community_false();
                }

            }
        }

        private void Cont_Click(object sender, EventArgs e)
        {
            tibi.Enabled = true;
            pictureBox8.Visible = false;
            richTextBox1.Visible = false;
            Cont.Visible = false;
            ImOut.Visible = false;
            NextQuestion1.Visible = true;
            NextQuestion2.Visible = true;
        }

        private void ImOut_Click(object sender, EventArgs e)
        {
            if (Round == 5)
            {
                StreamWriter file = new StreamWriter("../../Resources/money.txt");
                file.WriteLine("Ajándék 2");
                file.Close();
            }
            else if (Round == 10)
            {
                StreamWriter file = new StreamWriter("../../Resources/money.txt");
                file.WriteLine("Ajándék 3");
                file.Close();
            }

            this.Hide();
            f6.ShowDialog();
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            mp += 10;
            Ask.Visible = true;
            AskBack.Visible = true;
            progressBar1.Visible = true;
            progressBar2.Visible = true;
            progressBar3.Visible = true;
            progressBar4.Visible = true;
            progressBar1.Visible = true;
            Aska.Visible = true;
            Askb.Visible = true;
            Askc.Visible = true;
            Askd.Visible = true;
            AskBack.Visible = true;

            Community.Visible = false;
        }

        private void Community_false()
        {
            Ask.Visible = false;
            AskBack.Visible = false;
            progressBar1.Visible = false;
            progressBar2.Visible = false;
            progressBar3.Visible = false;
            progressBar4.Visible = false;
            progressBar1.Visible = false;
            Aska.Visible = false;
            Askb.Visible = false;
            Askc.Visible = false;
            Askd.Visible = false;
        }

        private void Ask_Click(object sender, EventArgs e)
        {
            int Bar1 = rnd.Next(0, 100);
            int Bar2 = rnd.Next(0, 100);
            int Bar3 = rnd.Next(0, 100);
            int Bar4 = rnd.Next(0, 100);

            while (Bar1 + Bar2 + Bar3 + Bar4 != 100)
            {
                Bar1 = rnd.Next(0, 100);
                Bar2 = rnd.Next(0, 100);
                Bar3 = rnd.Next(0, 100);
                Bar4 = rnd.Next(0, 100);
            }

            progressBar1.Value = Bar1;
            progressBar2.Value = Bar2;
            progressBar3.Value = Bar3;
            progressBar4.Value = Bar4;

            Ask.Visible = false;
        }

        private void Phone_Click(object sender, EventArgs e)
        {
            mp += 10;
            richTextBox1.Visible = true;

            int number = rnd.Next(1, 5);
            string answer;

            switch (number)
            {
                case 1:
                    answer = "Szerintem az A a helyes válasz.";
                    break;
                case 2:
                    answer = "Biztos vagyok abban hogy a B a helyes válasz.";
                    break;
                case 3:
                    answer = "Az én véleményem szerint a C lehet a helyes válasz.";
                    break;
                case 4:
                    answer = "Én a D-t választanám.";
                    break;
                default:
                    answer = "Nem tudom erre a választ.";
                    break;
            }

            Phone.Visible = false;
            richTextBox1.Text = answer;
        }

        private void Halved_Click(object sender, EventArgs e)
        {
            mp += 10;

            for (int i = 0; i <= 15; i++)
            {
                if ('A' != list[select].Answer && 'B' != list[select].Answer)
                {
                    Acaption.Enabled = false;
                    Bcaption.Enabled = false;
                }
                else if ('C' != list[select].Answer && 'D' != list[select].Answer)
                {
                    Ccaption.Enabled = false;
                    Dcaption.Enabled = false;
                }
            }

            Halved.Visible = false;
        }
    }
}

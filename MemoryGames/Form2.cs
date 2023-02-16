using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace MemoryGames
{
    public partial class Form2 : Form
    {
        static List<Class1> list = new List<Class1>();

        Random rnd = new Random();

        int Round = 0;

        static void Read()
        {
            StreamReader sr = new StreamReader("../../Resources/loim.txt");
            while (!sr.EndOfStream)
            {
                try
                {
                    list.Add(new Class1(sr.ReadLine()));
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
            sr.Close();
        }

        int mp = 25;

        public Form2()
        {
            InitializeComponent();
            Read();
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

        private void tibi_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 12; i++)
            {
                QuestionBox.Text = list[i].Question;
                Acaption.Text = list[i].A;
                Bcaption.Text = list[i].B;
                Ccaption.Text = list[i].C;
                Dcaption.Text = list[i].D;
                developerLabel.Text = list[i].Answer.ToString(); //for testing
            }
        }
    }
}

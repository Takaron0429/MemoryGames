using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MemoryGames
{
    public partial class Form2 : Form
    {
        static List<Class1> list = new List<Class1>();

        Random rnd = new Random();

        int Round = 0;

        char choice;
        int select = 0;

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
            Start.Visible = false;
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
                richTextBox1.Text = "Gratulálok! Kilépőponthoz erkeztünk, ha kilépni kivánsz és el vinni a 100.000 Ft nyomd meg a  a bal alsó sarokban a kilép gombot. Ha viszont folytatni akarod akkor nyomd meg a folytatást!";
                ImOut.Visible = true;
                Cont.Visible = true;
            }
            else if (Round == 6)
            {
                panel9.BackColor = Color.Orange;
                label6.BackColor = Color.Orange;
                label19.BackColor = Color.Orange;
            }
            else if (Round == 7)
            {
                panel8.BackColor = Color.Orange;
                label7.BackColor = Color.Orange;
                label20.BackColor = Color.Orange;
            }
            else if (Round == 8)
            {
                panel7.BackColor = Color.Orange;
                label8.BackColor = Color.Orange;
                label21.BackColor = Color.Orange;
            }
            else if (Round == 9)
            {
                panel6.BackColor = Color.Orange;
                label9.BackColor = Color.Orange;
                label22.BackColor = Color.Orange;
            }
            else if (Round == 10)
            {
                panel5.BackColor = Color.Orange;
                label10.BackColor = Color.Orange;
                label23.BackColor = Color.Orange;


                richTextBox1.Visible = true;
                richTextBox1.Text = "Gratulálok! Folytatod vagy elviszed a 400.000 Ft?";
                ImOut.Visible = true;
                Cont.Visible = true;
            }
            else if (Round == 11)
            {
                panel4.BackColor = Color.Orange;
                label11.BackColor = Color.Orange;
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
                label11.BackColor = Color.Orange;
                label26.BackColor = Color.Orange;
            }
            else if (Round == 14)
            {
                panel14.BackColor = Color.Orange;
                label11.BackColor = Color.Orange;
                label27.BackColor = Color.Orange;
            }
            else if (Round == 15)
            {
                panel16.BackColor = Color.Orange;
                label11.BackColor = Color.Orange;
                label28.BackColor = Color.Orange;
            }
        }



        private void tibi_Click(object sender, EventArgs e)
        {
            List<int> Numbers = new List<int>();

            Round++; //Kör 1-12
            Rounds();
            for (int i = 0; i <= 15; i++)
            {
                do
                {
                    select = rnd.Next(0, list.Count);
                } while (Numbers.Contains(select));

                QuestionBox.Text = i + "." + list[select].Question;
                Acaption.Text = "A   " + list[select].A;
                Bcaption.Text = "B:   " + list[select].B;
                Ccaption.Text = "C:   " + list[select].C;
                Dcaption.Text = "D:   " + list[select].D;
                developerLabel.Text = list[select].Answer.ToString(); //for testing
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
                }
                else
                {
                    Acaption.BackColor = Color.Red;
                }
            }
        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void Bcaption_Click(object sender, EventArgs e)
        {
            choice = 'B';

            for (int i = 0; i <= 15; i++)
            {
                if (choice == list[select].Answer)
                {
                    Bcaption.BackColor = Color.LightGreen;
                }
                else
                {
                    Bcaption.BackColor = Color.Red;
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
                }
                else
                {
                    Ccaption.BackColor = Color.Red;
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
                }
                else
                {
                    Dcaption.BackColor = Color.Red;
                }
            }
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }
    }
}

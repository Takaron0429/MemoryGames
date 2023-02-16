using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
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

        
        private void Rounds()
        {
            if(Round == 1)
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
                ImOut.Visible= true;
                Cont.Visible= true;
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
        }
        private void tibi_Click(object sender, EventArgs e)
        {
            Round++; //Kör 1-12
            for (int i = 0; i < 12; i++)
            {
                QuestionBox.Text = i + "." + list[i].Question;
                Acaption.Text = "A   " + list[i].A;
                Bcaption.Text = "B:   " + list[i].B;
                Ccaption.Text = "C:   " + list[i].C;
                Dcaption.Text = "D:   " + list[i].D;
                developerLabel.Text = list[i].Answer.ToString(); //for testing

            }
        }

        private void Acaption_Click(object sender, EventArgs e)
        {
            foreach(var item in Acaption.Text){
                if (Acaption.Text.Contains(list[item].Answer.ToString()))
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
    }
}

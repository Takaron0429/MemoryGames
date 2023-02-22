using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGames
{
    public partial class End : Form
    {
        public End()
        {
            InitializeComponent();
            Read();
            OK();
        }
      
       static List<string> lines = new List<string>();
        static List<string> lines2 = new List<string>();
        static void Read()
        {
            StreamReader name = new StreamReader("../../Resources/username.txt");
            StreamReader money = new StreamReader("../../Resources/money.txt");
            while (!name.EndOfStream && !money.EndOfStream )
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
           
            foreach (var str in lines)
            {
                name.Text = str;
                
            }
            foreach (var str in lines2)
            {
                Money.Text = str;

            }
            if (Money.Text=="0 Ft")
            {
                Money.ForeColor= Color.Red; 
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu f2 = new Menu();
            this.Hide();
            f2.ShowDialog();
            this.Close();
        }
        private void name_Click(object sender, EventArgs e)
        {
           
        }

        private void Money_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

      
    }
}


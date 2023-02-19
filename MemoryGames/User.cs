using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
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
            Game f2 = new Game();
            this.Hide();
            f2.ShowDialog();
            this.Close();
        }
    }
}

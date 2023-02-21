using System;
using System.Windows.Forms;

namespace MemoryGames
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

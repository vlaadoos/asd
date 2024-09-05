using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_Bird_Windows_Form
{
    public partial class MainMenu : Form
    {
        private Game game;
        public MainMenu()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            game = new Game();
            game.Visible = true;
            this.Hide();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}

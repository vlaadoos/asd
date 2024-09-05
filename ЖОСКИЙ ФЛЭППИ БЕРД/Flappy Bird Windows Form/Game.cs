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
    public partial class Game : Form
    {
        int pipeSpeed = 10;
        int gravity = 3; 
        int score = 0; 
        bool gameOver = false;

        public Game()
        {
            InitializeComponent();
        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -5;
            }


        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 5;
            }
            if (e.KeyCode == Keys.R && gameOver)
            {
                RestartGame();
            }

        }

        private void endGame()
        {
            gameTimer.Stop(); 
            scoreText.Text += " ";
            gameOver = true;

            txtRating.Enabled = true;
            NameRating.Enabled = true;
            buttonRating.Enabled = true;

            txtRating.Visible = true;
            NameRating.Visible = true;
            buttonRating.Visible = true;
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            Player.Top += gravity;
            pipeBottom.Left -= pipeSpeed; 
            pipeTop.Left -= pipeSpeed;
            scoreText.Text = " " + score;

            if(pipeBottom.Left < -150)
            {
                pipeBottom.Left = 800;
                score++;
            }
            if(pipeTop.Left < -180)
            {
                pipeTop.Left = 950;
                score++;
            }
     
            if (Player.Bounds.IntersectsWith(pipeBottom.Bounds) ||
                Player.Bounds.IntersectsWith(pipeTop.Bounds) ||
                Player.Bounds.IntersectsWith(ground.Bounds) || Player.Top < -25
                )
            {
                endGame();
            }

            if(score > 5)
            {
                pipeSpeed = 15;
            }
            if (score > 10)
            {
                pipeSpeed = 20;
            }

            if (score > 15)
            {
                pipeSpeed = 25;
            }
            if (score > 25)
            {
                pipeSpeed = 100;
            }

        }
        private void RestartGame()
        {
            gameOver = false;

            pipeTop.Left = 800;
            pipeBottom.Left = 1200;
            Player.Location = new Point(36, 286);

            score = 0;
            pipeSpeed = 10;
            scoreText.Text = " 0";
            gameTimer.Start();

             scoreText.Text = score.ToString();
        }

        private void buttonRating_Click(object sender, EventArgs e)
        {
            txtRating.Enabled = false;
            NameRating.Enabled = false;
            buttonRating.Enabled = false;

            txtRating.Visible = false;
            NameRating.Visible= false;
            buttonRating.Visible = false;

            listRating.Items.Add(txtRating.Text + " - " + score);
            txtRating.Text = "";

            RestartGame();
        }

        private void рейтингToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(listRating.Visible == false)
            {
                listRating.Visible = true;
                listRating.Enabled = true;
            }
            else
            {
                listRating.Visible = false;
                listRating.Enabled = false;
            }
        }

        private void выйтиИзИгрыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void управлениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Инструкция по управлению: \n + "+
                "Прерывистыми нажатиями на Space птичка будет лететь.");
        }

        private void цельИгрыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Наберите как можно больше очков не ударяясь об препятствия");
        }

        private void Game_Load(object sender, EventArgs e)
        {

        }

        private void инструкцияToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pipeTop_Click(object sender, EventArgs e)
        {

        }
    }
}

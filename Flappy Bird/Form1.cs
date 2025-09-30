using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_Bird
{
    public partial class Form1 : Form
    {
        int pipeSpeed=8;
        int gravity = 15;
        int score = 0;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            Flappy_Bird.Top += gravity;
            pictureBox2.Left -= pipeSpeed;
            Pipe_Down.Left -= pipeSpeed;
            label1.Text = "Score:" + score;


            if (pictureBox2.Left < -150)
            {
                pictureBox2.Left = 800;
                score++;
            }
            if (Pipe_Down.Left < -180)
            {
                Pipe_Down.Left = 950;
                score++;
            }
            if (Flappy_Bird.Bounds.IntersectsWith(pictureBox2.Bounds) ||
                Flappy_Bird.Bounds.IntersectsWith(Pipe_Down.Bounds) ||
                Flappy_Bird.Bounds.IntersectsWith(pictureBox6.Bounds) ||
                Flappy_Bird.Top < -25)
            {
                EndGame();
            }
            if (score > 5)
            {
                pipeSpeed = 15;
            }
        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Space)
            {
                gravity = -15;
            }



        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 15;
            }
        }
        private void EndGame()
        {
            gameTimer.Stop();
            label1.Text += " Game Over!!!";
            labelNewGame.Visible = true;
        }

        private void labelNewGame_Click(object sender, EventArgs e)
        {
            score = 0;
            pipeSpeed = 8;
            gravity = 15;

            label1.Text = "Score: 0";
            labelNewGame.Visible = false; 

           
            Flappy_Bird.Top = 200; 
            pictureBox2.Left = 800;
            Pipe_Down.Left = 950;

            
            gameTimer.Start();
        }
    }
}

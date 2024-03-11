using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FLAPPY_BIRDS_PROJECT
{
    public partial class Form1 : Form
    {

        int pipeSpeed = 8;
        int gravity = 5;
        int score = 0;


        public Form1()
        {
            InitializeComponent();
        }


       
        private void gameTimerEvent(object sender, EventArgs e)

        {
     



            BirdCharacter.Top += gravity;

            pictureBox2.Left -= pipeSpeed;
            pictureBox2.Top += pipeSpeed;
            pictureBox3.Left += pipeSpeed;
            pictureBox3.Top += pipeSpeed;

            if (pictureBox2.Left < -150 && pictureBox3.Left < -150)
            {
                pictureBox2.Left = 150;
                pictureBox3.Left = 150;
                score++;
            }
            if (pictureBox2.Left < -190 && pictureBox3.Left < -190)
            {
                pictureBox2.Left = 190;
                pictureBox3.Left = 190;
                score++;
            }
           

        }

        private void gameiskeydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity -= 20;
            }
        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 4;
            }
        }
  
    }

    
    
}

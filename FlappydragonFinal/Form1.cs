namespace FlappydragonFinal //this is a reimagining of the famous game flappy bird by Misbah Al Rehman
{
    public partial class Form1 : Form
    {
        int cloudspeed = 5; //speed of the clouds
        int pipeSpeed = 5; //speed of the pipes 
        int gravity = 10; //gravity
        int score = 0; //initial player's score
        int lastScoreSpeedIncreased = 0;
        Random Rnd = new Random();
        bool gameOver = false;
        public Form1()
        {
            InitializeComponent();
            ground.Controls.Add(scoreText); //score text becomes child of ground, meaning it'll have the same color, making it essentially transparent here
            scoreText.Left = 20;
            scoreText.Top = 25;
            RestartGame();
            
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            FlappyDragon.Top += gravity; //adds gravity to the game
            pipeBottom.Left -= pipeSpeed; //makes the pipes move left at assigned pipspeed
            pipeTop.Left -= pipeSpeed; //makes the pipes move left at assigned pipespeed
            scoreText.Text = "Score: " + score;
            cloud1.Left -= cloudspeed;
            cloud2.Left -= cloudspeed;
            cloud3.Left -= cloudspeed;
            cloud4.Left -= cloudspeed;
            if (pipeBottom.Left < -50)
            {
                pipeBottom.Left = Rnd.Next(400, 900);
                score++;
            }
            if (pipeTop.Left < -50)
            {
                pipeTop.Left = Rnd.Next(550, 800);
                score++;
            }
            if (FlappyDragon.Bounds.IntersectsWith(pipeBottom.Bounds) ||
                 FlappyDragon.Bounds.IntersectsWith(pipeTop.Bounds) ||
                 FlappyDragon.Bounds.IntersectsWith(ground.Bounds) || FlappyDragon.Top < -25)
            { 
                endGame();
            }
            if (cloud1.Left < -50)
            {
                cloud1.Left = 659;
            }
            if (cloud2.Left < -50)
            {
                cloud2.Left = 659;
            }
            if (cloud3.Left < -50)
            {
                cloud3.Left = 659;
            }
            if (cloud4.Left < -50)
            {
                cloud4.Left = 659;
            }
            if (score % 5 == 0 && score > lastScoreSpeedIncreased)
            {
                pipeSpeed += 2;
                cloudspeed += 2;
                lastScoreSpeedIncreased = score; // Update the last score when speed was increased
            }


        }

        private void gamekeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -10;
            }

        }

        private void gamekeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 10;
                
            }



        }
        private void endGame()
        {
            gameTimer.Stop();
            scoreText.Text += " ";
            gameOver = true;
            restart.Enabled = true;
            restart.Visible = true;
            Quit.Enabled = true;
            Quit.Visible = true;
            Gamedone.Visible = true;

        }
        private void RestartGame()
        {
            FlappyDragon.Location = new Point(34, 196);
            pipeTop.Left = 800;
            pipeBottom.Left = 372;
            score = 0;
            pipeSpeed = 5;
            cloudspeed = 5;
            scoreText.Text = "Score: 0";
            gameTimer.Start();
            Gamedone.Visible = false;
            Quit.Enabled = false;
            Quit.Visible = false;
            restart.Enabled = false;
            restart.Visible = false;
            cloud1.Location = new Point(169, 324);
            cloud2.Location = new Point(335, 45);
            cloud3.Location = new Point(535, 139);
            cloud4.Location = new Point(672, 351);
        }

        private void RestartEvent(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void RestartGame(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void QuitEvent(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}

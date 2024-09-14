namespace FlappydragonFinal
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pipeTop = new PictureBox();
            pipeBottom = new PictureBox();
            FlappyDragon = new PictureBox();
            ground = new PictureBox();
            scoreText = new Label();
            gameTimer = new System.Windows.Forms.Timer(components);
            cloud2 = new PictureBox();
            cloud1 = new PictureBox();
            cloud3 = new PictureBox();
            cloud4 = new PictureBox();
            restart = new PictureBox();
            Quit = new PictureBox();
            Gamedone = new Label();
            ((System.ComponentModel.ISupportInitialize)pipeTop).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipeBottom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FlappyDragon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ground).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cloud2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cloud1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cloud3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cloud4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)restart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Quit).BeginInit();
            SuspendLayout();
            // 
            // pipeTop
            // 
            pipeTop.Image = Properties.Resources.pipedown;
            pipeTop.Location = new Point(699, -8);
            pipeTop.Name = "pipeTop";
            pipeTop.Size = new Size(111, 199);
            pipeTop.SizeMode = PictureBoxSizeMode.StretchImage;
            pipeTop.TabIndex = 0;
            pipeTop.TabStop = false;
            // 
            // pipeBottom
            // 
            pipeBottom.Anchor = AnchorStyles.Top;
            pipeBottom.Image = Properties.Resources.pipe;
            pipeBottom.Location = new Point(372, 351);
            pipeBottom.Name = "pipeBottom";
            pipeBottom.Size = new Size(117, 176);
            pipeBottom.SizeMode = PictureBoxSizeMode.StretchImage;
            pipeBottom.TabIndex = 1;
            pipeBottom.TabStop = false;
            // 
            // FlappyDragon
            // 
            FlappyDragon.BorderStyle = BorderStyle.Fixed3D;
            FlappyDragon.Image = Properties.Resources.flappydragon;
            FlappyDragon.Location = new Point(61, 209);
            FlappyDragon.Name = "FlappyDragon";
            FlappyDragon.Size = new Size(121, 78);
            FlappyDragon.SizeMode = PictureBoxSizeMode.StretchImage;
            FlappyDragon.TabIndex = 2;
            FlappyDragon.TabStop = false;
            // 
            // ground
            // 
            ground.Image = Properties.Resources.ground;
            ground.Location = new Point(-9, 508);
            ground.Name = "ground";
            ground.Size = new Size(1263, 87);
            ground.SizeMode = PictureBoxSizeMode.StretchImage;
            ground.TabIndex = 3;
            ground.TabStop = false;
            // 
            // scoreText
            // 
            scoreText.AutoSize = true;
            scoreText.Font = new Font("Britannic Bold", 16F, FontStyle.Regular, GraphicsUnit.Point);
            scoreText.Location = new Point(34, 545);
            scoreText.Name = "scoreText";
            scoreText.Size = new Size(135, 36);
            scoreText.TabIndex = 4;
            scoreText.Text = "Score: 0";
            // 
            // gameTimer
            // 
            gameTimer.Enabled = true;
            gameTimer.Interval = 20;
            gameTimer.Tick += gameTimerEvent;
            // 
            // cloud2
            // 
            cloud2.Image = Properties.Resources.cloud;
            cloud2.Location = new Point(335, 45);
            cloud2.Name = "cloud2";
            cloud2.Size = new Size(119, 81);
            cloud2.SizeMode = PictureBoxSizeMode.StretchImage;
            cloud2.TabIndex = 5;
            cloud2.TabStop = false;
            // 
            // cloud1
            // 
            cloud1.Image = Properties.Resources.cloud;
            cloud1.Location = new Point(169, 324);
            cloud1.Name = "cloud1";
            cloud1.Size = new Size(119, 81);
            cloud1.SizeMode = PictureBoxSizeMode.StretchImage;
            cloud1.TabIndex = 6;
            cloud1.TabStop = false;
            // 
            // cloud3
            // 
            cloud3.Image = Properties.Resources.cloud;
            cloud3.Location = new Point(540, 136);
            cloud3.Name = "cloud3";
            cloud3.Size = new Size(119, 81);
            cloud3.SizeMode = PictureBoxSizeMode.StretchImage;
            cloud3.TabIndex = 7;
            cloud3.TabStop = false;
            // 
            // cloud4
            // 
            cloud4.Image = Properties.Resources.cloud;
            cloud4.Location = new Point(672, 351);
            cloud4.Name = "cloud4";
            cloud4.Size = new Size(119, 81);
            cloud4.SizeMode = PictureBoxSizeMode.StretchImage;
            cloud4.TabIndex = 8;
            cloud4.TabStop = false;
            // 
            // restart
            // 
            restart.Image = Properties.Resources.restart_1;
            restart.Location = new Point(254, 168);
            restart.Name = "restart";
            restart.Size = new Size(159, 150);
            restart.SizeMode = PictureBoxSizeMode.StretchImage;
            restart.TabIndex = 10;
            restart.TabStop = false;
            restart.Click += RestartGame;
            // 
            // Quit
            // 
            Quit.Image = Properties.Resources.quit;
            Quit.Location = new Point(419, 168);
            Quit.Name = "Quit";
            Quit.Size = new Size(159, 150);
            Quit.SizeMode = PictureBoxSizeMode.StretchImage;
            Quit.TabIndex = 11;
            Quit.TabStop = false;
            Quit.Click += QuitEvent;
            // 
            // Gamedone
            // 
            Gamedone.AutoSize = true;
            Gamedone.Font = new Font("Britannic Bold", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Gamedone.Location = new Point(630, 545);
            Gamedone.Name = "Gamedone";
            Gamedone.Size = new Size(171, 36);
            Gamedone.TabIndex = 12;
            Gamedone.Text = "GameOver!";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(813, 590);
            Controls.Add(Gamedone);
            Controls.Add(Quit);
            Controls.Add(restart);
            Controls.Add(scoreText);
            Controls.Add(ground);
            Controls.Add(FlappyDragon);
            Controls.Add(pipeBottom);
            Controls.Add(pipeTop);
            Controls.Add(cloud4);
            Controls.Add(cloud3);
            Controls.Add(cloud2);
            Controls.Add(cloud1);
            Name = "Form1";
            Text = " ";
            KeyDown += gamekeyDown;
            KeyUp += gamekeyUp;
            ((System.ComponentModel.ISupportInitialize)pipeTop).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipeBottom).EndInit();
            ((System.ComponentModel.ISupportInitialize)FlappyDragon).EndInit();
            ((System.ComponentModel.ISupportInitialize)ground).EndInit();
            ((System.ComponentModel.ISupportInitialize)cloud2).EndInit();
            ((System.ComponentModel.ISupportInitialize)cloud1).EndInit();
            ((System.ComponentModel.ISupportInitialize)cloud3).EndInit();
            ((System.ComponentModel.ISupportInitialize)cloud4).EndInit();
            ((System.ComponentModel.ISupportInitialize)restart).EndInit();
            ((System.ComponentModel.ISupportInitialize)Quit).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pipeTop;
        private PictureBox FlappyDragon;
        private PictureBox ground;
        private Label scoreText;
        private System.Windows.Forms.Timer gameTimer;
        public PictureBox pipeBottom;
        private PictureBox cloud2;
        private PictureBox cloud1;
        private PictureBox cloud3;
        private PictureBox cloud4;
        private PictureBox restart;
        private PictureBox Quit;
        private Label Gamedone;
    }
}
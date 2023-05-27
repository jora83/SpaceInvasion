namespace SpaceInvasion
{
    partial class GameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            enemy1 = new PictureBox();
            enemy2 = new PictureBox();
            enemy3 = new PictureBox();
            playerPictureBox = new PictureBox();
            bullet = new PictureBox();
            scoreText = new Label();
            gameTimer = new System.Windows.Forms.Timer(components);
            healthText = new Label();
            ((System.ComponentModel.ISupportInitialize)enemy1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)enemy2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)enemy3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playerPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bullet).BeginInit();
            SuspendLayout();
            // 
            // enemy1
            // 
            enemy1.Image = Properties.Resources.invader1;
            enemy1.Location = new Point(8, 80);
            enemy1.Margin = new Padding(6);
            enemy1.Name = "enemy1";
            enemy1.Size = new Size(125, 113);
            enemy1.SizeMode = PictureBoxSizeMode.AutoSize;
            enemy1.TabIndex = 0;
            enemy1.TabStop = false;
            enemy1.Tag = "enemy";
            // 
            // enemy2
            // 
            enemy2.Image = Properties.Resources.invader2;
            enemy2.Location = new Point(343, 93);
            enemy2.Margin = new Padding(6);
            enemy2.Name = "enemy2";
            enemy2.Size = new Size(125, 111);
            enemy2.SizeMode = PictureBoxSizeMode.AutoSize;
            enemy2.TabIndex = 1;
            enemy2.TabStop = false;
            enemy2.Tag = "enemy";
            // 
            // enemy3
            // 
            enemy3.Image = Properties.Resources.invader3;
            enemy3.Location = new Point(739, 91);
            enemy3.Margin = new Padding(6);
            enemy3.Name = "enemy3";
            enemy3.Size = new Size(138, 111);
            enemy3.SizeMode = PictureBoxSizeMode.AutoSize;
            enemy3.TabIndex = 2;
            enemy3.TabStop = false;
            enemy3.Tag = "enemy";
            // 
            // playerPictureBox
            // 
            playerPictureBox.Image = Properties.Resources.invader7;
            playerPictureBox.Location = new Point(342, 538);
            playerPictureBox.Margin = new Padding(6);
            playerPictureBox.Name = "playerPictureBox";
            playerPictureBox.Size = new Size(126, 100);
            playerPictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            playerPictureBox.TabIndex = 3;
            playerPictureBox.TabStop = false;
            // 
            // bullet
            // 
            bullet.Image = Properties.Resources.bullet;
            bullet.Location = new Point(404, 455);
            bullet.Margin = new Padding(6);
            bullet.Name = "bullet";
            bullet.Size = new Size(8, 15);
            bullet.SizeMode = PictureBoxSizeMode.AutoSize;
            bullet.TabIndex = 4;
            bullet.TabStop = false;
            // 
            // scoreText
            // 
            scoreText.AutoSize = true;
            scoreText.ForeColor = Color.White;
            scoreText.Location = new Point(716, 9);
            scoreText.Margin = new Padding(6, 0, 6, 0);
            scoreText.Name = "scoreText";
            scoreText.Size = new Size(123, 41);
            scoreText.TabIndex = 5;
            scoreText.Text = "Score: 0";
            // 
            // gameTimer
            // 
            gameTimer.Interval = 20;
            gameTimer.Tick += mainGameTimerEvent;
            // 
            // healthText
            // 
            healthText.AutoSize = true;
            healthText.ForeColor = Color.White;
            healthText.Location = new Point(8, 9);
            healthText.Name = "healthText";
            healthText.Size = new Size(167, 41);
            healthText.TabIndex = 6;
            healthText.Text = "Health: 100";
            // 
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 100);
            ClientSize = new Size(882, 653);
            Controls.Add(healthText);
            Controls.Add(scoreText);
            Controls.Add(bullet);
            Controls.Add(playerPictureBox);
            Controls.Add(enemy3);
            Controls.Add(enemy2);
            Controls.Add(enemy1);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(6);
            Name = "GameForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GameForm";
            KeyDown += KeyIsDown;
            KeyUp += KeyIsUp;
            ((System.ComponentModel.ISupportInitialize)enemy1).EndInit();
            ((System.ComponentModel.ISupportInitialize)enemy2).EndInit();
            ((System.ComponentModel.ISupportInitialize)enemy3).EndInit();
            ((System.ComponentModel.ISupportInitialize)playerPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)bullet).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox enemy1;
        private PictureBox enemy2;
        private PictureBox enemy3;
        private PictureBox playerPictureBox;
        private PictureBox bullet;
        private Label scoreText;
        private System.Windows.Forms.Timer gameTimer;
        private Label healthText;
    }
}
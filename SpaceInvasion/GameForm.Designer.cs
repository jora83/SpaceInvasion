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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            enemyPictureBox1 = new PictureBox();
            enemyPictureBox2 = new PictureBox();
            enemyPictureBox3 = new PictureBox();
            playerPictureBox = new PictureBox();
            bullet = new PictureBox();
            scoreText = new Label();
            gameTimer = new System.Windows.Forms.Timer(components);
            healthText = new Label();
            ((System.ComponentModel.ISupportInitialize)enemyPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)enemyPictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)enemyPictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playerPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bullet).BeginInit();
            SuspendLayout();
            // 
            // enemyPictureBox1
            // 
            enemyPictureBox1.Image = Properties.Resources.invader1;
            enemyPictureBox1.Location = new Point(8, 80);
            enemyPictureBox1.Margin = new Padding(6);
            enemyPictureBox1.Name = "enemyPictureBox1";
            enemyPictureBox1.Size = new Size(125, 113);
            enemyPictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            enemyPictureBox1.TabIndex = 0;
            enemyPictureBox1.TabStop = false;
            enemyPictureBox1.Tag = "enemyy";
            enemyPictureBox1.Visible = false;
            // 
            // enemyPictureBox2
            // 
            enemyPictureBox2.Image = Properties.Resources.invader2;
            enemyPictureBox2.Location = new Point(343, 93);
            enemyPictureBox2.Margin = new Padding(6);
            enemyPictureBox2.Name = "enemyPictureBox2";
            enemyPictureBox2.Size = new Size(125, 111);
            enemyPictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            enemyPictureBox2.TabIndex = 1;
            enemyPictureBox2.TabStop = false;
            enemyPictureBox2.Tag = "enemyy";
            enemyPictureBox2.Visible = false;
            // 
            // enemyPictureBox3
            // 
            enemyPictureBox3.Image = Properties.Resources.invader3;
            enemyPictureBox3.Location = new Point(739, 91);
            enemyPictureBox3.Margin = new Padding(6);
            enemyPictureBox3.Name = "enemyPictureBox3";
            enemyPictureBox3.Size = new Size(138, 111);
            enemyPictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            enemyPictureBox3.TabIndex = 2;
            enemyPictureBox3.TabStop = false;
            enemyPictureBox3.Tag = "enemyy";
            enemyPictureBox3.Visible = false;
            // 
            // playerPictureBox
            // 
            playerPictureBox.Image = (Image)resources.GetObject("playerPictureBox.Image");
            playerPictureBox.Location = new Point(369, 565);
            playerPictureBox.Margin = new Padding(6);
            playerPictureBox.Name = "playerPictureBox";
            playerPictureBox.Size = new Size(65, 55);
            playerPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
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
            gameTimer.Interval = 16;
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
            Controls.Add(enemyPictureBox3);
            Controls.Add(enemyPictureBox2);
            Controls.Add(enemyPictureBox1);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(6);
            Name = "GameForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GameForm";
            KeyDown += KeyIsDown;
            KeyUp += KeyIsUp;
            ((System.ComponentModel.ISupportInitialize)enemyPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)enemyPictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)enemyPictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)playerPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)bullet).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox enemyPictureBox1;
        private PictureBox enemyPictureBox2;
        private PictureBox enemyPictureBox3;
        private PictureBox playerPictureBox;
        private PictureBox bullet;
        private Label scoreText;
        private System.Windows.Forms.Timer gameTimer;
        private Label healthText;
    }
}
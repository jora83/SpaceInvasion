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
            scoreText = new Label();
            gameTimer = new System.Windows.Forms.Timer(components);
            healthText = new Label();
            label1 = new Label();
            gameOverLabel = new Label();
            exitButton = new Button();
            pauseBackground = new PictureBox();
            resumeLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pauseBackground).BeginInit();
            SuspendLayout();
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(369, 31);
            label1.Name = "label1";
            label1.Size = new Size(97, 41);
            label1.TabIndex = 7;
            label1.Text = "label1";
            // 
            // gameOverLabel
            // 
            gameOverLabel.AutoSize = true;
            gameOverLabel.Dock = DockStyle.Fill;
            gameOverLabel.Location = new Point(0, 0);
            gameOverLabel.Name = "gameOverLabel";
            gameOverLabel.Size = new Size(33, 41);
            gameOverLabel.TabIndex = 8;
            gameOverLabel.Text = "a";
            gameOverLabel.TextAlign = ContentAlignment.MiddleCenter;
            gameOverLabel.Visible = false;
            // 
            // exitButton
            // 
            exitButton.Enabled = false;
            exitButton.Location = new Point(350, 313);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(200, 60);
            exitButton.TabIndex = 12;
            exitButton.TabStop = false;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Visible = false;
            exitButton.Click += exitButton_Click;
            // 
            // pauseBackground
            // 
            pauseBackground.BackColor = Color.FromArgb(30, 30, 100);
            pauseBackground.Dock = DockStyle.Right;
            pauseBackground.Location = new Point(716, 0);
            pauseBackground.Name = "pauseBackground";
            pauseBackground.Size = new Size(166, 653);
            pauseBackground.TabIndex = 11;
            pauseBackground.TabStop = false;
            pauseBackground.Visible = false;
            // 
            // resumeLabel
            // 
            resumeLabel.AutoSize = true;
            resumeLabel.Location = new Point(220, 269);
            resumeLabel.Name = "resumeLabel";
            resumeLabel.Size = new Size(463, 41);
            resumeLabel.TabIndex = 12;
            resumeLabel.Text = "Press escape to resume the game";
            resumeLabel.Visible = false;
            // 
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 100);
            ClientSize = new Size(882, 653);
            Controls.Add(resumeLabel);
            Controls.Add(pauseBackground);
            Controls.Add(exitButton);
            Controls.Add(gameOverLabel);
            Controls.Add(label1);
            Controls.Add(healthText);
            Controls.Add(scoreText);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(6);
            Name = "GameForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GameForm";
            KeyDown += KeyIsDown;
            KeyUp += KeyIsUp;
            ((System.ComponentModel.ISupportInitialize)pauseBackground).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label scoreText;
        private System.Windows.Forms.Timer gameTimer;
        private Label healthText;
        private Label label1;
        private Label gameOverLabel;
        private Button exitButton;
        private PictureBox pauseBackground;
        private Label resumeLabel;
    }
}
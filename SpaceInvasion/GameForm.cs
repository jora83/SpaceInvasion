using SpaceInvasion.Scripts;

namespace SpaceInvasion
{
    public partial class GameForm : Form
    {
        private int formWidth;
        private int formHeight;
        private string username;
        private bool isGameOver, isGamePaused;
        private Player player;
        private EnemySpawner enemySpawner;
        private HighscoreSystem highscoreSystem;
        private GameBackground background;

        public GameForm(string username)
        {
            InitializeComponent();
            this.username = username;
            formWidth = this.Width;
            formHeight = this.Height;
            InitializeGame();
        }

        private void GameLoop(object sender, EventArgs e)
        {
            CheckForGameOver();

            UpdatePlayer();

            SpawnEnemies();

            UpdateHealthAndScoreText();

            UpdateEnemies();

            UpdateBackground();
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
            {
                player.MoveLeft = true;
            }
            if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
            {
                player.MoveRight = true;
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
            {
                player.MoveLeft = false;
            }

            if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
            {
                player.MoveRight = false;
            }

            if (e.KeyCode == Keys.Space && !player.Shooting )
            {
                player.IntitializeShooting();
            }

            if (e.KeyCode == Keys.Escape)
            {
                Pause();
            }

            if (e.KeyCode == Keys.Enter && isGameOver)
            {
                ResetGame();
            }

            if (e.KeyCode == Keys.Escape && isGameOver)
            {
                GoToMainMenu();
            }
        }

        private void UpdatePlayer()
        {
            player.Move(formWidth);
            player.Shoot();

            foreach (var bullet in player.ActiveBullets)
            {
                Controls.Add(bullet.PictureBox);
                if (bullet.PosY < 0)
                {
                    bullet.IsActive = false;
                    player.Shooting = false;
                }
                if (!bullet.IsActive)
                {
                    Controls.Remove(bullet.PictureBox);
                }
            }
            player.RemoveInactiveBullets();
        }

        private void SpawnEnemies()
        {
            enemySpawner.SpawnEnemies(player.Score);

            foreach (var enemy in enemySpawner.EnemyList)
            {
                Controls.Add(enemy.PictureBox);
                enemy.PictureBox.BringToFront();
            }
        }

        private void UpdateEnemies()
        {
            foreach (var enemy in enemySpawner.EnemyList)
            {
                enemy.MoveDown();

                if (!enemy.Dispose)
                {
                    if (enemy.HasCollided(player.PictureBox))
                    {
                        player.DecreaseHealth();
                        enemy.Dispose = true;
                    }
                    if (enemy.PictureBox.Top > formHeight)
                    {
                        player.DecreaseHealth();
                        enemy.Dispose = true;
                    }

                    foreach (var bullet in player.ActiveBullets)
                    {
                        if (enemy.HasCollided(bullet.PictureBox))
                        {
                            player.IncreaseScore();
                            enemy.Dispose = true;
                            bullet.IsActive = false;
                            Controls.Remove(bullet.PictureBox);
                            player.Shooting = false;

                        }
                    }
                    if (enemy.Dispose)
                    {
                        Controls.Remove(enemy.PictureBox);
                    }
                }
            }
            enemySpawner.RemoveEnemies();
        }

        private void UpdateBackground()
        {
            background.Update();
        }

        public void AddStars()
        {
            foreach (var star in background.Stars)
            {
                Controls.Add(star.PictureBox);
            }
        }

        private void Pause()
        {
            if (isGamePaused)
            {
                gameTimer.Stop();
                pauseAndGameOverPictureBox.Visible = true;
                pauseAndGameOverPictureBox.BringToFront();
                resumeLabel.Visible = true;
                resumeLabel.BringToFront();
                exitButton.Enabled = true;
                exitButton.Visible = true;
                exitButton.BringToFront();
            }
            else
            {
                gameTimer.Start();
                pauseAndGameOverPictureBox.Visible = false;
                resumeLabel.Visible = false;
                exitButton.Enabled = false;
                exitButton.Visible = false;
            }
            isGamePaused = !isGamePaused;
        }

        private void CheckForGameOver()
        {
            if (player.Health <= 0)
            {
                GameOver();
            }
            
        }

        private void UpdateHealthAndScoreText()
        {
            scoreText.Text = "Score: " + player.Score.ToString();
            healthText.Text = "Health: " + player.Health.ToString();
        }

        private void InitializeGame()
        {
            player = new Player(Constants.InitialPlayerHealth, Constants.PlayerSpeed, formWidth, formHeight);
            Controls.Add(player.PictureBox);
            player.PictureBox.BringToFront();

            enemySpawner = new EnemySpawner(Constants.InitialEnemySpawnFrequency, Constants.InitialEnemySpeed, formWidth);

            highscoreSystem = new HighscoreSystem();

            background = new GameBackground(Constants.StarCount, formWidth, formHeight);
            AddStars();

            gameTimer.Start();
        }

        private void ResetGame()
        {
            foreach (var enemy in enemySpawner.EnemyList)
            {
                Controls.Remove(enemy.PictureBox);
            }
            foreach (var bullet in player.ActiveBullets)
            {
                Controls.Remove(bullet.PictureBox);
            }

            player.Reset();
            enemySpawner.Reset();

            gameOverLabel.Visible = false;
            pauseAndGameOverPictureBox.Visible = false;
            isGameOver = false;

            gameTimer.Start();
        }

        private void GameOver()
        {
            isGameOver = true;
            
            gameTimer.Stop();

            isGameOver = true;

            pauseAndGameOverPictureBox.Visible = true;
            pauseAndGameOverPictureBox.BringToFront();

            gameOverLabel.Text = Environment.NewLine + "Game Over!" + Environment.NewLine + "Your score is: " + player.Score.ToString()
                + Environment.NewLine + "Press enter to try again" + Environment.NewLine + "Press escape to go to the Main Menu";
            gameOverLabel.Visible = true;
            gameOverLabel.BringToFront();

            highscoreSystem.AddUser(username, player.Score);
        }

        private void GoToMainMenu()
        {
            highscoreSystem.AddUser(username, player.Score);
            highscoreSystem.SaveHighscores();
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            GoToMainMenu();
        }


    }
}

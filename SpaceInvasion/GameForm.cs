using SpaceInvasion.Scripts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;

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
            //CheckForGameOver();

            UpdatePlayer();

            SpawnEnemies();

            UpdateHealthAndScore();

            UpdateEnemies();

            UpdateBackground();
        }

        private void UpdateBackground()
        {
            background.Update();
        }

        public void AddStars()
        {
            foreach (var star in background.stars)
            {
                Controls.Add(star.PictureBox);
            }
        }
        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
            {
                player.moveLeft = true;
            }
            if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
            {
                player.moveRight = true;
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
            {
                player.moveLeft = false;
            }

            if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
            {
                player.moveRight = false;
            }

            if (e.KeyCode == Keys.Space && player.shooting == false)
            {
                player.IntitializeShooting();
            }

            if (e.KeyCode == Keys.Escape)
            {
                Pause();
            }

            if (e.KeyCode == Keys.Enter && isGameOver == true)
            {
                InitializeGame();
            }

            if (e.KeyCode == Keys.Escape && isGameOver == true)
            {
                GoToMainMenu();
            }
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

        private void UpdatePlayer()
        {
            player.Move(formWidth);
            player.Shoot();

            foreach (var bullet in player.activeBullets)
            {
                Controls.Add(bullet.PictureBox);
                if (bullet.Y < 0)
                {
                    bullet.IsActive = false;
                    player.shooting = false;
                }
                if (!bullet.IsActive)
                {
                    Controls.Remove(bullet.PictureBox);
                }
            }
            player.RemoveInactiveBullets();
        }

        private void UpdateEnemies()
        {
            foreach (var enemy in enemySpawner.EnemyList)
            {
                enemy.MoveDown();

                if (!enemy.IsDead && !enemy.HasDealtDamage)
                {
                    if (enemy.Collided(player.PictureBox))
                    {
                        player.Health -= 10;
                        enemy.HasDealtDamage = true;
                    }
                    if (enemy.PictureBox.Top > formHeight)
                    {
                        player.Health -= 10;
                        enemy.HasDealtDamage = true;
                    }

                    foreach (var bullet in player.activeBullets)
                    {
                        if (enemy.Collided(bullet.PictureBox))
                        {
                            player.IncreaseScore(10);
                            enemy.IsDead = true;
                            bullet.IsActive = false;
                            Controls.Remove(bullet.PictureBox);
                            player.shooting = false;

                        }
                    }
                    if (enemy.IsDead || enemy.HasDealtDamage)
                    {
                        Controls.Remove(enemy.PictureBox);
                    }
                }
            }
            enemySpawner.EnemyList.RemoveAll(enemy => enemy.IsDead || enemy.HasDealtDamage);

        }

        private void Pause()
        {
            if (isGamePaused)
            {
                gameTimer.Stop();
                pauseBackground.Visible = true;
                resumeLabel.Visible = true;
                resumeLabel.BringToFront();
                exitButton.BringToFront();
                exitButton.TabStop = true;
                exitButton.Enabled = true;
                exitButton.Visible = true;
            }
            else
            {
                gameTimer.Start();
                pauseBackground.Visible = false;
                resumeLabel.Visible = false;
                exitButton.TabStop = false;
                exitButton.Enabled = false;
                exitButton.Visible = false;
            }
            isGamePaused = !isGamePaused;
        }

        private void CheckForGameOver()
        {
            if (player.Health <= 0)
                GameOver();
        }

        private void UpdateHealthAndScore()
        {
            scoreText.Text = "Score: " + player.Score.ToString();
            healthText.Text = "Health: " + player.Health.ToString();
        }

        private void InitializeGame()
        {
            player = new Player(100, 8, formWidth, formHeight);
            Controls.Add(player.PictureBox);
            player.PictureBox.BringToFront();
            enemySpawner = new EnemySpawner(Constants.EnemySpawnFrequency, Constants.EnemySpawnSpeed, formWidth);
            highscoreSystem = new HighscoreSystem();
            background = new GameBackground(30, formWidth, formHeight);
            AddStars();
            gameTimer.Start();
            gameOverLabel.Visible = false;
        }

        private void GoToMainMenu()
        {
            highscoreSystem.AddUser(username, player.Score);
            highscoreSystem.SaveHiscores();
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void GameOver()
        {
            isGameOver = true;
            foreach (Control y in this.Controls)
            {
                if (y is PictureBox && y.Tag != null && y.Tag.ToString() == "enemy")
                {
                    Controls.Remove(y);
                }
            }
            gameOverLabel.Text = Environment.NewLine + "Game Over!" + Environment.NewLine + "Your score is: " + player.Score.ToString()
                + Environment.NewLine + "Press enter to try again" + Environment.NewLine + "Press exit to go to the Main Menu";
            gameOverLabel.Visible = true;
            highscoreSystem.AddUser(username, player.Score);
            gameTimer.Stop();

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            GoToMainMenu();
        }


    }
}

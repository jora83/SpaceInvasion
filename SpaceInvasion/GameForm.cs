﻿using SpaceInvasion.Scripts;
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

namespace SpaceInvasion
{
    public partial class GameForm : Form
    {
        public static int formWidth = 900;
        public static int formHeight = 700;
        public static bool isGameOver, isGamePaused, hasExited;
        public static int score;
        public HighscoreSystem highscoreSystem = new HighscoreSystem();


        Player player = new Player();

        public GameForm()
        {
            InitializeComponent();
            InitializeGame();
            Controls.Add(player.PictureBox);
            highscoreSystem.LoadHighscores();
        }


        private void mainGameTimerEvent(object sender, EventArgs e)
        {
            CheckForGameOver();

            Controls.Add(Enemy.Spawn());

            UpdateHealthAndScore();

            EnemyBehavior();

            player.Move();

            player.Shoot(bullet);

            HasExited();
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
                player.IntitializeShooting(bullet);
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
            if (player.health <= 0)
                GameOver();
        }

        private void UpdateHealthAndScore()
        {
            scoreText.Text = "Score: " + score.ToString();
            healthText.Text = "Health: " + player.health.ToString();
        }

        private void InitializeGame()
        {
            gameTimer.Start();
            gameOverLabel.Visible = false;
            Enemy.speed = 5;
            Enemy.frequency = 100;
            Enemy.limit = 100;
            player.PictureBox.Left = GameForm.formWidth / 2 - player.width;
            player.health = 10;

            score = 0;
            player.bulletSpeed = 0;
            bullet.Left = -300;
            player.shooting = false;
            scoreText.Text = "Score: " + score.ToString();
        }

        private void GoToMainMenu()
        {
            highscoreSystem.SaveHiscores();
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void EnemyBehavior()
        {
            //label1.Text = Enemy.limit.ToString() + " " + Enemy.speed.ToString();
            label1.Text = EnterUserForm.username;

            foreach (Control enemy in this.Controls)
            {
                if (enemy is PictureBox && enemy.Tag != null && enemy.Tag.ToString() == "enemy")
                {
                    enemy.Top += Enemy.speed;

                    if (enemy.Top > formHeight)
                    {
                        player.health -= 10;
                        Controls.Remove(enemy);
                    }

                    if (bullet.Bounds.IntersectsWith(enemy.Bounds))
                    {
                        score += 10;
                        Controls.Remove(enemy);
                        player.shooting = false;
                    }

                    if (player.PictureBox.Bounds.IntersectsWith(enemy.Bounds))
                    {
                        player.health -= 10;
                        Controls.Remove(enemy);
                    }

                }
            }
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
            gameOverLabel.Text = Environment.NewLine + "Game Over!" + Environment.NewLine + "Your score is: " + score.ToString()
                + Environment.NewLine + "Press enter to try again" + Environment.NewLine + "Press exit to go to the Main Menu";
            gameOverLabel.Visible = true;
            highscoreSystem.AddUser(EnterUserForm.username, score);
            //HighscoreSystem.SaveHiscores();
            gameTimer.Stop();

        }


        private void exitButton_Click(object sender, EventArgs e)
        {
            GoToMainMenu();
        }
    }
}

using SpaceInvasion.Scripts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceInvasion
{
    public partial class GameForm : Form
    {
        public static int formWidth = 900;
        public static int formHeight = 700;
        bool isGameOver;
        int score;

        Player player = new Player();

        public GameForm()
        {
            InitializeComponent();
            InitializeGame();

            player.PictureBox = playerPictureBox;
        }

        private void mainGameTimerEvent(object sender, EventArgs e)
        {
            CheckForGameOver();
            
            Controls.Add(Enemy.Spawn());

            UpdateHealthAndScore();

            EnemyBehavior();

            player.Move();

            player.Shoot(bullet);

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

            if (e.KeyCode == Keys.Enter && isGameOver == true)
            {
                InitializeGame();
            }
        }

        private void CheckForGameOver()
        {
            if (player.health < 0)
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
            Enemy.speed = 5;

            player.health = 100;

            score = 0;
            player.bulletSpeed = 0;
            bullet.Left = -300;
            player.shooting = false;

            scoreText.Text = "Score: " + score.ToString();
        }

        private void EnemyBehavior()
        {
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
            gameTimer.Stop();
            scoreText.Text += Environment.NewLine + "Game Over" + Environment.NewLine + "Press enter to try again";
        }
    }
}

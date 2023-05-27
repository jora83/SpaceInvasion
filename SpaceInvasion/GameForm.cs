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
        int bulletSpeed;
        int enemySpeed;
        Random rnd = new Random();

        Player player = new Player();

        public GameForm()
        {
            InitializeComponent();
            ResetGame();
            player.playerPictureBox = playerPictureBox;
        }

        private void mainGameTimerEvent(object sender, EventArgs e)
        {

            scoreText.Text = "Score: " + score.ToString();
            healthText.Text = "Health: " + player.health.ToString();

            enemy1.Top += enemySpeed;
            enemy2.Top += enemySpeed;
            enemy3.Top += enemySpeed;

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag != null && x.Tag.ToString() == "enemy")
                {
                    if (x.Top > formHeight)
                    {
                        player.health -= 10;
                        x.Left = rnd.Next(8, 740);
                        x.Top = rnd.Next(0, 200) * -1;
                    }

                    if (bullet.Bounds.IntersectsWith(x.Bounds))
                    {
                        score += 10;
                        x.Left = rnd.Next(8, 740);
                        x.Top = rnd.Next(0, 200) * -1;
                        player.shooting = false;
                    }

                    if (player.playerPictureBox.Bounds.IntersectsWith(x.Bounds))
                    {
                        player.health -= 5;
                        x.Left = rnd.Next(8, 740);
                        x.Top = rnd.Next(0, 200) * -1;
                    }
                }
            }

            //if (playerHealth <= 0)
            //GameOver();

            player.MoveLeft();

            player.MoveRight();

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
                ResetGame();
            }
        }

        private void ResetGame()
        {
            gameTimer.Start();
            enemySpeed = 3;


            player.health = 100;

            enemy1.Left = rnd.Next(8, 740);
            enemy2.Left = rnd.Next(8, 740);
            enemy3.Left = rnd.Next(8, 740);

            enemy1.Top = rnd.Next(0, 500) * -1;
            enemy2.Top = rnd.Next(0, 700) * -1;
            enemy3.Top = rnd.Next(0, 1200) * -1;

            score = 0;
            player.bulletSpeed = 0;
            bullet.Left = -300;
            player.shooting = false;

            scoreText.Text = "Score: " + score.ToString();

        }

        private void GameOver()
        {
            isGameOver = true;
            gameTimer.Stop();
            scoreText.Text += Environment.NewLine + "Game Over" + Environment.NewLine + "Press enter to try again";
        }
    }
}

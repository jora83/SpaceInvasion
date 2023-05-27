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
        int formWidth = 900;
        int formHeight = 700;
        bool moveLeft, moveRight, shooting;
        bool isGameOver;
        int score;
        int playerSpeed = 12;
        int playerHealth = 100;
        int bulletSpeed;
        int enemySpeed;
        Random rnd = new Random();

        Player plr = new Player();
        
        public GameForm()
        {

            InitializeComponent();
            ResetGame();
            plr.playerPictureBox = player;
        }

        //public PictureBox PlayerPictureBox
        //{
        //    get
        //    {
        //        return player;
        //    }
        //}

        private void mainGameTimerEvent(object sender, EventArgs e)
        {

            scoreText.Text = "Score: " + score.ToString();
            healthText.Text = "Health: " + playerHealth.ToString();

            enemy1.Top += enemySpeed;
            enemy2.Top += enemySpeed;
            enemy3.Top += enemySpeed;

            //if (enemy1.Top > 700 || enemy2.Top > 700 || enemy3.Top > 700)
            //{
            //    playerHealth -= 10;
            //}

            //if (enemy1.Top > 700)
            //{
            //    playerHealth -= 10;
            //    enemy1.Left = rnd.Next(8, 740);
            //    enemy1.Top = rnd.Next(0, 200) * -1;
            //}
            //if (enemy2.Top > 700)
            //{
            //    playerHealth -= 10;
            //    enemy2.Left = rnd.Next(8, 740);
            //    enemy2.Top = rnd.Next(0, 200) * -1;
            //}
            //if (enemy3.Top > 700)
            //{
            //    playerHealth -= 10;
            //    enemy3.Left = rnd.Next(8, 740);
            //    enemy3.Top = rnd.Next(0, 200) * -1;
            //}

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag != null && x.Tag.ToString() == "enemy")
                {
                    if (x.Top > formHeight)
                    {
                        playerHealth -= 10;
                        x.Left = rnd.Next(8, 740);
                        x.Top = rnd.Next(0, 200) * -1;
                    }

                    if (bullet.Bounds.IntersectsWith(x.Bounds))
                    {
                        score += 10;
                        x.Left = rnd.Next(8, 740);
                        x.Top = rnd.Next(0, 200) * -1;
                        shooting = false;
                    }

                    if(player.Bounds.IntersectsWith(x.Bounds))
                    {
                        playerHealth -= 5;
                        x.Left = rnd.Next(8, 740);
                        x.Top = rnd.Next(0, 200) * -1;
                    }
                }
            }

            //if (playerHealth <= 0)
            //GameOver();

            if (moveLeft == true && plr.playerPictureBox.Left > 0)
            {  
                plr.MoveLeft();
            }
            if (moveRight == true && player.Left < (formWidth - player.Width))
            {
                player.Left += playerSpeed;
            }

            if (shooting == true)
            {
                bulletSpeed = 20;
                bullet.Top -= bulletSpeed;
            }
            else
            {
                bullet.Left = -300;
                bulletSpeed = 0;
            }

            if (bullet.Top < -30)
            {
                shooting = false;
            }

            //if (bullet.Bounds.IntersectsWith(enemy1.Bounds))
            //{
            //    score += 10;
            //    enemy1.Left = rnd.Next(8, 740);
            //    enemy1.Top = rnd.Next(0, 200) * -1;
            //    shooting = false;
            //}

            //if (bullet.Bounds.IntersectsWith(enemy2.Bounds))
            //{
            //    score += 10;
            //    enemy2.Left = rnd.Next(8, 740);
            //    enemy2.Top = rnd.Next(0, 200) * -1;
            //    shooting = false;
            //}

            //if (bullet.Bounds.IntersectsWith(enemy3.Bounds))
            //{
            //    score += 10;
            //    enemy3.Left = rnd.Next(8, 740);
            //    enemy3.Top = rnd.Next(0, 200) * -1;
            //    shooting = false;
            //}


        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
            {
                moveLeft = true;
            }
            if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
            {
                moveRight = true;
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
            {
                moveLeft = false;
            }
            if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
            {
                moveRight = false;
            }
            if (e.KeyCode == Keys.Space && shooting == false)
            {
                shooting = true;

                bullet.Top = player.Top - (bullet.Height + 5);
                bullet.Left = player.Left + (player.Width / 2);
            }

            if (e.KeyCode == Keys.Enter && isGameOver == true)
            {
                ResetGame();
            }
        }

        private void ResetGame()
        {
            gameTimer.Start();
            enemySpeed = 6;
            

            playerHealth = 100;

            enemy1.Left = rnd.Next(8, 740);
            enemy2.Left = rnd.Next(8, 740);
            enemy3.Left = rnd.Next(8, 740);

            enemy1.Top = rnd.Next(0, 500) * -1;
            enemy2.Top = rnd.Next(0, 700) * -1;
            enemy3.Top = rnd.Next(0, 1200) * -1;

            score = 0;
            bulletSpeed = 0;
            bullet.Left = -300;
            shooting = false;

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

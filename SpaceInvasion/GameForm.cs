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

        int enemyCounter = 100;
        int enemyLimit = 100;

        List<PictureBox> enemyList = new List<PictureBox>();
        List<PictureBox> enemyRemover = new List<PictureBox>();

        Random rnd = new Random();

        Player player = new Player();

        List<PictureBox> enemies = new List<PictureBox>();

        //Enemy enemy1 = new Enemy();
        //Enemy enemy2 = new Enemy();
        //Enemy enemy3 = new Enemy();


        public GameForm()
        {
            InitializeComponent();
            InitializeGame();

            player.PictureBox = playerPictureBox;

            //enemy1.PictureBox = enemyPictureBox1;
            //enemy2.PictureBox = enemyPictureBox2;
            //enemy3.PictureBox = enemyPictureBox3;

            //enemies.Add(enemy1);
            //enemies.Add(enemy2);
            //enemies.Add(enemy3);
        }

        private void mainGameTimerEvent(object sender, EventArgs e)
        {

            //Enemy.counter--;
            enemyCounter--;

            if (enemyCounter == 0)
            {
                SpawnEnemies();
                enemyCounter = enemyLimit;
                if (score > 0)
                {
                    if (score % 100 == 0)
                    {
                        enemyLimit = 2;
                        enemySpeed = 20;
                    }
                }
                
                //Enemy.Spawn();
                //Enemy.counter = Enemy.limit;
            }

            //foreach (PictureBox pb in Enemy.PictureBoxes)
            //{
            //    Controls.Add(pb);
            //}


            scoreText.Text = "Score: " + score.ToString();
            healthText.Text = "Health: " + player.health.ToString();

            //enemy1.Top += enemySpeed;
            //enemy2.Top += enemySpeed;
            //enemy3.Top += enemySpeed;

            //enemy1.Move();
            //enemy2.Move();
            //enemy3.Move();

            foreach (Control y in this.Controls)
            {
                if (y is PictureBox && y.Tag != null && y.Tag.ToString() == "enemy")
                {
                    y.Top += enemySpeed;
                }
            }

            //foreach (PictureBox x in Enemy.PictureBoxes)
            //{
            //    if (x is PictureBox && x.Tag != null && x.Tag.ToString() == "enemy")
            //    {
            //        if (x.Top > formHeight)
            //        {
            //            player.health -= 10;
            //            //x.Left = rnd.Next(8, 740);
            //            //x.Top = rnd.Next(200, 400) * -1;
            //            enemyRemover.Add((PictureBox)x);
            //        }

            //        if (bullet.Bounds.IntersectsWith(x.Bounds))
            //        {
            //            score += 10;
            //            //x.Left = rnd.Next(8, 740);
            //            //x.Top = rnd.Next(200, 500) * -1;
            //            enemyRemover.Add((PictureBox)x);
            //            player.shooting = false;
            //        }

            //        if (player.PictureBox.Bounds.IntersectsWith(x.Bounds))
            //        {
            //            player.health -= 5;
            //            //x.Left = rnd.Next(8, 740);
            //            //x.Top = rnd.Next(200, 600) * -1;
            //            enemyRemover.Add((PictureBox)x);
            //        }

            //    }
            //}

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag != null && x.Tag.ToString() == "enemy")
                {
                    if (x.Top > formHeight)
                    {
                        player.health -= 10;
                        //x.Left = rnd.Next(8, 740);
                        //x.Top = rnd.Next(200, 400) * -1;
                        enemyRemover.Add((PictureBox)x);
                    }

                    if (bullet.Bounds.IntersectsWith(x.Bounds))
                    {
                        score += 10;
                        //x.Left = rnd.Next(8, 740);
                        //x.Top = rnd.Next(200, 500) * -1;
                        enemyRemover.Add((PictureBox)x);
                        player.shooting = false;
                    }

                    if (player.PictureBox.Bounds.IntersectsWith(x.Bounds))
                    {
                        player.health -= 5;
                        //x.Left = rnd.Next(8, 740);
                        //x.Top = rnd.Next(200, 600) * -1;
                        enemyRemover.Add((PictureBox)x);
                    }

                }
            }

            foreach (PictureBox enemy in enemyRemover)
            {
                Controls.Remove(enemy);
            }

            enemyRemover.Clear();
            //foreach (Enemy x in enemies)
            //{
            //    if (x.PictureBox is PictureBox && x.PictureBox.Tag != null && x.PictureBox.Tag.ToString() == "enemy")
            //    {
            //        if (x.PictureBox.Top > formHeight)
            //        {
            //            player.health -= 10;
            //            x.PictureBox.Left = rnd.Next(8, 740);
            //            x.PictureBox.Top = rnd.Next(0, 200) * -1;
            //        }

            //        if (bullet.Bounds.IntersectsWith(x.PictureBox.Bounds))
            //        {
            //            score += 10;
            //            x.PictureBox.Left = rnd.Next(8, 740);
            //            x.PictureBox.Top = rnd.Next(0, 200) * -1;
            //            player.shooting = false;
            //        }

            //        if (player.PictureBox.Bounds.IntersectsWith(x.PictureBox.Bounds))
            //        {
            //            player.health -= 5;
            //            x.PictureBox.Left = rnd.Next(8, 740);
            //            x.PictureBox.Top = rnd.Next(0, 200) * -1;
            //        }
            //    }
            //}

            if (player.health < 0)
                GameOver();

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
                InitializeGame();
            }
        }

        public void SpawnEnemies()
        {
            PictureBox newEnemy = new PictureBox()
            {
                Tag = "enemy",
                Width = 125,
                Height = 113,
                Left = rnd.Next(8, 740),
                Top = rnd.Next(300, 500) * -1,
                Image = Properties.Resources.invader1
            };
            newEnemy.Refresh();
            enemyList.Add(newEnemy);
            Controls.Add(newEnemy);
        }

        private void InitializeGame()
        {
            gameTimer.Start();
            enemySpeed = 5;


            player.health = 100;

            //enemyPictureBox1.Left = rnd.Next(8, 740);
            //enemyPictureBox2.Left = rnd.Next(8, 740);
            //enemyPictureBox3.Left = rnd.Next(8, 740);

            //enemyPictureBox1.Top = rnd.Next(500, 700) * -1;
            //enemyPictureBox2.Top = rnd.Next(600, 900) * -1;
            //enemyPictureBox3.Top = rnd.Next(700, 1200) * -1;

            //enemy1.Spawn();
            //enemy2.Spawn();
            //enemy3.Spawn();

            score = 0;
            player.bulletSpeed = 0;
            bullet.Left = -300;
            player.shooting = false;

            scoreText.Text = "Score: " + score.ToString();

            

        }

        private void GameOver()
        {
            isGameOver = true;
            foreach (PictureBox x in enemyList)
            {
                if (x is PictureBox && x.Tag != null && x.Tag.ToString() == "enemy")
                {
                    Controls.Remove(x);
                }
            }
            enemyList.Clear();
            foreach (Control y in this.Controls)
            {
                if (y is PictureBox && y.Tag != null && y.Tag.ToString() == "enemy")
                {
                    
                    enemyRemover.Add((PictureBox)y);
                    Controls.Remove(y);
                }
            }
            enemyRemover.Clear();
            gameTimer.Stop();
            scoreText.Text += Environment.NewLine + "Game Over" + Environment.NewLine + "Press enter to try again";
        }
    }
}

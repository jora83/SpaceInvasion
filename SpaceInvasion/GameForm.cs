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

        //List<PictureBox> enemies = new List<PictureBox>();

        public GameForm()
        {
            InitializeComponent();
            InitializeGame();

            player.PictureBox = playerPictureBox;
        }

        private void mainGameTimerEvent(object sender, EventArgs e)
        {
            if (player.health < 0)
                GameOver();


            //enemy class
            //Enemy.counter--;
            
            //if(Enemy.counter == 0)
            //{
                ///////Enemy.Spawn();
                
            Controls.Add(Enemy.Spawn());
              //  Enemy.counter = Enemy.limit;
            //}

            //foreach (PictureBox pb in Enemy.enemyList) 
            //{
            //    Controls.Add(pb);
            //}

            //Enemy.enemyList.Clear();


            //enemy class

            //enemyCounter--;

            //if (enemyCounter == 0)
            //{
            //    SpawnEnemies();
            //    enemyCounter = enemyLimit;
            //}

            scoreText.Text = "Score: " + score.ToString();
            healthText.Text = "Health: " + player.health.ToString();

            //foreach (Control y in this.Controls)
            //{
            //    if (y is PictureBox && y.Tag != null && y.Tag.ToString() == "enemy")
            //    {
            //        y.Top += enemySpeed;
            //    }
            //}

            EnemyBehavior();

            foreach (PictureBox enemy in enemyRemover)
            {
                Controls.Remove(enemy);
            }

            enemyRemover.Clear();

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

        //public void SpawnEnemies()
        //{
        //    PictureBox newEnemy = new PictureBox()
        //    {
        //        Tag = "enemy",
        //        Width = 65,
        //        Height = 55,
        //        Left = rnd.Next(8, 740),
        //        Top = rnd.Next(300, 500) * -1,
        //        Image = Properties.Resources.invader1,
        //        SizeMode = PictureBoxSizeMode.StretchImage
        //    };
        //    newEnemy.Refresh();
        //    enemyList.Add(newEnemy);
        //    Controls.Add(newEnemy);
        //}

        private void InitializeGame()
        {
            gameTimer.Start();
            enemySpeed = 5;

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
                    enemy.Top += enemySpeed;

                    if (enemy.Top > formHeight)
                    {
                        player.health -= 10;
                        enemyRemover.Add((PictureBox)enemy);
                    }

                    if (bullet.Bounds.IntersectsWith(enemy.Bounds))
                    {
                        score += 10;
                        enemyRemover.Add((PictureBox)enemy);
                        player.shooting = false;
                    }

                    if (player.PictureBox.Bounds.IntersectsWith(enemy.Bounds))
                    {
                        player.health -= 10;
                        enemyRemover.Add((PictureBox)enemy);
                    }

                }
            }
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
                    Controls.Remove(y);
                }
            }
            enemyRemover.Clear();
            gameTimer.Stop();
            scoreText.Text += Environment.NewLine + "Game Over" + Environment.NewLine + "Press enter to try again";
        }
    }
}

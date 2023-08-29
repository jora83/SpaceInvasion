using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvasion.Scripts
{
    public class Enemy
    {
        private static Random rnd = new Random();
        //public static int InitialSpeed{ get; set;} = 5
        public int Speed { get; set; } //5
        public int PosX { get; set; }
        public int PosY { get; set; }
        public bool HasDealtDamage { get; set; }
        public bool IsDead { get; set; }
        public PictureBox PictureBox { get; private set; }
        private static Image[] enemyImages = new Image[] { Properties.Resources.alien1, Properties.Resources.alien2,
                                                    Properties.Resources.alien3, Properties.Resources.alien4 };

        public Enemy(int speed, int posX, int posY) 
        {
            Speed = speed;
            PosX = posX;
            PosY = posY;
            HasDealtDamage = false;
            IsDead = false;
            Image enemyImage = enemyImages[rnd.Next(enemyImages.Length)];

            PictureBox = new PictureBox()
            {
                Location = new Point(posX, posY),
                Size = new Size(Constants.EnemyWidth, Constants.EnemyHeight),
                Image = enemyImage
                //SizeMode = PictureBoxSizeMode.StretchImage
            };
        }

        public void MoveDown()
        {
            PosY += Speed;
            PictureBox.Top = PosY;
        }
        public bool Collided(PictureBox pictureBox)
        {
            if (pictureBox.Bounds.IntersectsWith(PictureBox.Bounds))
            { 
                return true;
            }
            return false;
        }

        public void Collision(int formHeight, Player player)
        {
            if (PictureBox.Top > formHeight)
            {
                HasDealtDamage = true;
            }

            //if (player.Bullet.Bounds.IntersectsWith(PictureBox.Bounds))
            //{
            //    IsDead = true;
            //}

            if (player.PictureBox.Bounds.IntersectsWith(PictureBox.Bounds))
            {
                HasDealtDamage = true;
            }
        }
    }
}

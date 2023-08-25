using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvasion.Scripts
{
    public class Enemies
    {
        private static Random rnd = new Random();
        //public static int initialSpeed { get; set; } = 5;
        public int Speed { get; set; } //5
        public int PosX { get; set; }
        public int PosY { get; set; }
        //public int frequency { get; set; } //100
        //public int limit { get; set; } //100
        //public bool increaseSpeedAndFrequency { get; set; }
        //public static List<PictureBox> Disposal = new List<PictureBox>();
        public bool HasDealtDamage { get; set; }
        public bool IsDead { get; set; }
        public PictureBox PictureBox { get; private set; }
        private static Image[] enemyImages = new Image[] { Properties.Resources.alien1, Properties.Resources.alien2,
                                                    Properties.Resources.alien3, Properties.Resources.alien4 };
        //public static List<Enemies> enemyList {  get; set; }

        public Enemies(int speed, int posX, int posY) 
        {
            Speed = speed;
            PosX = posX;
            PosY = posY;

            Image enemyImage = enemyImages[rnd.Next(enemyImages.Length)];

            PictureBox = new PictureBox()
            {
                Tag = "enemy",
                Width = 64, //75
                Height = 64, //65
                Left = PosX,
                Top = PosY,
                Image = enemyImage,
                SizeMode = PictureBoxSizeMode.StretchImage
            };
        }

        //public PictureBox RenderEnemyPictureBox()
        //{
        //    image = new Image[] { Properties.Resources.alien1, Properties.Resources.alien2, Properties.Resources.alien3, Properties.Resources.alien4 };
        //    return new PictureBox()
        //    {
        //        Tag = "enemy",
        //        Width = 75,
        //        Height = 65,
        //        //Left = rnd.Next(8, 740),
        //        Left = PosX,
        //        //Top = rnd.Next(300, 500) * -1,
        //        Top = PosY,
        //        Image = image[rnd.Next(image.Length)],
        //        SizeMode = PictureBoxSizeMode.StretchImage
        //    };

        //}

        public void MoveDown()
        {
            PosY += Speed;
            PictureBox.Top = PosY;
        }

        public void Collision(int formHeight, Player player)
        {
            if (PictureBox.Top > formHeight)
            {
                HasDealtDamage = true;
                //EnemySpawner.enemyList.Remove(this);
            }

            if (player.Bullet.Bounds.IntersectsWith(PictureBox.Bounds))
            {
                IsDead = true;
                //EnemySpawner.enemyList.Remove(this);
                //player.shooting = false;
            }

            if (player.PictureBox.Bounds.IntersectsWith(PictureBox.Bounds))
            {
                HasDealtDamage = true;
                //EnemySpawner.enemyList.Remove(this);
            }
            //HasDealtDamage=false;
            //IsDead = false;
        }
        
        //public PictureBox? Spawn()
        //{
        //    if (GameForm.score > 0 && GameForm.score % 100 == 0 && increaseSpeedAndFrequency)
        //    {
        //        limit -= 5;
        //        speed++;
        //        increaseSpeedAndFrequency = true;
        //    }

        //    if (GameForm.score % 100 != 0)
        //    {
        //        increaseSpeedAndFrequency = false;
        //    }

        //    frequency--;
        //    if (frequency == 0)
        //    {
        //        frequency = limit;
        //        return new PictureBox()
        //        {
        //            Tag = "enemy",
        //            Width = 75,
        //            Height = 65,
        //            Left = rnd.Next(8, 740),
        //            Top = rnd.Next(300, 500) * -1,
        //            //Image = Properties.Resources.alien1,
        //            Image = image[rnd.Next(image.Length)],
        //            SizeMode = PictureBoxSizeMode.StretchImage
        //        };
        //    }
        //    return null;
        //}

    }
}

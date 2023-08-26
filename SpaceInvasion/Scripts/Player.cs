using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvasion.Scripts
{
    public class Player
    {
        public int Health { get; set; }//= 100;
        //public int Width { get; set; } //= 85;
        //public int Height { get; set; }//= 75;
        public int Speed { get; set; }//= 8;
        public int PosX { get; set; }
        public int PosY { get; set; }
        public PictureBox PictureBox { get; }
        public PictureBox Bullet { get; } //{ Image = Properties.Resources.bullet };

        public bool moveLeft, moveRight, shooting;
        private readonly int initialPosX;
        private readonly int initialPosY;

       
        public Player(int health, int speed, int formWidth, int formHeight)
        {
            Health = health;
            //Width = width;
            //Height = height;
            Speed = speed;
            

            Image playerImage = Properties.Resources.spaceship;

            PictureBox = new PictureBox()
            {
                Tag = "player",
                Width = 64,
                Height = 64,
                Left = PosX,
                Top = PosY,
                Image = playerImage,
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            //PosX = formWidth / 2 - PictureBox.Width;
            //PosY = formHeight - PictureBox.Height * 2;
            PosX = (formWidth - PictureBox.Width) / 2;
            PosY = formHeight - PictureBox.Height * 2;
            initialPosX = PosX;
            initialPosY = PosY;

            Image bulletImage = Properties.Resources.bullet;

            Bullet = new PictureBox
            {
                Tag = "bullet",
                Image = bulletImage,
                Left = -300
            };
        }
        public void Reset()
        {
            Health = 100;
            PosX = initialPosX;
            PosY = initialPosY;
            PictureBox.Left = PosX;
            PictureBox.Top = PosY;
        }
        //public PictureBox RenderPlayerPicturebox()
        //{
        //    return new PictureBox()
        //    {
        //        Tag = "player",
        //        Width = Width,
        //        Height = Height,
        //        //Left = GameForm.formWidth / 2 - width,
        //        //Left = posX,
        //        //Top = GameForm.formHeight - height * 2 + 15,
        //        //Top = posY,
        //        Image = Properties.Resources.spaceship,
        //        SizeMode = PictureBoxSizeMode.StretchImage
        //    };
        //}

        public void Move()
        {
            //if (moveLeft == true && PictureBox.Left > 0)
            //    PictureBox.Left -= speed;

            //if (moveRight == true && PictureBox.Left < (900 - 85) - 10)//(GameForm.formWidth - PictureBox.Width))
            //    PictureBox.Left += speed;
            if (moveLeft == true && PosX > 0)
            {
                PosX -= Speed;
                PictureBox.Left = PosX;
            }
                

            if (moveRight == true && PosX < (900 - 85) - 10)//(GameForm.formWidth - PictureBox.Width))
            {
                PosX += Speed;
                PictureBox.Left = PosX;
            }    

        }

        public void IntitializeShooting()
        { 
            shooting = true;

            Bullet.Top = PictureBox.Top - (Bullet.Height + 5);
            Bullet.Left = PictureBox.Left + (PictureBox.Width / 2);

        }

        public void Shoot()
        {
            int bulletSpeed = 20;
            
            if (shooting == true)
            {
                bulletSpeed = 20;
                Bullet.Top -= bulletSpeed;
            }
            else
            {
                Bullet.Left = -300;
                bulletSpeed = 0;
            }

            if (Bullet.Top < -30)
            {
                shooting = false;
            }
        }
    }
}

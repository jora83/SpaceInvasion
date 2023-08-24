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
        public int health { get; set; }//= 100;
        public int width { get; set; } //= 85;
        public int height { get; set; }//= 75;
        public int speed { get; set; }//= 8;
        public int posX { get; set; }
        public int posY { get; set; }
        public int bulletSpeed { get; set; }//= 20;
        public bool moveLeft, moveRight, shooting;
        public PictureBox PictureBox { get; set; }

        public PictureBox bullet { get; set; } //{ Image = Properties.Resources.bullet };
        public Player()
        {
            //PictureBox = RenderPlayerPicturebox();
        }
        public void RenderPlayer()
        {

        }
        public PictureBox RenderPlayerPicturebox()
        {
            return new PictureBox()
            {
                Tag = "player",
                Width = width,
                Height = height,
                //Left = GameForm.formWidth / 2 - width,
                //Left = posX,
                //Top = GameForm.formHeight - height * 2 + 15,
                //Top = posY,
                Image = Properties.Resources.spaceship,
                SizeMode = PictureBoxSizeMode.StretchImage
            };
        }

        public void Move()
        {
            //if (moveLeft == true && PictureBox.Left > 0)
            //    PictureBox.Left -= speed;

            //if (moveRight == true && PictureBox.Left < (900 - 85) - 10)//(GameForm.formWidth - PictureBox.Width))
            //    PictureBox.Left += speed;
            if (moveLeft == true && posX > 0)
            {
                posX -= speed;
                PictureBox.Left = posX;
            }
                

            if (moveRight == true && posX < (900 - 85) - 10)//(GameForm.formWidth - PictureBox.Width))
            {
                posX += speed;
                PictureBox.Left = posX;
            }    

        }

        public void IntitializeShooting()
        { 
            shooting = true;

            bullet.Top = PictureBox.Top - (bullet.Height + 5);
            bullet.Left = PictureBox.Left + (PictureBox.Width / 2);

        }

        public void Shoot()
        {
            
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
        }
    }
}

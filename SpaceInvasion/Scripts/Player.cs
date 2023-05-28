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
        public int health = 100;
        int speed = 12;
        public int bulletSpeed = 20;
        public bool moveLeft, moveRight, shooting;
        public PictureBox PictureBox;

        public void MoveLeft()
        {
            if (moveLeft == true && PictureBox.Left > 0)
            PictureBox.Left -= speed;
        }

        public void MoveRight()
        {
            if (moveRight == true && PictureBox.Left < (900-65))//(GameForm.formWidth - PictureBox.Width))
            PictureBox.Left += speed;
        }

        public void IntitializeShooting(PictureBox bullet)
        { 
            shooting = true;

            bullet.Top = PictureBox.Top - (bullet.Height + 5);
            bullet.Left = PictureBox.Left + (PictureBox.Width / 2);

        }

        public void Shoot(PictureBox bullet)
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

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
        public int Health { get; set; }
        public int Score { get; private set; }
        public int Speed { get; set; }
        public int PosX { get; set; }
        public int PosY { get; set; }
        public PictureBox PictureBox { get; }
        public List<Bullet> activeBullets { get; set; }
        public bool moveLeft, moveRight, shooting;
        private readonly int initialPosX;
        private readonly int initialPosY;


        public Player(int health, int speed, int formWidth, int formHeight)
        {
            Health = health;
            Speed = speed;
            Score = 0;
            PosX = (formWidth - Constants.PlayerWidth - Constants.PictureboxMargin) / 2;
            PosY = formHeight - Constants.PlayerHeight * 2;

            activeBullets = new List<Bullet>();

            Image playerImage = Properties.Resources.spaceship;

            PictureBox = new PictureBox()
            {
                Tag = "player",
                Size = new Size(Constants.PlayerWidth, Constants.PlayerHeight),
                Left = PosX,
                Top = PosY,
                Image = playerImage,
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            initialPosX = PosX;
            initialPosY = PosY;
        }
        //public void Reset()
        //{
        //    Health = 100;
        //    PosX = initialPosX;
        //    PosY = initialPosY;
        //    PictureBox.Left = PosX;
        //    PictureBox.Top = PosY;
        //}

        public void IncreaseScore(int points)
        {
            Score += points;
        }

        public void Move(int formWidth)
        {
            if (moveLeft == true && PosX > 0)
            {
                PosX -= Speed;
                PictureBox.Left = PosX;
            }

            if (moveRight == true && PosX < formWidth - Constants.PlayerWidth - Constants.PictureboxMargin)
            {
                PosX += Speed;
                PictureBox.Left = PosX;
            }
        }

        public void IntitializeShooting()
        {
            shooting = true;
            activeBullets.Add(new Bullet(PictureBox.Left + PictureBox.Width / 2, PictureBox.Top));

        }

        public void Shoot()
        {

            if (shooting)
            {
                foreach (var bullet in activeBullets)
                {
                    bullet.Move();
                }
            }

            RemoveInactiveBullets();
        }

        public void RemoveInactiveBullets()
        {
            activeBullets.RemoveAll(bullet => !bullet.IsActive);
        }
    }
}

﻿namespace SpaceInvasion.Scripts
{
    public class Bullet
    {
        private readonly int bulletSpeed = Constants.BulletSpeed;
        public int PosX { get; set; }
        public int PosY { get; set; }
        public PictureBox PictureBox { get; private set; }
        public bool IsActive { get; set; }

        public Bullet(int x, int y)
        {
            PosX = x;
            PosY = y;

            IsActive = true;

            PictureBox = new PictureBox
            {
                Location = new Point(x, y),
                Size = new Size(Constants.BulletWidth, Constants.BulletHeight), 
                Image = Properties.Resources.bullet
            };
        }

        public void Move()
        {
            PosY -= bulletSpeed;
            PictureBox.Top = PosY;
        }
    }
}

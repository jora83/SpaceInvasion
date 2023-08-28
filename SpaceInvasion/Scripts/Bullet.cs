using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvasion.Scripts
{
    public class Bullet
    {
        private const int BulletSpeed = 20;
        public int X { get; set; }
        public int Y { get; set; }
        public PictureBox PictureBox { get; private set; }

        public bool IsActive { get; set; }

        public Bullet(int x, int y)
        {
            X = x;
            Y = y;

            IsActive = true;

            PictureBox = new PictureBox
            {
                Location = new Point(x, y),
                Size = new Size(5, 15), // Adjust size as needed
                Image = Properties.Resources.bullet,
                BackColor = Color.Transparent
            };
        }

        public void Move()
        {
            Y -= BulletSpeed;
            PictureBox.Top = Y;
        }
    }
}

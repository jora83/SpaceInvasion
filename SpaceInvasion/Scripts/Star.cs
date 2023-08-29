using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvasion.Scripts
{
    public class Star
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Speed { get; set; }
        public PictureBox PictureBox { get; set; }

        public Star(int x, int y, int speed, Image image)
        {
            X = x;
            Y = y;
            Speed = speed;

            PictureBox = new PictureBox
            {
                Location = new Point(x, y),
                Size = new Size(20, 20), // Adjust size as needed
                Image = image,
                BackColor = Color.Transparent

            };
        }

        public void Move()
        {
            Y += Speed;
            PictureBox.Top = Y;
        }
    }
}

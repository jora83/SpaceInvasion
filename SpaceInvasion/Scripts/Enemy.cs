using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvasion.Scripts
{
    public static class Enemy
    {
        static Random rnd = new Random();
        static int speed = 3;
        public static int counter = 100;
        public static int limit = 100;
        public static List<PictureBox> PictureBoxes = new List<PictureBox>();

        public static void Spawn()
        {
            PictureBox newEnemy = new PictureBox()
            {
                Tag = "enemy",
                Width = 65,
                Height = 55,
                Left = rnd.Next(8, 740),
                Top = rnd.Next(300, 500) * -1,
                Image = Properties.Resources.invader1,
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            newEnemy.Refresh();
            PictureBoxes.Add(newEnemy);
        }

        public static void Move()
        {
            foreach(PictureBox pb in PictureBoxes)
            {
                if (pb is PictureBox && pb.Tag != null && pb.Tag.ToString() == "enemy")
                {
                    pb.Top += speed;
                }
            }
        }
    }
}

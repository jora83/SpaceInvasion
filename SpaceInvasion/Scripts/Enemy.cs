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
        public static int speed = 3;
        public static int counter = 100;
        public static int limit = 100;
        //public static List<PictureBox> enemyList = new List<PictureBox>();
        public static List<PictureBox> Disposal = new List<PictureBox>();
        public static PictureBox newEnemy = new PictureBox();

        //public static void Spawn()
        //{
        //    counter--;
        //    if (counter == 0)
        //    {
        //        newEnemy = new PictureBox()
        //        {
        //            Tag = "enemy",
        //            Width = 65,
        //            Height = 55,
        //            Left = rnd.Next(8, 740),
        //            Top = rnd.Next(300, 500) * -1,
        //            Image = Properties.Resources.invader1,
        //            SizeMode = PictureBoxSizeMode.StretchImage
        //        };
        //        newEnemy.Refresh();
        //        enemyList.Add(newEnemy);
        //        counter = limit;
        //    }
        //}

        public static PictureBox Spawn()
        {
            counter--;
            if (counter == 0)
            {
                counter = limit;
                return new PictureBox()
                {
                    Tag = "enemy",
                    Width = 65,
                    Height = 55,
                    Left = rnd.Next(8, 740),
                    Top = rnd.Next(300, 500) * -1,
                    Image = Properties.Resources.invader1,
                    SizeMode = PictureBoxSizeMode.StretchImage
                };
            }
            return null;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvasion.Scripts
{
    public static class Enemy
    {
        static Random rnd = new Random();
        static int speed = 3;
        static int counter = 100;
        static PictureBox enemyPictureBox; 
        static List<PictureBox> enemyList = new List<PictureBox> ();
        public static void Spawn()
        {
            counter--;
            if(counter == 0)
            {
                enemyList.Add(new PictureBox()
                {
                    Tag = "enemy",
                    Width = 125,
                    Height = 113,
                    Left = rnd.Next(8, 740),
                    Top = rnd.Next(0, 500) * -1
                });
                foreach(PictureBox enemy in enemyList)
                {
                    enemy.Image = Properties.Resources.invader1;
                    enemy.Refresh();
                    //enemy.Load();
                }
                //enemyPictureBox = new PictureBox()
                //{
                //    Tag = "enemy",
                //    Width = 125,
                //    Height = 113,
                //    Image = Properties.Resources.invader1
                //};
                //enemyPictureBox.Left = rnd.Next(8, 740);
                //enemyPictureBox.Top = rnd.Next(0, 500) * -1;
                //enemyPictureBox.Refresh();
                //enemyPictureBox.Load();
            }   
        }

        public static void Move()
        {
            foreach (PictureBox x in enemyList)
            {
                if (x is PictureBox && x.Tag != null && x.Tag.ToString() == "enemy")
                {
                    x.Top += speed;
                }
            }
        }
    }
}

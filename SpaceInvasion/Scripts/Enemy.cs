using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace SpaceInvasion.Scripts
{
    public static class Enemy
    {
        static Random rnd = new Random();
        public static int speed = 5;
        public static int frequency = 100;
        public static int limit = 100;
        public static bool increaseSpeedAndFrequency;
        public static List<PictureBox> Disposal = new List<PictureBox>();
        public static PictureBox newEnemy = new PictureBox();
        
        public static PictureBox? Spawn()
        {
            //if (GameForm.score > 0 && GameForm.score % 10 == 0)
            //{
            //    Enemy.increaseSpeedAndFrequency = true;
            //}

            if (GameForm.score > 0 && GameForm.score % 100 == 0 && !Enemy.increaseSpeedAndFrequency)
            {
                Enemy.limit -= 5;
                Enemy.speed++;
                Enemy.increaseSpeedAndFrequency = true;
            }

            if(GameForm.score % 100 != 0)
            {
                Enemy.increaseSpeedAndFrequency = false;
            }

            frequency--;
            if (frequency == 0)
            {
                frequency = limit;
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

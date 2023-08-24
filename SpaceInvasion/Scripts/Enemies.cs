using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvasion.Scripts
{
    public class Enemies
    {
        static Random rnd = new Random();
        public int speed { get; set; } //5
        public int posX { get; set; }
        public int posY { get; set; }
        //public int frequency { get; set; } //100
        //public int limit { get; set; } //100
        public bool increaseSpeedAndFrequency { get; set; }
        //public static List<PictureBox> Disposal = new List<PictureBox>();
        public PictureBox enemyPictureBox { get; set; }
        private Image[] image { get; set; }
       

        public Enemies() 
        {
            enemyPictureBox = RenderEnemyPictureBox();
        }

        public PictureBox RenderEnemyPictureBox()
        {
            image = new Image[] { Properties.Resources.alien1, Properties.Resources.alien2, Properties.Resources.alien3, Properties.Resources.alien4 };
            return new PictureBox()
            {
                Tag = "enemy",
                Width = 75,
                Height = 65,
                //Left = rnd.Next(8, 740),
                Left = posX,
                //Top = rnd.Next(300, 500) * -1,
                Top = posY,
                Image = image[rnd.Next(image.Length)],
                SizeMode = PictureBoxSizeMode.StretchImage
            };

        }

        public void Move()
        {
            posY += speed;
            enemyPictureBox.Top = posY;
        }


        public void enemyInteractions(PictureBox objectToInterractWith)
        {

        }
        //public PictureBox? Spawn()
        //{
        //    if (GameForm.score > 0 && GameForm.score % 100 == 0 && increaseSpeedAndFrequency)
        //    {
        //        limit -= 5;
        //        speed++;
        //        increaseSpeedAndFrequency = true;
        //    }

        //    if (GameForm.score % 100 != 0)
        //    {
        //        increaseSpeedAndFrequency = false;
        //    }

        //    frequency--;
        //    if (frequency == 0)
        //    {
        //        frequency = limit;
        //        return new PictureBox()
        //        {
        //            Tag = "enemy",
        //            Width = 75,
        //            Height = 65,
        //            Left = rnd.Next(8, 740),
        //            Top = rnd.Next(300, 500) * -1,
        //            //Image = Properties.Resources.alien1,
        //            Image = image[rnd.Next(image.Length)],
        //            SizeMode = PictureBoxSizeMode.StretchImage
        //        };
        //    }
        //    return null;
        //}

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvasion.Scripts
{
    public class GameBackground
    {
        public List<Star> stars = new List<Star>();
        private Random random;
        private Image[] starImages;
        private int starCount;
        private int maxWidth;
        private int maxHeight;

        public GameBackground(int starCount, int maxWidth, int maxHeight)
        {
            this.starCount = starCount;
            this.maxWidth = maxWidth;
            this.maxHeight = maxHeight;

            stars = GenerateStars();
        }

        private List<Star> GenerateStars()
        {
            List<Star> newStars = new List<Star>();
            random = new Random();

            starImages = new Image[]
            {
                Properties.Resources.star1
                // Add more images here
            };

            HashSet<Point> usedPositions = new HashSet<Point>();
            int spacing = 50;

            for (int i = 0; i < starCount; i++)
            {
                int x, y;
                do
                {
                    x = random.Next(0, maxWidth);
                    y = random.Next(0, maxHeight);
                } while (IsTooClose(x, y, usedPositions, spacing));

                usedPositions.Add(new Point(x, y));

                //int speed = random.Next(1, 5);
                int speed = 5;
                Image image = starImages[random.Next(0, starImages.Length)];
                newStars.Add(new Star(x, y, speed, image));
            }

            return newStars;
        }

        private bool IsTooClose(int x, int y, HashSet<Point> usedPositions, int minDistance)
        {
            foreach (var position in usedPositions)
            {
                if (Math.Abs(x - position.X) < minDistance && Math.Abs(y - position.Y) < minDistance)
                    return true;
            }
            return false;
        }

        public void Update()
        {
            foreach (Star star in stars)
            {
                star.Move();

                if (star.Y > maxHeight)
                {
                    star.Y = 0;
                    star.X = random.Next(0, maxWidth);
                }
            }
        }
    }
}

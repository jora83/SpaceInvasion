using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvasion.Scripts
{
    public class GameBackground
    {
        public List<Star> Stars { get; private set; } = new List<Star>();
        private Random rnd;
        private Image[] starImages;
        private int starCount;
        private int maxWidth;
        private int maxHeight;

        public GameBackground(int starCount, int maxWidth, int maxHeight)
        {
            this.starCount = starCount;
            this.maxWidth = maxWidth;
            this.maxHeight = maxHeight;

            Stars = GenerateStars();
        }

        private List<Star> GenerateStars()
        {
            List<Star> newStars = new List<Star>();
            rnd = new Random();

            starImages = new Image[]
            {
                Properties.Resources.star1,
                Properties.Resources.star2,
                Properties.Resources.star3
            };

            HashSet<Point> usedPositions = new HashSet<Point>();
            int spacing = Constants.StarSpacing;

            for (int i = 0; i < starCount; i++)
            {
                int x, y;
                do
                {
                    x = rnd.Next(0, maxWidth);
                    y = rnd.Next(0, maxHeight);
                } while (IsTooClose(x, y, usedPositions, spacing));

                usedPositions.Add(new Point(x, y));

                int speed = Constants.StarSpeed;
                Image image = starImages[rnd.Next(0, starImages.Length)];
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
            foreach (Star star in Stars)
            {
                star.Move();

                if (star.PosY > maxHeight)
                {
                    star.PosY = 0;
                    star.PosX = rnd.Next(0, maxWidth);
                }
            }
        }
    }
}

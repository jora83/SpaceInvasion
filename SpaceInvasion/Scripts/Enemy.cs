namespace SpaceInvasion.Scripts
{
    public class Enemy
    {
        private Random rnd = new Random();
        private int speed;
        public int PosX { get; set; }
        public int PosY { get; set; }
        public bool Dispose { get; set; }
        public PictureBox PictureBox { get; private set; }
        private static Image[] enemyImages = new Image[] { Properties.Resources.alien1, Properties.Resources.alien2,
                                                    Properties.Resources.alien3, Properties.Resources.alien4 };

        public Enemy(int speed, int posX, int posY) 
        {
            this.speed = speed;
            PosX = posX;
            PosY = posY;

            Image enemyImage = enemyImages[rnd.Next(enemyImages.Length)];

            PictureBox = new PictureBox()
            {
                Location = new Point(posX, posY),
                Size = new Size(Constants.EnemyWidth, Constants.EnemyHeight),
                Image = enemyImage
            };
        }

        public void MoveDown()
        {
            PosY += speed;
            PictureBox.Top = PosY;
        }
        public bool HasCollided(PictureBox pictureBox)
        {
            if (pictureBox.Bounds.IntersectsWith(PictureBox.Bounds))
            {
                return true;
            }
            return false;
        }

    }
}

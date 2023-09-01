namespace SpaceInvasion.Scripts
{
    public class Player
    {
        private int speed;
        private int posX;
        private int posY;
        private readonly int initialPosX;
        private readonly int initialPosY;
        public int Health { get; private set; }
        public int Score { get; private set; }
        public bool Shooting { get; set; }
        public bool MoveLeft { get; set; }
        public bool MoveRight { get; set; }
        public PictureBox PictureBox { get; }
        public List<Bullet> ActiveBullets { get; private set; }
        
        public Player(int health, int speed, int formWidth, int formHeight)
        {
            Health = health;
            this.speed = speed;
            Score = Constants.InitialPlayerScore;
            posX = (formWidth - Constants.PlayerWidth) / 2;
            posY = formHeight - Constants.PlayerHeight * 2;
            initialPosX = posX;
            initialPosY = posY;

            ActiveBullets = new List<Bullet>();

            Image playerImage = Properties.Resources.player;

            PictureBox = new PictureBox()
            {
                Location = new Point(posX, posY),
                Size = new Size(Constants.PlayerWidth, Constants.PlayerHeight),
                Image = playerImage                
            };
        }

        public void Reset()
        {
            Health = Constants.InitialPlayerHealth;
            Score = Constants.InitialPlayerScore;
            posX = initialPosX;
            posY = initialPosY;
            PictureBox.Left = posX;
            PictureBox.Top = posY;
            ActiveBullets.Clear();
        }

        public void IncreaseScore()
        {
            Score += Constants.ScoreIncreasePerEnemy;
        }

        public void DecreaseHealth()
        {
            Health -= Constants.DamagePerEnemyCollision;
        }

        public void Move(int maxWidth)
        {
            if (MoveLeft && posX > 0)
            {
                posX -= speed;
                PictureBox.Left = posX;
            }

            if (MoveRight &&  posX < maxWidth - Constants.PlayerWidth)
            {
                posX += speed;
                PictureBox.Left = posX;
            }
        }

        public void IntitializeShooting()
        {
            Shooting = true;
            ActiveBullets.Add(new Bullet(PictureBox.Left + PictureBox.Width / 2, PictureBox.Top));
        }

        public void Shoot()
        {
            if (Shooting)
            {
                foreach (var bullet in ActiveBullets)
                {
                    bullet.Move();
                }
            }

            RemoveInactiveBullets();
        }

        public void RemoveInactiveBullets()
        {
            ActiveBullets.RemoveAll(bullet => !bullet.IsActive);
        }
    }
}

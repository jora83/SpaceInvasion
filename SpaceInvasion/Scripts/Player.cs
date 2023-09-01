namespace SpaceInvasion.Scripts
{
    public class Player
    {
        private int speed;
        private int posX;
        private int posY;
        public int Health { get; private set; }
        public int Score { get; private set; }
        public bool Shooting { get; set; }
        public bool MoveLeft { get; set; }
        public bool MoveRight { get; set; }
        public PictureBox PictureBox { get; }
        public List<Bullet> activeBullets { get; private set; }
        
        private readonly int initialPosX;
        private readonly int initialPosY;


        public Player(int health, int speed, int formWidth, int formHeight)
        {
            Health = health;
            this.speed = speed;
            Score = Constants.InitialPlayerScore;
            posX = (formWidth - Constants.PlayerWidth) / 2;
            posY = formHeight - Constants.PlayerHeight * 2;
            initialPosX = posX;
            initialPosY = posY;

            activeBullets = new List<Bullet>();

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
            activeBullets.Clear();
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
            if (MoveLeft == true && posX > 0)
            {
                posX -= speed;
                PictureBox.Left = posX;
            }

            if (MoveRight == true &&  posX < maxWidth - Constants.PlayerWidth)
            {
                posX += speed;
                PictureBox.Left = posX;
            }
        }

        public void IntitializeShooting()
        {
            Shooting = true;
            activeBullets.Add(new Bullet(PictureBox.Left + PictureBox.Width / 2, PictureBox.Top));

        }

        public void Shoot()
        {

            if (Shooting)
            {
                foreach (var bullet in activeBullets)
                {
                    bullet.Move();
                }
            }

            RemoveInactiveBullets();
        }

        public void RemoveInactiveBullets()
        {
            activeBullets.RemoveAll(bullet => !bullet.IsActive);
        }
    }
}

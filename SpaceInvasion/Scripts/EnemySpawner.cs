namespace SpaceInvasion.Scripts
{
    public class EnemySpawner
    {
        private int frequency;
        private int newFrequency;
        private int enemySpeed;
        private int formWidth;
        private bool increaseSpeedAndFrequency;
        private Random rnd = new Random();
        public List<Enemy> EnemyList { get; private set; }

        public EnemySpawner(int frequency, int enemySpeed, int formWidth)
        {
            this.frequency = frequency;
            newFrequency = frequency;
            this.enemySpeed = enemySpeed;
            this.formWidth = formWidth;
            EnemyList = new List<Enemy>();
            EnemyList.Clear();
        }

        public void Reset()
        {
            frequency = Constants.InitialEnemySpawnFrequency;
            newFrequency = Constants.InitialEnemySpawnFrequency;
            EnemyList.Clear();
        }

        public void SpawnEnemies(int score)
        {
            int enemyPosX = rnd.Next(0, formWidth - Constants.EnemyWidth);
            int enemyPosY = rnd.Next(Constants.EnemyPosY1, Constants.EnemyPosY2);

            frequency--;

            if (frequency == 0)
            {
                frequency = newFrequency;
                EnemyList.Add(new Enemy(enemySpeed, enemyPosX, enemyPosY));
            }

            if (score > 0 && score % 100 == 0 && score <= 500 && increaseSpeedAndFrequency)
            {
                enemySpeed++; 
                newFrequency -= 5;
                increaseSpeedAndFrequency = false;
            }
            else if (score % 100 != 0)
            {
                increaseSpeedAndFrequency = true;
            }

        }

        public void RemoveEnemies()
        {
            EnemyList.RemoveAll(enemy => enemy.Dispose);
        }
    }
}

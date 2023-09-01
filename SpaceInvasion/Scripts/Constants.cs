namespace SpaceInvasion.Scripts
{
    public static class Constants
    {
        public const int InitialPlayerHealth = 100;
        public const int InitialPlayerScore = 0;
        public const int PlayerSpeed = 8;
        public const int PlayerWidth = 82;
        public const int PlayerHeight = 64;
        
        public const int InitialEnemySpeed = 5;
        public const int InitialEnemySpawnFrequency = 100;
        public const int EnemyWidth = 82;
        public const int EnemyHeight = 64;
        public const int EnemyPosY1 = 300;
        public const int EnemyPosY2 = 500;

        public const int BulletSpeed = 20;
        public const int BulletWidth = 5;
        public const int BulletHeight = 15;

        public const int StarCount = 30;
        public const int StarWidth = 20;
        public const int StarHeight = 20;
        public const int StarSpacing = 50;
        public const int StarSpeed = 5;

        public const int ScoreIncreasePerEnemy = 10;
        public const int DamagePerEnemyCollision = 10;

        public const string HighscoresFileName = "HighScores.json";
        public const string ObjectiveFileName = "Objective.txt";
        public const string ControlsFileName = "Controls.txt";
    }

}

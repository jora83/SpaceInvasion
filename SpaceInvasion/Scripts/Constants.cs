using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvasion.Scripts
{
    public static class Constants
    {
        public const int PictureboxMargin = 16;
        public const int InitialPlayerHealth = 100;
        public const int PlayerSpeed = 8;
        public const int PlayerWidth = 64;
        public const int PlayerHeight = 64;

        public const int InitialEnemySpeed = 5;
        public const int EnemySpawnFrequency = 50;
        public const int EnemySpawnSpeed = 5;
        public const int EnemyWidth = 64;
        public const int EnemyHeight = 64;

        public const int BulletSpeed = 20;
        public const int BulletWidth = 5;
        public const int BulletHeight = 15;

        public const int StarCount = 30;
        public const int BackgroundMaxWidth = 900;
        public const int BackgroundMaxHeight = 600;

        public const int ScoreIncreasePerEnemy = 10;
        public const int DamagePerEnemyCollision = 10;

        public const string HighscoresFileName = "Highscores.json";
    }

}

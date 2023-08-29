using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvasion.Scripts
{
    public class EnemySpawner
    {
        private static Random rnd = new Random();
        public int Frequency { get; set; }
        public int NewFrequency { get; set; }
        public int EnemySpawnSpeed { get; set; }
        private int FormWidth { get; set; }
        private bool IncreaseSpeedAndFrequency { get; set; }
        private bool shouldSpawnEnemy { get; set; }
        public List<Enemy> EnemyList { get; set; }

        public EnemySpawner(int frequency, int speed, int formWidth)
        {
            //InitialFrequency = initialFrequency;
            Frequency = frequency;
            NewFrequency = frequency;
            EnemySpawnSpeed = speed;
            FormWidth = formWidth;
            EnemyList = new List<Enemy>();
            EnemyList.Clear();
            // EnemyRemover = new List<Enemies>();
            // EnemyRemover.Clear();
        }

        public void SpawnEnemies(int score)
        {
            int enemyPosX = rnd.Next(0, FormWidth - Constants.EnemyWidth - Constants.PictureboxMargin);
            int enemyPosY = rnd.Next(300, 500) * -1;

            Frequency--;

            if (Frequency == 0)
            {
                //Frequency = NewFrequency;
                Frequency = NewFrequency;
                EnemyList.Add(new Enemy(EnemySpawnSpeed, enemyPosX, enemyPosY));
                shouldSpawnEnemy = false;
            }

            if (score > 0 && score % 100 == 0 && !IncreaseSpeedAndFrequency)
            {
                EnemySpawnSpeed++; 
                NewFrequency -= 5;
                IncreaseSpeedAndFrequency = true;
            }

            if (score % 100 != 0)
            {
                IncreaseSpeedAndFrequency = false;
            }

        }

        
    }
}

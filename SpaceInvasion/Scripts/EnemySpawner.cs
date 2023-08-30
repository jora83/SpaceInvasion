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
        private Random rnd = new Random();
        private int formWidth;
        private bool increaseSpeedAndFrequency;
        private int frequency;
        private int newFrequency;
        private int enemySpeed;
        public List<Enemy> EnemyList { get; } = new List<Enemy>();

        public EnemySpawner(int frequency, int enemySpeed, int formWidth)
        {
            this.frequency = frequency;
            this.newFrequency = frequency;
            this.enemySpeed = enemySpeed;
            this.formWidth = formWidth;
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
            int enemyPosY = rnd.Next(Constants.EnemyPosY1, Constants.EnemyPosY2) * -1;

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

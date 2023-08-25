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

        private int newFrequency { get; set; }
        //public int NewFrequency { get; set; }

        private bool shouldSpawnEnemy;

        public List<Enemies> EnemyList { get; set; }
        //public static List<Enemies> EnemyRemover { get; set; }

        public EnemySpawner(int frequency)
        {
            Frequency = frequency;
            newFrequency = frequency;
            EnemyList = new List<Enemies>();
            EnemyList.Clear();
           // EnemyRemover = new List<Enemies>();
           // EnemyRemover.Clear();
        }

        public void SpawnEnemy(int score, int formWidth, int formHeight)
        {
            int enemySpeed = 5 + (score / 100);
            int enemyPosX = rnd.Next(8, 740);
            int enemyPosY = rnd.Next(300, 500) * - 1;
            newFrequency = newFrequency - (score / 20);
            Frequency--;
            if (Frequency == 0)
            {
                Frequency = newFrequency;

                shouldSpawnEnemy = true;
            }
            
            if (shouldSpawnEnemy)
            {
                //Enemies newEnemy = new Enemies(enemySpeed,)
                //Enemies.enemyList.Add(new Enemies(enemySpeed, enemyPosX, enemyPosY));
                EnemyList.Add(new Enemies(enemySpeed, enemyPosX, enemyPosY));
                shouldSpawnEnemy = false;
            }

        }
    }
}

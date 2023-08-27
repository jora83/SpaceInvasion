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
        public List<Enemies> EnemyList { get; set; }

        public EnemySpawner(int frequency, int speed, int formWidth)
        {
            //InitialFrequency = initialFrequency;
            Frequency = frequency;
            NewFrequency = frequency;
            EnemySpawnSpeed = speed;
            FormWidth = formWidth;
            EnemyList = new List<Enemies>();
            EnemyList.Clear();
            // EnemyRemover = new List<Enemies>();
            // EnemyRemover.Clear();
        }

        public void SpawnEnemies(int score)
        {
            int enemyPosX = rnd.Next(0, FormWidth /*- 80*/);
            int enemyPosY = rnd.Next(300, 500) * -1;

            Frequency--;

            if (Frequency == 0)
            {
                //Frequency = NewFrequency;
                Frequency = NewFrequency;
                EnemyList.Add(new Enemies(EnemySpawnSpeed, enemyPosX, enemyPosY));
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

        //public void GetNewFrequency(int score)
        //{
        //    NewFrequency -= score / 20;
        //}

        //public int GetEnemySpeed(int score)
        //{
        //    int enemySpeed = 5;

        //    return enemySpeed += score / 100;
        //}

        //public void SpawnEnemy(int score, int formWidth, int formHeight)
        //{
        //    //int enemySpeed = 5;
        //    //int newEnemySpeed = enemySpeed + (score / 100);

        //    int enemyPosX = rnd.Next(8, 740);
        //    int enemyPosY = rnd.Next(300, 500) * -1;
        //    if (score > 0 && score % 100 == 0 && !IncreaseSpeedAndFrequency)
        //    {
        //        //NewFrequency = NewFrequency - (score / 20);
        //        EnemySpawnSpeed++; //(score / 100);
        //        NewFrequency -= 5;
        //        IncreaseSpeedAndFrequency = true;
        //    }

        //    if (score % 100 != 0)
        //    {

        //        IncreaseSpeedAndFrequency = false;
        //    }

        //    Frequency--;
        //    if (Frequency == 0)
        //    {
        //        Frequency = NewFrequency;

        //        shouldSpawnEnemy = true;
        //    }

        //    if (shouldSpawnEnemy)
        //    {
        //        //Enemies newEnemy = new Enemies(enemySpeed,)
        //        //Enemies.enemyList.Add(new Enemies(enemySpeed, enemyPosX, enemyPosY));
        //        //EnemyList.Add(new Enemies(newEnemySpeed, enemyPosX, enemyPosY));
        //        shouldSpawnEnemy = false;
        //    }

        //}
    }
}

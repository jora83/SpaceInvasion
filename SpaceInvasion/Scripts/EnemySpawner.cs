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
        public int frequency { get; set; }
        public int newFrequency { get; set; }

        private bool shouldSpawnEnemy { get; set; }

        public List<Enemies> enemyList = new List<Enemies>();

        public void SpawnEnemy(int speed)
        {
            
            if(frequency == 0)
            {
                frequency = newFrequency;

                shouldSpawnEnemy = true;
            }

            if (shouldSpawnEnemy)
            {
                Enemies newEnemy = new Enemies
                {
                    speed = speed,
                    posX = rnd.Next(8, 740),
                    posY = rnd.Next(300, 500) * -1
                };
            }
                
        }
    }
}

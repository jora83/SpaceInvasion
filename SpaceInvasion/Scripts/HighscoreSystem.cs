using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace SpaceInvasion.Scripts
{
    public class HighscoreSystem
    {
        private Dictionary<string, int> highscores = new Dictionary<string, int>();
        private string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"Highscores.json" );
        public void AddUser(string user, int score)
        {
            if (highscores.ContainsKey(user) && score > highscores[user])
                highscores[user] = score;
            else
                highscores.Add(user, score);
        }

        public List<KeyValuePair<string, int>> GetHighscores()
        {
            var sortedHighscores = highscores.OrderByDescending(x => x.Value).ToList();
            return sortedHighscores;
        }

        public void SaveHiscores()
        {
            string json = JsonSerializer.Serialize(highscores,
                new JsonSerializerOptions
                {
                    WriteIndented = true
                });
            File.WriteAllText(filePath, json);
        }

        public void LoadHighscores()
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                highscores = JsonSerializer.Deserialize<Dictionary<string, int>>(json);
            }
        }
    }
}

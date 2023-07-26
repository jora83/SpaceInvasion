using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SpaceInvasion.Scripts
{
    public class HighscoreSystem
    {
        private Dictionary<string, int> highscores = new Dictionary<string, int>();
        //private string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"Highscores.json" );
        string filePath = @"C:\\Users\\joraa\\source\\repos\\SpaceInvasion\\SpaceInvasion\\Highscores.json";
        public void AddUser(string username, int score)
        {
            if (highscores.ContainsKey(username))
            {
                // If the user already exists, update the score if it's higher
                if (score > highscores[username])
                {
                    highscores[username] = score;
                }
            }
            else
            {
                // If the user doesn't exist, add them to the highscores
                highscores[username] = score;
            }
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

using System.Text.Json;

namespace SpaceInvasion.Scripts
{
    public class HighscoreSystem
    {

        private Dictionary<string, int> highscores = new Dictionary<string, int>();
        string filePath;

        public HighscoreSystem()
        {
            filePath = Path.Combine(Application.StartupPath, Constants.HighscoresFileName);
            LoadHighscores();
        }

        public void AddUser(string username, int score)
        {
            if (highscores.ContainsKey(username))
            {
                if (score > highscores[username])
                {
                    highscores[username] = score;
                }
            }
            else
            {
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

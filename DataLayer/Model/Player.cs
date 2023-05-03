using Newtonsoft.Json;

namespace DataLayer.Model
{
    
    public class Player
    {
        private const string IMG_PATH = "..//..//..//..//DataLayer//Resources//Maradona.jpeg";

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("captain")]
        public bool Captain { get; set; }

        [JsonProperty("shirt_number")]
        public long ShirtNumber { get; set; }

        [JsonProperty("position")]
        public string Position { get; set; }

        [JsonProperty("imagePath")]
        public string ImagePath { get; set; }

        [JsonProperty("imageTTPath")]
        public string ImageTTPath { get; set; }

        [JsonProperty("goalsCount")]
        public int GoalsCount { get; set; } = 0;

        [JsonProperty("yellowCartonCount")]
        public int YellowCartonCount { get; set; } = 0;

        public Player()
        {
            ImagePath = IMG_PATH;
            
        }

        public override bool Equals(object obj)
        {
            return obj is Player player &&
                   Name == player.Name &&
                   Captain == player.Captain &&
                   ShirtNumber == player.ShirtNumber &&
                   Position == player.Position &&
                   ImagePath == player.ImagePath &&
                   ImageTTPath == player.ImageTTPath &&
                   GoalsCount == player.GoalsCount &&
                   YellowCartonCount == player.YellowCartonCount;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Captain, ShirtNumber, Position, ImagePath, ImageTTPath, GoalsCount, YellowCartonCount);
        }
    }
}

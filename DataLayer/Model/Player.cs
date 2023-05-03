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

        public string ImagePath { get; set; }

        public int GoalsCount { get; set; } = 0;

        public int YellowCartonCount { get; set; } = 0;

        public Player()
        {
            ImagePath = IMG_PATH;
            
        }
    }
}

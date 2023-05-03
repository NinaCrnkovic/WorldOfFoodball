using Newtonsoft.Json;


namespace DataLayer.Model
{
    public class FavoriteCountryandPlayersSetup
    {
        [JsonProperty("FifaCodeFavCountry")]
        public string FifaCodeFavCountry { get; set; }

        [JsonProperty("FifaCodeOppositeCountry")]
        public string OppositeTeam { get; set; }

        [JsonProperty("FavoritePlayersList")]
        public List<Player> FavoritePlayersList { get; set; }

        [JsonProperty("NotFavoritePlayersList")]
        public List<Player> NotFavoritePlayersList { get; set; }

     

    }
}

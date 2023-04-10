using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Model
{
    public class FavoriteCountryandPlayersSetup
    {
        [JsonProperty("FavoritePlayersList")]
        public List<Player> FavoritePlayersList { get; set; }

        [JsonProperty("AllPlayersList")]
        public List<Player> AllPlayersList { get; set; }

        [JsonProperty("FifaCodeFavCountry")]
        public string FifaCodeFavCountry { get; set; }
    }
}

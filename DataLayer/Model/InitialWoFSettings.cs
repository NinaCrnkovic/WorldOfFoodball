using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Model
{
    public class InitialWoFSettings
    {
        [JsonProperty("Language")]
        public string Language { get; set; }

        [JsonProperty("Championship")]
        public string Championship { get; set; }

        [JsonProperty("ScreenSize")]

        public string ScreenSize { get; set; }


        [JsonProperty("FifaCodeFavCountry")]
        public string FifaCodeFavCountry { get; set; }


        [JsonProperty("FifaCodeOppositeCountry")]

        public string OppositeTeam { get; set; }

    }
}


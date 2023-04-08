using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;


namespace DataLayer.Model
{
    public class Team
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("alternate_name")]
        public object AlternateName { get; set; }

        [JsonProperty("fifa_code")]
        public string FifaCode { get; set; }

        [JsonProperty("group_id")]
        public long GroupId { get; set; }

        [JsonProperty("group_letter")]
        public string GroupLetter { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Team team &&
                   Id == team.Id &&
                   Country == team.Country &&
                   EqualityComparer<object>.Default.Equals(AlternateName, team.AlternateName) &&
                   FifaCode == team.FifaCode &&
                   GroupId == team.GroupId &&
                   GroupLetter == team.GroupLetter;
        }

        public Team()
        {

        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Country, AlternateName, FifaCode, GroupId, GroupLetter);
        }

        public override string ToString() => $"{Country} ({FifaCode})";
      


    }

    
}

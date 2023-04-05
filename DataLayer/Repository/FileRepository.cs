using DataLayer.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repository
{
    public class FileRepository : IRepository
    {
        private readonly string teamsFilePathMen = "..//JSONFiles/men/teams.json";
        private readonly string matchesFilePathMen = "..//JSONFiles/men/matches.json";
        private readonly string groupResultFilePathMen = "..//JSONFiles/men/group_result.json";
        private readonly string resultsFilePathMen = "..//JSONFiles/men/results.json";

        private readonly string teamsFilePathWomen = "..//JSONFiles/women/teams.json";
        private readonly string matchesFilePathWomen = "..//JSONFiles/women/matches.json";
        private readonly string groupResultFilePathWomen = "..//JSONFiles/women/group_result.json";
        private readonly string resultsFilePathWomen = "..//JSONFiles/women/results.json";


        public FileRepository()
        {
           
        }

        public Team GetTeam(int id, bool isWomen)
        {
            string filePath = isWomen ? teamsFilePathWomen : teamsFilePathMen;
            var teams = GetTeamsFromJsonFile(filePath);
            return teams.FirstOrDefault(t => t.Id == id);
        }

        public List<Team> GetTeams(bool isWomen)
        {
            string filePath = isWomen ? teamsFilePathWomen : teamsFilePathMen;
            return GetTeamsFromJsonFile(filePath);
        }

        private List<Team> GetTeamsFromJsonFile(string filePath)
        {
            var json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<List<Team>>(json);
        }
    }

}

using DataLayer.Model;
using Newtonsoft.Json;

namespace DataLayer.Repository
{
    public class FileRepository : IRepository
    {
        private const string JSON_FILES_PATH = "..//..//..//..//DataLayer//JSONFiles";
        private static readonly string TEAMS_FILE_PATH_MEN = Path.Combine(JSON_FILES_PATH, "men", "teams.json");
        private static readonly string MATCHES_FILE_PATH_MEN = Path.Combine(JSON_FILES_PATH, "men", "matches.json");
        private static readonly string GROUP_RESULT_FILE_PATH_MEN = Path.Combine(JSON_FILES_PATH, "men", "group_result.json");
        private static readonly string RESULTS_FILE_PATH_MEN = Path.Combine(JSON_FILES_PATH, "men", "results.json");

        private static readonly string TEAMS_FILE_PATH_WOMEN = Path.Combine(JSON_FILES_PATH, "women", "teams.json");
        private static readonly string MATCHES_FILE_PATH_WOMEN = Path.Combine(JSON_FILES_PATH, "women", "matches.json");
        private static readonly string GROUP_RESULT_FILE_PATH_WOMEN = Path.Combine(JSON_FILES_PATH, "women", "group_result.json");
        private static readonly string RESULTS_FILE_PATH_WOMEN = Path.Combine(JSON_FILES_PATH, "women", "results.json");




        public FileRepository()
        {
          

            if (File.Exists(TEAMS_FILE_PATH_MEN))
            {
                Console.WriteLine("radi");
            }
            else
            {
                Console.WriteLine("neradi");
            }
        }
       

        public async Task<List<Team>> GetTeams(bool isWomen)
        {
            string filePath = isWomen ? TEAMS_FILE_PATH_WOMEN : TEAMS_FILE_PATH_MEN;
            return GetTeamsFromJsonFile(filePath);
        }

        private List<Team> GetTeamsFromJsonFile(string filePath)
        {
            var json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<List<Team>>(json);
        }

        public async Task<Team> GetTeam(int id, bool isWomen)
        {
            var teams = await GetTeams(isWomen);
            return teams.FirstOrDefault(t => t.Id == id);
        }
    }

}

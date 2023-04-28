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

            CheckIfFileExists();
        }

        public void CheckIfFileExists()
        {
           
            if (!File.Exists(TEAMS_FILE_PATH_MEN))
            {
                File.Create(TEAMS_FILE_PATH_MEN).Close();
            }

            if (!File.Exists(MATCHES_FILE_PATH_MEN))
            {
                File.Create(MATCHES_FILE_PATH_MEN).Close();
            }

            if (!File.Exists(GROUP_RESULT_FILE_PATH_MEN))
            {
                File.Create(GROUP_RESULT_FILE_PATH_MEN).Close();
            }

            if (!File.Exists(RESULTS_FILE_PATH_MEN))
            {
                File.Create(RESULTS_FILE_PATH_MEN).Close();
            }

            if (!File.Exists(TEAMS_FILE_PATH_WOMEN))
            {
                File.Create(TEAMS_FILE_PATH_WOMEN).Close();
            }

            if (!File.Exists(MATCHES_FILE_PATH_WOMEN))
            {
                File.Create(MATCHES_FILE_PATH_WOMEN).Close();
            }

            if (!File.Exists(GROUP_RESULT_FILE_PATH_WOMEN))
            {
                File.Create(GROUP_RESULT_FILE_PATH_WOMEN).Close();
            }

            if (!File.Exists(RESULTS_FILE_PATH_WOMEN))
            {
                File.Create(RESULTS_FILE_PATH_WOMEN).Close();
            }

        }

        

        public Task<List<Team>> GetTeams(bool isWomen)
        {
            string filePath = isWomen ? TEAMS_FILE_PATH_WOMEN : TEAMS_FILE_PATH_MEN;
            var json = File.ReadAllText(filePath);
            var teams = JsonConvert.DeserializeObject<List<Team>>(json);
            return Task.FromResult(teams);
        }

        public Task<List<FootballMatch>> GetMatches(bool isWomen)
        {
            string filePath = isWomen ? MATCHES_FILE_PATH_WOMEN : MATCHES_FILE_PATH_MEN;
            var json = File.ReadAllText(filePath);
            var matches = JsonConvert.DeserializeObject<List<FootballMatch>>(json);
            return Task.FromResult(matches);
        }

        public Task<List<FootballMatch>> GetMatchesByFifaCode(bool isWomen, string fifaCode)
        {
            string filePath = isWomen ? MATCHES_FILE_PATH_WOMEN : MATCHES_FILE_PATH_MEN;
            var json = File.ReadAllText(filePath);
            var matches = JsonConvert.DeserializeObject<List<FootballMatch>>(json);
            var filteredMatches = matches.Where(m => m.HomeTeam.Code == fifaCode || m.AwayTeam.Code == fifaCode).ToList();
            return Task.FromResult(filteredMatches);
        }

        public Task<List<Result>> GetResults(bool isWomen)
        {
            string filePath = isWomen ? RESULTS_FILE_PATH_WOMEN : RESULTS_FILE_PATH_MEN;
            var json = File.ReadAllText(filePath);
            var results = JsonConvert.DeserializeObject<List<Result>>(json);
            return Task.FromResult(results);
        }
    }

}

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

            DownloadFilesIfNotExist().Wait();
        }

        public async Task DownloadFilesIfNotExist()
        {
            await Task.Run(() =>
            {
                if (!File.Exists(TEAMS_FILE_PATH_MEN))
                {
                    DownloadFile("https://worldcup.sfg.io/matches/country?fifa_code=ALL&year=2018", "JSONFiles/men/teams.json").Wait();
                }

                if (!File.Exists(MATCHES_FILE_PATH_MEN))
                {
                    DownloadFile("https://worldcup.sfg.io/matches?year=2018", "JSONFiles/men/matches.json").Wait();
                }

                if (!File.Exists(GROUP_RESULT_FILE_PATH_MEN))
                {
                    DownloadFile("https://worldcup.sfg.io/teams/group_results", "JSONFiles/men/group_result.json").Wait();
                }

                if (!File.Exists(RESULTS_FILE_PATH_MEN))
                {
                    DownloadFile("https://worldcup.sfg.io/matches/results", "JSONFiles/men/results.json").Wait();
                }

                if (!File.Exists(TEAMS_FILE_PATH_WOMEN))
                {
                    DownloadFile("https://worldcup.sfg.io/matches/country?fifa_code=ALL&year=2019&fifa_code=ALL", "JSONFiles/women/teams.json").Wait();
                }

                if (!File.Exists(MATCHES_FILE_PATH_WOMEN))
                {
                    DownloadFile("https://worldcup.sfg.io/matches?year=2019&fifa_code=ALL", "JSONFiles/women/matches.json").Wait();
                }

                if (!File.Exists(GROUP_RESULT_FILE_PATH_WOMEN))
                {
                    DownloadFile("https://worldcup.sfg.io/teams/group_results?year=2019&fifa_code=ALL", "JSONFiles/women/group_result.json").Wait();
                }

                if (!File.Exists(RESULTS_FILE_PATH_WOMEN))
                {
                    DownloadFile("https://worldcup.sfg.io/matches/results?year=2019&fifa_code=ALL", "JSONFiles/women/results.json").Wait();
                }
            });
        }

        private async Task DownloadFile(string url, string filePath)
        {
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(url))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        using (var fileStream = new FileStream(filePath, FileMode.Create))
                        {
                            await response.Content.CopyToAsync(fileStream);
                        }
                    }
                    else
                    {
                        throw new Exception($"Failed to download file from {url}. Response status code: {response.StatusCode}.");
                    }
                }

            }   
        }

        public Task<List<Team>> GetTeams(bool isWomen)
        {
            string filePath = isWomen ? TEAMS_FILE_PATH_WOMEN : TEAMS_FILE_PATH_MEN;
            var json = File.ReadAllText(filePath);
            var teams = JsonConvert.DeserializeObject<List<Team>>(json);
            return Task.FromResult(teams);
        }

     

      
    }

}

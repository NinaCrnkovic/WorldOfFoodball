using DataLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RestSharp;
using Newtonsoft.Json;

namespace DataLayer.Repository
{

    public class ApiRepository : IRepository
    {
        private string baseUrl = "https://worldcup-vua.nullbit.hr";
        private string menTeamsEndpoint = "/men/teams";
        private string womenTeamsEndpoint = "/women/teams";
        private string menTeamsResultEndpoint = "/men/teams/results";
        private string womenTeamsResultEndpoint = "/women/teams/results";
        private string menMatchesEndpoint = "/men/matches";
        private string womenMatchesEndpoint = "/women/matches";
      
        public Task<List<FootballMatch>> GetMatches(bool isWomen)
        {
            return Task.Run(async () =>
            {
                var endpoint = isWomen ? womenMatchesEndpoint : menMatchesEndpoint;
                var fullEndpoint = $"{baseUrl}{endpoint}";
                var apiClient = new RestClient(fullEndpoint);
                var apiResult = await apiClient.ExecuteAsync<List<FootballMatch>>(new RestRequest());
                return JsonConvert.DeserializeObject<List<FootballMatch>>(apiResult.Content);
            });
        }

        public Task<List<FootballMatch>> GetMatchesByFifaCode(bool isWomen, string fifaCode)
        {
            return Task.Run(async () =>
            {
                var endpoint = isWomen ? womenMatchesEndpoint : menMatchesEndpoint;
                var fullEndpoint = $"{baseUrl}{endpoint}/{fifaCode}";
                var apiClient = new RestClient(fullEndpoint);
                var apiResult = await apiClient.ExecuteAsync<List<FootballMatch>>(new RestRequest());
                return JsonConvert.DeserializeObject<List<FootballMatch>>(apiResult.Content);
            });
        }

        public Task<List<Result>> GetResults(bool isWomen)
        {
            return Task.Run(async () =>
            {
                var endpoint = isWomen ? womenTeamsResultEndpoint : menTeamsResultEndpoint;
                var fullEndpoint = $"{baseUrl}{endpoint}";
                var apiClient = new RestClient(fullEndpoint);
                var apiResult = await apiClient.ExecuteAsync<List<Result>>(new RestRequest());
                return JsonConvert.DeserializeObject<List<Result>>(apiResult.Content);
            });
        }

        public Task<List<Team>> GetTeams(bool isWomen)
        {
            return Task.Run(async () =>
            {
                var endpoint = isWomen ? womenTeamsEndpoint : menTeamsEndpoint;
                var fullEndpoint = $"{baseUrl}{endpoint}";
                var apiClient = new RestClient(fullEndpoint);
                var apiResult = await apiClient.ExecuteAsync<List<Team>>(new RestRequest());
                return JsonConvert.DeserializeObject<List<Team>>(apiResult.Content);
            });
        }




    }


    
}


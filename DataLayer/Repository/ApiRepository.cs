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
        private string menMatchesCountryEndpoint = "/men/matches/country";
        private string womenMatchesCountryEndpoint = "/women/matches/country";

        public Task<List<Match>> GetMaches(bool isWomen)
        {
            return Task.Run(async () =>
            {
                var endpoint = isWomen ? womenMatchesEndpoint : menMatchesEndpoint;
                var fullEndpoint = $"{baseUrl}{endpoint}";
                var apiClient = new RestClient(fullEndpoint);
                var apiResult = await apiClient.ExecuteAsync<List<Match>>(new RestRequest());
                return JsonConvert.DeserializeObject<List<Match>>(apiResult.Content);
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


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
        //private string menTeamsResultEndpoint = "/men/teams/results";
        //private string womenTeamsResultEndpoint = "/women/teams/results";
        //private string menMatchesEndpoint = "/men/matches";
        //private string womenMatchesEndpoint = "/women/matches";
        //private string menMatchesCountryEndpoint = "/men/matches/country";
        //private string womenMatchesCountryEndpoint = "/women/matches/country";
       

        public async Task<Team> GetTeam(int id, bool isWomen)
        {
            var teams = await GetTeams(isWomen);
            return teams.FirstOrDefault(t => t.Id == id);
        }

        public async Task<List<Team>> GetTeams(bool isWomen)
        {
            var endpoint = isWomen ? womenTeamsEndpoint : menTeamsEndpoint;
            var fullEndpoint = $"{baseUrl}{endpoint}";
            var apiResponse = await GetTeamsFromApi(fullEndpoint);
            return apiResponse.Teams;
        }

        public async Task<TeamsApiResponse> GetTeamsFromApi(string endpoint)
        {
            var apiClient = new RestClient(endpoint);
            var apiResult = await apiClient.ExecuteAsync<TeamsApiResponse>(new RestRequest());
            return JsonConvert.DeserializeObject<TeamsApiResponse>(apiResult.Content);
        }

        public class TeamsApiResponse
        {
            public List<Team> Teams { get; set; }
        }
    }
}


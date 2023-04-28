using DataLayer.Model;


namespace DataLayer.Repository
{
    public interface IRepository
    {
       
        Task<List<Team>> GetTeams(bool isWomen);
        Task<List<FootballMatch>> GetMatches(bool isWomen);
        Task<List<FootballMatch>> GetMatchesByFifaCode(bool isWomen, string fifaCode);

    }
}

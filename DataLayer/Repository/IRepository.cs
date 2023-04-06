using DataLayer.Model;


namespace DataLayer.Repository
{
    public interface IRepository
    {
        Task<Team> GetTeam(int id, bool isWomen);
        Task<List<Team>> GetTeams(bool isWomen);
    }
}

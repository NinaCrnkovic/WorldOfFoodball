using DataLayer.Model;


namespace DataLayer.Repository
{
    public interface IRepository
    {
       
        Task<List<Team>> GetTeams(bool isWomen);
    }
}

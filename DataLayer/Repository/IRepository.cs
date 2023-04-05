using DataLayer.Model;


namespace DataLayer.Repository
{
    public interface IRepository
    {
        Team GetTeam(int id, bool isWomen);
        List<Team> GetTeams(bool isWomen);
    }
}

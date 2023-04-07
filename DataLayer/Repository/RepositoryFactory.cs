

namespace DataLayer.Repository
{
    public static class RepoFactory
    {
        public static IRepository GetRepo() => new ApiRepository();
    }
}

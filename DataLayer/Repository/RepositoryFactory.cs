

using DataLayer.Model;

namespace DataLayer.Repository
{
    public static class RepoFactory
    {
        public static IRepository GetRepo(Configuration config)
        {
            if (config.UseApiRepository)
            {
                return new ApiRepository();
            }
            else if (config.UseFileRepository)
            {
                return new FileRepository();
            }
            else
            {
                // Obrada grešaka ako ništa nije konfigurirano.
                throw new Exception("No repository specified in configuration.");
            }
        }
        public static IConfigRepository GetConfigRepo() => new ConfigurationRepository();

    }
}

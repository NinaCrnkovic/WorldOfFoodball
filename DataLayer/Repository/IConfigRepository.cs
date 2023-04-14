using DataLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repository
{
    public interface IConfigRepository
    {
        Task<Configuration> GetConfigurationFile();
        void SaveInitialSettings(InitialWoFSettings settings);
        Task<InitialWoFSettings> GetInitialSettings();
        void SaveFavoritePlayersSettings(List<Player> favoritePlayers, List<Player> allPlayers, string fifaCode);

        Task<FavoriteCountryandPlayersSetup> GetFavoritePlayersSettings();



    }
}

using DataLayer.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repository
{
    public class ConfigurationRepository : IConfigRepository
    {
        //config file mora postojati inače aplikacija ne radi
        private const string CONFIG_FILE = "..//..//..//..//DataLayer//ConfigurationFiles//repository_config.json";
        private const string INITIAL_SETTINGS_FILE = "..//..//..//..//DataLayer//ConfigurationFiles//initial_wof_settings.json";
        private const string FAVORITES_SETTINGS_FILE = "..//..//..//..//DataLayer//ConfigurationFiles//favorites_wof_settings.json";

        



        public ConfigurationRepository()
        {
            CreateFileIfNotExist();
        }

        private void CreateFileIfNotExist()
        {
            if (!File.Exists(INITIAL_SETTINGS_FILE))
            {
                File.Create(INITIAL_SETTINGS_FILE).Close();
            }
            if (!File.Exists(FAVORITES_SETTINGS_FILE))
            {
                File.Create(FAVORITES_SETTINGS_FILE).Close();
            }

        }
        public Task<Configuration> GetConfigurationFile()
        {
            string configJson = File.ReadAllText(CONFIG_FILE);
            Configuration config = JsonConvert.DeserializeObject<Configuration>(configJson);
            return Task.FromResult(config);
        }

     
        public void SaveInitialSettings(InitialWoFSettings settings)
        {
            // Serijaliziraj RepositoryConfig objekt u JSON format
            var configJson = JsonConvert.SerializeObject(settings);
            // Spremi JSON u datoteku na disku
            File.WriteAllText(INITIAL_SETTINGS_FILE, configJson);
        }

        public Task<InitialWoFSettings> GetInitialSettings()
        {
            string configJson = File.ReadAllText(INITIAL_SETTINGS_FILE);
            InitialWoFSettings config = JsonConvert.DeserializeObject<InitialWoFSettings>(configJson);
            return Task.FromResult(config);
        }

        public void SaveFavoritePlayersSettings(List<Player> favoritePlayers, List<Player> allPlayers, string fifaCode)
        {
           
            var args = new FavoriteCountryandPlayersSetup
            {
                FavoritePlayersList = favoritePlayers,
                AllPlayersList = allPlayers,
                FifaCodeFavCountry = fifaCode
            };

         
            var json = JsonConvert.SerializeObject(args);

            // Spremi JSON u datoteku na disku
            File.WriteAllText(FAVORITES_SETTINGS_FILE, json);
        }

        public Task<FavoriteCountryandPlayersSetup> GetFavoritePlayersSettings()
        {
            var json = File.ReadAllText(FAVORITES_SETTINGS_FILE);

            // Deserijaliziraj JSON sadržaj u FavoritePlayersTeamEventArgs objekt
            var args = JsonConvert.DeserializeObject<FavoriteCountryandPlayersSetup>(json);

            return Task.FromResult(args); ;
        }

       

        
    }
}

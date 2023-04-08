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
            
        }
        public Configuration GetConfigurationFile()
        {
            string configJson = File.ReadAllText(CONFIG_FILE);
            Configuration config = JsonConvert.DeserializeObject<Configuration>(configJson);
            return config;
        }

        public void GetInitialSettings()
        {
            
        }

        public void SaveInitialSettings(InitialWoFSettings settings)
        {
            // Serijaliziraj RepositoryConfig objekt u JSON format
            var configJson = JsonConvert.SerializeObject(settings);
            // Spremi JSON u datoteku na disku
            File.WriteAllText(INITIAL_SETTINGS_FILE, configJson);
        }
    }
}

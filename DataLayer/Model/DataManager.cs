using DataLayer.Repository;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Model
{
    public class DataManager
    {
        private string configJson;
        private RepositoryConfig config;
        private IRepository repo;
        private List<Team> teams;
        private const string CONFIG_FILE = "..//..//..//..//DataLayer//ConfigurationFiles//repository_config.json";

        public DataManager()
        {
            try
            {
                GetConfigurationFile();
            }
            catch (Exception)
            {

                throw new Exception("Error reading configuration file");
            }
           
            teams = new List<Team>();
        }

        private void GetConfigurationFile()
        {
            configJson = File.ReadAllText(CONFIG_FILE);
            config = JsonConvert.DeserializeObject<RepositoryConfig>(configJson);
            repo = RepoFactory.GetRepo(config);
        }

        public List<Team> GetTeamsList() => teams;


        public async Task LoadTeams(bool isWomen)
        {
           
            try
            {
                teams = await repo.GetTeams(isWomen);
            
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }


        

       


    }





}


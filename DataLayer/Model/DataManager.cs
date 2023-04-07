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
     
        private Configuration config;
        private IRepository repo;
        private IConfigRepository configRepo = RepoFactory.GetConfigRepo();
        private List<Team> teams;
 

        public DataManager()
        {
            try
            {
                SetConfigForRepo();
            }
            catch (Exception)
            {

                throw new Exception("Error reading configuration file");
            }
           
            teams = new List<Team>();
        }

        private void SetConfigForRepo()
        {
           config = configRepo.GetConfigurationFile();
           repo = RepoFactory.GetRepo(config);
        }

        public void SaveInitialSettingsToRepo(InitialWoFSettings settings)
        {
            configRepo.SaveInitialSettings(settings);
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


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
     
        private Configuration _config;
        private IRepository _repo;
        private IConfigRepository _configRepo = RepoFactory.GetConfigRepo();
        private List<Team> _teams;
 

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
           
            _teams = new List<Team>();
        }

        private void SetConfigForRepo()
        {
           _config = _configRepo.GetConfigurationFile();
           _repo = RepoFactory.GetRepo(_config);
        }

        public void SaveInitialSettingsToRepo(InitialWoFSettings settings)
        {
            _configRepo.SaveInitialSettings(settings);
        }

        public List<Team> GetTeamsList() => _teams;


        public async Task LoadTeams(bool isWomen)
        {
           
            try
            {
                _teams = await _repo.GetTeams(isWomen);
            
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }


        

       


    }





}


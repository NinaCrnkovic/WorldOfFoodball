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
        private InitialWoFSettings _initialWoFSettings;
        private FavoriteCountryandPlayersSetup _favoriteCountryandPlayersSettings;
        private IRepository _repo;
        private IConfigRepository _configRepo = RepoFactory.GetConfigRepo();
        private List<Team> _teams;
        private List<Player> _favoriteplayers;
        private List<Player> _notFavoriteplayers;
        private string _fifaCodeFavCountry;
        private string _language;
        private string _champinonship;
        private List<FootballMatch> _matches;
 

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

            //_teams = new List<Team>();
        }

        private async void SetConfigForRepo()
        {

           _config = await _configRepo.GetConfigurationFile();
           
           _repo = RepoFactory.GetRepo(_config);
        }

        

        public List<Team> GetTeamsList() => _teams;
        public List<FootballMatch> GetMatchesList() => _matches;


        public async void LoadSavedSettings()
        {
            
            LoadInitialSettingsFromRepo();
            LoadFavoritePlayersSettingsFromRepo();
    
        }
        public async void LoadTeams(bool isWomen)
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


        public async void LoadMaches(bool isWomen)
        {

            try
            {
                _matches = await _repo.GetMatches(isWomen);

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        #region Favorite player settings
        public void SaveFavoritePlayersToRepo(List<Player> favoritePlayers, List<Player> allPlayers, string fifaCode)
        {
            _configRepo.SaveFavoritePlayersSettings(favoritePlayers, allPlayers, fifaCode);
        }

        private async void LoadFavoritePlayersSettingsFromRepo()
        {
            _favoriteCountryandPlayersSettings = await _configRepo.GetFavoritePlayersSettings();
            if(_favoriteCountryandPlayersSettings == null)
            {
                return;
            }
            _favoriteplayers = _favoriteCountryandPlayersSettings.FavoritePlayersList;
            _notFavoriteplayers = _favoriteCountryandPlayersSettings.AllPlayersList;
            _fifaCodeFavCountry = _favoriteCountryandPlayersSettings.FifaCodeFavCountry;
        }

        public List<Player> GetFavoritePlayers() => _favoriteplayers;
        public List<Player> GetNotFavoritePlayers() => _notFavoriteplayers;
        public string GetFavFifaCode()=> _fifaCodeFavCountry;
        

        #endregion

        #region Initial settings language and championship

        public void SaveInitialSettingsToRepo(InitialWoFSettings settings)
        {
            _configRepo.SaveInitialSettings(settings);
        }

        private async void LoadInitialSettingsFromRepo()
        {
            _initialWoFSettings = await _configRepo.GetInitialSettings();
            if(_initialWoFSettings == null)
            {
                return;
            }
            _language = _initialWoFSettings.Language;
            _champinonship = _initialWoFSettings.Championship;

        }

        public string GetLanguage() => _language;
        public bool GetChampionship()
        {
            if (_champinonship != "Mens")
            {
                return true;
            }
           
            return false;
        } 

        #endregion
    }





}


using DataLayer.Repository;


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
        private List<Result> _results;
        private List<Player> _favoriteplayers;
        private List<Player> _notFavoriteplayers;
        private string _fifaCodeFavCountry;
        private string _fifaCodeOppositeFCountry;
        private string _language;
        private string _champinonship;
        private string _screenSize;
        private List<FootballMatch> _matches;
        private List<FootballMatch> _matchesOppositeTeam;
 

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

           
        }

        private async void SetConfigForRepo()
        {

           _config = await _configRepo.GetConfigurationFile();
           
           _repo = RepoFactory.GetRepo(_config);
        }


     

        public async Task LoadSavedSettings()
        {
            
            await LoadInitialSettingsFromRepo();
            await  LoadFavoritePlayersSettingsFromRepo();
    
        }

        #region Get Fifa lists
        public List<Team> GetTeamsList() => _teams;
        public List<Result> GetResutlsList() => _results;

        public List<FootballMatch> GetMatchesList() => _matches;
        public List<FootballMatch> GetMatchesOppositeTeamList() => _matchesOppositeTeam;
        #endregion

        #region Load fifa content
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

        public async Task LoadResults(bool isWomen)
        {

            try
            {
                _results = await _repo.GetResults(isWomen);

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }


        public async Task LoadMaches(bool isWomen)
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

        public async Task LoadMachesByFifaCode(bool isWomen, string fifaCode)
        {

            try
            {
                _matchesOppositeTeam = await _repo.GetMatchesByFifaCode(isWomen, fifaCode);

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        #endregion

        #region Favorite player settings
        public async Task SaveFavoritePlayersToRepo(FavoriteCountryandPlayersSetup favoriteCountryandPlayersSetup)
        {
             await _configRepo.SaveFavoritePlayersSettings(favoriteCountryandPlayersSetup);
        }

        private async Task LoadFavoritePlayersSettingsFromRepo()
        {
            _favoriteCountryandPlayersSettings = await _configRepo.GetFavoritePlayersSettings();
            if(_favoriteCountryandPlayersSettings == null)
            {
                return;
            }
            _favoriteplayers = _favoriteCountryandPlayersSettings.FavoritePlayersList;
            _notFavoriteplayers = _favoriteCountryandPlayersSettings.NotFavoritePlayersList;
            _fifaCodeFavCountry = _favoriteCountryandPlayersSettings.FifaCodeFavCountry;
            _fifaCodeOppositeFCountry = _favoriteCountryandPlayersSettings.OppositeTeam;
        }

        public List<Player> GetFavoritePlayers() => _favoriteplayers;
        public List<Player> GetNotFavoritePlayers() => _notFavoriteplayers;
        public string GetFavFifaCode()=> _fifaCodeFavCountry;
        public string GetOppositeFifaCode()=> _fifaCodeOppositeFCountry;
        

        #endregion

        #region Initial settings language and championship

        public async Task SaveInitialSettingsToRepo(InitialWoFSettings settings)
        {
            await _configRepo.SaveInitialSettings(settings);
        }

        private async Task LoadInitialSettingsFromRepo()
        {
            _initialWoFSettings = await _configRepo.GetInitialSettings();
            if(_initialWoFSettings == null)
            {
                return;
            }
            _language = _initialWoFSettings.Language;
            _champinonship = _initialWoFSettings.Championship;
            _screenSize = _initialWoFSettings.ScreenSize;
       


        }
        public string GetScreenSize () => _screenSize;
        public string GetLanguage() => _language;
        public bool GetChampionship()
        {
            if (_champinonship == "Mens")
            {
                return true;
            }
           
            return false;
        } 

        #endregion
    }





}


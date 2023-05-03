using DataLayer.Model;
using Newtonsoft.Json;
using System.Globalization;
using WorldOfFootball.CustomDesign;
using WorldOfFootball.EventsAndArgs;
using WorldOfFootball.UserControls;

namespace WorldOfFootball
{
    public partial class formMainForm : Form
    {
        
        private DataManager _dataManager = new();
        private TitleForm _titleForm;
        private LanguageAndChampionship _languageAndChampionshipForm;
        private FavoriteTeam _favoriteTeamForm;
        private FavoritePlayers _favoritePlayersForm;
        private RankingLists _rankingListsForm;
        private LoadingForm _loadingForm = new();
        private FavoriteCountryandPlayersSetup _favoriteCountryandPlayersSetup = new();
        private System.Windows.Forms.Timer _timer;
        private List<Player> _favoriteplayers;
        private List<Player> _notFavoriteplayers;
        private bool _isWomens;
        private string _language;
        private string _fifaCode;
   
        public formMainForm()
        {

            InitializeComponent();
       
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {

            CallTitleForm();
            _loadingForm.StartLoader();
            await _dataManager.LoadSavedSettings();
            _loadingForm.StopLoader();
            LoadSettings();
            LoadNextForm();

        }



        #region Call Forms
        private void LoadNextForm()
        {
            if (_language == null)
            {
                _language = "en";
             
                CallLanguageAndChampionshipForm();
               
            }
            else if (_fifaCode == null)
            {
                SetLanguage();
            
                CallFavoriteTeamForm();
             
            }
            else
            {
                SetLanguage();
            
                CallFavoritePlayersForm();
            
            }
        }

        
        private void CallTitleForm()
        {
            _titleForm = new TitleForm();
    
            this.Controls.Add(_titleForm);
            _titleForm.BringToFront();


            _timer = new System.Windows.Forms.Timer();
            _timer.Interval = 2000;
            _timer.Tick += new EventHandler(Timer_Tick);
            _timer.Start();
        }

       

        private void CallLanguageAndChampionshipForm()
        {
           
            _languageAndChampionshipForm = new LanguageAndChampionship(_language);
            _languageAndChampionshipForm.LangAndChamp += BtnNextLangAndChamp_Click;
            _languageAndChampionshipForm.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(_languageAndChampionshipForm);
        
        }
        private async void CallFavoriteTeamForm()
        {
            try
            {
                _loadingForm.StartLoader();
                await _dataManager.LoadTeams(_isWomens);
                _loadingForm.StopLoader();
                var teams = _dataManager.GetTeamsList();
                _favoriteTeamForm = new FavoriteTeam(teams, _language, _fifaCode);
            }
            catch (Exception)
            {
            
                
            }
      
            _favoriteTeamForm.Dock = DockStyle.Fill;
            _favoriteTeamForm.FavoriteTeamSelected += BtnNextFavoiriteTeam_Click;
            pnlContainer.Controls.Add(_favoriteTeamForm);

        }

        private async void CallFavoritePlayersForm()
        {
            _loadingForm.StartLoader();
            await _dataManager.LoadMaches(_isWomens);
            _loadingForm.StopLoader();
            var matches =  _dataManager.GetMatchesList();
            _favoritePlayersForm = new FavoritePlayers(matches, _fifaCode, _language, _favoriteplayers, _notFavoriteplayers);
            _favoritePlayersForm.Dock = DockStyle.Fill;
            _favoritePlayersForm.FavoritePlayersList += BtnNextFavoritePlayers_Click;
            pnlContainer.Controls.Add(_favoritePlayersForm);
        }
        private void CallRankingListForm(List<Player> allPlayersForCountry, string fifaCode)
        {
            var matches = _dataManager.GetMatchesList();
            _rankingListsForm = new RankingLists(matches, allPlayersForCountry, fifaCode);
            _rankingListsForm.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(_rankingListsForm);

        }


        #endregion

        #region Events on Buttons in Forms
        private void BtnNextLangAndChamp_Click(object sender, LanguageAndChampionshipEventArgs e)
        {
            // Spremi odabrani jezik i prvenstvo u RepositoryConfig objekt
            InitialWoFSettings initialWoFSettings = new()
            {
                Language = e.Language,
                Championship = e.Championship
            };
   
            _dataManager.SaveInitialSettingsToRepo(initialWoFSettings);
            _language = initialWoFSettings.Language;
            if (initialWoFSettings.Championship == "Mens")
            {
                _isWomens = false;
            }
            else
            {
                _isWomens = true;
            }
            SetLanguage();
            _languageAndChampionshipForm.Dispose();
            
        
         
            CallFavoriteTeamForm();
           
       
           

        }
        private void BtnNextFavoiriteTeam_Click(object sender, FavoriteTeamEventArgs e)
        {
            var favoriteTeam = e.favoriteTeam;
            _fifaCode = favoriteTeam.FifaCode;
            _favoriteCountryandPlayersSetup.FifaCodeFavCountry = _fifaCode;
            _favoriteCountryandPlayersSetup.FavoritePlayersList = null;
            _favoriteCountryandPlayersSetup.NotFavoritePlayersList = null;
            _dataManager.SaveFavoritePlayersToRepo(_favoriteCountryandPlayersSetup);
         
            _favoriteTeamForm.Dispose();
            CallFavoritePlayersForm();
        
           

        }

        private void BtnNextFavoritePlayers_Click(object sender, FavoritePlayersTeamEventArgs e)
        {
            _favoriteCountryandPlayersSetup.FavoritePlayersList = e.FavoritePlayersList;
            _favoriteCountryandPlayersSetup.NotFavoritePlayersList = e.NotFavoritePlayersList;
            _favoriteCountryandPlayersSetup.FifaCodeFavCountry = e.FifaCodeFavCountry;
            _fifaCode = e.FifaCodeFavCountry;
            var allPlayersForCountry = e.AllPlayers;
      

            _dataManager.SaveFavoritePlayersToRepo(_favoriteCountryandPlayersSetup);
            pnlContainer.Controls.Clear();
           
         
            _favoritePlayersForm.Dispose();
            CallRankingListForm(allPlayersForCountry, _fifaCode);
  
           
        }


        #endregion

        #region Events on Buttons in Main Form
        private void PbSettings_Click(object sender, EventArgs e)
        {
            pnlContainer.Controls.Clear();
            _favoriteplayers = null;
            _notFavoriteplayers = null;
 
            CallLanguageAndChampionshipForm();
        
         
        }

  

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            string message;
            string warning;


            if (_language == "hr")
            {
                message = Properties.Resources.messageLeavingHr;
                warning = Properties.Resources.messageWarningHr;
            }
            else
            {
                message = Properties.Resources.messageLeavingEn;
                warning = Properties.Resources.messageWarningEn;

            }

            var result = CustomMessageBox.Show(message, warning, MessageBoxButtons.OKCancel, _language);
            if (result == DialogResult.No)
            {
                e.Cancel = true; // ovdje sprijeèavamo zatvaranje aplikacije
            }


        }
        #endregion

        #region Methods

        private void LoadSettings()
        {

            //_loadingForm.StartLoader();
            try
            {
                _language = _dataManager.GetLanguage();
                _isWomens = _dataManager.GetChampionship();
                _fifaCode = _dataManager.GetFavFifaCode();
                _favoriteplayers = _dataManager.GetFavoritePlayers();
                _notFavoriteplayers = _dataManager.GetNotFavoritePlayers();
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(ex.Message,"Warning" ,MessageBoxButtons.OK, _language);
                
            }
   
            //_loadingForm.StopLoader();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Zaustavi timer
            ((System.Windows.Forms.Timer)sender).Stop();

            // Ukloni TitleForm iz glavne forme
            this.Controls.Remove(_titleForm);

            // Oslobodi resurse
            _titleForm.Dispose();
        }

        private void SetLanguage()
        {
           
            Thread.CurrentThread.CurrentCulture = new CultureInfo(_language);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(_language);
            
        }





        #endregion

 

      
    }
}
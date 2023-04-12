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
        
        private DataManager _dataManager = new DataManager();
        private TitleForm _titleForm;
        private LanguageAndChampionship _languageAndChampionshipForm;
        private FavoriteTeam _favoriteTeamForm;
        private FavoritePlayers _favoritePlayersForm;
        private RankingLists _rankingListsForm;
        private bool _isWomens;
        private string _language;
        private string _fifaCode;
   
        public formMainForm()
        {

            CallTitleForm();
            InitializeComponent();
            
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            if (_language == null)
            {
                _language = "en";
            }
            await _dataManager.LoadTeams(false);

            CallLanguageAndChampionshipForm();
      


        }

        #region Call Forms
        private void CallTitleForm()
        {
            _titleForm = new TitleForm();
            this.Controls.Add(_titleForm);
            _titleForm.BringToFront();

            // Stvori novi timer sa vremenom kašnjenja od 15 sekundi
            System.Windows.Forms.Timer timer = new ();
            timer.Interval = 1500;
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Start();
        }

        private void CallLanguageAndChampionshipForm()
        {
            _languageAndChampionshipForm = new LanguageAndChampionship(_language);
            _languageAndChampionshipForm.LangAndChamp += BtnNextLangAndChamp_Click;
            _languageAndChampionshipForm.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(_languageAndChampionshipForm);
        }
        private async void CallFavoriteTeamForm(bool isWomens)
        {
            await _dataManager.LoadTeams(isWomens);
            var teams = _dataManager.GetTeamsList();
            _favoriteTeamForm = new FavoriteTeam(teams, _language);
            _favoriteTeamForm.Dock = DockStyle.Fill;
            _favoriteTeamForm.FavoriteTeamSelected += BtnNextFavoiriteTeam_Click;
            pnlContainer.Controls.Add(_favoriteTeamForm);

        }

        private async void CallFavoritePlayersForm(bool isWomens)
        {
            await _dataManager.LoadMaches(isWomens);
            var matches = _dataManager.GetMatchesList();
            _favoritePlayersForm = new FavoritePlayers(matches, _fifaCode, _language);
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
            var settings = new InitialWoFSettings
            {
                Language = e.Language,
                Championship = e.Championship
            };
            _dataManager.SaveInitialSettingsToRepo(settings);
            _language = settings.Language;
            if (settings.Championship == "Mens")
            {
                _isWomens = false;
            }
            else
            {
                _isWomens = true;
            }
            SetLanguage();
            CallFavoriteTeamForm(_isWomens);
            _languageAndChampionshipForm.Dispose();

        }
        private void BtnNextFavoiriteTeam_Click(object sender, FavoriteTeamEventArgs e)
        {
            var favoriteTeam = e.favoriteTeam;
            _fifaCode = favoriteTeam.FifaCode;
      
            CallFavoritePlayersForm(_isWomens);
            _favoriteTeamForm.Dispose();

        }

        private void BtnNextFavoritePlayers_Click(object sender, FavoritePlayersTeamEventArgs e)
        {
            var favoritePlayers = e.FavoritePlayersList;
            var allNotFavoritePlayers = e.NotFavoritePlayersList;
            var allPlayersForCountry = e.AllPlayers;
            string fifaCode = e.FifaCodeFavCountry;

            _dataManager.SaveFavoritePlayersToRepo(favoritePlayers, allNotFavoritePlayers, fifaCode);
            pnlContainer.Controls.Clear();
            CallRankingListForm(allPlayersForCountry, fifaCode);
            _favoritePlayersForm.Dispose();
        }


        #endregion

        #region Events on Buttons in Main Form
        private void PbSettings_Click(object sender, EventArgs e)
        {
            pnlContainer.Controls.Clear();
            CallLanguageAndChampionshipForm();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            string message ="";
            string warning = "";
          
                     
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
            //if (_language == null)
            //{
            //    MessageBox.Show("Nije izabran jezik");
            //}
            
            Thread.CurrentThread.CurrentCulture = new CultureInfo(_language);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(_language);
            
        }


        #endregion

       

       
    }
}
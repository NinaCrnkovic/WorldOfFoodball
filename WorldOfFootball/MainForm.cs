using DataLayer.Model;
using Newtonsoft.Json;
using WorldOfFootball.EventsAndArgs;
using WorldOfFootball.UserControls;

namespace WorldOfFootball
{
    public partial class MainForm : Form
    {
        private DataManager _dataManager = new DataManager();
        private TitleForm _titleForm;
        private LanguageAndChampionship _languageAndChampionshipForm;
        private FavoriteTeam _favoriteTeamForm;
   
        public MainForm()
        {

            CallTitleForm();
            InitializeComponent();
            
        }


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

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Zaustavi timer
            ((System.Windows.Forms.Timer)sender).Stop();

            // Ukloni TitleForm iz glavne forme
            this.Controls.Remove(_titleForm);

            // Oslobodi resurse
            _titleForm.Dispose();
        }


        private async void MainForm_Load(object sender, EventArgs e)
        {

            await _dataManager.LoadTeams(false);
           // FillTeamsListBox(false);
            CallLanguageAndChampionshipForm();
     

        }

        private void CallLanguageAndChampionshipForm()
        {
            _languageAndChampionshipForm = new LanguageAndChampionship();
            _languageAndChampionshipForm.LangAndChamp += BtnNextLangAndChamp_Click;
            pnlContainer.Controls.Add(_languageAndChampionshipForm);
        }

        private void BtnNextLangAndChamp_Click(object sender, LanguageAndChampionshipEventArgs e)
        {
            // Spremi odabrani jezik i prvenstvo u RepositoryConfig objekt
            var settings = new InitialWoFSettings
            {
                Language = e.Language,
                Championship = e.Championship
            };
            _dataManager.SaveInitialSettingsToRepo(settings);
        
            CallFavoriteTeamForm();
            _languageAndChampionshipForm.Dispose();

        }

        private async void CallFavoriteTeamForm()
        {
            await _dataManager.LoadTeams(false);
            var teams = _dataManager.GetTeamsList();
            _favoriteTeamForm = new FavoriteTeam(teams);
            pnlContainer.Controls.Add(_favoriteTeamForm);
         
        }




    }
}
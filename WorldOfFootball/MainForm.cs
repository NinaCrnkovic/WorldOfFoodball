using DataLayer.Model;
using Newtonsoft.Json;
using WorldOfFootball.EventsAndArgs;
using WorldOfFootball.UserControls;

namespace WorldOfFootball
{
    public partial class MainForm : Form
    {
        private DataManager _dataManager = new DataManager();
        private TitleForm titleForm;
        private LanguageAndChampionship languageAndChampionshipForm;
        private FavoriteTeam favoriteTeamForm;
        private List<Team> teamList;
        public MainForm()
        {
            teamList = _dataManager.GetTeamsList();

            CallTitleForm();
            InitializeComponent();
            
        }


        private void CallTitleForm()
        {
            titleForm = new TitleForm();
            this.Controls.Add(titleForm);
            titleForm.BringToFront();

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
            this.Controls.Remove(titleForm);

            // Oslobodi resurse
            titleForm.Dispose();
        }


        private async void MainForm_Load(object sender, EventArgs e)
        {

            await _dataManager.LoadTeams(false);
            FillTeamsListBox(false);
            CallLanguageAndChampionshipForm();

        }

        private void CallLanguageAndChampionshipForm()
        {
            languageAndChampionshipForm = new LanguageAndChampionship();
            languageAndChampionshipForm.LangAndChamp += BtnNextLangAndChamp_Click;
            pnlContainer.Controls.Add(languageAndChampionshipForm);
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
            languageAndChampionshipForm.Dispose();


        }

        private void CallFavoriteTeamForm()
        {
            favoriteTeamForm = new FavoriteTeam();
            pnlContainer.Controls.Add(favoriteTeamForm);
        }

        private  void FillTeamsListBox(bool isWomen)
        {
            var teams =  _dataManager.GetTeamsList();


            lbTeams.Items.Clear();

            foreach (var team in teams)
            {
                lbTeams.Items.Add($"{ team.Country} ({team.FifaCode})");
            }
        }


    }
}
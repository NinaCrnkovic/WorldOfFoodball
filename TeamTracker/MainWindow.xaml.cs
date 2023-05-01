using DataLayer.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TeamTracker.EventsArgsTT;
using WorldOfFootball.CustomDesign;

namespace TeamTracker
{
  
    public partial class MainWindow : Window
    {
        private DataManager _dataManager = new();
       
        private bool _isWomens;
        private string _language;
        private string _championship;
        private string _screenSize;
        private string _favTeamCode;
        private string _oppTeamCode;
        private string _result;
        private List<FootballMatch> _footballMatchList;
        
        public MainWindow()
        {
            LoadInitialSettings();
            SetLanguage();
            SetScreenSize();
        
            InitializeComponent();

            LoadFirstScreen();
        }

        private void LoadFirstScreen()
        {
            if (_language != null || _screenSize != null)
            {

                CallOverviewOfTheTeam();

            }
            else 
            {
                CallInitialSettings();
            }
          
        }

        private void LoadInitialSettings()
        {
            try
            {
                _dataManager.LoadSavedSettings();
                _language = _dataManager.GetLanguage();
                _isWomens = _dataManager.GetChampionship();
                _screenSize = _dataManager.GetScreenSize();
                _favTeamCode= _dataManager.GetFavFifaCode();
                _oppTeamCode= _dataManager.GetOppositeFifaCode();
        
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(ex.Message, "Warning", System.Windows.Forms.MessageBoxButtons.OK, _language);

            }
        }

        private void SetLanguage()
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(_language);
        }

        private void CallInitialSettings()
        {   SetScreenSize();
            UserControls.InitialSettings initialSettings = new(_language, _isWomens, _screenSize);
            initialSettings.InitSett += InitialSettingsFormBtn_Click;
            Container.Content = initialSettings;
        }

        private void CallOverviewOfTheTeam()
        {

            SetScreenSize();
            UserControls.OverviewOfTheTeam overview = new(_isWomens, _favTeamCode, _oppTeamCode);
            overview.TeamOverview += OverviewBtn_Click;
            overview.BackClick += OverwievBack_Click;
            Container.Content = overview;
        }

        private void OverwievBack_Click(object sender, EventArgs e)
        {
            CallInitialSettings();
        }

        private void CallFirstEleven()
        {
            UserControls.FirstEleven firstEleven = new(_favTeamCode, _oppTeamCode, _result, _footballMatchList);
            Container.Content = firstEleven;
        }

        private void OverviewBtn_Click(object sender, OverviewEventArgs e)
        {
            _result = e.Result;
            _footballMatchList = e.FootballMatches;
            _favTeamCode = e.FavoriteTeam;
            _oppTeamCode = e.OppositeTeam;
            FavoriteCountryandPlayersSetup settings = new()
            {
                FifaCodeFavCountry = _favTeamCode,
                OppositeTeam = _oppTeamCode
            };
                     
            _dataManager.SaveFavoritePlayersToRepo(settings);

            CallFirstEleven();
        }

    

        private void InitialSettingsFormBtn_Click(object sender, InitialSettingsEventArgs e) 
        {
            _language = e.Language;
            _championship = e.Championship;
            _screenSize = e.ScreenSize;
            _isWomens = _championship == "Mens" ? false : true;
            InitialWoFSettings settings = new()
            {
                Language = _language,
                Championship = _championship,
                ScreenSize = _screenSize
            };
            _dataManager.SaveInitialSettingsToRepo(settings);
           
          
        
            SetLanguage();
            SetScreenSize();
            CallOverviewOfTheTeam();
        }

    

        private void SetScreenSize()
        {
            if (_screenSize is null || _screenSize == "Original")
            {
                this.Width = 1500;
                this.Height = 800;
            }
            else if (_screenSize == "Fullscreen")
            {
                // Dobivanje referene na prozor
                Window window = Application.Current.MainWindow;

                // Postavljanje prozora u puni zaslon
                window.WindowState = WindowState.Maximized;
            }
            else if (_screenSize == "Small")
            {
                this.Width = 800;
                this.Height = 800;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
        
            CallInitialSettings();
           
        }
    }
}

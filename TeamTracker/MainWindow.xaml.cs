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
        private InitialWoFSettings _settings = new();
        //private string _language;
        private bool _isWomens;
     
    
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
            if (_settings.Language == null)
            {
                CallInitialSettings();

            }
            else 
            {
                SetScreenSize();
                CallOverviewOfTheTeam();
            }
          
        }

        private void LoadInitialSettings()
        {
            try
            {
                _dataManager.LoadSavedSettings();
                _dataManager.LoadFavoritePlayersSettingsFromRepo();
                _settings.Language = _dataManager.GetLanguage();
                _isWomens = _dataManager.GetChampionship();
                _settings.ScreenSize = _dataManager.GetScreenSize();
                _settings.FifaCodeFavCountry = _dataManager.GetFavFifaCode();
                _settings.OppositeTeam = _dataManager.GetOppositeFifaCode();
        
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(ex.Message, "Warning", System.Windows.Forms.MessageBoxButtons.OK, _settings.Language);

            }
        }

        private void SetLanguage()
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(_settings.Language);
        }

        private void CallInitialSettings()
        {
            UserControls.InitialSettings initialSettings = new();
            initialSettings.InitSett += InitialSettingsFormBtn_Click;
            Container.Content = initialSettings;
        }

        private void CallOverviewOfTheTeam()
        {
            UserControls.OverviewOfTheTeam overview = new(_isWomens, _settings.FifaCodeFavCountry, _settings.OppositeTeam);
            overview.TeamOverview += OverviewBtn_Click;
            Container.Content = overview;
        }

        private void CallFirstEleven()
        {
            UserControls.FirstEleven firstEleven = new(_settings.FifaCodeFavCountry, _settings.OppositeTeam, _result, _footballMatchList);
            Container.Content = firstEleven;
        }

        private void OverviewBtn_Click(object sender, OverviewEventArgs e)
        {
            _result = e.Result;
            _footballMatchList = e.FootballMatches;
            _settings.OppositeTeam = e.FavoriteTeam;
            _settings.FifaCodeFavCountry = e.OppositeTeam;
            _dataManager.SaveInitialSettingsToRepo(_settings);

            CallFirstEleven();
        }

    

        private void InitialSettingsFormBtn_Click(object sender, InitialSettingsEventArgs e) 
        {
            _settings.Language = e.Language;
            _settings.Championship = e.Championship;
            _settings.ScreenSize = e.ScreenSize;
        
            _dataManager.SaveInitialSettingsToRepo(_settings);
            _settings.Language = _settings.Language;
            var championship = _settings.Championship;
            _isWomens = championship == "Mens" ? false : true;
        
            SetLanguage();
            SetScreenSize();
            CallOverviewOfTheTeam();
        }

    

        private void SetScreenSize()
        {
            if (_settings.ScreenSize is null || _settings.ScreenSize == "Original")
            {
                this.Width = 1500;
                this.Height = 800;
            }
            else if (_settings.ScreenSize == "Fullscreen")
            {
                // Dobivanje referene na prozor
                Window window = Application.Current.MainWindow;

                // Postavljanje prozora u puni zaslon
                window.WindowState = WindowState.Maximized;
            }
            else if (_settings.ScreenSize == "Small")
            {
                this.Width = 800;
                this.Height = 800;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _settings.FifaCodeFavCountry = null;
            _settings.OppositeTeam = null;
            CallInitialSettings();
           
        }
    }
}

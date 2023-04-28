using DataLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace TeamTracker
{
  
    public partial class MainWindow : Window
    {
        private DataManager _dataManager = new();
        private string _language;
        private string _championship;
        private string _screenSize;
        private string _favoriteTeam;
        private string _oppositeTeam;
        private string _result;
        private List<FootballMatch> _footballMatchList;
        
        public MainWindow()
        {
            InitializeComponent();
            if (true)
            {
                CallInitialSettings();
            }
        }

        private void CallInitialSettings()
        {
            UserControls.InitialSettings initialSettings = new();
            initialSettings.InitSett += InitialSettingsFormBtn_Click;
            Container.Content = initialSettings;
        }

        private void CallOverviewOfTheTeam()
        {
            UserControls.OverviewOfTheTeam overview = new(_championship);
            overview.TeamOverview += OverviewBtn_Click;
            Container.Content = overview;
        }

        private void CallFirstEleven()
        {
            UserControls.FirstEleven firstEleven = new(_favoriteTeam, _oppositeTeam, _result, _footballMatchList);
            Container.Content = firstEleven;
        }

        private void OverviewBtn_Click(object sender, OverviewEventArgs e)
        {
            _favoriteTeam = e.FavoriteTeam;
            _oppositeTeam = e.OppositeTeam;
            _result = e.Result;
            _footballMatchList = e.FootballMatches;

            CallFirstEleven();
        }

    

        private void InitialSettingsFormBtn_Click(object sender, InitialSettingsEventArgs e) 
        {
            InitialWoFSettings settings = new InitialWoFSettings
            {
                Language = e.Language,
                Championship = e.Championship,
                ScreenSize = e.ScreenSize
            };
            _dataManager.SaveInitialSettingsToRepo(settings);
            _language = settings.Language;
            _championship = settings.Championship;
            _screenSize = settings.ScreenSize;
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
    }
}

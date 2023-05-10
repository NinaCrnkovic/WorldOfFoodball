using DataLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;
using TeamTracker.EventsArgsTT;

namespace TeamTracker.UserControls
{

    public partial class OverviewOfTheTeam : UserControl
    {
        private bool _isWomens;
        private DataManager _dataManager = new();

        private List<FootballMatch> _matches;
        private List<Result> _results;
        private string _favoriteFifaCode;
        private string _oppositeFifaCode;
        private static string _language;

        public OverviewOfTheTeam(bool isWomens, string favoriteTeamCode, string oppositeTemCode, string language)
        {
            InitializeComponent();

            _isWomens = isWomens;
            _favoriteFifaCode = favoriteTeamCode;
            _oppositeFifaCode = oppositeTemCode;
            _language = language;
            GetMatches();
            GetTeams();
            FillFavoriteComboBox();
            GetResults();


        }

       

    
        #region Get methods

        private async void GetResults()
        {
            await _dataManager.LoadResults(_isWomens);
            _results = _dataManager.GetResutlsList();
        }
        private async void GetMatches()
        {
            await _dataManager.LoadMaches(_isWomens);
            _matches = _dataManager.GetMatchesList();
        }
        private List<FootballMatch> GetMatchesOppositeTeam()
        {

            _dataManager.LoadMachesByFifaCode(_isWomens, _favoriteFifaCode).Wait();
            var matchesOppositeTeam = _dataManager.GetMatchesOppositeTeamList();
            return matchesOppositeTeam;
        }

        private List<Team> GetTeams()
        {

            _dataManager.LoadTeams(_isWomens).Wait();
            var teams = _dataManager.GetTeamsList();
            return teams;
        }

        private List<Team> GetOppositeTeams()
        {
            List<Team> oppositeTeams = new();
            List<Team> teams = GetTeams();
            List<FootballMatch> matchesOppositeTeam = GetMatchesOppositeTeam();
            foreach (var item in matchesOppositeTeam)
            {
                if (item.HomeTeam.Code != _favoriteFifaCode)
                {
                    var team = teams.Where(t => t.FifaCode == item.HomeTeam.Code).FirstOrDefault();
                    if (team != null)
                    {
                        oppositeTeams.Add(new Team { Id = team.Id, FifaCode = team.FifaCode, AlternateName = team.AlternateName, Country = team.Country, GroupId = team.GroupId, GroupLetter = team.GroupLetter });
                    }
                }
                if (item.AwayTeam.Code != _favoriteFifaCode && item.AwayTeam.Code != null)
                {
                    var team = teams.Where(t => t.FifaCode == item.AwayTeam.Code).FirstOrDefault();
                    if (team != null)
                    {
                        oppositeTeams.Add(new Team { Id = team.Id, FifaCode = team.FifaCode, AlternateName = team.AlternateName, Country = team.Country, GroupId = team.GroupId, GroupLetter = team.GroupLetter });
                    }
                }
            }
            return oppositeTeams;
        }

        #endregion

        #region Fill methods

        private void FillResultLabel()
        {

            var favoriteFifaCode = cbFavoriteTeam.SelectedItem.ToString().Substring(cbFavoriteTeam.SelectedItem.ToString().IndexOf("(") + 1, 3);
            var oppositeFifaCode = cbOppositeTeam.SelectedItem.ToString().Substring(cbOppositeTeam.SelectedItem.ToString().IndexOf("(") + 1, 3);
            long goalsFavoriteTeam = 0;
            long goalsOppostieTeam = 0;
            List<FootballMatch> matchesOppositeTeam = GetMatchesOppositeTeam();
            foreach (FootballMatch match in matchesOppositeTeam)
            {
                if (match.HomeTeam.Code == favoriteFifaCode && match.AwayTeam.Code == oppositeFifaCode)
                {
                    goalsFavoriteTeam = match.HomeTeam.Goals;
                    goalsOppostieTeam = match.AwayTeam.Goals;
                }
                else if (match.AwayTeam.Code == favoriteFifaCode && match.HomeTeam.Code == oppositeFifaCode)
                {
                    goalsFavoriteTeam = match.AwayTeam.Goals;
                    goalsOppostieTeam = match.HomeTeam.Goals;
                }

            }
            lblResult.Content = $"{goalsFavoriteTeam} : {goalsOppostieTeam}";

        }
        private void FillFavoriteTeamList()
        {

            string selectedCountry = cbFavoriteTeam.SelectedItem.ToString();
            _favoriteFifaCode = selectedCountry.Substring(selectedCountry.IndexOf("(") + 1, 3);


            FootballMatch matchWithCode = null;
            foreach (var item in _matches)
            {
                if (item.AwayTeam.Code == _favoriteFifaCode)
                {
                    matchWithCode = item;
                    break;
                }
            }

            List<Player> players = new List<Player>();
            if (matchWithCode != null)
            {

                foreach (var startingPlayer in matchWithCode.AwayTeamStatistics.StartingEleven)
                {
                    players.Add(startingPlayer);
                }
                foreach (var substiturePlayer in matchWithCode.AwayTeamStatistics.Substitutes)
                {
                    players.Add(substiturePlayer);
                }
            }
            else
            {
                Console.WriteLine($"No matches found with FIFA code {_favoriteFifaCode}");
            }
            lbFavoriteTeam.ItemsSource = players;


        }

        private void FillOppositeTeamList()
        {

            string selectedCountry = cbOppositeTeam.SelectedItem.ToString();
            _oppositeFifaCode = selectedCountry.Substring(selectedCountry.IndexOf("(") + 1, 3);


            FootballMatch matchWithCode = null;
            foreach (var item in _matches)
            {
                if (item.AwayTeam.Code == _oppositeFifaCode)
                {
                    matchWithCode = item;
                    break;
                }
                else if (item.HomeTeam.Code == _oppositeFifaCode)
                {
                    matchWithCode = item;
                    break;
                }
            }
            List<Player> players = new List<Player>();
            if (matchWithCode != null)
            {

                foreach (var startingPlayer in matchWithCode.AwayTeamStatistics.StartingEleven)
                {
                    players.Add(startingPlayer);
                }
                foreach (var substiturePlayer in matchWithCode.AwayTeamStatistics.Substitutes)
                {
                    players.Add(substiturePlayer);
                }
            }
            else
            {
                Console.WriteLine($"No matches found with FIFA code {_oppositeFifaCode}");
            }
            lbOppositeTeam.ItemsSource = players;



        }

        private void FillFavoriteComboBox()
        {
            cbFavoriteTeam.Items.Clear();
            var teams = GetTeams();
            var sortedTeams = teams.OrderBy(t => t.Country).ToList();

            if (cbFavoriteTeam != null)
            {
                foreach (var team in sortedTeams)
                {
                    cbFavoriteTeam.Items.Add(team);
                }
                if (_favoriteFifaCode == null)
                {
                    cbFavoriteTeam.SelectedIndex = 0;
                }
                else
                {
                    foreach (var item in cbFavoriteTeam.Items)
                    {
                        var code = item.ToString().Substring(item.ToString().IndexOf("(") + 1, 3);
                        if (code == _favoriteFifaCode)
                        {
                            int index = cbFavoriteTeam.Items.IndexOf(item);
                            cbFavoriteTeam.SelectedIndex = index;
                            break;
                        }
                    }
                }
            }

        }

        private void FillOppositeComboBox()
        {

            cbOppositeTeam.Items.Clear();

            var team = GetOppositeTeams();
            var sortedTeams = team.OrderBy(t => t.Country).ToList();
            if (cbOppositeTeam != null)
            {
                foreach (var item in sortedTeams)
                {

                    cbOppositeTeam.Items.Add(item);
                }
                cbOppositeTeam.SelectedIndex = 0;
            }


        }







        #endregion

        #region Events and buttons


        public event EventHandler<OverviewEventArgs> TeamOverview;
        private void Btn_Next_Click(object sender, RoutedEventArgs e)
        {
            string favoriteTeam = cbFavoriteTeam.SelectedItem.ToString().Substring(cbFavoriteTeam.SelectedItem.ToString().IndexOf("(") + 1, 3);
            string oppositeTeam = cbOppositeTeam.SelectedItem.ToString().Substring(cbOppositeTeam.SelectedItem.ToString().IndexOf("(") + 1, 3);
            string result = lblResult.Content.ToString();
            TeamOverview?.Invoke(this, new OverviewEventArgs { FavoriteTeam = favoriteTeam, OppositeTeam = oppositeTeam, Result = result, FootballMatches = _matches });
        }

        public event EventHandler BackClick;
        private void Btn_Back_Click(object sender, RoutedEventArgs e)
        {

            BackClick?.Invoke(this, EventArgs.Empty);
        }

        private void cbFavoriteTeam_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            FillFavoriteTeamList();
            GetOppositeTeams();
            FillOppositeComboBox();
            FillResultLabel();

        }

        private void cbOppositeTeam_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbOppositeTeam.SelectedItem != null)
            {
                FillOppositeTeamList();
                FillResultLabel();
            }


        }
        private void Btn_FavoriteTeamInfo_Click(object sender, RoutedEventArgs e)
        {
            var fifaCode = cbFavoriteTeam.SelectedItem.ToString().Substring(cbFavoriteTeam.SelectedItem.ToString().IndexOf("(") + 1, 3);

            Result teamResult = _results.FirstOrDefault(r => r.FifaCode == fifaCode);
            if (teamResult != null)
            {
                OpenCountryInfoWindow(teamResult);
            }
       



        }

        private void Btn_OppositeTeamInfo_Click(object sender, RoutedEventArgs e)
        {
            var fifaCode = cbOppositeTeam.SelectedItem.ToString().Substring(cbOppositeTeam.SelectedItem.ToString().IndexOf("(") + 1, 3);


            Result teamResult = _results.FirstOrDefault(r => r.FifaCode == fifaCode);
            if (teamResult != null)
            {
                OpenCountryInfoWindow(teamResult);
            }
        
        }
        #endregion

        #region Country info window
        private static void OpenCountryInfoWindow(Result result)
        {
        
            CountryInfo country = new CountryInfo(_language);
            FillCountriInfoWindow(result, country);

            DoubleAnimation animation = new DoubleAnimation();
            animation.From = 0;
            animation.To = 1;
            animation.Duration = TimeSpan.FromSeconds(2);

            // Stvaranje druge animacije
            DoubleAnimation rotateAnimation = new DoubleAnimation();
            rotateAnimation.From = 0;
            rotateAnimation.To = 360;
            rotateAnimation.Duration = TimeSpan.FromSeconds(3);

            // Pokretanje animacija
            country.BeginAnimation(UIElement.OpacityProperty, animation);
            Storyboard.SetTargetProperty(animation, new PropertyPath("Opacity"));

            country.RenderTransformOrigin = new Point(0.5, 0.5);

            TransformGroup transformGroup = new TransformGroup();
            RotateTransform rotateTransform = new RotateTransform();

            transformGroup.Children.Add(rotateTransform);

            country.RenderTransform = transformGroup;

            country.RenderTransform.BeginAnimation(RotateTransform.AngleProperty, rotateAnimation);
            Storyboard.SetTargetProperty(rotateAnimation, new PropertyPath("RenderTransform.Children[0].Angle"));

            // Create the storyboard and add the animation
            Storyboard storyboard = new Storyboard();
            storyboard.Children.Add(animation);
            storyboard.Children.Add(rotateAnimation);
            storyboard.Begin(country);

            country.Loaded += (s, ea) =>
            {
                // Start the storyboard when the dialog is loaded
                storyboard.Begin(country);
            };


            country.ShowDialog();
        }

        private static void FillCountriInfoWindow(Result result, CountryInfo country)
        {
            country.lblName.Content = result.Country;
            country.lblFifaCode.Content = result.FifaCode;
            country.lblGamesPlayed.Content = result.GamesPlayed;
            country.lblWins.Content = result.Wins;
            country.lblLoses.Content = result.Losses;
            country.lblDraws.Content = result.Draws;
            country.lblGoalsFor.Content = result.GoalsFor;
            country.lblGoalsAgainst.Content = result.GoalsAgainst;
            country.lblGoalDifferential.Content = result.GoalDifferential;
        }
        #endregion
    }
}
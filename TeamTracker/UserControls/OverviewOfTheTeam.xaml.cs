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

namespace TeamTracker.UserControls
{
    
    public partial class OverviewOfTheTeam : UserControl
    {
        private string _championshpip;
        private DataManager _dataManager = new();
    
        private List<FootballMatch> _matches;
    
        private bool _isWomens;
        private string _favoriteFifaCode;
        private string _oppositeFifaCode;

        public OverviewOfTheTeam(string championship)
        {
            InitializeComponent();
            _championshpip = championship;
            _isWomens = _championshpip == "Mens" ? false : true;
            GetMatches();
            GetTeams();
            FillFavoriteComboBox();
            FillResult();
      
        
          

        }

        private void FillResult()
        {
            long goalsFavoriteTeam = 0;
            long goalsOppostieTeam = 0;
            List<FootballMatch> matchesOppositeTeam = GetMatchesOppositeTeam();
            foreach (FootballMatch match in matchesOppositeTeam)
            {
                if (match.HomeTeam.Code == _favoriteFifaCode)
                {
                    goalsFavoriteTeam = match.HomeTeam.Goals;
                    goalsOppostieTeam = match.AwayTeam.Goals;
                }
                else if (match.AwayTeam.Code == _favoriteFifaCode)
                {
                    goalsFavoriteTeam = match.AwayTeam.Goals;
                    goalsOppostieTeam = match.HomeTeam.Goals;
                }
     
            }
            lblResult.Content = $"{goalsFavoriteTeam} : {goalsOppostieTeam}";

        }
        #region Get methods
        private void GetMatches()
        {
            _dataManager.LoadMaches(_isWomens);
            _matches = _dataManager.GetMatchesList();
        }
        private List<FootballMatch> GetMatchesOppositeTeam()
        {

            _dataManager.LoadMachesByFifaCode(_isWomens, _favoriteFifaCode);
            var matchesOppositeTeam = _dataManager.GetMatchesOppositeTeamList();
            return matchesOppositeTeam;
        }

        private List<Team> GetTeams()
        {

            _dataManager.LoadTeams(_isWomens);
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
                foreach (var item in sortedTeams)
                {
                    
                    cbFavoriteTeam.Items.Add(item);
                }
                cbFavoriteTeam.SelectedIndex = 0;
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

           // FillOppositeTeamList();
        }


        #endregion


        public event EventHandler<OverviewEventArgs> TeamOverview;
        private void Btn_Next_Click(object sender, RoutedEventArgs e)
        {
            TeamOverview?.Invoke(this, new OverviewEventArgs { FavoriteTeam= "test", OppositeTeam= "Test", Result ="Test"});
        }

        private void cbFavoriteTeam_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                FillFavoriteTeamList();

                GetOppositeTeams();

                FillOppositeComboBox();
                FillResult();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"u prvoj" +ex);
            }
       


          
        }

        private void cbOppositeTeam_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

             if (cbOppositeTeam.SelectedItem != null)
                {
                    FillOppositeTeamList();
                
                }

            FillResult();

        }

      
    }
}

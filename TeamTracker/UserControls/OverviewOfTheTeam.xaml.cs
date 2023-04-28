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
        private List<Team> _teams;

        private List<Team> _oppositeTeams = new();
  
        private List<FootballMatch> _matches;
        private List<FootballMatch> _matchesOppositeTeam;
        private bool _isWomens;
        private string _favoriteFifaCode;

        public OverviewOfTheTeam(string championship)
        {
            InitializeComponent();
            _championshpip = championship;
            _isWomens = _championshpip == "Mens" ? false : true;
            GetMatches();
            GetTeams();
            FillFavoriteComboBox();
        
          

        }

        private void GetMatches()
        {
            _dataManager.LoadMaches(_isWomens);
            _matches = _dataManager.GetMatchesList();
        }
        private void GetMatchesOppositeTeam()
        {

            _dataManager.LoadMachesByFifaCode(_isWomens, _favoriteFifaCode);
            _matchesOppositeTeam = _dataManager.GetMatchesOppositeTeamList();

        }

        private void GetTeams()
        {

            _dataManager.LoadTeams(_isWomens);
            _teams = _dataManager.GetTeamsList();
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
            List <Player> players = new();
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

        
        private void FillFavoriteComboBox()
        {
            cbFavoriteTeam.Items.Clear();
            var sortedTeams = _teams.OrderBy(t => t.Country).ToList();
            if (cbFavoriteTeam != null)
            {
                foreach (var team in sortedTeams)
                {
                    
                    cbFavoriteTeam.Items.Add(team);
                }
                cbFavoriteTeam.SelectedIndex = 0;
            }
           
        }

        private void FillOppositeComboBox()
        {

            cbOppositeTeam.Items.Clear();
       
            var sortedTeams = _oppositeTeams.OrderBy(t => t.Country).ToList();
            if (cbOppositeTeam != null)
            {
                foreach (var team in sortedTeams)
                {

                    cbOppositeTeam.Items.Add(team);
                }
                cbOppositeTeam.SelectedIndex = 0;
            }


        }

        private void GetOppositeTeams()
        {
            foreach (var item in _matchesOppositeTeam)
            {
                if (item.HomeTeam.Code != _favoriteFifaCode)
                {
                    var team = _teams.Where(t => t.FifaCode == item.HomeTeam.Code).FirstOrDefault();
                    if (team != null)
                    {
                        _oppositeTeams.Add(new Team { Id = team.Id, FifaCode = team.FifaCode, AlternateName = team.AlternateName, Country = team.Country, GroupId = team.GroupId, GroupLetter = team.GroupLetter });
                    }
                }
                if (item.AwayTeam.Code != _favoriteFifaCode && item.AwayTeam.Code != null)
                {
                    var team = _teams.Where(t => t.FifaCode == item.AwayTeam.Code).FirstOrDefault();
                    if (team != null)
                    {
                        _oppositeTeams.Add(new Team { Id = team.Id, FifaCode = team.FifaCode, AlternateName = team.AlternateName, Country = team.Country, GroupId = team.GroupId, GroupLetter = team.GroupLetter });
                    }
                }
            }
        }



        public event EventHandler<OverviewEventArgs> TeamOverview;
        private void Btn_Next_Click(object sender, RoutedEventArgs e)
        {
            TeamOverview?.Invoke(this, new OverviewEventArgs { FavoriteTeam= "test", OppositeTeam= "Test", Result ="Test"});
        }

        private void cbFavoriteTeam_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
            FillFavoriteTeamList();
            GetMatchesOppositeTeam();
            GetOppositeTeams();
            FillOppositeComboBox();
          
        }
    }
}

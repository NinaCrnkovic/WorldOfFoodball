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

namespace TeamTracker.UserControls
{
    /// <summary>
    /// Interaction logic for FirstEleven.xaml
    /// </summary>
    public partial class FirstEleven : UserControl
    {
        private DataManager _dataManager = new();
        private string _favoriteTeam;
        private string _oppositeTeam;
        private string _result;
        private List<FootballMatch> _matches;
        private List<Player> _favoriteFirstEleven= new();
        private List<Player> _oppositeFirstEleven = new();
        public FirstEleven(string favoriteTeam, string oppositeTeam, string result, List<FootballMatch> matches)
        {
            _favoriteTeam = favoriteTeam;
            _oppositeTeam = oppositeTeam;
            _result = result;
            _matches = matches;
            InitializeComponent();
            FillFirstElevenList();
            FillFirstElelvenPositions();
        }

        private void FillFirstElelvenPositions()
        {
            foreach (Player player in _favoriteFirstEleven)
            {
                if(player.Position == "Goalie")
                {
                    PlayerControl playerControl = new ();
                    playerControl.lblName.Content = player.Name;
                   // playerControl.imgPicture.ImageSource. = player.ImagePath;
                    spGoalieFavorite.Children.Add(playerControl);
                }
                else if (player.Position == "Defender")
                {
                    PlayerControl playerControl = new();
                    playerControl.lblName.Content = player.Name;
                    //playerControl.imgPicture.ImageSource = player.ImagePath;
                    spDefenderFavorite.Children.Add(playerControl);
                }
                else if (player.Position == "Midfield")
                {
                    PlayerControl playerControl = new();
                    playerControl.lblName.Content = player.Name;
                    //playerControl.imgPicture.ImageSource = player.ImagePath;
                    spMidfieldFavorite.Children.Add(playerControl);
                }
                else if (player.Position == "Forward")
                {
                    PlayerControl playerControl = new();
                    playerControl.lblName.Content = player.Name;
                    //playerControl.imgPicture.ImageSource = player.ImagePath;
                    spFowardFavorite.Children.Add(playerControl);
                }


            }
            foreach (Player player in _oppositeFirstEleven)
            {
                if (player.Position == "Goalie")
                {
                    PlayerControl playerControl = new();
                    playerControl.lblName.Content = player.Name;
                    //playerControl.imgPicture.ImageSource = player.ImagePath;
                    spGoalieOpposite.Children.Add(playerControl);
                }
                else if (player.Position == "Defender")
                {
                    PlayerControl playerControl = new();
                    playerControl.lblName.Content = player.Name;
                    //playerControl.imgPicture.ImageSource = player.ImagePath;
                    spDefenderOpposite.Children.Add(playerControl);
                }
                else if (player.Position == "Midfield")
                {
                    PlayerControl playerControl = new();
                    playerControl.lblName.Content = player.Name;
                    //playerControl.imgPicture.ImageSource = player.ImagePath;
                    spMidfieldOpposite.Children.Add(playerControl);
                }
                else if (player.Position == "Forward")
                {
                    PlayerControl playerControl = new();
                    playerControl.lblName.Content = player.Name;
                    //playerControl.imgPicture.ImageSource = player.ImagePath;
                    spFowardOpposite.Children.Add(playerControl);
                }


            }
        }

        private void FillFirstElevenList()
        {
            //test
            foreach (var match in _matches)
            {
                if(match.HomeTeam.Code == _favoriteTeam && match.AwayTeam.Code == _oppositeTeam)
                {
                    foreach (var startingPlayer in match.HomeTeamStatistics.StartingEleven)
                    {
                        _favoriteFirstEleven.Add(startingPlayer);
                    }
                    foreach (var startingPlayer in match.AwayTeamStatistics.StartingEleven)
                    {
                        _oppositeFirstEleven.Add(startingPlayer);
                    }
                }else if (match.HomeTeam.Code == _oppositeTeam && match.AwayTeam.Code == _favoriteTeam)
                {
                    foreach (var startingPlayer in match.HomeTeamStatistics.StartingEleven)
                    {
                        _oppositeFirstEleven.Add(startingPlayer);
                    }
                    foreach (var startingPlayer in match.AwayTeamStatistics.StartingEleven)
                    {
                        _favoriteFirstEleven.Add(startingPlayer);
                    }
                }
            }



        }
    }
}

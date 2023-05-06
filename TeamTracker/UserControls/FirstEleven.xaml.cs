using DataLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;


namespace TeamTracker.UserControls
{

    public partial class FirstEleven : UserControl
    {
     
        private string _favoriteTeam;
        private string _oppositeTeam;
        private string _result;
        private List<FootballMatch> _matches;
        private List<Player> _favoriteFirstEleven= new();
        private List<Player> _oppositeFirstEleven = new();
        private List<Player> _favoriteAllPlayers = new();
        public FirstEleven(string favoriteTeam, string oppositeTeam, string result, List<FootballMatch> matches, List<Player> favoriteAllPlayers)
        {
            _favoriteTeam = favoriteTeam;
            _oppositeTeam = oppositeTeam;
            _favoriteAllPlayers = favoriteAllPlayers;
            _result = result;
            _matches = matches;
            InitializeComponent();
            FillFirstElevenList();
            FillFirstElelvenPositions();
            FillLabels();

        }
        #region Fill methods

        private void FillLabels()
        {
            lblScore.Content = _result;

            // Pronalazi omiljeni tim
            var favoriteMatch = _matches.FirstOrDefault(m => m.HomeTeam.Code == _favoriteTeam || m.AwayTeam.Code == _favoriteTeam);
            if (favoriteMatch != null)
            {
                lblFavoriteTeam.Content = favoriteMatch.HomeTeam.Code == _favoriteTeam ? favoriteMatch.HomeTeam.Country : favoriteMatch.AwayTeam.Country;
            }

            // Pronalazi protivnički tim
            var oppositeMatch = _matches.FirstOrDefault(m => m.HomeTeam.Code == _oppositeTeam || m.AwayTeam.Code == _oppositeTeam);
            if (oppositeMatch != null)
            {
                lblOppostieTeam.Content = oppositeMatch.HomeTeam.Code == _oppositeTeam ? oppositeMatch.HomeTeam.Country : oppositeMatch.AwayTeam.Country;
            }
        }


        private void FillFirstElelvenPositions()
        {
            foreach (Player player in _favoriteFirstEleven)
            {
                if(player.Position == "Goalie")
                {
                    PlayerControl playerControl = new ();
                    playerControl.PlayerControlData += PlayerControl_PlayerControlData;
                    playerControl.lblName.Content = player.Name;
                    playerControl.lblShirtNumb.Content = player.ShirtNumber;
                    spGoalieFavorite.Children.Add(playerControl);
                }
                else if (player.Position == "Defender")
                {
                    PlayerControl playerControl = new();
                    playerControl.PlayerControlData += PlayerControl_PlayerControlData;
                    playerControl.lblName.Content = player.Name;
                    playerControl.lblShirtNumb.Content = player.ShirtNumber;
                    spDefenderFavorite.Children.Add(playerControl);
                }
                else if (player.Position == "Midfield")
                {
                    PlayerControl playerControl = new();
                    playerControl.PlayerControlData += PlayerControl_PlayerControlData;
                    playerControl.lblName.Content = player.Name;
                    playerControl.lblShirtNumb.Content = player.ShirtNumber;
                    spMidfieldFavorite.Children.Add(playerControl);
                }
                else if (player.Position == "Forward")
                {
                    PlayerControl playerControl = new();
                    playerControl.PlayerControlData += PlayerControl_PlayerControlData;
                    playerControl.lblName.Content = player.Name;
                    playerControl.lblShirtNumb.Content = player.ShirtNumber;
                    spFowardFavorite.Children.Add(playerControl);
                }


            }
            foreach (Player player in _oppositeFirstEleven)
            {
                if (player.Position == "Goalie")
                {
                    PlayerControl playerControl = new();
                    playerControl.PlayerControlData += PlayerControl_PlayerControlData;
                    playerControl.lblName.Content = player.Name;
                    playerControl.lblShirtNumb.Content = player.ShirtNumber;
                    spGoalieOpposite.Children.Add(playerControl);
                }
                else if (player.Position == "Defender")
                {
                    PlayerControl playerControl = new();
                    playerControl.PlayerControlData += PlayerControl_PlayerControlData;
                    playerControl.lblName.Content = player.Name;
                    playerControl.lblShirtNumb.Content = player.ShirtNumber;
                    spDefenderOpposite.Children.Add(playerControl);
                }
                else if (player.Position == "Midfield")
                {
                    PlayerControl playerControl = new();
                    playerControl.PlayerControlData += PlayerControl_PlayerControlData;
                    playerControl.lblName.Content = player.Name;
                    playerControl.lblShirtNumb.Content = player.ShirtNumber;
                    spMidfieldOpposite.Children.Add(playerControl);
                }
                else if (player.Position == "Forward")
                {
                    PlayerControl playerControl = new();
                    playerControl.PlayerControlData += PlayerControl_PlayerControlData;
                    playerControl.lblName.Content = player.Name;
                    playerControl.lblShirtNumb.Content = player.ShirtNumber;
                    spFowardOpposite.Children.Add(playerControl);
                }


            }
        }

        private void FillFirstElevenList()
        {

            foreach (var match in _matches)
            {
                if (match.HomeTeam.Code == _favoriteTeam && match.AwayTeam.Code == _oppositeTeam)
                {
                    foreach (var startingPlayer in match.HomeTeamStatistics.StartingEleven)
                    {
                        
                        _favoriteFirstEleven.Add(startingPlayer);
                    }
                    foreach (var startingPlayer in match.AwayTeamStatistics.StartingEleven)
                    {
                        _oppositeFirstEleven.Add(startingPlayer);
                    }
                }
                else if (match.HomeTeam.Code == _oppositeTeam && match.AwayTeam.Code == _favoriteTeam)
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


            if (_favoriteAllPlayers.Count > 0)
            {

                foreach (var player in _favoriteAllPlayers)
                {
                    foreach (var first in _favoriteFirstEleven)
                    {
                        if (player.ShirtNumber == first.ShirtNumber)
                        {
                            player.ImagePath = first.ImagePath;
                        }
                    }
                }


            }


        }

        #endregion

        #region Player info

        private void PlayerControl_PlayerControlData(object sender, EventsArgsTT.PlayerControlEventArgs e)
        {
            string name = e.Name;
            //I used the null-coalescing operator ??, which checks the first expression and if it is null, uses the second expression. This allows you to get a player from both teams in a single line of code.
            
            Player player = _favoriteFirstEleven.FirstOrDefault(t => t.Name == name) ?? _oppositeFirstEleven.FirstOrDefault(t => t.Name == name);


            PlayerInfo playerInfo = new();
            if (!string.IsNullOrEmpty(player.ImagePath))
            {
                // Stvaranje instance BitmapImage klase
      
                Image image = new();
                image.Source = new BitmapImage(new Uri(player.ImagePath, UriKind.RelativeOrAbsolute)); ;
                playerInfo.imgPicture = image;

         

            }
            else
            {
                //    //ovdje je built action postavljen na resource
                playerInfo.imgPicture.Source = new BitmapImage(new Uri("/Resources/Maradona.jpeg", UriKind.RelativeOrAbsolute));
            }


            playerInfo.lblName.Content = player.Name;
            playerInfo.lblGoals.Content = player.GoalsCount;
            playerInfo.lblShirtNum.Content = player.ShirtNumber;
            playerInfo.lblCartons.Content = player.YellowCartonCount;
            playerInfo.lblRole.Content = player.Position;
            playerInfo.lblCapitan.Content = player.Captain ? "yes" : "no";

            StartAnimation(playerInfo);

            playerInfo.ShowDialog();



        }
        private static void StartAnimation(PlayerInfo playerInfo)
        {


            // Stvaranje animacije
            DoubleAnimation animation = new DoubleAnimation();
            animation.From = 0;
            animation.To = 1;
            animation.Duration = TimeSpan.FromSeconds(3);

            // Pokretanje animacije
            playerInfo.BeginAnimation(UIElement.OpacityProperty, animation);
            Storyboard.SetTargetProperty(animation, new PropertyPath("Opacity"));

            // Create the storyboard and add the animation
            Storyboard storyboard = new Storyboard();
            storyboard.Children.Add(animation);
            storyboard.Begin(playerInfo);

            playerInfo.Loaded += (s, ea) =>
            {
                // Start the storyboard when the dialog is loaded
                storyboard.Begin(playerInfo);
            };
        }

        #endregion
    }
}

using DataLayer.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorldOfFootball.CustomDesign;

namespace WorldOfFootball.UserControls
{
    public partial class RankingLists : UserControl
    {
        private List<FootballMatch> _matches;
        private List<Player> _players;
        private string _fifaCode;
        private GoalorCarton _goalOrCarton;
        public RankingLists(List<FootballMatch> matches, List<Player> players, string fifaCode)
        {
            _matches = matches;
            _fifaCode = fifaCode;
            _players = players;


            UpdatePlayerStatisticsForCountry();
            InitializeComponent();
            
        }

        private void RankingLists_Load(object sender, EventArgs e)
        {
            LoadPanelGoalOrCard(true, pnlGoals);
            LoadPanelGoalOrCard(false, pnlCards);

        }

        

        private void LoadPanelGoalOrCard(bool isGoal, FlowLayoutPanel panel)
        {
            var sortedPlayers = _players.OrderByDescending(p => isGoal ? p.GoalsCount : p.YellowCartonCount);
            foreach (var player in sortedPlayers)
            {
                _goalOrCarton = new GoalorCarton();

                _goalOrCarton.Name = player.ShirtNumber.ToString();
                Label lblName = _goalOrCarton.Controls.Find("lblName", true).FirstOrDefault() as Label;
                lblName.Text = player.Name;
                Label lblGoals = _goalOrCarton.Controls.Find("lblGoals", true).FirstOrDefault() as Label;
                if (isGoal)
                {
                    lblGoals.Text = player.GoalsCount.ToString();
                }
                else
                {
                    lblGoals.Text = player.YellowCartonCount.ToString();
                }


                PictureBox pbGoalOrCard = _goalOrCarton.Controls.Find("pbGoalOrCard", true).FirstOrDefault() as PictureBox;
                if (isGoal)
                {
                    pbGoalOrCard.Image = Properties.Resources.goal;
                }
                else
                {
                    pbGoalOrCard.Image = Properties.Resources.yellow_card;
                }

                OvalPictureBox pbImage = _goalOrCarton.Controls.Find("opImg", true).FirstOrDefault() as OvalPictureBox;
                pbImage.Image = Image.FromFile(player.ImagePath);


                panel.Controls.Add(_goalOrCarton);
            }
        }






        private void UpdatePlayerStatisticsForCountry()
        {
            
            foreach (FootballMatch match in _matches)
            {
                UpdatePlayerStatisticsForEvents(match.HomeTeamEvents, match.HomeTeam);
                UpdatePlayerStatisticsForEvents(match.AwayTeamEvents, match.AwayTeam);
            }
        }

        private void UpdatePlayerStatisticsForEvents(List<TeamEvent> events, PlayingTeam team)
        {
            foreach (TeamEvent ev in events)
            {
                if (ev.TypeOfEvent == "goal" || ev.TypeOfEvent == "yellow-card")
                {
                    Player player = _players.FirstOrDefault(p => p.Name == ev.Player);
                    if (player != null)
                    {
                        if (ev.TypeOfEvent == "goal")
                        {
                           
                                player.GoalsCount++;
                            
                        }
                        else if (ev.TypeOfEvent == "yellow-card")
                        {
                            
                                player.YellowCartonCount++;
                            
                        }
                    }
                }
            }
        }





    }
}

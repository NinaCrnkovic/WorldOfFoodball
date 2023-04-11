using DataLayer.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
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
        private Visitors _visitors;
        private int printPages = 0;

        private List<GoalorCarton> listGoals;
        private List<GoalorCarton> listCartons;
        private string buttonName;



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
            LoadPanelVisitors();
            GetListForPrint();
            btnPrintGoals.Click += BtnPrintGoals_Click;
            btnPrintCartons.Click += BtnPrintCartons_Click;
           

        }

        private void LoadPanelVisitors()
        {
            List<FootballMatch> sortedMatches = _matches.Where(m => m.HomeTeam.Code == _fifaCode || m.AwayTeam.Code == _fifaCode).OrderByDescending(m => m.Attendance).ToList();

            int index = 1;
            foreach (var match in sortedMatches)
            {
                _visitors = new Visitors();

                _visitors.Name = match.Attendance.ToString();
                Label lblTeams = _visitors.Controls.Find("lblTeams", true).FirstOrDefault() as Label;
                lblTeams.Text = $"{match.HomeTeamCountry} : {match.AwayTeamCountry}";
                Label lblIndex = _visitors.Controls.Find("lblIndex", true).FirstOrDefault() as Label;
                lblIndex.Text = index.ToString();
                Label lblVenue = _visitors.Controls.Find("lblVenue", true).FirstOrDefault() as Label;
                lblVenue.Text = match.Venue;
                Label lblLocation = _visitors.Controls.Find("lblLocation", true).FirstOrDefault() as Label;
                lblLocation.Text = match.Location;

                Label lblVisitors = _visitors.Controls.Find("lblVisitors", true).FirstOrDefault() as Label;
                lblVisitors.Text = match.Attendance.ToString();
                pnlVisitors.Controls.Add(_visitors);
                index++;
            }

        }

        private void LoadPanelGoalOrCard(bool isGoal, FlowLayoutPanel panel)
        {
            var sortedPlayers = _players.OrderByDescending(p => isGoal ? p.GoalsCount : p.YellowCartonCount);
            int index = 1;
            foreach (var player in sortedPlayers)
            {
                _goalOrCarton = new GoalorCarton();

                _goalOrCarton.Name = player.ShirtNumber.ToString();
                Label lblName = _goalOrCarton.Controls.Find("lblName", true).FirstOrDefault() as Label;
                lblName.Text = player.Name;
                Label lblIndex = _goalOrCarton.Controls.Find("lblIndex", true).FirstOrDefault() as Label;
                lblIndex.Text = index.ToString();
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
                index++;
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





      

        private void BtnPrintGoals_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            buttonName = clickedButton.Name;
             
            printPreviewDialog.ShowDialog();
        }

        private void BtnPrintCartons_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            buttonName = clickedButton.Name;

            printPreviewDialog.ShowDialog();
        }

        private void GetListForPrint()
        {
            
            listGoals = new List<GoalorCarton>();

             foreach (GoalorCarton goalorCarton in pnlGoals.Controls.OfType<GoalorCarton>())
             {
                    listGoals.Add(goalorCarton);
             }
           

             listCartons = new List<GoalorCarton>();

             foreach (GoalorCarton goalorCarton in pnlCards.Controls.OfType<GoalorCarton>())
             {
                    listCartons.Add(goalorCarton);
             }
            
            
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            var list = new List <GoalorCarton>();
            if (buttonName == "btnPrintGoals")
            {
                list = listGoals;

              
            }
            else if (buttonName == "btnPrintCartons")
            {
                list = listCartons;

            }
            float dpiX = e.Graphics.DpiX;
            float dpiY = e.Graphics.DpiY;
            RectangleF bounds = e.PageSettings.PrintableArea;
            bounds.X = bounds.X * dpiX / 100;
            bounds.Y = bounds.Y * dpiY / 100;
            bounds.Width = bounds.Width * dpiX / 100;
            bounds.Height = bounds.Height * dpiY / 100;

            int controlsPerPage = 13;
            int currentControlIndex = printPages * controlsPerPage;
            int controlsOnThisPage = 0;
            float top = bounds.Top;

            // Loop through each control that will fit on the current page
            float y = top;

            while (currentControlIndex < list.Count &&
                    y + listGoals[currentControlIndex].Height + list[currentControlIndex].Margin.Vertical <= top + bounds.Height &&
                    controlsOnThisPage < controlsPerPage)
            {
                // Get the current control
                Control control = list[currentControlIndex];

                // Draw the control to the page
                Bitmap bitmap = new Bitmap(control.Width, control.Height);
                control.DrawToBitmap(bitmap, control.ClientRectangle);
                e.Graphics.DrawImage(bitmap, bounds.Left + control.Margin.Left, y + control.Margin.Top);

                // Update the vertical position for the next control
                y += control.Height + control.Margin.Vertical;

                // Move to the next control
                currentControlIndex++;
                controlsOnThisPage++;
            }

            // If there are more controls to print, set the HasMorePages property to true
            // and move to the next page
            if (currentControlIndex < list.Count)
            {
                e.HasMorePages = true;
                printPages++;
            }
            else
            {
                e.HasMorePages = false;
                printPages = 0;
            }
        }



        private void PrintDocument_EndPrint(object sender, PrintEventArgs e)
            {

            }
        }
    } 
    


        
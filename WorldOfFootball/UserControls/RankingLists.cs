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

namespace WorldOfFootball.UserControls
{
    public partial class RankingLists : UserControl
    {
        private List<FootballMatch> _matches;
        private List<Player> _players;
        private string _fifaCode;
        public RankingLists(List<FootballMatch> matches, List<Player> players, string fifaCode)
        {
            _matches = matches;
            _fifaCode = fifaCode;
            _players = players;
            

            InitializeComponent();
            UpdatePlayerStatisticsForCountry();
        }

        private void RankingLists_Load(object sender, EventArgs e)
        {

           
            // Set up the columns in the DataGridView
            dgRankings.AutoGenerateColumns = false;
            //dgRankings.Columns.Add(new DataGridViewImageColumn { Name = "Image", HeaderText = "Image", DataPropertyName = "ImagePath" });
            

            dgRankings.Columns.Add(new DataGridViewTextBoxColumn { Name = "Name", HeaderText = "Name", DataPropertyName = "Name" });
            dgRankings.Columns.Add(new DataGridViewTextBoxColumn { Name = "Goals", HeaderText = "Goals", DataPropertyName = "GoalsCount" });

            // Set the DataSource of the DataGridView to the list of players

            dgRankings.CellFormatting += dgRankings_CellFormatting;
            dgRankings.DataSource = _players;
        

        }


        private void dgRankings_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dgRankings.Columns["Image"].Index && e.Value != null)
            {
                string imagePath = e.Value.ToString();
                if (!string.IsNullOrEmpty(imagePath))
                {
                    Image image = Image.FromFile(imagePath);
                    e.Value = new Bitmap(image, new Size(100, 100)); // postavljamo veličinu slike na 50x50
                    e.FormattingApplied = true;

                    // postaviti svojstva slike
                    dgRankings.Columns["Image"].DefaultCellStyle.NullValue = null;
                    dgRankings.Columns["Image"].Width = 50;
                  
                    dgRankings.Columns["Image"].DefaultCellStyle.Padding = new Padding(3);
                    dgRankings.Columns["Image"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dgRankings.Columns["Image"].DefaultCellStyle.NullValue = null;
                    dgRankings.Columns["Image"].DefaultCellStyle.BackColor = Color.White;
                    dgRankings.Columns["Image"].DefaultCellStyle.SelectionBackColor = Color.White;
                    dgRankings.Columns["Image"].DefaultCellStyle.SelectionForeColor = Color.Black;
                    ((DataGridViewImageColumn)dgRankings.Columns["Image"]).ImageLayout = DataGridViewImageCellLayout.Stretch;
                }
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

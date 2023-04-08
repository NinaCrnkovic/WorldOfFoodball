using DataLayer.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorldOfFootball.UserControls
{
    public partial class FavoritePlayers : UserControl
    {
       
        private List<FootballMatch> _matches;
        private string _fifaCode;
        public FavoritePlayers(List<FootballMatch> matches, string fifaCode)
        {
            InitializeComponent();
            _matches = matches;
            _fifaCode = fifaCode;   
            FillAllPlayersPanel();
            
        }

        private void FillAllPlayersPanel()
        {
            
            FootballMatch matchWithCode = null;
            foreach (var item in _matches)
            {
                if (item.AwayTeam.Code == _fifaCode)
                {
                    matchWithCode = item;
                    break;
                }
            }
            List<Player> playerList = new List<Player>();
            if (matchWithCode != null)
            {
                              
                foreach (var startingPlayer in matchWithCode.AwayTeamStatistics.StartingEleven)
                {
                    playerList.Add(startingPlayer);
                }
                foreach (var substiturePlayer in matchWithCode.AwayTeamStatistics.Substitutes)
                {
                    playerList.Add(substiturePlayer);
                }
            }
            else
            {
                Console.WriteLine($"No matches found with FIFA code {_fifaCode}");
            }

            

          

                LoadPlayerFormLabel(playerList);
                //lbl.MouseDown += NewLabel_MouseDown;
                //lbl.MouseMove += Lbl_MouseMove;
                //pnlAllPlayers.Controls.Add(lbl);

            

        }

        private void LoadPlayerFormLabel(List<Player> players)
        {
            foreach (var player in players)
            {
                PlayerForm playerForm = new PlayerForm();
                Label lblName = playerForm.Controls.Find("lblName", true).FirstOrDefault() as Label;
                lblName.Text = player.Name;
                Label lblNumber = playerForm.Controls.Find("lblNumber", true).FirstOrDefault() as Label;
                lblNumber.Text = player.ShirtNumber.ToString();
                Label lblPosition = playerForm.Controls.Find("lblPosition", true).FirstOrDefault() as Label;
                lblPosition.Text = player.Position;
                PictureBox pbCapitan = playerForm.Controls.Find("pbCapitan", true).FirstOrDefault() as PictureBox;
                if (player.Captain)
                {
                    pbCapitan.Visible = true;
                }
                else
                {
                    pbCapitan.Visible = false;
                }
                
                pnlAllPlayers.Controls.Add(playerForm);
            }
            //var label = new Label
            //{
            //    Text = $"{pl.Name}",
            //    AutoSize = false,
            //    Size = size,
            //    BackColor = Color.FromArgb(15, 76, 117),
            //    ForeColor = Color.WhiteSmoke,
            //    TextAlign = ContentAlignment.MiddleCenter,
            //    Margin = new Padding(3),
            //    Anchor = AnchorStyles.None,
            //    Tag = pl.Name
            //};


            
        }
    }
}

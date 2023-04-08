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
                PictureBox pbStar = playerForm.Controls.Find("pbStar", true).FirstOrDefault() as PictureBox;
                pbStar.Visible = false;
                playerForm.MouseMove += PlayerForm_MouseMove;

                pnlAllPlayers.Controls.Add(playerForm);
            }
                        
        }

        private void PlayerForm_MouseMove(object sender, MouseEventArgs e)
        {
            PlayerForm player = sender as PlayerForm;
            player?.DoDragDrop(player, DragDropEffects.Move);
        }

        private void PnlFavoritePlayers_DragDrop(object sender, DragEventArgs e)
        {
            PlayerForm draggedPlayer = e.Data?.GetData(typeof(PlayerForm)) as PlayerForm;
            if (draggedPlayer != null)
            {
                PlayerForm newPlayer = AddNewPlayerForm(draggedPlayer);
                Point mouseLocation = MousePosition;
                mouseLocation = pnlFavoritePlayers.PointToClient(mouseLocation);
                newPlayer.Location = mouseLocation;
                pnlFavoritePlayers.Controls.Add(newPlayer);
                pnlAllPlayers.Controls?.Remove(draggedPlayer);
            }
           

        }

        private PlayerForm AddNewPlayerForm(PlayerForm draggedPlayer)
        {
            PlayerForm newPlayer = new PlayerForm();

            Label lblName = newPlayer.Controls.Find("lblName", true).FirstOrDefault() as Label;
            lblName.Text = draggedPlayer.Controls.Find("lblName", true).FirstOrDefault().Text;
            Label lblNumber = newPlayer.Controls.Find("lblNumber", true).FirstOrDefault() as Label;
            lblNumber.Text = draggedPlayer.Controls.Find("lblNumber", true).FirstOrDefault().Text;
            Label lblPosition = newPlayer.Controls.Find("lblPosition", true).FirstOrDefault() as Label;
            lblPosition.Text = draggedPlayer.Controls.Find("lblPosition", true).FirstOrDefault().Text;
            PictureBox pbCapitan = newPlayer.Controls.Find("pbCapitan", true).FirstOrDefault() as PictureBox;
            pbCapitan.Visible = draggedPlayer.Controls.Find("pbCapitan", true).FirstOrDefault().Visible;
            PictureBox pbStar = newPlayer.Controls.Find("pbStar", true).FirstOrDefault() as PictureBox;
            pbStar.Visible = true;

            return newPlayer;

        }

        private void PnlFavoritePlayers_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }


      
    }
}

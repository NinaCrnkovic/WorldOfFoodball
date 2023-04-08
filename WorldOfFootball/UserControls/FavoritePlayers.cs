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
            List<Player> playerList = new List<Player>();
            foreach (var item in _matches)
            {
                if(item.AwayTeam.Code == _fifaCode)
                {
                    foreach(var startingPlayer in item.AwayTeamStatistics.StartingEleven)
                    {
                        playerList.Add(startingPlayer);
                    }
                    foreach (var substiturePlayer in item.AwayTeamStatistics.Substitutes)
                    {
                        playerList.Add(substiturePlayer);
                    }
                }
            }
            foreach(var player in playerList)
            {
                listBox1.Items.Add(player.Name);
            }

        }
    }
}

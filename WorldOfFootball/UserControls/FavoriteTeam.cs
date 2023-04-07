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
    public partial class FavoriteTeam : UserControl
    {
        private List<Team> _teams;
        public FavoriteTeam(List<Team>teams)
        {
            InitializeComponent();
            _teams = teams;
            FillComboBox();
          
        }

        private void FillComboBox()
        {
            var sortedTeams = _teams.OrderBy(t => t.Country).ToList();
            if (cbTeams != null)
            {
                foreach (var team in sortedTeams)
                {
                    cbTeams.Items.Add(team.Country);
                }
                cbTeams.SelectedIndex = 0;
            }
         
        }
    }
}

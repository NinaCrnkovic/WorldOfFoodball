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
using WorldOfFootball.EventsAndArgs;

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
            btnNextFavTeam.Click += btnNextFavTeam_Click;
        }

        public event EventHandler<FavoriteTeamEventArgs> FavoriteTeamSelected;
        private void btnNextFavTeam_Click(object sender, EventArgs e)
        {
            string selectedCountry = cbTeams.SelectedItem.ToString();
            string fifaCode = selectedCountry.Substring(selectedCountry.IndexOf("(") + 1, 3);
            var selectedTeam = _teams.Find(t => t.FifaCode == fifaCode);
      
            if (selectedTeam != null){
                MessageBox.Show(selectedTeam.Country);
                FavoriteTeamSelected?.Invoke(this, new FavoriteTeamEventArgs { favoriteTeam = new Team
                {
                    Id = selectedTeam.Id,
                    Country = selectedTeam.Country,
                    AlternateName = selectedTeam.AlternateName,
                    FifaCode = selectedTeam.FifaCode,
                    GroupId = selectedTeam.GroupId,
                    GroupLetter = selectedTeam.GroupLetter
                } 
                });
              
            }
            else
            {
                // Bacanje greške ako nijedan radio button nije odabran
                MessageBox.Show("Niste izabrali omiljeni tim");
            }
        }

        private void FillComboBox()
        {
            cbTeams.Items.Clear();
            var sortedTeams = _teams.OrderBy(t => t.Country).ToList();
            cbTeams.Items.Add("Izaberite tim");
            if (cbTeams != null)
            {
                foreach (var team in sortedTeams)
                {
                    cbTeams.Items.Add(team);
                }
                cbTeams.SelectedIndex = 0;
            }
         
        }
    }
}

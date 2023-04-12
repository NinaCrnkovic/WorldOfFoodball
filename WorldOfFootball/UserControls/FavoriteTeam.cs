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
using WorldOfFootball.EventsAndArgs;

namespace WorldOfFootball.UserControls
{
    public partial class FavoriteTeam : UserControl
    {
        private List<Team> _teams;
        private string _language;
        public FavoriteTeam(List<Team>teams, string language)
        {
            InitializeComponent();
            _teams = teams;
            _language = language;   
            FillComboBox();
            btnNextFavTeam.Click += btnNextFavTeam_Click;
        }

        #region Events
        public event EventHandler<FavoriteTeamEventArgs> FavoriteTeamSelected;
        private void btnNextFavTeam_Click(object sender, EventArgs e)
        {
            string selectedCountry = cbTeams.SelectedItem.ToString();
            string fifaCode = selectedCountry.Substring(selectedCountry.IndexOf("(") + 1, 3);
            var selectedTeam = _teams.Find(t => t.FifaCode == fifaCode);
      
            if (selectedTeam != null){
            
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
                CallFaworiteTeamMessage();
            }
        }

       

        #endregion

        #region Methods
        private void FillComboBox()
        {
            cbTeams.Items.Clear();
            var sortedTeams = _teams.OrderBy(t => t.Country).ToList();
            if (_language == "hr")
            {
                cbTeams.Items.Add(Properties.Resources.chooseTeamHr);
            }
            else
            {
                cbTeams.Items.Add(Properties.Resources.chooseTeamEn);
            }
          
            if (cbTeams != null)
            {
                foreach (var team in sortedTeams)
                {
                    cbTeams.Items.Add(team);
                }
                cbTeams.SelectedIndex = 0;
            }
         
        }

        private void CallFaworiteTeamMessage()
        {
            string message = "";
            string warning = "";

            if (_language == "en")
            {
                message = Properties.Resources.messageFavoriteTeamEn;
                warning = Properties.Resources.messageWarningEn;

            }
            else if (_language == "hr")
            {
                message = Properties.Resources.messageFavoriteTeamHr;
                warning = Properties.Resources.messageWarningHr;
            }
            // Bacanje greške ako nijedan radio button nije odabran
            CustomMessageBox.Show(message, warning, MessageBoxButtons.OK, _language);
        }

        #endregion
    }
}

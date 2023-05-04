using DataLayer.Model;
using System.Data;
using WorldOfFootball.CustomDesign;
using WorldOfFootball.EventsAndArgs;

namespace WorldOfFootball.UserControls
{
    public partial class FavoriteTeam : UserControl
    {
        private List<Team> _teams;
        private string _language;
        private string _fifaCode;
        public FavoriteTeam(List<Team>teams, string language, string fifaCode)
        {
            InitializeComponent();
            _teams = teams;
            _language = language;   
            _fifaCode = fifaCode;   
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
                if (_fifaCode == null)
                {
                    cbTeams.SelectedIndex = 0;
                }
                else
                {
                    foreach (var item in cbTeams.Items)
                    {
                        var code = item.ToString().Substring(item.ToString().IndexOf("(") + 1, 3);
                        if (code == _fifaCode)
                        {
                            int index = cbTeams.Items.IndexOf(item);
                            cbTeams.SelectedIndex = index;
                            break; 
                        }
                    }
                }
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

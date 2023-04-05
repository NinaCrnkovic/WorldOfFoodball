using DataLayer.Model;

namespace WorldOfFoodbal
{
    public partial class MainForm : Form
    {
        private DataManager _dataManager = new DataManager();
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _dataManager.LoadTeamsToDictionary(false);


            IDictionary<long, Team> teams = _dataManager.GetTeamDictionary();
            foreach (var team in teams.Values)
            {
                lbTeams.Items.Add(team.Country); // Dodajte vrijednost u list box
            }
        }

        
    }
}
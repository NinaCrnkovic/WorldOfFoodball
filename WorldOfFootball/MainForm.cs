using DataLayer.Model;
using WorldOfFootball.UserControls;

namespace WorldOfFootball
{
    public partial class MainForm : Form
    {
        private DataManager _dataManager = new DataManager();
        private TitleForm titleForm;
        public MainForm()
        {
            CallTitleForm();
            InitializeComponent();


        }

        private void CallTitleForm()
        {
            titleForm = new TitleForm();
            this.Controls.Add(titleForm);
            titleForm.BringToFront();

            // Stvori novi timer sa vremenom kašnjenja od 15 sekundi
            System.Windows.Forms.Timer timer = new ();
            timer.Interval = 1500;
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Zaustavi timer
            ((System.Windows.Forms.Timer)sender).Stop();

            // Ukloni TitleForm iz glavne forme
            this.Controls.Remove(titleForm);

            // Oslobodi resurse
            titleForm.Dispose();
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
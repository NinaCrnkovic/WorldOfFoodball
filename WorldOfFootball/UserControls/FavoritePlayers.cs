using DataLayer.Model;
using WorldOfFootball.CustomDesign;
using WorldOfFootball.EventsAndArgs;

namespace WorldOfFootball.UserControls
{
    public partial class FavoritePlayers : UserControl
    {

        private List<FootballMatch> _matches;
        private string _fifaCode;
        private PlayerForm _playerForm;
        private List<Player> _players;
        private List<Player> _favoritePlayers;
        private List<Player> _notFavoritePlayers;

        private string _teamName;
        private string _language;
        private const string PATH = "..//..//..//..//TeamTracker//Resources//";
        private const string FILTER = "Slike|*.jpg;*.jpeg;*.png;*.bmp|Sve datoteke|*.*";
        public FavoritePlayers(List<FootballMatch> matches, string fifaCode, string language, List<Player> favoritePlayers, List<Player> notFavoriePlayer)
        {
            InitializeComponent();
            _matches = matches;
            _fifaCode = fifaCode;
            _language = language;   
            _favoritePlayers = favoritePlayers;
            _notFavoritePlayers = notFavoriePlayer;
      


        }

        private void FavoritePlayers_Load(object sender, EventArgs e)
        {
           
        
            if (_favoritePlayers != null && _notFavoritePlayers !=null)
            {
                var match = _matches.FirstOrDefault(m => m.AwayTeam.Code == _fifaCode);
                if (match != null)
                {
                    _teamName = match.AwayTeam.Country;
                }
                _players = _favoritePlayers.Concat(_notFavoritePlayers).ToList();
                LoadPlayerFormLabel(_notFavoritePlayers, pnlAllPlayers);
                LoadPlayerFormLabel(_favoritePlayers, pnlFavoritePlayers);
            }
            else
            {
                LoadPlayerListFromMatches();
                LoadPlayerFormLabel(_players, pnlAllPlayers);
            }
        
            SetCountryNameOnLabel();
            btnNextFavTeam.Click += BtnNextFavTeam_Click;

        }
        #region Events on buttons


        public event EventHandler<FavoritePlayersTeamEventArgs> FavoritePlayersList;

        private void BtnNextFavTeam_Click(object sender, EventArgs e)
        {
            List<Player> favoritePlayers = GetListOfFavoritePlayers();

            if (favoritePlayers.Count < 3)
            {
                CallMessageMustHaveFavorite();
                return;
            }

            List<Player> notFavoritePlayers = GetListOfNotFavoritePlayers();

            FavoritePlayersTeamEventArgs args = new FavoritePlayersTeamEventArgs()
            {
                FavoritePlayersList = new List<Player>(favoritePlayers),
                NotFavoritePlayersList = new List<Player>(notFavoritePlayers),
                AllPlayers = new List<Player>(_players),
                FifaCodeFavCountry = _fifaCode
            };

            FavoritePlayersList?.Invoke(this, args);
        }

        

        private void BtnChangeImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = FILTER;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = Path.GetFileName(openFileDialog.FileName);
                string newPath = Path.Combine(PATH, fileName);
                string newTTPath = fileName;
                File.Copy(openFileDialog.FileName, newPath, true);

                // Pronalazimo kontrolu koja je pokrenula događaj
                Button clickedBtn = (Button)sender;
                PlayerForm clickedPlayerForm = (PlayerForm)clickedBtn.Parent;
                if (clickedPlayerForm == null)
                {
                    return;
                }
                OvalPictureBox pbImage = clickedPlayerForm.Controls.Find("pbImage", true).FirstOrDefault() as OvalPictureBox;
                pbImage.Image = new Bitmap(openFileDialog.FileName);
                // Get the shirt number of the player from the player form's Name property
                var shirtNumber = int.Parse(clickedPlayerForm.Name);
                var player = _players.FirstOrDefault(p => p.ShirtNumber == shirtNumber);
                if (player == null)
                {
                    return;
                }
                player.ImagePath = newPath;
                player.ImageTTPath = newTTPath;
            }


        }

        private void PbMoveToAllPlayers_Click(object sender, EventArgs e)
        {
            List<PlayerForm> selectedPlayers = new List<PlayerForm>();
            foreach (PlayerForm playerForm in pnlFavoritePlayers.Controls)
            {
                if (playerForm.IsSelected)
                {
                    selectedPlayers.Add(playerForm);
                }
            }
            foreach (PlayerForm playerForm in selectedPlayers)
            {
                bool isPlayerAlreadyAdded = IsPlayerAdded(playerForm, pnlAllPlayers);
                if (!isPlayerAlreadyAdded)
                {
                    AddPlayer(playerForm, pnlAllPlayers, pnlFavoritePlayers);
                }
            }
        }

        

        private void PbMoveToFavoritePlayers_Click(object sender, EventArgs e)
        {
            List<PlayerForm> selectedPlayers = new List<PlayerForm>();
            foreach (PlayerForm playerForm in pnlAllPlayers.Controls)
            {
                if (playerForm.IsSelected)
                {
                    selectedPlayers.Add(playerForm);
                }
            }

            foreach (PlayerForm playerForm in selectedPlayers)
            {
                bool isPlayerAlreadyAdded = IsPlayerAdded(playerForm, pnlFavoritePlayers);
                if (!isPlayerAlreadyAdded)
                {
                    if (pnlFavoritePlayers.Controls.Count < 3)
                    {
                        AddPlayer(playerForm, pnlFavoritePlayers, pnlAllPlayers);

                    }
                    else
                    {
                        CallMessageOnly3Players();

                    }
                }
            }

        }

        
        #endregion

        #region Methods for lists
        private List<Player> GetListOfNotFavoritePlayers()
        {
            List<Player> allPlayers = new List<Player>();
            foreach (Control control in pnlAllPlayers.Controls)
            {
                if (control is PlayerForm playerForm)
                {
                    Player player = new Player();
                    player = _players.First(p => control.Name == p.ShirtNumber.ToString());
                    allPlayers.Add(player);
                }
            }

            return allPlayers;
        }

        private List<Player> GetListOfFavoritePlayers()
        {
            List<Player> favoritePlayers = new List<Player>();
            foreach (Control control in pnlFavoritePlayers.Controls)
            {
                if (control is PlayerForm playerForm)
                {
                    Player player = new Player();
                    player = _players.First(p => control.Name == p.ShirtNumber.ToString());
                    favoritePlayers.Add(player);
                }
            }

            return favoritePlayers;
        }
        #endregion

        #region Methods for labels and panels

        private void LoadPlayerListFromMatches()
        {

            FootballMatch matchWithCode = null;
            foreach (var item in _matches)
            {
                if (item.AwayTeam.Code == _fifaCode)
                {
                    _teamName = item.AwayTeam.Country;
                    matchWithCode = item;
                    break;
                }
            }
            _players = new List<Player>();
            if (matchWithCode != null)
            {

                foreach (var startingPlayer in matchWithCode.AwayTeamStatistics.StartingEleven)
                {
                    _players.Add(startingPlayer);
                }
                foreach (var substiturePlayer in matchWithCode.AwayTeamStatistics.Substitutes)
                {
                    _players.Add(substiturePlayer);
                }
            }
            else
            {
                Console.WriteLine($"No matches found with FIFA code {_fifaCode}");
            }

          

        }

        private void LoadPlayerFormLabel(List<Player> players, FlowLayoutPanel panel)
        {
            foreach (var player in players)
            {
                _playerForm = new PlayerForm();

                _playerForm.Name = player.ShirtNumber.ToString();
                Label lblName = _playerForm.Controls.Find("lblName", true).FirstOrDefault() as Label;
                lblName.Text = player.Name;
                Label lblNumber = _playerForm.Controls.Find("lblNumber", true).FirstOrDefault() as Label;
                lblNumber.Text = player.ShirtNumber.ToString();
                Label lblPosition = _playerForm.Controls.Find("lblPosition", true).FirstOrDefault() as Label;
                lblPosition.Text = player.Position;
                PictureBox pbCapitan = _playerForm.Controls.Find("pbCapitan", true).FirstOrDefault() as PictureBox;
                if (player.Captain)
                {
                    pbCapitan.Visible = true;
                }
                else
                {
                    pbCapitan.Visible = false;
                }
                PictureBox pbStar = _playerForm.Controls.Find("pbStar", true).FirstOrDefault() as PictureBox;
                if (panel == pnlFavoritePlayers)
                {
                    pbStar.Visible = true;
                }
                else
                {
                    pbStar.Visible = false;
                }
               
                OvalPictureBox pbImage = _playerForm.Controls.Find("pbImage", true).FirstOrDefault() as OvalPictureBox;
                pbImage.Image = Image.FromFile(player.ImagePath);
              
                Button btnPicture = _playerForm.Controls.Find("btnPicture", true).FirstOrDefault() as Button;
                btnPicture.Click += BtnChangeImage_Click;

                _playerForm.MouseDown += PlayerForm_MouseMove;
                panel.Controls.Add(_playerForm);
            }

        }


        private void SetCountryNameOnLabel()
        {
            lblAllPlayers.Text = $"{lblAllPlayers.Text} - {_teamName}";
            lblFavoritePlayers.Text = $"{lblFavoritePlayers.Text} - {_teamName}";
        }

        private void AddPlayer(PlayerForm draggedPlayer, FlowLayoutPanel addToPnl,
          FlowLayoutPanel removeFromPnl)
        {
            PlayerForm newPlayer = AddNewPlayerForm(draggedPlayer);
            Point mouseLocation = MousePosition;
            mouseLocation = addToPnl.PointToClient(mouseLocation);
            newPlayer.Location = mouseLocation;
            newPlayer.MouseDown += PlayerForm_MouseMove;
            addToPnl.Controls.Add(newPlayer);
            removeFromPnl.Controls?.Remove(draggedPlayer);
        }

        

        private bool IsPlayerAdded(PlayerForm draggedPlayer, FlowLayoutPanel panel)
        {
            bool isPlayerAlreadyAdded = false;
            foreach (PlayerForm player in panel.Controls)
            {
                if (player.Name == draggedPlayer.Name)
                {
                    isPlayerAlreadyAdded = true;
                    break;
                }
            }

            return isPlayerAlreadyAdded;
        }

        private PlayerForm AddNewPlayerForm(PlayerForm draggedPlayer)
        {
            PlayerForm newPlayer = new PlayerForm();
            newPlayer.Name = draggedPlayer.Name;
            Label lblName = newPlayer.Controls.Find("lblName", true).FirstOrDefault() as Label;
            lblName.Text = draggedPlayer.Controls.Find("lblName", true).FirstOrDefault().Text;
            Label lblNumber = newPlayer.Controls.Find("lblNumber", true).FirstOrDefault() as Label;
            lblNumber.Text = draggedPlayer.Controls.Find("lblNumber", true).FirstOrDefault().Text;
            Label lblPosition = newPlayer.Controls.Find("lblPosition", true).FirstOrDefault() as Label;
            lblPosition.Text = draggedPlayer.Controls.Find("lblPosition", true).FirstOrDefault().Text;
            PictureBox pbCapitan = newPlayer.Controls.Find("pbCapitan", true).FirstOrDefault() as PictureBox;
            pbCapitan.Visible = draggedPlayer.Controls.Find("pbCapitan", true).FirstOrDefault().Visible;
            PictureBox pbStar = newPlayer.Controls.Find("pbStar", true).FirstOrDefault() as PictureBox;
            if (pbStar.Visible == draggedPlayer.Controls.Find("pbStar", true).FirstOrDefault().Visible)
            {
                pbStar.Visible = false;
            }
            else
            {
                pbStar.Visible = true;
            }
            OvalPictureBox pbImage = newPlayer.Controls.Find("pbImage", true).FirstOrDefault() as OvalPictureBox;
            pbImage.Image = draggedPlayer.Controls.OfType<PictureBox>().FirstOrDefault()?.Image;


            Button btnPicture = _playerForm.Controls.Find("btnPicture", true).FirstOrDefault() as Button;
            btnPicture.Click += BtnChangeImage_Click;

            return newPlayer;

        }


    

    #endregion

        #region Drag and drop


    private void PlayerForm_MouseMove(object sender, MouseEventArgs e)
        {
            PlayerForm player = sender as PlayerForm;
            player?.DoDragDrop(player, DragDropEffects.Move);

            player.IsSelected = !player.IsSelected;
            if (player.IsSelected)
            {
                player.BackColor = Color.FromArgb(50, 130, 184);
            }
            else
            {
                player.BackColor = Color.FromArgb(15, 76, 117);
            }
        }



        private void PnlFavoritePlayers_DragDrop(object sender, DragEventArgs e)
        {
            List<PlayerForm> selectedPlayers = new List<PlayerForm>();
            foreach (PlayerForm playerForm in pnlAllPlayers.Controls)
            {
                if (playerForm.IsSelected)
                {
                    selectedPlayers.Add(playerForm);
                }
            }

            PlayerForm draggedPlayer = e.Data?.GetData(typeof(PlayerForm)) as PlayerForm;
            if (draggedPlayer != null)
            {
                foreach (PlayerForm playerForm in selectedPlayers)
                {
                    bool isPlayerAlreadyAdded = IsPlayerAdded(playerForm, pnlFavoritePlayers);
                    if (!isPlayerAlreadyAdded)
                    {
                        if (pnlFavoritePlayers.Controls.Count < 3)
                        {
                            AddPlayer(playerForm, pnlFavoritePlayers, pnlAllPlayers);

                        }
                        else
                        {
                            CallMessageOnly3Players();

                        }
                    }
                }


            }

        }


        private void PnlFavoritePlayers_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }



        private void PnlAllPlayers_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void PnlAllPlayers_DragDrop(object sender, DragEventArgs e)
        {
            List<PlayerForm> selectedPlayers = new List<PlayerForm>();
            foreach (PlayerForm playerForm in pnlFavoritePlayers.Controls)
            {
                if (playerForm.IsSelected)
                {
                    selectedPlayers.Add(playerForm);
                }
            }

            PlayerForm draggedPlayer = e.Data?.GetData(typeof(PlayerForm)) as PlayerForm;
            if (draggedPlayer != null)
            {
              
                foreach (PlayerForm playerForm in selectedPlayers)
                {
                    bool isPlayerAlreadyAdded = IsPlayerAdded(playerForm, pnlAllPlayers);
                    if (!isPlayerAlreadyAdded)
                    {
                        AddPlayer(playerForm, pnlAllPlayers, pnlFavoritePlayers);
                    }
                }
            }
        }
        #endregion

        #region Messagebox callings
        private void CallMessageOnly3Players()
        {
            string message = "";
            string warning = "";

            if (_language == "hr")
            {
                message = Properties.Resources.messageWarningOnly3Hr;
                warning = Properties.Resources.messageWarningHr;
            }
            else
            {
                message = Properties.Resources.messageWarningOnly3Hr;
                warning = Properties.Resources.messageWarningEn;

            }

            var result = CustomMessageBox.Show(message, warning, MessageBoxButtons.OK, _language);
        }

        private void CallMessageMustHaveFavorite()
        {
            string message = "";
            string warning = "";

            if (_language == "hr")
            {
                message = Properties.Resources.messageWarningFavPlNotChosenHr;
                warning = Properties.Resources.messageWarningHr;
            }
            else
            {
                message = Properties.Resources.messageWarningFavPlNotChosenEn;
                warning = Properties.Resources.messageWarningEn;

            }

            CustomMessageBox.Show(message, warning, MessageBoxButtons.OK, _language);
        }

        #endregion

        
    }

}

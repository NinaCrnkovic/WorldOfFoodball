using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace TeamTracker
{
      public partial class CountryInfo : Window
    {
        public string TeamName
        {
            get { return lblName.Content.ToString(); }
            set { lblName.Content = value; }
        }

        public string FifaCode
        {
            get { return lblFifaCode.Content.ToString(); }
            set { lblFifaCode.Content = value; }
        }

        public int GamesPlayed
        {
            get { return int.Parse(lblGamesPlayed.Content.ToString()); }
            set { lblGamesPlayed.Content = value.ToString(); }
        }

        public int Wins
        {
            get { return int.Parse(lblWins.Content.ToString()); }
            set { lblWins.Content = value.ToString(); }
        }

        public int Losses
        {
            get { return int.Parse(lblLoses.Content.ToString()); }
            set { lblLoses.Content = value.ToString(); }
        }

        public int Draws
        {
            get { return int.Parse(lblDraws.Content.ToString()); }
            set { lblDraws.Content = value.ToString(); }
        }

        public int GoalsFor
        {
            get { return int.Parse(lblGoalsFor.Content.ToString()); }
            set { lblGoalsFor.Content = value.ToString(); }
        }

        public int GoalsAgainst
        {
            get { return int.Parse(lblGoalsAgainst.Content.ToString()); }
            set { lblGoalsAgainst.Content = value.ToString(); }
        }

        public int GoalDifferential
        {
            get { return int.Parse(lblGoalDifferential.Content.ToString()); }
            set { lblGoalDifferential.Content = value.ToString(); }
        }
        public CountryInfo()
        {
            InitializeComponent();
        }
    }
}

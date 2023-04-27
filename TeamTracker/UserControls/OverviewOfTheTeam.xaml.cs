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
using System.Windows.Navigation;
using System.Windows.Shapes;
using TeamTracker.EventsArgsTT;

namespace TeamTracker.UserControls
{
    /// <summary>
    /// Interaction logic for OverviewOfTheTeam.xaml
    /// </summary>
    public partial class OverviewOfTheTeam : UserControl
    {
        public OverviewOfTheTeam()
        {
            InitializeComponent();
        }

        public event EventHandler<OverviewEventArgs> TeamOverview;
        private void Btn_Next_Click(object sender, RoutedEventArgs e)
        {
            TeamOverview?.Invoke(this, new OverviewEventArgs { FavoriteTeam= "test", OppositeTeam= "Test", Result ="Test"});
        }
    }
}

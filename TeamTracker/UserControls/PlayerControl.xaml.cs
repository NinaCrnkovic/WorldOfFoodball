using DataLayer.Model;
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

namespace TeamTracker.UserControls
{
    /// <summary>
    /// Interaction logic for Player.xaml
    /// </summary>
    public partial class PlayerControl : UserControl
    {
        public PlayerControl()
        {
            InitializeComponent();
        }

        private void grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Player player = e.OriginalSource as Player;
            PlayerInfo playerInfo = new PlayerInfo();
            playerInfo.lblName.Content = player.Name;
            playerInfo.lblGoals.Content = player.GoalsCount.ToString();
            playerInfo.lblShirtNum.Content = player.ShirtNumber.ToString();
            playerInfo.lblCartons.Content = player.YellowCartonCount.ToString();
            playerInfo.lblRole.Content = player.Position;
            playerInfo.lblCapitan.Content = player.Captain ? "yes" : "no";  
            playerInfo.ShowDialog();
        }
    }
}

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
    /// Interaction logic for InitialSettings.xaml
    /// </summary>
    public partial class InitialSettings : UserControl
    {
        public InitialSettings()
        {
            InitializeComponent();
        }

        public event EventHandler<InitialSettingsEventArgs> InitSett;
        private void InitialSettingsButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

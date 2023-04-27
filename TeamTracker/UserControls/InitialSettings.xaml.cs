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
            string language = "";
            if (rbCro.IsChecked == true)
            {
                language = "hr";
            }
            else if (rbEn.IsChecked == true)
            {
                language = "en";
            }

            string championship = "";
            if (rbF.IsChecked == true)
            {
                championship = "Womens";
            }
            else if (rbM.IsChecked == true)
            {
                championship = "Mens";
            }

            string screenSize = "";
            if (rbFull.IsChecked == true)
            {
                screenSize = "Fullscreen";
            }
            else if (rbOriginal.IsChecked == true)
            {
                screenSize = "Original";
            }
            else if (rbSmall.IsChecked == true)
            {
                screenSize = "Small";
            }
            if(language == string.Empty || championship == string.Empty || screenSize == string.Empty)
            {
                MessageBox.Show("Morate izabrati");
            }
            else
            {

            InitSett?.Invoke(this, new InitialSettingsEventArgs { Language = language, Championship = championship, ScreenSize = screenSize });
            }


        }
    }
}

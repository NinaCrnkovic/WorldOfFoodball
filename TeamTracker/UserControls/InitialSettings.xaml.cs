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
using WorldOfFootball.CustomDesign;

namespace TeamTracker.UserControls
{
    /// <summary>
    /// Interaction logic for InitialSettings.xaml
    /// </summary>
    public partial class InitialSettings : UserControl
    {
        string _language;
        string _championship;
        string _screenSize;
        public InitialSettings(string language, string championship, string screenSize)
        {
            _language = language;
            _championship = championship;
            _screenSize = screenSize;
       
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            if (_language != null)
            {
                if(_language == "hr")
                {
                    rbCro.IsChecked = true;
                }
                else 
                { 
                    rbEn.IsChecked = true; 
                }
            }
            if (_championship != null)
            {
                if (_championship == "Womens")
                {
                    rbF.IsChecked = true;
                }
                else
                {
                    rbM.IsChecked = true;
                }
            }
            if (_screenSize != null)
            {
                if(_screenSize == "Small")
                {
                    rbSmall.IsChecked = true;
                }
                else if(_screenSize == "Fullscreen")
                {
                    rbFull.IsChecked = true;
                }
                else
                {
                    rbOriginal.IsChecked = true;
                }
            }
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
                CustomMessageBox.Show("You have to choose a language, championship and screen size", "Warning", System.Windows.Forms.MessageBoxButtons.OK, "en");
            }
            else
            {

            InitSett?.Invoke(this, new InitialSettingsEventArgs { Language = language, Championship = championship, ScreenSize = screenSize });
            }


        }
    }
}

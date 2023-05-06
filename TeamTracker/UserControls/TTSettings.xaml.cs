using System;
using System.Windows;
using System.Windows.Controls;
using TeamTracker.EventsArgsTT;


namespace TeamTracker.UserControls
{
     public partial class TTSettings : UserControl
    {
        string _language;
        bool _isWomens;
        string _screenSize;
        public TTSettings(string language, bool isWomens, string screenSize)
        {
            _language = language;
            _isWomens = isWomens;
            _screenSize = screenSize;

            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            if (_language != null)
            {
                if (_language == "hr")
                {
                    rbCro.IsChecked = true;
                }
                else
                {
                    rbEn.IsChecked = true;
                }
            }
            else
            {
                rbEn.IsChecked = true;
            }


            if (_isWomens == true)
            {
                rbF.IsChecked = true;
            }
            else if (_isWomens == false)
            {
                rbM.IsChecked = true;
            }


            if (_screenSize != null)
            {
                if (_screenSize == "Small")
                {
                    rbSmall.IsChecked = true;
                }
                else if (_screenSize == "Fullscreen")
                {
                    rbFull.IsChecked = true;
                }
                else
                {
                    rbOriginal.IsChecked = true;
                }
            }
            else
            {
                rbOriginal.IsChecked = true;
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


            if (language == string.Empty || championship == string.Empty || screenSize == string.Empty)
            {
                MessageBox.Show(Properties.Resources.messageInitialSettings, Properties.Resources.warning,MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else
            {
                var result = MessageBox.Show(Properties.Resources.messageConfirmSettings, Properties.Resources.warning, MessageBoxButton.OKCancel, MessageBoxImage.Question);
                if (result == MessageBoxResult.OK)
                {
                    InitSett?.Invoke(this, new InitialSettingsEventArgs { Language = language, Championship = championship, ScreenSize = screenSize });
                }
                return;
            }


        }
    }
}

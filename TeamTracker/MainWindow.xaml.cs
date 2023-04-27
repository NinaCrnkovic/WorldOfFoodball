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

namespace TeamTracker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DataManager _dataManager = new();
        public MainWindow()
        {
            InitializeComponent();
            if (true)
            {
                CallInitialSettings();
            }
        }

        private void CallInitialSettings()
        {
            UserControls.InitialSettings initialSettings = new();
            Container.Content = initialSettings;
        }
    }
}

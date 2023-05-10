using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
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
        private string _language;
        public CountryInfo(string language)
        {
            InitializeComponent();
            _language = language;
            SetLanguage();
        }

        private void SetLanguage()
        {
            if (_language != null)
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(_language);
            }
            else
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");
            }

        }
    }
}

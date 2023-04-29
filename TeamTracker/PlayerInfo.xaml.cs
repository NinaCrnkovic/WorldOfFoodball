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
    /// <summary>
    /// Interaction logic for PlayerInfo.xaml
    /// </summary>
    public partial class PlayerInfo : Window
    {

        public string PlayerName
        {
            get { return lblName.Content.ToString(); }
            set { lblName.Content = value; }
        }

        public string ShirtNumber
        {
            get { return lblShirtNum.Content.ToString(); }
            set { lblShirtNum.Content = value; }
        }

        public int Goals
        {
            get { return int.Parse(lblGoals.Content.ToString()); }
            set { lblGoals.Content = value.ToString(); }
        }

        public int Cartons
        {
            get { return int.Parse(lblCartons.Content.ToString()); }
            set { lblCartons.Content = value.ToString(); }
        }

        public int Role
        {
            get { return int.Parse(lblRole.Content.ToString()); }
            set { lblRole.Content = value.ToString(); }
        }

        public int Capitan
        {
            get { return int.Parse(lblCapitan.Content.ToString()); }
            set { lblCapitan.Content = value.ToString(); }
        }

        public PlayerInfo()
        {
            InitializeComponent();
        }
    }
}

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
using TeamTracker.EventsArgsTT;

namespace TeamTracker.UserControls
{
    
    public partial class PlayerControl : UserControl
    {
        public PlayerControl()
        {
            InitializeComponent();
        }

        public event EventHandler<PlayerControlEventArgs> PlayerControlData;
        private void grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            string name = "";
            if(lblName != null)
            {
                name = lblName.Content.ToString();
            }
       

            PlayerControlData?.Invoke(this, new PlayerControlEventArgs { Name = name });
      
          
        }
    }
}

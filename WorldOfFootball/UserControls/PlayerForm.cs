using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorldOfFootball.UserControls
{
    public partial class PlayerForm : UserControl
    {
        public bool IsSelected { get; set; }
        public PlayerForm()
        {
            
        InitializeComponent();
               
        }
    }
}

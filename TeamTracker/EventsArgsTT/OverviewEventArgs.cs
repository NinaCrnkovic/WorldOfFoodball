using DataLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamTracker.EventsArgsTT
{
    public class OverviewEventArgs : EventArgs
    {
        public string FavoriteTeam { get; set; }
        public string OppositeTeam { get; set; }

        public string Result { get; set; }
        public List<FootballMatch> FootballMatches { get; set; } = new List<FootballMatch>();
    }
}

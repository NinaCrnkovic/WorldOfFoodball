using DataLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldOfFootball.EventsAndArgs
{
    public class FavoriteTeamEventArgs : EventArgs
    {
        public Team favoriteTeam { get; set; }
    }
}

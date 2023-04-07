using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldOfFootball.EventsAndArgs
{
    public class LanguageAndChampionshipEventArgs : EventArgs
    {
        public string Language { get; set; }
        public string Championship { get; set; }
    }
}

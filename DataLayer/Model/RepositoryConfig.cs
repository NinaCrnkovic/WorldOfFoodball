using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Model
{
    public class RepositoryConfig
    {
        public bool UseApiRepository { get; set; }
        public bool UseFileRepository { get; set; }
        // druge moguće konfiguracije ovdje
    }
}

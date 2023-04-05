﻿using DataLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repository
{
    public interface IRepository
    {
        Team GetTeam(int id, bool isWomen);
        List<Team> GetTeams(bool isWomen);
    }
}

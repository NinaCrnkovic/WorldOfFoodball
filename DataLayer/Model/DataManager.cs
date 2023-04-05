using DataLayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Model
{
    public class DataManager
    {
        private IRepository repo = RepoFactory.GetRepo();
        IDictionary<long, Team> teamsDictionary = new Dictionary<long, Team>();

        public void LoadTeamsToDictionary(bool isWoomenSend)
        {
            bool isWomen = isWoomenSend;   
            try
            {
                IList<Team> teams = repo.GetTeams(isWomen);
                FillTeamsDictionary(teams);
            }
            catch (Exception e)
            {
              throw new Exception(e.Message);
            }
        }

        //metoda za punjenje dicitonaria iz liste
        private void FillTeamsDictionary(IList<Team> teams)
        {
            foreach (var item in teams)
            {
                try
                {
                    teamsDictionary.Add(item.Id, item);

                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
            }
        }

        public IDictionary<long, Team> GetTeamDictionary() => teamsDictionary;

    }
}

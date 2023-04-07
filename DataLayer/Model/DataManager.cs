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
        private List<Team> teams;
        public DataManager()
        {
            teams = new List<Team>();

        }
       

        //public void LoadTeamsToDictionary(bool isWoomenSend)
        //{
        //    bool isWomen = isWoomenSend;
        //    try
        //    {
        //        IList<Team> teams = repo.GetTeams(isWomen);
        //        FillTeamsDictionary(teams);
        //    }
        //    catch (Exception e)
        //    {
        //        throw new Exception(e.Message);
        //    }
        //}



        ////metoda za punjenje dicitonaria iz liste
        //private void FillTeamsDictionary(IList<Team> teams)
        //{
        //    foreach (var item in teams)
        //    {
        //        try
        //        {
        //            teamsDictionary.Add(item.Id, item);

        //        }
        //        catch (Exception e)
        //        {
        //            throw new Exception(e.Message);
        //        }
        //    }
        //}



        public List<Team> GetTeamsList() => teams;


        public async Task LoadTeams(bool isWomen)
        {
           
            try
            {
                teams = await repo.GetTeams(isWomen);
            
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        ////metoda za punjenje dicitonaria iz liste
        //private async void FillTeamsDictionary(List<Team> teams)
        //{
        //    foreach (var item in teams)
        //    {
        //        try
        //        {
        //            teamsDictionary.Add(item.Id, item);
        //        }
        //        catch (Exception e)
        //        {
        //            throw new Exception(e.Message);
        //        }
        //    }
        //}

        //public async Task<Team> GetTeam(int id, bool isWomen)
        //{
        //    return await repo.GetTeams(id, isWomen);
        //}

        

       


    }





}


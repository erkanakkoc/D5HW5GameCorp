using GameCorpV3.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameCorpV3.Abstract
{
    public abstract class BaseUserManager : IUserService, IGameService, ICampaignService
    {
        public void Delete(User user)
        {
            Console.WriteLine(user.FirstName + " " +user.LastName+ " deleted");
        }
        public void Update(User user)
        {
            Console.WriteLine(user.FirstName + " " + user.LastName + " updated");
        }

        public virtual void Save(User user)
        {
            Console.WriteLine(user.FirstName + " " + user.LastName + " added");
        }

        //IGameService


        public void Save(Game game)
        {
            Console.WriteLine(game.GameName + " added");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.GameName + " updated");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName + " deleted");
        }

        //ICampaignService

        public void Save(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " added");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " deleted");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " updated");
        }
    }
}

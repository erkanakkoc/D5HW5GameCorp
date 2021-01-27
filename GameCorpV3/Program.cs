using GameCorpV3.Abstract;
using GameCorpV3.Adapters;
using GameCorpV3.Concrete;
using GameCorpV3.Entities;
using System;

namespace GameCorpV3
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseUserManager userManager = new UserManager(new MernisServiceAdapter());
            //userManager.Save(new User { UserId = 1, FirstName = "Erkan", LastName = "Akkoç", DateOfBirth = new DateTime(1989, 5, 29), NationalityId = "32782834726" });

            BaseUserManager gameManager = new GameManager();
            //gameManager.Save(new Game { GameId = 1, GameName = "GTA 5", GamePrice = 15.95 });

            BaseUserManager campaignManager = new CampaignManager();
            //campaignManager.Save(new Campaign { CampaignId = 1, CampaignName = "%50 Discount", CampaignDiscount = 50 });

            Console.WriteLine("WELCOME TO GAME CORP. \n 1) Add User \n 2) Update User \n 3) Delete User");
            int userChoice = Convert.ToInt32(Console.ReadLine());
            switch (userChoice)
            {
                case 1:

                    User user2 = new User();
                    user2.UserId = 2;
                    Console.WriteLine("First Name: ");
                    user2.FirstName = Console.ReadLine();
                    Console.WriteLine("Last Name: ");
                    user2.LastName = Console.ReadLine();
                    Console.WriteLine("Birthday Year: ");
                    user2.YearOfBirth= Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Nationality Id: ");
                    user2.NationalityId = Console.ReadLine();

                    userManager.Save(user2);

                    break;
                case 2:
                    break;
                case 3:
                    break;

                default:
                   
                    break;
            }

        }
    }
}
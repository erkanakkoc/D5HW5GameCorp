using GameCorpV3.Abstract;
using GameCorpV3.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameCorpV3.Concrete
{
    class UserManager : BaseUserManager       
    {
        private IUserCheckService _userCheckService;

        public UserManager(IUserCheckService userCheckService)
        {
            _userCheckService = userCheckService;
        }

        public override void Save(User user)
        {
            if (_userCheckService.CheckIfRealPerson(user))
            {
                base.Save(user);
            }
            else
            {
               
                
                Console.WriteLine("Error to Validation");
                //throw new Exception("Not a valid person");
             }
            
            
        }
    }
}

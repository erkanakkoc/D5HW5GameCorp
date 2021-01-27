using GameCorpV3.Abstract;
using GameCorpV3.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameCorpV3.Concrete
{
    class UserCheckManager : IUserCheckService

    {
        public bool CheckIfRealPerson(User user)
        {
            return true;
        }
    }
}

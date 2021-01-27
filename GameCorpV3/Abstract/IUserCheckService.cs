using GameCorpV3.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameCorpV3.Abstract
{
    public interface IUserCheckService
    {
        bool CheckIfRealPerson(User user);
    }
}

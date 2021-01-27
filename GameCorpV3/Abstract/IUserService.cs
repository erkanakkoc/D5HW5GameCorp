using GameCorpV3.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameCorpV3.Abstract
{
    public interface IUserService
    {
        void Save(User user);

        void Delete(User user);

        void Update(User user);
    }
}

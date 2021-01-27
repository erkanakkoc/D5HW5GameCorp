using GameCorpV3.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameCorpV3.Abstract
{
    public interface IGameService
    {
        void Save(Game game);

        void Delete(Game game);

        void Update(Game game);
    }
}

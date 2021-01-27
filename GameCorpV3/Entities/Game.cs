using GameCorpV3.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameCorpV3.Entities
{
    public class Game : IEntity
    {
        public int GameId { get; set; }
        public string GameName { get; set; }
        public double GamePrice { get; set; }
    }
}

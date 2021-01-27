using GameCorpV3.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameCorpV3.Entities
{
    public class Campaign:IEntity
    {
        public int CampaignId { get; set; }
        public string CampaignName { get; set; }
        public int CampaignDiscount { get; set; }
    }
}

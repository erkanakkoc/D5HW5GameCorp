using GameCorpV3.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameCorpV3.Abstract
{
    public interface ICampaignService
    {
        void Save(Campaign campaign);

        void Delete(Campaign campaign);

        void Update(Campaign campaign);
    }
}

using GameCorpV3.Abstract;
using GameCorpV3.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GameCorpV3.Adapters
{
    public class MernisServiceAdapter : IUserCheckService
    {
        public bool CheckIfRealPerson(User user)
        {
            return TaskAsync(user).Result;
        }
        public static async Task<bool> TaskAsync(User user)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap12);
            var status = await (client.TCKimlikNoDogrulaAsync(Convert.ToInt64(user.NationalityId), user.FirstName, user.LastName, user.YearOfBirth));
            return status.Body.TCKimlikNoDogrulaResult;

        }
    }
}



using GymApp.BusinessLogic.Interfaces;
using GymApp.DataAccess.Interfaces;

namespace GymApp.BusinessLogic.Services
{
    public class SubsctiptionService : ISubscriptionService
    {
        private readonly ISubscriptionRepository _subsctiptionRepository;
        public SubsctiptionService(ISubscriptionRepository subsctiptionRepository)
        {
            _subsctiptionRepository = subsctiptionRepository;
        }
    }
}

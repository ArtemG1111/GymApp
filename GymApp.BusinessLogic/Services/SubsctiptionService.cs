

using GymApp.BusinessLogic.Interfaces;
using GymApp.DataAccess.Data.Models;
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
        public void AddSubscription(Subscription subscription)
        {
            _subsctiptionRepository.AddSubscription(subscription);
        }
        public List<Subscription> GetSubscriptions()
        {
            return _subsctiptionRepository.GetSubscriptions();
        }
        public void UpdateSubscription(Subscription subscription)
        {
            _subsctiptionRepository.UpdateSubscription(subscription);
        }
        public void DeleteSubscription(int id)
        {
            _subsctiptionRepository.DeleteSubscription(id);
        }
        public void AddSectionsToSubscription(int id)
        {
            _subsctiptionRepository.AddSectionsToSubscription(id);
        }
    }
}

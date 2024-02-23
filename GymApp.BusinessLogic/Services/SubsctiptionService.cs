

using GymApp.BusinessLogic.Interfaces;
using GymApp.DataAccess.Data;
using GymApp.DataAccess.Data.Models;
using GymApp.DataAccess.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace GymApp.BusinessLogic.Services
{
    public class SubsctiptionService : ISubscriptionService
    {
        private readonly ISubscriptionRepository _subsctiptionRepository;
        private readonly UserManager<Client> _userManager;
        private readonly GymAppContext _dbContext;
        public SubsctiptionService(ISubscriptionRepository subsctiptionRepository, UserManager<Client> userManager,
            GymAppContext dbContext)
        {
            _subsctiptionRepository = subsctiptionRepository;
            _userManager = userManager;
            _dbContext = dbContext;
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
        public async Task AddClientsToSubscription(int subscriptionId, string userName)
        {
            var client = await _userManager.FindByNameAsync(userName);

            var subscription =  _dbContext.Subscriptions.Find(subscriptionId);

            subscription.Clients.Add(client);

            _dbContext.SaveChanges();
        }
    }
}

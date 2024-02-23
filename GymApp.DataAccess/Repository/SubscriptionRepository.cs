

using GymApp.DataAccess.Data;
using GymApp.DataAccess.Data.Models;
using GymApp.DataAccess.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GymApp.DataAccess.Repository
{
    public class SubscriptionRepository : ISubscriptionRepository
    {
        private readonly GymAppContext _dbContext;
        public SubscriptionRepository(GymAppContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void AddSubscription(Subscription subscription)
        {
            _dbContext.Subscriptions.Add(subscription);
            _dbContext.SaveChanges();
        }
        public List<Subscription> GetSubscriptions()
        {
            return _dbContext.Subscriptions.ToList();
        }
        public void UpdateSubscription(Subscription subscription)
        {
            _dbContext.Attach(subscription);
        }
        public void DeleteSubscription(int id)
        {
            Subscription? subscription = _dbContext.Subscriptions.Find(id);
            if(subscription == null)
            {
                throw new Exception($"Subscription with id {id} not found");
            }
            _dbContext.Remove(subscription);
        }
    }
}

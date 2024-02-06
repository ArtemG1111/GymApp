

using GymApp.DataAccess.Data.Models;

namespace GymApp.DataAccess.Interfaces
{
    public interface ISubscriptionRepository
    {
        void AddSubscription(Subscription subscription);
        List<Subscription> GetSubscriptions();
        void UpdateSubscription(Subscription subscription);
        void DeleteSubscription(int id);
        void AddSectionsToSubscription(int id);
    }
}

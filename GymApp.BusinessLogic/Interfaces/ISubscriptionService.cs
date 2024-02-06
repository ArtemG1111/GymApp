
using GymApp.DataAccess.Data.Models;

namespace GymApp.BusinessLogic.Interfaces
{
    public interface ISubscriptionService
    {
        void AddSubscription(Subscription subscription);
        List<Subscription> GetSubscriptions();
        void UpdateSubscription(Subscription subscription);
        void DeleteSubscription(int id);
        void AddSectionsToSubscription(int id);
    }
}

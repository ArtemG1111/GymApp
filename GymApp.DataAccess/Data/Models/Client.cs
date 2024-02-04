

namespace GymApp.DataAccess.Data.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BirthDay { get; set; }
        public string Email { get; set; }
        public bool HasPaidForSubscription { get; set; }
        public List<FinancialOperation> FinOperations { get; set; }
        public Subscription Subscription { get; set; }
        public int SubscriptionId { get; set; }
        
    }
}

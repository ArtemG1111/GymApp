

using Microsoft.AspNetCore.Identity;

namespace GymApp.DataAccess.Data.Models
{
    public class Client : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BirthDay { get; set; }
        public bool HasPaidForSubscription { get; set; }
        public List<FinancialOperation>? FinOperations { get; set; }
        public Subscription? Subscription { get; set; }
        public int? SubscriptionId { get; set; }
    }
}

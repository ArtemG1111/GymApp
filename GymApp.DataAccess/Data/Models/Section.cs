

namespace GymApp.DataAccess.Data.Models
{
    public class Section
    {
        public int Id { get; set; }
        public string Name { get; set; }      
        public Subscription? Subscription { get; set; }
        public string? SubscriptionId { get; set; }
    }
}

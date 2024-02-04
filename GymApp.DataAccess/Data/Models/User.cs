

namespace GymApp.DataAccess.Data.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BirthDay { get; set; }
        public string Email { get; set; }
        public FinancialOperation FinOperation { get; set; }
        public Subscription Subscription { get; set; }
        public List<Section> Sections { get; set; }
    }
}

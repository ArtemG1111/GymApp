namespace GymApp.WEB.ViewModels
{
    public class ClientViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BirthDay { get; set; }
        public string Email { get; set; }
        public bool HasPaidForSubscription { get; set; }
    }
}

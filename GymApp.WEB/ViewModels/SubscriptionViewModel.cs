namespace GymApp.WEB.ViewModels
{
    public class SubscriptionViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public List<SectionViewModel> Sections { get; set; }
        public List<ClientViewModel> Clients { get; set; }
    }
}



namespace GymApp.DataAccess.Data.Models
{
    public class Subscription
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public List<Section> Sections { get; set; }
        public List<Client> Clients { get; set; }
    }
}

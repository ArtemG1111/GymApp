

namespace GymApp.DataAccess.Data.Models
{
    public class FinancialOperation
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public string ClientId { get; set; }
        public Client? Client { get; set; }
    }
}



namespace GymApp.DataAccess.Data.Models
{
    public class FinancialOperation
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}

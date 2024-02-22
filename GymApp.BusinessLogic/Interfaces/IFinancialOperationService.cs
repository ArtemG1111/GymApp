

using GymApp.DataAccess.Data.Models;

namespace GymApp.BusinessLogic.Interfaces
{
    public interface IFinancialOperationService
    {
        Task AddFunds(decimal amount, string userName);
        Task<List<FinancialOperation>> GetFinOperations(string userName);
    }
}

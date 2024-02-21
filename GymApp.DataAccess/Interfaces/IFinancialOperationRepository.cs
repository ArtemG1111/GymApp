

using GymApp.DataAccess.Data.Models;

namespace GymApp.DataAccess.Interfaces
{
    public interface IFinancialOperationRepository
    {
        void AddFunds(int amount);
        List<FinancialOperation> GetFinOperations();
    }
}

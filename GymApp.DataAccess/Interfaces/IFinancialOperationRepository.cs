

using GymApp.DataAccess.Data.Models;

namespace GymApp.DataAccess.Interfaces
{
    public interface IFinancialOperationRepository
    {
        void AddFunds(FinancialOperation financialOperation);
        List<FinancialOperation> GetFinOperations(string id);
    }
}

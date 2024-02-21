

using GymApp.DataAccess.Data.Models;

namespace GymApp.BusinessLogic.Interfaces
{
    public interface IFinancialOperationService
    {
        void AddFunds(int amount);
        List<FinancialOperation> GetFinOperations();
    }
}

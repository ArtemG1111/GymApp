

using GymApp.DataAccess.Data.Models;

namespace GymApp.BusinessLogic.Interfaces
{
    public interface IFinancialOperationService
    {
        List<FinancialOperation> GetOperations();
    }
}

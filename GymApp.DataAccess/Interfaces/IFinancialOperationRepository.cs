

using GymApp.DataAccess.Data.Models;

namespace GymApp.DataAccess.Interfaces
{
    public interface IFinancialOperationRepository
    {
        List<FinancialOperation> GetOperations();
    }
}

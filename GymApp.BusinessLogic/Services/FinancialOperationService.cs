

using GymApp.BusinessLogic.Interfaces;
using GymApp.DataAccess.Data.Models;
using GymApp.DataAccess.Interfaces;

namespace GymApp.BusinessLogic.Services
{
    public class FinancialOperationService : IFinancialOperationService
    {
        private readonly IFinancialOperationRepository _financialOperationRepository;
        public FinancialOperationService(IFinancialOperationRepository financialOperationRepository)
        {
            _financialOperationRepository = financialOperationRepository;
        }
        public List<FinancialOperation> GetOperations()
        {
            return _financialOperationRepository.GetOperations();
        }
    }
}

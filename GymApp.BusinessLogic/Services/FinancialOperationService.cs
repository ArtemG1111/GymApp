

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
        public List<FinancialOperation> GetFinOperations()
        {
            return _financialOperationRepository.GetFinOperations();
        }
        public void AddFunds(int amount)
        {
            _financialOperationRepository.AddFunds(amount);
        }
    }
}

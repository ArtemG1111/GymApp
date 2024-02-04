

using GymApp.BusinessLogic.Interfaces;
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
    }
}

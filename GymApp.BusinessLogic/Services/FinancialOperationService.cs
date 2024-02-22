

using GymApp.BusinessLogic.Interfaces;
using GymApp.DataAccess.Data.Models;
using GymApp.DataAccess.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace GymApp.BusinessLogic.Services
{
    public class FinancialOperationService : IFinancialOperationService
    {
        private readonly IFinancialOperationRepository _financialOperationRepository;
        private readonly UserManager<Client> _userManager;
        public FinancialOperationService(IFinancialOperationRepository financialOperationRepository,
            UserManager<Client> userManager)
        {
            _financialOperationRepository = financialOperationRepository;
            _userManager = userManager;
        }
        public async Task<List<FinancialOperation>> GetFinOperations(string userName)
        {
            var user = await _userManager.FindByNameAsync(userName);

            return _financialOperationRepository.GetFinOperations(user.Id);
        }
        public async Task AddFunds(decimal amount, string userName)
        {
            var user = await _userManager.FindByNameAsync(userName);
            var finOperation = new FinancialOperation()
            {
                Amount = amount,
                Date = DateTime.Now,
                ClientId = user.Id
            };
            _financialOperationRepository.AddFunds(finOperation);
        }
    }
}

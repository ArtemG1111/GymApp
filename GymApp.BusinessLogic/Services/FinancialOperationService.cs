

using GymApp.BusinessLogic.Interfaces;
using GymApp.DataAccess.Data;
using GymApp.DataAccess.Data.Models;
using GymApp.DataAccess.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace GymApp.BusinessLogic.Services
{
    public class FinancialOperationService : IFinancialOperationService
    {
        private readonly IFinancialOperationRepository _financialOperationRepository;
        private readonly UserManager<Client> _userManager;
        private readonly GymAppContext _dbContext;
        public FinancialOperationService(IFinancialOperationRepository financialOperationRepository,
            UserManager<Client> userManager, GymAppContext dbContext)
        {
            _financialOperationRepository = financialOperationRepository;
            _userManager = userManager;
            _dbContext = dbContext;
        }
        public async Task<List<FinancialOperation>> GetFinOperations(string userName)
        {
            var user = await _userManager.FindByNameAsync(userName);

            return _financialOperationRepository.GetFinOperations(user.Id);
        }
        public async Task AddFunds(decimal amount, string userName)
        {

            var user = _dbContext.Users.Include(s => s.Subscription).FirstOrDefault(u => u.UserName == userName);

            var finOperation = new FinancialOperation()
            {
                Amount = amount,
                Date = DateTime.Now,
                ClientId = user.Id
            };
            _financialOperationRepository.AddFunds(finOperation);
            
            user.Balance += amount;

            if (!user.HasPaidForSubscription && user.Balance >= user.Subscription.Price)
            {
                user.Balance -= user.Subscription.Price;

                user.HasPaidForSubscription = true;
            }

            _dbContext.SaveChanges();
        }

    }
}

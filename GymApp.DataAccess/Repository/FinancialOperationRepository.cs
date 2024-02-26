

using GymApp.DataAccess.Data;
using GymApp.DataAccess.Data.Models;
using GymApp.DataAccess.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace GymApp.DataAccess.Repository
{
    public class FinancialOperationRepository : IFinancialOperationRepository
    {
        private readonly GymAppContext _dbContext;
        private readonly UserManager<Client> _userManager;
        public FinancialOperationRepository(GymAppContext dbContext, UserManager<Client> userManager)
        {
            _dbContext = dbContext;
            _userManager = userManager;
        }
        public List<FinancialOperation> GetFinOperations(string id)
        {
            return _dbContext.FinancialOperations.Where(s => s.ClientId == id).AsNoTracking().ToList();
        }
        public void AddFunds(FinancialOperation financialOperation)
        {
            _dbContext.FinancialOperations.Add(financialOperation);
        }
    }
}

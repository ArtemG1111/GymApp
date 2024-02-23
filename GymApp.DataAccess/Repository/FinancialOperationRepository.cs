

using GymApp.DataAccess.Data;
using GymApp.DataAccess.Data.Models;
using GymApp.DataAccess.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GymApp.DataAccess.Repository
{
    public class FinancialOperationRepository : IFinancialOperationRepository
    {
        private readonly GymAppContext _dbContext;
        public FinancialOperationRepository(GymAppContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<FinancialOperation> GetFinOperations(string id)
        {
            return _dbContext.FinancialOperations.Where(s => s.ClientId == id).AsNoTracking().ToList();
        }
        public void AddFunds(FinancialOperation financialOperation)
        {
            _dbContext.FinancialOperations.Add(financialOperation);
            _dbContext.SaveChanges();
        }
    }
}

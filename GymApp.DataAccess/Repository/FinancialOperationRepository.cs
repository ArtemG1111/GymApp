

using GymApp.DataAccess.Data;
using GymApp.DataAccess.Data.Models;
using GymApp.DataAccess.Interfaces;

namespace GymApp.DataAccess.Repository
{
    public class FinancialOperationRepository : IFinancialOperationRepository
    {
        private readonly GymAppContext _dbContext;
        public FinancialOperationRepository(GymAppContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<FinancialOperation> GetFinOperations()
        {
            return _dbContext.FinancialOperations.ToList();
        }
        public void AddFunds(int amount)
        {
            _dbContext.FinancialOperations.Add();
        }
    }
}

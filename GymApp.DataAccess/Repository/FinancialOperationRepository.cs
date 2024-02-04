

using GymApp.DataAccess.Data;
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
    }
}

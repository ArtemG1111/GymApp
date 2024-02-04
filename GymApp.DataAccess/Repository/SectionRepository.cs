

using GymApp.DataAccess.Data;
using GymApp.DataAccess.Interfaces;

namespace GymApp.DataAccess.Repository
{
    public class SectionRepository : ISectionRepository
    {
        private readonly GymAppContext _dbContext;
        public SectionRepository(GymAppContext dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
